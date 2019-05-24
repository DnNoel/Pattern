using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Palindrome
    {
        public static void Main()
        {
            Console.Write("Enter a Phrase:");
            string phrase = Console.ReadLine();

            string reversePhrase = "";

            for (int i = 0; i < phrase.Length; i++)
            {
                string a = phrase.Substring(i, 1);
                reversePhrase = a + reversePhrase;
            }

            if (phrase == reversePhrase)
            {
                Console.WriteLine("This phrase is Palindrome");
            }
            else
            {
                Console.WriteLine("This phrase is Not Palindrome");
            }
        }
    }
}
