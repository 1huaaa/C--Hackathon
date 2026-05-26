namespace Hackathon02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.Text == ".")
            {
                if (txtInput.Text.Contains(".")) return; // 已有小數點
                if (txtInput.Text == "") return;          // 空白的話不能輸入
            }

            txtInput.Text += clickedButton.Text;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                MessageBox.Show("請先輸入數字！");
                return;
            }

            if (!double.TryParse(txtInput.Text, out double inputTemp))
            {
                MessageBox.Show("請輸入有效的溫度數字！");
                return;
            }

            if (rbCtoF.Checked)
            {
                double fahrenheit = (9.0 / 5.0) * inputTemp + 32;
                lblResult.Text = $"結果：{inputTemp}℃ = {fahrenheit:F1}℉";
            }
            else
            {
                double celsius = (inputTemp - 32) * (5.0 / 9.0);
                lblResult.Text = $"結果：{inputTemp}℉ = {celsius:F1}℃";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lblResult.Text = "";
        }
    }
}
