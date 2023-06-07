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
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(Karetka);
            panel1.Location = new Point(12, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 100);
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
            textBox1.Location = new Point(12, 360);
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
            button1.Location = new Point(276, 219);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Старт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(19, 283);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(746, 58);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(toRight);
            Controls.Add(toLeft);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
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
        private TextBox textBox2;
    }
}