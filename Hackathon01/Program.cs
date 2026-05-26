namespace Hackathon01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個大於90的整數：");
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                if (i % 15 == 0)
                    Console.WriteLine("Dann");
                else if (i % 3 == 0)
                    Console.WriteLine("Build");
                else if (i % 5 == 0)
                    Console.WriteLine("School");
                else
                    Console.WriteLine(i);
            }
        } 
    }
}
