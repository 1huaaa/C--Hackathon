using System.Security.AccessControl;

namespace Hackathon04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnCheck.Enabled = false;
            btnReset.Enabled = false;
            btnShowAnswer.Enabled = false;
        }

        int[] answer = new int[4];
        Random rnd = new Random();

        private void btnStart_Click(object sender, EventArgs e)
        {
            answer = Enumerable.Range(0, 10).OrderBy(x => rnd.Next()).Take(4).ToArray();

            lstHistory.Items.Clear();
            txtInput.Clear();
            btnCheck.Enabled = true;
            btnReset.Enabled = true;
            btnShowAnswer.Enabled = true;
            btnStart.Enabled = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string guess = txtInput.Text;

            if (guess.Length != 4)
            {
                MessageBox.Show("請輸入4個數字!");
                return;
            }

            if (!guess.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("只能輸入數字!");
                return;
            }

            if (guess.Distinct().Count() != 4)
            {
                MessageBox.Show("數字不能重複!");
                return;
            }

            int countA = 0;
            int countB = 0;

            for (int i = 0; i < 4; i++)
            {
                int guessNum = int.Parse(guess[i].ToString());

                if (guessNum == answer[i])
                {
                    countA++;
                }
                else if (Array.IndexOf(answer, guessNum) != -1)
                    countB++;
            }

            lstHistory.Items.Add($"{guess} : {countA}A{countB}B");

            if (countA == 4)
            {
                MessageBox.Show("恭喜你猜中了!");

                btnCheck.Enabled = false;
                btnShowAnswer.Enabled = false;
                btnReset.Enabled = false;
                btnStart.Enabled = true;
            }

            txtInput.Clear();
            txtInput.Focus();
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            string ans = string.Join("", answer);
            MessageBox.Show($"答案是:{ans}");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();
            txtInput.Clear();
            btnCheck.Enabled = false;
            btnReset.Enabled = false;
            btnShowAnswer.Enabled = false;
            btnStart.Enabled = true;
        }
    }
}
