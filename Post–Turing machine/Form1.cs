
using System;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace Post_Turing_machine;
public partial class Form1 : System.Windows.Forms.Form
{
    Post_Machine machine = new Post_Machine(-50);
    public Form1()
    {
        InitializeComponent();

    }

    void SetupPanel()
    {
        Button button = new Button();
        for (int i = 0; i < 101; i++)
        {
            CoolLabel label = new CoolLabel();
            label.Text = (50 - i).ToString() + "   0";
            label.Location = new Point(2500 - i * 25, panel1.Location.Y / 2);
            label.Width = 25;
            label.Height = 30;
            label.Click += OnTapeClick;
            machine.Notify += label.ChangeValue;

            panel1.Controls.Add(label);
        }
    }


    private void OnTapeClick(object? sender, EventArgs e)
    {
        string pos = "";
        int posNum = 0;
        string text = ((Label)sender).Text;
        int posOfText = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ' ')
            {
                posOfText = i;
                posNum = int.Parse(pos);
                break;
            }
            pos += text[i];
        }
        for (int i = posOfText; i < text.Length; i++)
        {
            if (text[i] == ' ')
            {
                continue;
            }
            if (text[i] == '0')
            {
                text = pos + "   1";
            }
            else
            {
                text = pos + "   0";
            }
        }
        ((Label)sender).Text = text;
        if (posNum >= 0)
        {
            if (machine.RightTape[posNum] == false)
            {
                machine.RightTape[posNum] = true;
            }
            else
            {
                machine.RightTape[posNum] = false;
            }
        }
        if (posNum < 0)
        {
            if (machine.LeftTape[Math.Abs(posNum)] == false)
            {
                machine.LeftTape[Math.Abs(posNum)] = true;
            }
            else
            {
                machine.LeftTape[Math.Abs(posNum)] = false;
            }
        }
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        SetupPanel();
    }

    private void toLeft_Click(object sender, EventArgs e)
    {
        if (Karetka.Location.X - 25 >= 0)
        {
            Karetka.Location = new Point(Karetka.Location.X - 25, Karetka.Location.Y);
        }
        machine.CurrentPos -= 1;
    }

    private void toRight_Click(object sender, EventArgs e)
    {
        if (Karetka.Location.X + 25 <= 2500)
        {
            Karetka.Location = new Point(Karetka.Location.X + 25, Karetka.Location.Y);
        }
        machine.CurrentPos += 1;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        machine.Commands.Clear();
        string input = textBox1.Text;
        string tempCommand = "";
        int counter = 1;
        foreach (char c in input)
        {
            if (c == '\r')
            {
                machine.Commands.Add(counter, tempCommand);
                counter++;
                tempCommand = "";

                continue;
            }
            if (c == '\n') { continue; }
            tempCommand += c;
        }
        machine.Commands.Add(counter, tempCommand);
        machine.Start();
        Karetka.Location = new Point((machine.CurrentPos + 50) * 25 + 7, Karetka.Location.Y);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Text files(*.txt)|*.txt";
        if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            return;

        StreamReader reader = new StreamReader(openFileDialog.FileName);
        textBox1.Text = reader.ReadToEnd();
        reader.Close();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Text files(*.txt)|*.txt";
        if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            return;

        StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false);
        writer.Write(textBox1.Text);
        writer.Close();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Post Files(*.pst)|*.pst";
        if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            return;


        StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false);

        for (int i = -50; i < 0; i++)
        {
            writer.Write(Convert.ToInt32(machine.LeftTape[Math.Abs(i)]));
        }
        for (int i = 0; i < 50; i++)
        {
            writer.Write(Convert.ToInt32(machine.RightTape[i]));
        }
        writer.WriteLine(machine.CurrentPos.ToString());

        writer.WriteLine(textBox1.Text);
        writer.Close();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Post Files(*.pst)|*.pst";
        if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            return;

        StreamReader reader = new StreamReader(openFileDialog.FileName);
        for (int i = -50; i < 0; i++)
        {
            machine.LeftTape[Math.Abs(i)] = Convert.ToBoolean(reader.Read() - '0');
        }
        for (int i = 0; i < 50; i++)
        {
            machine.RightTape[i] = Convert.ToBoolean(reader.Read() - '0');
        }
        machine.CurrentPos = Convert.ToInt32(reader.ReadLine());
        Karetka.Location = new Point((machine.CurrentPos + 50) * 25 + 7, Karetka.Location.Y);
        machine.NotifyLabels();
        textBox1.Text = reader.ReadToEnd();
        reader.Close();
    }
}