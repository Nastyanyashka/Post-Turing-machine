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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            Karetka = new Label();
            commands = new TextBox();
            toLeft = new Button();
            toRight = new Button();
            startButton = new Button();
            label1 = new Label();
            loadCommands = new Button();
            saveCommands = new Button();
            saveState = new Button();
            loadState = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(Karetka);
            panel1.Location = new Point(12, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 80);
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
            // commands
            // 
            commands.Location = new Point(12, 246);
            commands.Multiline = true;
            commands.Name = "commands";
            commands.Size = new Size(473, 232);
            commands.TabIndex = 3;
            commands.Leave += commands_Changed;
            // 
            // toLeft
            // 
            toLeft.BackColor = Color.FromArgb(179, 97, 79);
            toLeft.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toLeft.Location = new Point(12, 12);
            toLeft.Name = "toLeft";
            toLeft.Size = new Size(75, 23);
            toLeft.TabIndex = 4;
            toLeft.Text = "Влево";
            toLeft.UseVisualStyleBackColor = false;
            toLeft.Click += toLeft_Click;
            // 
            // toRight
            // 
            toRight.BackColor = Color.FromArgb(179, 97, 79);
            toRight.ForeColor = SystemColors.ControlText;
            toRight.Location = new Point(707, 12);
            toRight.Name = "toRight";
            toRight.Size = new Size(75, 23);
            toRight.TabIndex = 5;
            toRight.Text = "Вправо";
            toRight.UseVisualStyleBackColor = false;
            toRight.Click += toRight_Click;
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(179, 97, 79);
            startButton.Enabled = false;
            startButton.Location = new Point(12, 127);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 6;
            startButton.Text = "Старт";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
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
            // loadCommands
            // 
            loadCommands.BackColor = Color.FromArgb(148, 129, 111);
            loadCommands.Location = new Point(229, 191);
            loadCommands.Name = "loadCommands";
            loadCommands.Size = new Size(256, 23);
            loadCommands.TabIndex = 8;
            loadCommands.Text = "Загрузить команды из текстового файла";
            loadCommands.UseVisualStyleBackColor = false;
            loadCommands.Click += loadCommands_Click;
            // 
            // saveCommands
            // 
            saveCommands.BackColor = Color.FromArgb(148, 129, 111);
            saveCommands.Location = new Point(229, 162);
            saveCommands.Name = "saveCommands";
            saveCommands.Size = new Size(256, 23);
            saveCommands.TabIndex = 9;
            saveCommands.Text = "Загрузить команды в текствоый файл";
            saveCommands.UseVisualStyleBackColor = false;
            saveCommands.Click += saveCommands_Click;
            // 
            // saveState
            // 
            saveState.BackColor = Color.FromArgb(148, 129, 111);
            saveState.Location = new Point(12, 162);
            saveState.Name = "saveState";
            saveState.Size = new Size(211, 23);
            saveState.TabIndex = 10;
            saveState.Text = "Сохранить состояние машины";
            saveState.UseVisualStyleBackColor = false;
            saveState.Click += saveState_Click;
            // 
            // loadState
            // 
            loadState.BackColor = Color.FromArgb(148, 129, 111);
            loadState.Location = new Point(12, 191);
            loadState.Name = "loadState";
            loadState.Size = new Size(211, 23);
            loadState.TabIndex = 11;
            loadState.Text = "Загрузить состояние машины";
            loadState.UseVisualStyleBackColor = false;
            loadState.Click += loadState_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(491, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 351);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Правила использования";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(279, 315);
            label2.TabIndex = 0;
            label2.Text = resources.GetString("label2.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 217, 186);
            ClientSize = new Size(793, 490);
            Controls.Add(groupBox1);
            Controls.Add(loadState);
            Controls.Add(saveState);
            Controls.Add(saveCommands);
            Controls.Add(loadCommands);
            Controls.Add(label1);
            Controls.Add(startButton);
            Controls.Add(toRight);
            Controls.Add(toLeft);
            Controls.Add(commands);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Машина поста";
            Load += Form1_Load;
            Click += Form1_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox commands;
        private Label Karetka;
        private Button toLeft;
        private Button toRight;
        private Button startButton;
        private Label label1;
        private Button loadCommands;
        private Button saveCommands;
        private Button saveState;
        private Button loadState;
        private GroupBox groupBox1;
        private Label label2;
    }
}