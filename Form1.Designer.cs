namespace DichotomyMethodSolver
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
            LeftBoundTextBox = new TextBox();
            RightBoundTextBox = new TextBox();
            EpsilonTextBox = new TextBox();
            ResultTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // LeftBoundTextBox
            // 
            LeftBoundTextBox.Location = new Point(75, 101);
            LeftBoundTextBox.Name = "LeftBoundTextBox";
            LeftBoundTextBox.Size = new Size(330, 23);
            LeftBoundTextBox.TabIndex = 0;
            // 
            // RightBoundTextBox
            // 
            RightBoundTextBox.Location = new Point(75, 152);
            RightBoundTextBox.Name = "RightBoundTextBox";
            RightBoundTextBox.Size = new Size(330, 23);
            RightBoundTextBox.TabIndex = 1;
            // 
            // EpsilonTextBox
            // 
            EpsilonTextBox.Location = new Point(75, 205);
            EpsilonTextBox.Name = "EpsilonTextBox";
            EpsilonTextBox.Size = new Size(330, 23);
            EpsilonTextBox.TabIndex = 2;
            // 
            // ResultTextBox
            // 
            ResultTextBox.Location = new Point(75, 256);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.Size = new Size(330, 23);
            ResultTextBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(75, 303);
            button1.Name = "button1";
            button1.Size = new Size(149, 23);
            button1.TabIndex = 4;
            button1.Text = "Знайти корені";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SearchZeroButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(256, 303);
            button2.Name = "button2";
            button2.Size = new Size(149, 23);
            button2.TabIndex = 5;
            button2.Text = "Зберегти результат";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SaveResultButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 83);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 6;
            label1.Text = "Ліва границя поліному";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 134);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 7;
            label2.Text = "Права границя поліному";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 187);
            label3.Name = "label3";
            label3.Size = new Size(141, 15);
            label3.TabIndex = 8;
            label3.Text = "Точність обчислення (Е)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 238);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 9;
            label4.Text = "Результат";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 46);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(330, 23);
            textBox1.TabIndex = 10;
            textBox1.Text = "x * x - 9 * x + 14";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 28);
            label5.Name = "label5";
            label5.Size = new Size(214, 15);
            label5.TabIndex = 11;
            label5.Text = "Функція поліному за замовчуванням:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(496, 381);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ResultTextBox);
            Controls.Add(EpsilonTextBox);
            Controls.Add(RightBoundTextBox);
            Controls.Add(LeftBoundTextBox);
            MaximizeBox = false;
            MaximumSize = new Size(512, 420);
            MinimumSize = new Size(512, 420);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Метод половинного ділення (дихотомії)";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LeftBoundTextBox;
        private TextBox RightBoundTextBox;
        private TextBox EpsilonTextBox;
        private TextBox ResultTextBox;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
    }
}