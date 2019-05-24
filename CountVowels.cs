using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CountVowels
    {
        public static void Main()
        {
            Console.Write("Enter a phrase:");
            string phrase = Console.ReadLine();

            int count = 0;
            string[] vowels = { "a", "e", "i", "o", "u" };
            int[] voewlcount = new int[5];

            for (int i = 0;i< phrase.Length; i++)
            {
                string c = phrase.Substring(i, 1).ToLower();
                if (vowels.Contains(c))
                {
                    count++;
                }
                for (int j = 0; j < 5; j++)
                {
                    if (c == vowels[j])
                    {
                        voewlcount[j]++;
                    }
                }
            }

            Console.WriteLine("Total number of vowels:" + count);
                for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Number of {0}: {1}", vowels[i], voewlcount[i]);
            }
        }
    }
}
