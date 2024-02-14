using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int length = 5;               // число чисел
            int[] array = new int[length];
            int[] array1 = new int[length];
            int[] array2 = new int[length];

            Task fillArray1 = new Task(() =>
            {
                for (int i = 0; i < length; i++)
                {
                    Thread.Sleep(100);
                    array1[i] = random.Next(1, 10);
                    Console.WriteLine($"array1[{i}] = {array1[i]}");
                }
            });

            Task fillArray2 = new Task(() =>
            {
                for (int i = 0; i < length; i++)
                {
                    Thread.Sleep(100);
                    array2[i] = random.Next(1, 10);
                    Console.WriteLine($"array2[{i}] = {array2[i]}");
                }
            });

            Task sumArrays = new Task(() =>
            {
                for (int i = 0; i < length; i++)
                {
                    Thread.Sleep(100);
                    array[i] = array1[i] + array2[i];
                    Console.WriteLine($"\tarray[{i}] = {array[i]}");
                }
            });

            fillArray1.Start();

            Thread.Sleep(25);
            fillArray2.Start();

            Thread.Sleep(75);
            sumArrays.Start();

            fillArray1.Wait();
            fillArray2.Wait();
            sumArrays.Wait();
        }
    }
}
