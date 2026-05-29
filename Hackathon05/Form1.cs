namespace Hackathon05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            // 取得生日，轉成整數
            DateTime birthday = dtpBirth.Value;
            int initialNumber = int.Parse(birthday.ToString("yyyyMMdd"));

            // 取後四位判斷星座
            int md = initialNumber % 10000;
            string zodiac = GetZodiac(md);

            // 算生命靈數
            int lifeNumber = CalculateLifeNumber(initialNumber);

            // 從資料檔找描述
            string description = GetDescription(zodiac, lifeNumber);

            lblZodiac.Text = $"你的星座是 {zodiac}";
            lblComment.Text = description;
        }

        static string GetZodiac(int md)
        {
            if (md <= 119) return "Capricorn摩羯座";
            if (md <= 218) return "Aquarius水瓶座";
            if (md <= 320) return "Pisces雙魚座";
            if (md <= 419) return "Aries牧羊座";
            if (md <= 520) return "Taurus金牛座";
            if (md <= 620) return "Gemini雙子座";
            if (md <= 722) return "Cancer巨蟹座";
            if (md <= 822) return "Leo獅子座";
            if (md <= 922) return "Virgo處女座";
            if (md <= 1022) return "Libra天秤座";
            if (md <= 1121) return "Scorpio天蠍座";
            if (md <= 1221) return "Sagittarius射手座";
            return "Capricorn摩羯座";
        }

        static int CalculateLifeNumber(int n)
        {
            if (n < 10) return n;

            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return CalculateLifeNumber(sum);
        }

        static string GetDescription(string zodiac, int lifeNumber)
        {
            string filePath =  "生命靈數.txt";
            if (!File.Exists(filePath)) return "找不到資料檔案";

            string currentZodiac = "";

            foreach (string line in File.ReadLines(filePath))
            {
                string trimmed = line.Trim();

                // 標題行判斷
                if (trimmed.Contains("【"))
                {
                    currentZodiac = trimmed.Contains(zodiac) ? zodiac : "";
                    continue;
                }

                // 找對應生命靈數
                if (currentZodiac == zodiac && trimmed.StartsWith($"生命靈數{lifeNumber}："))
                {
                    return trimmed;
                }
            }

            return "找不到對應描述";
        }

    }
}
