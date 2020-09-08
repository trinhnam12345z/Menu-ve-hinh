using System;

namespace Ve_hinh
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 5;
            int i, j, a, b, k;
            int choice1 = 0;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Print the rectangle");
                Console.WriteLine("2. Print the square triangle (The corner is square at 4 different angles: top-left, top-right, botton-left, botton-right)");
                Console.WriteLine("3. Print isosceles triangle");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        for (i = 1; i <= 3; i++)
                        {
                            for (j = 1; j <= 7; j++)
                            {
                                Console.Write(" * ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Chon goc: ");
                            Console.WriteLine("1. top-left");
                            Console.WriteLine("2. top-right");
                            Console.WriteLine("3. botton-left");
                            Console.WriteLine("4. botton-right");
                            choice1 = Int32.Parse(Console.ReadLine());
                            while (choice1 != 0)
                            {
                                if (choice1 == 1)
                                {
                                    for (a = 5; a >= 1; a--)
                                    {
                                        for (b = 1; b <= a; b++)
                                        {
                                            Console.Write("*");
                                        }
                                        Console.WriteLine();
                                    }
                                    break;
                                }
                                else if (choice1 == 2)
                                {
                                    for (a = 1; a <= 5; a++)
                                    {
                                        for (b = 1; b <= 5; b++)
                                        {
                                            if (b < a)
                                            {
                                                Console.Write(" ");
                                            }
                                            else
                                                Console.Write("*");
                                        }
                                        Console.WriteLine();
                                    }
                                    break;



                                }
                                else if (choice1 == 3)
                                {
                                    for (a = 1; a <= 5; a++)
                                    {
                                        for (b = 1; b <= a; b++)
                                        {
                                            Console.Write("*");
                                        }
                                        Console.WriteLine();
                                    }
                                    break;
                                }
                                else if (choice1 == 4)
                                {
                                    for (a = 1; a <= 5; a++)
                                    {
                                        for (b = 5; b >= 1; b--)
                                        {
                                            if (b > a)
                                            {
                                                Console.Write(" ");
                                            }
                                            else
                                                Console.Write("*");
                                        }
                                        Console.WriteLine();
                                    }
                                    break;
                                }
                            }
                        }
                        break;
                    case 3:
                        for (i = 1; i < 10; i += 2)
                        {
                            for (k = 0; k < (4 - i / 2); k++)
                            {
                                Console.Write(" ");
                            }
                            for (j = 0; j < i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine("");
                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
    }
}
