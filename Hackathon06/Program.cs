namespace Hackathon06
{
    internal class Program
    {
        struct TaxBracket
        {
            public decimal UpperLimit;
            public decimal Rate;
        }
        static void Main(string[] args)
        {
            TaxBracket[] brackets = {
            new TaxBracket { UpperLimit = 540_000,         Rate = 0.05m },
            new TaxBracket { UpperLimit = 1_210_000,       Rate = 0.12m },
            new TaxBracket { UpperLimit = 2_420_000,       Rate = 0.20m },
            new TaxBracket { UpperLimit = 4_530_000,       Rate = 0.30m },
            new TaxBracket { UpperLimit = 10_310_000,      Rate = 0.40m },
            new TaxBracket { UpperLimit = decimal.MaxValue, Rate = 0.50m },
        };

            Console.Write("請輸入年收入：");
            string input = Console.ReadLine();

            if (!decimal.TryParse(input, out decimal income) || income < 0)
            {
                Console.WriteLine("輸入無效，請輸入正整數。");
                return;
            }

            decimal tax = 0;
            decimal previous = 0;

            foreach (var bracket in brackets)
            {
                if (income <= previous) break;

                decimal upper = Math.Min(income, bracket.UpperLimit);
                decimal taxable = upper - previous;
                tax += taxable * bracket.Rate;

                previous = bracket.UpperLimit;
            }


            Console.WriteLine($"年收入：{income}");
            Console.WriteLine($"應繳稅額：{tax:N2}");
        }
    }
}
