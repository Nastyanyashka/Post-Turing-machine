
using System;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace Post_Turing_machine;
public partial class Form1 : System.Windows.Forms.Form
{
    Post_Machine machine = new Post_Machine();
    public Form1()
    {
        InitializeComponent();

    }

    void SetupPanel()
    {
        Button button = new Button();
        for (int i = 0; i < 101; i++)
        {
            Label label = new Label();
            label.Text = (50 - i).ToString() + "   0";
            label.Location = new Point(2500 - i * 25, panel1.Location.Y / 2);
            label.Width = 25;
            label.Height = 30;
            label.Click += OnTapeClick;

            //button.Text = "0";
            //button.Location = new Point(2500 - i * 25, panel1.Location.Y / 2 + 20);
            //button.Click += OnTapeClick;

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
        for (int i = posOfText; i<text.Length; i++)
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
}