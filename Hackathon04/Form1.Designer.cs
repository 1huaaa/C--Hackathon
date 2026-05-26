namespace Hackathon04
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
            btnStart = new Button();
            btnShowAnswer = new Button();
            lstHistory = new ListBox();
            lblHistory = new Label();
            lblInput = new Label();
            txtInput = new TextBox();
            btnCheck = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(101, 83);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 34);
            btnStart.TabIndex = 0;
            btnStart.Text = "開始遊戲";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnShowAnswer
            // 
            btnShowAnswer.Location = new Point(101, 148);
            btnShowAnswer.Name = "btnShowAnswer";
            btnShowAnswer.Size = new Size(112, 34);
            btnShowAnswer.TabIndex = 1;
            btnShowAnswer.Text = "看答案";
            btnShowAnswer.UseVisualStyleBackColor = true;
            btnShowAnswer.Click += btnShowAnswer_Click;
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.Location = new Point(450, 89);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(230, 257);
            lstHistory.TabIndex = 2;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Location = new Point(449, 63);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(82, 23);
            lblHistory.TabIndex = 3;
            lblHistory.Text = "遊戲歷程";
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(101, 287);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(46, 23);
            lblInput.TabIndex = 4;
            lblInput.Text = "輸入";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(101, 313);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(150, 30);
            txtInput.TabIndex = 5;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(101, 358);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(112, 34);
            btnCheck.TabIndex = 6;
            btnCheck.Text = "檢查答案";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(231, 358);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 37);
            btnReset.TabIndex = 7;
            btnReset.Text = "放棄重來";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnCheck);
            Controls.Add(txtInput);
            Controls.Add(lblInput);
            Controls.Add(lblHistory);
            Controls.Add(lstHistory);
            Controls.Add(btnShowAnswer);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnShowAnswer;
        private ListBox lstHistory;
        private Label lblHistory;
        private Label lblInput;
        private TextBox txtInput;
        private Button btnCheck;
        private Button btnReset;
    }
}
