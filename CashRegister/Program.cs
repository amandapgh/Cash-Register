using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your purchase total:");
            string inputTotal = Console.ReadLine();
            decimal total = Convert.ToDecimal(inputTotal);

            Console.WriteLine("Enter the amount the customer paid:");
            string inputPayment = Console.ReadLine();
            decimal payment = Convert.ToDecimal(inputPayment);

            decimal change = (payment - total);

            Console.WriteLine("The change is " + (change) + ".");

            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            int g = 0;
            int h = 0;

            while (change >= 20)
            {
                change = change - 20;
                a++;
                if (change < 20)
                {
                    Console.Write(a);
                    Console.Write(" " + "twenty dollar bill");
                }
                if (a > 1)
                {
                    Console.Write("s"); }
            }
            Console.Write(",");
        }

                while (change >= 10)
                {
                    change = change - 10;
                    b++;
                    if (change< 10)
                    {
                        Console.Write(b);
                        Console.Write(" " + "ten dollar bill");
                    }
                        if (b > 1) ;
                   
                        {
                            Console.Write("s");
                        }
                        Console.Write(",");
                }

                    while (change >= 5)
                    {
                        change = change - 5;
                        c++;
                        if (change < 5)
                        {
                            Console.Write(c);
                            Console.Write(" " + "five dollar bill");
                        }
                        if (c > 1) ;
                        {
                            Console.Write("s");
                        }
                        Console.Write(",");
                    }

                    while (change >= 1)
                    {
                        change = change - 1;
                        d++;
                        if (change < 1)
                        {
                            Console.Write(d);
                            Console.Write(" " + "one dollar bill");
                        }
                            if (d > 1) ;
                            {
                                Console.Write("s");
                            }
                            Console.Write(",");
                        }
                    }

                    while (change >= (.25m))
                    {
                        change = change - (.25m);
                        e++;
                        if (change < (.25m))
                        {
                            Console.Write(e);
                            Console.Write(" " + "quarter");
                        }
                            if (e > 1) ;
                            {
                                Console.Write("s");
                            }
                            Console.Write(",");
                        }
                    }

                    while (change >= (.1m))
                    {
                        change = change - (.1m);
                        f++;
                        if (change < (.1m))
                        {
                            Console.Write(f);
                            Console.Write(" " + "dime");
                        }
                            if (f > 1) ;
                            {
                                Console.Write("s");
                            }
                            Console.Write(",");
                        }
                    }

                    while (change >= (.05m))
                    {
                        change = change - (.05m);
                        g++;
                        if (change < (.05m))
                        {
                            Console.Write(g);
                            Console.Write(" " + "nickel");
                        }
                            if (g > 1) ;
                            {
                                Console.Write("s");
                            }
                            Console.Write(",");
                        }
                    }

                    while (change >= (.01m))
                    {
                        change = change - (.01m);
                        h++;
                        if (h > 1)
                        {
                            Console.Write(h);
                            Console.Write(" " + "pennies");
                        }
                        else if (h == 0)
                        {
                            Console.Write(h);
                            Console.Write(" " + "penny");
                        }
                    }
                }
                    Console.Write(".");


                }
            }
        }


    
