
using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Windows.Input;

namespace Post_Turing_machine;
public partial class Form1 : System.Windows.Forms.Form
{
    Post_Machine machine = new Post_Machine(-50);
    int num;
    int num2;
    public Form1()
    {
        InitializeComponent();
        this.ActiveControl = toRight;
        toLeft.FlatStyle = FlatStyle.Flat;
        toLeft.FlatAppearance.BorderSize = 0;
        toRight.FlatStyle = FlatStyle.Flat;
        toRight.FlatAppearance.BorderSize = 0;
        saveCommands.FlatStyle = FlatStyle.Flat;
        saveCommands.FlatAppearance.BorderSize = 0;
        loadCommands.FlatStyle = FlatStyle.Flat;
        loadCommands.FlatAppearance.BorderSize = 0;
        saveState.FlatStyle = FlatStyle.Flat;
        saveState.FlatAppearance.BorderSize = 0;
        loadState.FlatStyle = FlatStyle.Flat;
        loadState.FlatAppearance.BorderSize = 0;
        startButton.FlatStyle = FlatStyle.Flat;
        startButton.FlatAppearance.BorderSize = 0;
        double multiplayer = 25 / (double)7;
        num2 = Convert.ToInt32((num / 100) / multiplayer);
    }

    void SetupPanel()
    {
        double multiplayer = 2500 / (double)770;
        num = Convert.ToInt32(multiplayer * panel1.Width);
        Button button = new Button();
        for (int i = 0; i < 101; i++)
        {
            CoolLabel label = new CoolLabel();
            label.Text = (50 - i).ToString() + "   0";
            label.Location = new Point(num - i * (num / 100), panel1.Location.Y / 2);
            label.Width = num / 100+Convert.ToInt32(multiplayer);
            label.Height = panel1.Height / 2;
            label.Click += OnTapeClick;
            machine.Notify += label.ChangeValue;

            panel1.Controls.Add(label);
        }
        Karetka.Location = new Point(num-100*(num/100) + Convert.ToInt32((num / 100) / (25 / (double)7)), 0 );
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
        if (Karetka.Location.X - num / 100 >= 0)
        {
            Karetka.Location = new Point(Karetka.Location.X - num / 100, Karetka.Location.Y);
        }
        machine.CurrentPos -= 1;
    }

    private void toRight_Click(object sender, EventArgs e)
    {
        if (Karetka.Location.X + num / 100 <= num)
        {
            Karetka.Location = new Point(Karetka.Location.X + num / 100, Karetka.Location.Y);
        }
        machine.CurrentPos += 1;
    }

    private void startButton_Click(object sender, EventArgs e)
    {
        machine.Commands.Clear();
        string input = commands.Text;
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
        Karetka.Location = new Point((machine.CurrentPos + 50) * (num / 100) + num2, Karetka.Location.Y);
    }

    private void loadCommands_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Text files(*.txt)|*.txt";
        if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            return;

        StreamReader reader = new StreamReader(openFileDialog.FileName);
        commands.Text = reader.ReadToEnd();
        reader.Close();
    }

    private void saveCommands_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Text files(*.txt)|*.txt";
        if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            return;

        StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false);
        writer.Write(commands.Text);
        writer.Close();
    }

    private void saveState_Click(object sender, EventArgs e)
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

        writer.WriteLine(commands.Text);
        writer.Close();
    }

    private void loadState_Click(object sender, EventArgs e)
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
        Karetka.Location = new Point((machine.CurrentPos + 50) * (100/num) + num2, Karetka.Location.Y);
        machine.NotifyLabels();
        commands.Text = reader.ReadToEnd();
        reader.Close();
    }

    private void commands_Changed(object sender, EventArgs e)
    {

        string input = commands.Text;
        if (input == "")
        {
            startButton.Enabled = false;
            return;
        }
        string tempCommand = "";
        int counter = 1;
        foreach (char c in input)
        {
            if (c == '\r')
            {
                counter++;
                if (inputValidation(tempCommand) == false)
                {
                    startButton.Enabled = false;
                    MessageBox.Show("Неверено введена команда");
                    return;
                }
                tempCommand = "";
                continue;
            }
            if (c == '\n') { continue; }
            tempCommand += c;
        }
        if (inputValidation(tempCommand) == false)
        {
            startButton.Enabled = false;
            MessageBox.Show("Неверено введена команда");
            return;
        }
        startButton.Enabled = true;
    }
    private bool inputValidation(string input)
    {
        if (input == "")
        {
            return true;
        }
        if (input.Length < 3)
        {
            return false;
        }
        int value = 0;
        if (input[0] == '<' || input[0] == '>' || input[0] == '?' || input[0] == '1' || input[0] == '0')
        {
            if (input[1] == ' ')
            {
                if (input[0] == '?')
                {
                    try
                    {
                        for (int i = 2; i < input.Length; i++)
                        {
                            if (input[i] == ',')
                            {
                                continue;
                            }
                            value = Convert.ToInt32(input[i]);
                        }
                        return true;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
                else
                {
                    try
                    {
                        for (int i = 2; i < input.Length; i++)
                        {
                            value = Convert.ToInt32(input[i]);
                        }
                        return true;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
        }
        return false;
    }

    private void Form1_Click(object sender, EventArgs e)
    {
        this.ActiveControl = toRight;
    }
}