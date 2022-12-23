using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Exercice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "green", "brown", "blue", "red" };
            string s = "e";
            var query = colors.Where(c => c.Contains(s));
            s = "n";
            query = query.Where(c => c.Contains(s));
            Console.WriteLine(query.Count());
            //// Step 1
            //Console.WriteLine("--------------------");
            //Console.WriteLine("STEP 1 :");
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var numbersRange = Enumerable.Range(1, 10);

            //Parallel.ForEach(numbers, (number) =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine($"Processing number: {number}");
            //});

            ////Step 2
            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //Console.WriteLine("STEP 2 :");
            //var timer = new Stopwatch();

            //timer.Start();
            //Parallel.ForEach(numbers, (number) =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine($"Processing number: {number}");
            //});

            //timer.Stop();
            //Console.WriteLine("{0} Elapsed time to process 10 integers Parallel", timer.Elapsed.ToString());

            //timer.Reset();
            //timer.Start();
            //// Simple foreach sur la liste
            //numbers.ForEach(number =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine($"Processing number: {number}");
            //});

            //timer.Stop();
            //Console.WriteLine("{0} Elapsed time to process 10 integers ForEach", timer.Elapsed.ToString());

            //// Step 3 
            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //Console.WriteLine("STEP 3 :");
            //timer.Reset();

            //timer.Start();
            //Parallel.For(0, numbers.Count, (number) =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine($"Processing number: {numbers[number]}");
            //});
            //timer.Stop();
            //Console.WriteLine("{0} Elapsed time to process 10 integers with Parallel.For", timer.Elapsed.ToString());

            //// Step 4
            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //Console.WriteLine("STEP 4 :");
            //timer.Reset();
            //Console.WriteLine("Using Action class to run 2 parallel methods : Starting timer");
            //timer.Start();

            //Action task1 = () =>
            //{
            //    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //    Console.WriteLine("Task 1 is running.");
            //    Parallel.ForEach(numbers, (number) =>
            //    {
            //        Console.WriteLine($"Processing number: {number}");
            //    });
            //    Thread.Sleep(1000);
            //};

            //Action task2 = () =>
            //{
            //    List<int> numbers = new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            //    Console.WriteLine("Task 2 is running.");
            //    Parallel.ForEach(numbers, (number) =>
            //    {
            //        Console.WriteLine($"Processing number: {number}");
            //    });
            //    Thread.Sleep(1500);
            //};

            //// Use the Parallel.Invoke method to run the actions concurrently.
            //Parallel.Invoke(task1, task2);
            //timer.Stop();

            //Console.WriteLine("{0} Elapsed time to run 2 actions using Parallel.Invoke", timer.Elapsed.ToString());

            //// Step 5
            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //Console.WriteLine("STEP 5 :");

            //var sumNumbers = 0;
            //timer.Reset();
            //timer.Start();

            //Action action = () =>
            //{
            //    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //    sumNumbers = numbers.Aggregate((total, next) => total + next);
            //};

            //Parallel.Invoke(action);
            //timer.Stop();
            //Console.WriteLine("Aggregation result : {0}", sumNumbers);
            //Console.WriteLine("{0} Elapsed time to get sum using Parallel.Invoke", timer.Elapsed.ToString());

            //timer.Reset();
            //timer.Start();
            //var sumWithLinq = numbers.Sum();
            //timer.Stop();
            //Console.WriteLine("Linq sum result : {0}", sumWithLinq);
            //Console.WriteLine("{0} Elapsed time to get sum using Linq", timer.Elapsed.ToString());

            //// Step 6
            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //Console.WriteLine("STEP 6 :");
            //List<string> filePaths = new List<string>
            //{
            //    "file1.txt",
            //    "file2.txt"
            //};

            //var numberOfWordsFile1 = 0;
            //var numberOfWordsFile2 = 0;

            //Action taskFile1 = () =>
            //{
            //    string[] contents = File.ReadAllLines(filePaths[0]);

            //    Parallel.ForEach(contents, (content) =>
            //    {
            //        var words = content.Split(" ");
            //        numberOfWordsFile1 += words.Length;
            //        Console.WriteLine("Number of words for this line : {0}", words.Length.ToString());
            //    });
            //};

            //Action taskFile2 = () =>
            //{
            //    string[] contents = File.ReadAllLines(filePaths[1]);

            //    Parallel.ForEach(contents, (content) =>
            //    {
            //        var words = content.Split(" ");
            //        numberOfWordsFile2 += words.Length;
            //        Console.WriteLine("Number of words for this line : {0}", words.Length.ToString());
            //    });
            //};

            //Parallel.Invoke(taskFile1, taskFile2);

            //Console.WriteLine("Number of words for file 1 : {0}", numberOfWordsFile1.ToString());
            //Console.WriteLine("Number of words for file 2 : {0}", numberOfWordsFile2.ToString());
        }
    }
}
