using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Simple
    {
        public static void Main()
        {
            //Console.Write("Please Enter Your Name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Good Morning {0} where {0} is the name you had input.", name);

            //Console.Write("Input integers:");
            //double input = Convert.ToDouble(Console.ReadLine());
            //double result = Math.Round(Math.Sqrt(input),3);
            //Console.WriteLine("{0:0.###}",result);

            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.Write("Enter your Gender M/F:");
            string gender = Console.ReadLine();
            Console.Write("Enter your Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            switch (gender)
            {
                case "M":
                    if (age >= 40)
                    {
                        Console.WriteLine("Good Morning Uncle {0}",name);
                    }
                    else
                    {
                        Console.WriteLine("Good Morning Mr. {0}", name);
                    }
                    break;
                case "F":
                    if (age >= 40)
                    {
                        Console.WriteLine("Good Morning Anty {0}", name);
                    }
                    else
                    {
                        Console.WriteLine("Good Morning Ms. {0}", name);
                    }
                    break;

                default:
                    Console.WriteLine("Wrong Gender");
                    break;
            }


        }
    }
}
