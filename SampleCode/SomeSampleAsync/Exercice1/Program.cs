using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Exercice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1
            Console.WriteLine("--------------------");
            Console.WriteLine("STEP 1 :");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Parallel.ForEach(numbers, (number) =>
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Processing number: {number}");
            });

            // Step 2
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine("STEP 2 :");
            var timer = new Stopwatch();

            timer.Start();
            Parallel.ForEach(numbers, (number) =>
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Processing number: {number}");
            });
            timer.Stop();
            Console.WriteLine("{0} Elapsed time to process 10 integers", timer.Elapsed.ToString());

            // Step 3 
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine("STEP 3 :");
            timer.Reset();

            timer.Start();
            Parallel.For(0, numbers.Count, (i) =>
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Processing number: {numbers[i]}");
            });
            timer.Stop();
            Console.WriteLine("{0} Elapsed time to process 10 integers with Parallel.For", timer.Elapsed.ToString());

            // Step 4
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine("STEP 4 :");
            timer.Reset();
            Console.WriteLine("Using Action class to run 2 parallel methods : Starting timer");
            timer.Start();

            Action task1 = () =>
            {
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                Parallel.ForEach(numbers, (number) =>
                {
                    Console.WriteLine($"Processing number: {number}");
                });
                Console.WriteLine("Task 1 is running.");
                Thread.Sleep(1000);
            };

            Action task2 = () =>
            {
                List<int> numbers = new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

                Parallel.ForEach(numbers, (number) =>
                {
                    Console.WriteLine($"Processing number: {number}");
                });
                Console.WriteLine("Task 2 is running.");
                Thread.Sleep(1500);
            };

            // Use the Parallel.Invoke method to run the tasks concurrently.
            Parallel.Invoke(task1, task2);
            timer.Stop();

            Console.WriteLine("{0} Elapsed time to run 2 actions using Parallel.Invoke", timer.Elapsed.ToString());
        }
    }
}
