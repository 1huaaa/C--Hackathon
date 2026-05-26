namespace Hackathon02
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
            groupBox1 = new GroupBox();
            rbFtoC = new RadioButton();
            rbCtoF = new RadioButton();
            btn1 = new Button();
            btndot = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            txtInput = new TextBox();
            btnConvert = new Button();
            btnClear = new Button();
            lblResult = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFtoC);
            groupBox1.Controls.Add(rbCtoF);
            groupBox1.Location = new Point(77, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // rbFtoC
            // 
            rbFtoC.AutoSize = true;
            rbFtoC.Location = new Point(39, 79);
            rbFtoC.Name = "rbFtoC";
            rbFtoC.Size = new Size(161, 27);
            rbFtoC.TabIndex = 1;
            rbFtoC.Text = "華氏轉換為攝氏";
            rbFtoC.UseVisualStyleBackColor = true;
            // 
            // rbCtoF
            // 
            rbCtoF.AutoSize = true;
            rbCtoF.Checked = true;
            rbCtoF.Location = new Point(39, 46);
            rbCtoF.Name = "rbCtoF";
            rbCtoF.Size = new Size(161, 27);
            rbCtoF.TabIndex = 0;
            rbCtoF.TabStop = true;
            rbCtoF.Text = "攝氏轉換為華氏";
            rbCtoF.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Location = new Point(361, 62);
            btn1.Name = "btn1";
            btn1.Size = new Size(38, 40);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumber_Click;
            // 
            // btndot
            // 
            btndot.Location = new Point(413, 200);
            btndot.Name = "btndot";
            btndot.Size = new Size(38, 40);
            btndot.TabIndex = 2;
            btndot.Text = ".";
            btndot.UseVisualStyleBackColor = true;
            btndot.Click += btnNumber_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(361, 200);
            btn0.Name = "btn0";
            btn0.Size = new Size(38, 40);
            btn0.TabIndex = 3;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumber_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(467, 154);
            btn9.Name = "btn9";
            btn9.Size = new Size(38, 40);
            btn9.TabIndex = 4;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumber_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(413, 154);
            btn8.Name = "btn8";
            btn8.Size = new Size(38, 40);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumber_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(361, 154);
            btn7.Name = "btn7";
            btn7.Size = new Size(38, 40);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumber_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(467, 108);
            btn6.Name = "btn6";
            btn6.Size = new Size(38, 40);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumber_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(413, 108);
            btn5.Name = "btn5";
            btn5.Size = new Size(38, 40);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumber_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(361, 108);
            btn4.Name = "btn4";
            btn4.Size = new Size(38, 40);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumber_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(467, 62);
            btn3.Name = "btn3";
            btn3.Size = new Size(38, 40);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(413, 62);
            btn2.Name = "btn2";
            btn2.Size = new Size(38, 40);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumber_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(556, 114);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(149, 30);
            txtInput.TabIndex = 12;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(548, 198);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(78, 42);
            btnConvert.TabIndex = 13;
            btnConvert.Text = "轉換";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(648, 198);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 42);
            btnClear.TabIndex = 14;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(548, 268);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 23);
            lblResult.TabIndex = 15;
            lblResult.Text = "結果:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnClear);
            Controls.Add(btnConvert);
            Controls.Add(txtInput);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn0);
            Controls.Add(btndot);
            Controls.Add(btn1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbFtoC;
        private RadioButton rbCtoF;
        private Button btn1;
        private Button btndot;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private TextBox txtInput;
        private Button btnConvert;
        private Button btnClear;
        private Label lblResult;
    }
}
