using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            CutLetter(text);
            Console.ReadKey();
        }

        public static void CutLetter(string text)
        {
            int sum = 0;
            int number = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] % 2 != 0)
                {
                    number = text[i] - 48;
                    sum += number;
                    Console.WriteLine(sum);
                }
            }
        }
        
    }
}