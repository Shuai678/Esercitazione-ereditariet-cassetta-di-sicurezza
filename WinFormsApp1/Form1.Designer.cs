namespace WinFormsApp1
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
            btn1 = new Button();
            btn2 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            label1 = new Label();
            confermabtn = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(95, 89);
            btn1.Name = "btn1";
            btn1.Size = new Size(46, 45);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(147, 89);
            btn2.Name = "btn2";
            btn2.Size = new Size(46, 45);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(95, 140);
            btn4.Name = "btn4";
            btn4.Size = new Size(46, 45);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(199, 89);
            btn3.Name = "btn3";
            btn3.Size = new Size(46, 45);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(199, 140);
            btn6.Name = "btn6";
            btn6.Size = new Size(46, 45);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(147, 140);
            btn5.Name = "btn5";
            btn5.Size = new Size(46, 45);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(147, 242);
            btn0.Name = "btn0";
            btn0.Size = new Size(46, 45);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(199, 191);
            btn9.Name = "btn9";
            btn9.Size = new Size(46, 45);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(147, 191);
            btn8.Name = "btn8";
            btn8.Size = new Size(46, 45);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(95, 191);
            btn7.Name = "btn7";
            btn7.Size = new Size(46, 45);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 32);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 11;
            label1.Text = "label1";
            
            // 
            // confermabtn
            // 
            confermabtn.Location = new Point(199, 242);
            confermabtn.Name = "confermabtn";
            confermabtn.Size = new Size(46, 45);
            confermabtn.TabIndex = 12;
            confermabtn.Text = "ok";
            confermabtn.UseVisualStyleBackColor = true;
            confermabtn.Click += confermabtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(82, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 275);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "cassettaDiSicureza";
            // 
            // button1
            // 
            button1.Location = new Point(13, 219);
            button1.Name = "button1";
            button1.Size = new Size(46, 45);
            button1.TabIndex = 14;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 378);
            Controls.Add(confermabtn);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "cassettaDiSicurezza";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn4;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Label label1;
        private Button confermabtn;
        private GroupBox groupBox1;
        private Button button1;
    }
}
