using System;
using System.Collections.Generic;
using System.Linq;

namespace Hackathon03

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入英文敘述字串：");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("輸入內容不能為空！");
                return;
            }

            // 只保留字母，其他全部變空格
            string cleanInput = new string(
                input.ToLower()
                     .Select(c => char.IsLetter(c) ? c : ' ')
                     .ToArray()
            );

            // 用空格切開，過濾空項目
            string[] words = cleanInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);


            Console.WriteLine("\n計算結果：");
            foreach (var group in words.GroupBy(w => w))
            {
                Console.WriteLine($" {group.Key} : {group.Count()}");
            }
        }
    }
}