using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mass1 = new int[5];
            int[] mass2 = new int[5];
            int[] mass3 = new int[5];
            Random random = new Random();
            Task task1 = new Task(() =>
            {
                for (int i = 0; i < mass1.Length; i++)
                {
                    Thread.Sleep(500);
                    mass1[i] = random.Next(1, 10);
                    Console.WriteLine($"mass1[{i}] = {mass1[i]}");
                }
            });

            Task task2 = new Task(() =>
            {
                for (int i = 0; i < mass2.Length; i++)
                {
                    Thread.Sleep(500);
                    mass2[i] = random.Next(1, 10);
                    Console.WriteLine($"mass2[{i}] = {mass2[i]}");
                }
            });

            Task task3 = new Task(() =>
            {
                for (int i = 0; i < mass3.Length; i++)
                {
                    Thread.Sleep(500);
                    mass3[i] = mass1[i] + mass2[i];
                    Console.WriteLine($"mass3[{i}] = {mass3[i]}");
                }
            });

            task1.Start();
            Thread.Sleep(50);
            task2.Start();
            Thread.Sleep(100);
            task3.Start();

            task1.Wait();
            task2.Wait();
            task3.Wait();
            Console.ReadKey();
        }
    }
}
