using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Stars
    {
        public static void Main()
        {
            for(int i = 0; i < 6; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //int pad = 50;
            //for (int i = 1; i < 6; i++)
            //{
            //    for (int j = 0; j <pad; j++)
            //    {
            //        if (j < (pad - i))
            //        {
            //            Console.Write("");
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }

            //}

            int spaces = 20;
            string stars, spaceString;

            for (int i = 1; i < 6; i++)
            {
                if(i%2 == 0)
                {
                    spaces--;
                }
                spaceString = new String(' ', spaces);
                stars = new String('*',i);
                Console.WriteLine("{0}{1}", spaceString, stars);
            }

            //inverse triangle
            int spacesI = 20;
            string starsI, spaceStringI;

            for (int i = 6; i >=1; i--)
            {
                if (i % 2 == 0)
                {
                    spaces++;
                }
                spaceStringI = new String(' ', spacesI);
                starsI = new String('*', i);
                Console.WriteLine("{0}{1}", spaceStringI, starsI);
            }

            for(int i = 1;i <=5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+ " ");
                }
                Console.WriteLine();
            }

            //OtherWise
            int number = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }

            //OneDice till 6
            Random r = new Random();
            int dice;

            do
            {
                dice = r.Next(1, 7);
                Console.WriteLine(dice);
            } while (dice != 6);

            //Two Dice till equal one and two
            //Random r = new Random();
            int one, two;

            do
            {
                one = r.Next(1, 7);
                two = r.Next(1, 7);
                Console.WriteLine("{0}{1}",one,two);
            } while (one != two);

            //Two Dice till same number in a row
            //Random r = new Random();
            int Nowdice =0;
            int previous = 0;

            do
            {
                previous = Nowdice;
                Nowdice = r.Next(1, 7);
                Console.WriteLine(Nowdice);
            } while (Nowdice != previous);

            //dec order sort
            int[] a = new int[] { 2,4,6,8,10,12,14,16,18};

            for (int i = 0;i< a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[j] > a[i])
                    {
                        int temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                    Console.WriteLine(String.Join(" ", a));
                }
            }

            //asc order sort
            int[] b = new int[] { 12, 4, 19, 8, 10, 1, 14, 9, 18 };

            for (int i = 0; i < b.Length; i++)
            {
                for (int j = i + 1; j < b.Length; j++)
                {
                    if (b[j] < b[i])
                    {
                        int temp = b[j];
                        b[j] = b[i];
                        b[i] = temp;
                    }
                    Console.WriteLine(String.Join(" ", b));
                }
            }
        }
               
    }
}
