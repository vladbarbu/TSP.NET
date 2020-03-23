using System;
using System.Threading;
using System.Diagnostics;

namespace Lab1.net
{
    class Program
    {
        static int MaxPrimeNumFirst(int num)
        {
            DateTime date1 = DateTime.Now;
            var sw = Stopwatch.StartNew();

            Console.WriteLine("First Thread {0}: {1}",
                        Thread.CurrentThread.ManagedThreadId, date1);
            for (int i = num - 1; i > 1; i--)
            {
                bool flag = true;
                for(int j = 2;j < i; j++)
                {
                    if (i % j == 0)
                        flag = false;
                }
                if (flag) {
                    Console.WriteLine("First Max prime number: {0}", i);
                    break;
                }

            }
            Console.WriteLine("Thread {0}: Elapsed {1:N2} seconds",
                           Thread.CurrentThread.ManagedThreadId,
                           sw.ElapsedMilliseconds / 1000.0);
            sw.Stop();
            return 0;
        }

        static int MaxPrimeNumSecond(int num)
        {
            DateTime date1 = DateTime.Now;
            var sw = Stopwatch.StartNew();

            Console.WriteLine("First Thread {0}: {1}",
                        Thread.CurrentThread.ManagedThreadId, date1);
            int last_num = 0;
            for (int i = 2; i < num; i++)
            {
                bool flag = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        flag = false;
                }
                if (flag)
                {
                    last_num = i;
                }
            }
            Console.WriteLine("Thread {0}: Elapsed {1:N2} seconds",
                           Thread.CurrentThread.ManagedThreadId,
                           sw.ElapsedMilliseconds / 1000.0);
            sw.Stop();

            Console.WriteLine("Second Max prime number: {0}", last_num);
            return 0;
        }
        static void Main(string[] args)
        {            
            int param_1 = 500000;
            int param_2 = 500000;
            Thread t_1 = new Thread(() => MaxPrimeNumFirst(param_1));
            Thread t_2 = new Thread(() => MaxPrimeNumSecond(param_2));

            t_1.Start();
            t_2.Start();
            t_2.Join();
        }
    }
}
