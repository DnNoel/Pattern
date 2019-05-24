using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AlternativeNo
    {
        public static void Main()
        {
            int[] a = new int[20];

            int even = 1;
            int odd = 20;
            
            for (int i = 0; i <20; i++)
            {
                if(i%2 == 0)
                {
                    a[i] = even;
                    even++;
                }
                else
                {
                    a[i] = odd;
                    odd--;
                }
            }

            string output = String.Join("", a);
            Console.WriteLine(output);
        }
    }
}
