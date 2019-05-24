using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fibonacci
    {
        public static void Main()
        {
            int[] a = new int[12];

            a[0] = 0;
            a[1] = 1;

            for (int i = 2; i <= 11; i++)
            {
                a[i] = a[i - 1] + a[i - 2];

            }

            string output = String.Join("", a);
            Console.WriteLine(output);
        }
    }
}
