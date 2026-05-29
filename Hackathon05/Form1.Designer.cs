namespace Hackathon05
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
            lblSelectBirth = new Label();
            dtpBirth = new DateTimePicker();
            btnAnalyze = new Button();
            lblAboutYou = new Label();
            lblZodiac = new Label();
            lblComment = new Label();
            SuspendLayout();
            // 
            // lblSelectBirth
            // 
            lblSelectBirth.AutoSize = true;
            lblSelectBirth.Location = new Point(138, 81);
            lblSelectBirth.Name = "lblSelectBirth";
            lblSelectBirth.Size = new Size(100, 23);
            lblSelectBirth.TabIndex = 0;
            lblSelectBirth.Text = "請選擇生日\n";
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(87, 127);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(192, 30);
            dtpBirth.TabIndex = 1;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(126, 210);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(112, 34);
            btnAnalyze.TabIndex = 2;
            btnAnalyze.Text = "分析結果";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // lblAboutYou
            // 
            lblAboutYou.AutoSize = true;
            lblAboutYou.Location = new Point(351, 81);
            lblAboutYou.Name = "lblAboutYou";
            lblAboutYou.Size = new Size(64, 23);
            lblAboutYou.TabIndex = 3;
            lblAboutYou.Text = "關於你";
            // 
            // lblZodiac
            // 
            lblZodiac.AutoSize = true;
            lblZodiac.Location = new Point(347, 143);
            lblZodiac.Name = "lblZodiac";
            lblZodiac.Size = new Size(100, 23);
            lblZodiac.TabIndex = 4;
            lblZodiac.Text = "你的星座是";
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Location = new Point(351, 177);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(0, 23);
            lblComment.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 450);
            Controls.Add(lblComment);
            Controls.Add(lblZodiac);
            Controls.Add(lblAboutYou);
            Controls.Add(btnAnalyze);
            Controls.Add(dtpBirth);
            Controls.Add(lblSelectBirth);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelectBirth;
        private DateTimePicker dtpBirth;
        private Button btnAnalyze;
        private Label lblAboutYou;
        private Label lblZodiac;
        private Label lblComment;
    }
}
