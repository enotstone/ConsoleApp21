using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp21
{
    class Program
    {
        const int n = 10;
        const int m = n;
        static int[,] squard = new int[n, m];

        static void Main()
        {


            //int[,] squard = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    squard[i, j] = 0;
                    Console.Write(squard[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();

            ThreadStart threadStart = new ThreadStart(Gardner1);
            Thread thread = new Thread(threadStart);
            thread.Start();

            Gardner2();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    Console.Write($"{squard[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
        static void Gardner1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (squard[i, j] == 0)
                    {
                        squard[i, j] = 1;
                    }
                    Thread.Sleep(10);
                }
            }
        }

        static void Gardner2()
        {
            for (int j = n - 1; j >= 0; j--) 
            {
                for (int i = 0; i<m; i++)
                {
                    if (squard[i, j] == 0)
                    {
                        squard[i, j] = 2;
                    }
                    Thread.Sleep(10);
                    //Console.Write(squard[i, j] + " ");


                    //for (int ir = 0; ir<n; ir++)
                    //{
                    //    for (int jr = 0; jr<m; jr++)
                    //    {

                    //        Console.Write(squard[ir, jr] + " ");
                    //    }
                    //    Console.WriteLine();
                    //}
                    //Thread.Sleep(100);
                    //Console.WriteLine();  
                }
                //Console.WriteLine();
            }
        }
    }
}
