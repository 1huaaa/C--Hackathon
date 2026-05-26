using System;
using System.Collections.Generic;

namespace Hackathon03

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個有意義的英文敘述字串：");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("輸入內容不能為空！");
                return;
            }

            char[] delimiters = { ' ', ',', '.', '!', '?', ';', ':', '"', '\'' };
            string[] words = input.ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            var wordCounts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                wordCounts[word] = wordCounts.GetValueOrDefault(word) + 1;
            }

            Console.WriteLine("\n計算結果：");
            foreach (var kvp in wordCounts)
            {
                Console.WriteLine($" {kvp.Key} : {kvp.Value}");
            }
        }
    }
}