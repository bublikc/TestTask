using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskDataWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please, choose action:");
                Console.WriteLine("1) Convert roman to int");
                Console.WriteLine("2) Check balance");
                Console.WriteLine("3) Reverse list");
                Console.WriteLine("4) Exit");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        {
                            Console.WriteLine("Enter roman:");
                            var roman = Console.ReadLine();
                            int number = RomanNumbers.ToInt(roman);
                            Console.WriteLine($"Your number is {number}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter string with parentheses:");
                            var stringWithParentheses = Console.ReadLine();
                            var result = ParenthesesChecker.Check(stringWithParentheses);
                            Console.WriteLine($"Entered string is corrected: {result}");
                            break;
                        }
                    case 3:
                        {
                            var list = new DoubleLinkedList<int>();
                            for (int i = 5; i > 0; i--)
                            {
                                list.AddFirst(i);
                            }
                            for (int i = 5; i < 10; i++)
                            {
                                list.AddLast(i);
                            }

                            Console.WriteLine("Before reversing:");
                            list.Print();

                            Console.WriteLine("After reversing:");
                            list.Reverse();
                            list.Print();



                            break;
                        }
                    case 4: { return; }
                }
            }
        }
    }
}
