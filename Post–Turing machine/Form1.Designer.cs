namespace Post_Turing_machine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Karetka = new Label();
            textBox1 = new TextBox();
            toLeft = new Button();
            toRight = new Button();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(Karetka);
            panel1.Location = new Point(12, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 80);
            panel1.TabIndex = 2;
            // 
            // Karetka
            // 
            Karetka.AutoSize = true;
            Karetka.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Karetka.Location = new Point(7, 0);
            Karetka.Name = "Karetka";
            Karetka.Size = new Size(16, 20);
            Karetka.TabIndex = 0;
            Karetka.Text = "↓";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 246);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(760, 189);
            textBox1.TabIndex = 3;
            // 
            // toLeft
            // 
            toLeft.Location = new Point(12, 12);
            toLeft.Name = "toLeft";
            toLeft.Size = new Size(75, 23);
            toLeft.TabIndex = 4;
            toLeft.Text = "Влево";
            toLeft.UseVisualStyleBackColor = true;
            toLeft.Click += toLeft_Click;
            // 
            // toRight
            // 
            toRight.Location = new Point(697, 12);
            toRight.Name = "toRight";
            toRight.Size = new Size(75, 23);
            toRight.TabIndex = 5;
            toRight.Text = "Вправо";
            toRight.UseVisualStyleBackColor = true;
            toRight.Click += toRight_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 127);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Старт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 228);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 7;
            label1.Text = "Ввод команд";
            // 
            // button2
            // 
            button2.Location = new Point(516, 217);
            button2.Name = "button2";
            button2.Size = new Size(256, 23);
            button2.TabIndex = 8;
            button2.Text = "Загрузить команды из текстового файла";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(516, 188);
            button3.Name = "button3";
            button3.Size = new Size(256, 23);
            button3.TabIndex = 9;
            button3.Text = "Загрузить команды в текствоый файл";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 162);
            button4.Name = "button4";
            button4.Size = new Size(211, 23);
            button4.TabIndex = 10;
            button4.Text = "Сохранить состояние машины";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 191);
            button5.Name = "button5";
            button5.Size = new Size(211, 23);
            button5.TabIndex = 11;
            button5.Text = "Загрузить состояние машины";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 443);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(toRight);
            Controls.Add(toLeft);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Машина поста";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label Karetka;
        private Button toLeft;
        private Button toRight;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}