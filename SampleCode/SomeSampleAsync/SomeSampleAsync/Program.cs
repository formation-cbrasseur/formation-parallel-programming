// See https://aka.ms/new-console-template for more information
using SomeSampleAsync;
using System.Diagnostics;

var timer = new Stopwatch();
// First sample using async and await, both calls are waited but done in the same time
//SimpleAsyncUsage.SimpleAsyncCall();
//Thread.Sleep(4000);

// Second sample comparing time of 4 different usage of async
//try
//{

//    // Version 1
//    Console.WriteLine("First way to use Async");
//    timer.Start();
//    Console.WriteLine("RandomNumber-UpperString : {0}", await WaysToUseAsync.DoTasksV1("Some string"));
//    timer.Stop();
//    Console.WriteLine("{0} Elapsed time V1", timer.Elapsed.ToString());

//    // Version 2
//    Console.WriteLine("Second way to use Async");
//    timer.Reset();
//    timer.Start();
//    Console.WriteLine("RandomNumber-UpperString : {0}", await WaysToUseAsync.DoTasksV2("Some string"));
//    timer.Stop();
//    Console.WriteLine("{0} Elapsed time V2", timer.Elapsed.ToString());

//    // Version 3
//    Console.WriteLine("Thrird way to use Async");
//    timer.Reset();
//    timer.Start();
//    Console.WriteLine("RandomNumber-UpperString : {0}", await WaysToUseAsync.DoTasksV3("Some string"));
//    timer.Stop();
//    Console.WriteLine("{0} Elapsed time V3", timer.Elapsed.ToString());

//    // Version 4
//    Console.WriteLine("Fourth way to use Async");
//    timer.Reset();
//    timer.Start();
//    Console.WriteLine("RandomNumber-UpperString : {0}", await WaysToUseAsync.DoTasksV4("Some string"));
//    timer.Stop();
//    Console.WriteLine("{0} Elapsed time V4", timer.Elapsed.ToString());
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.ToString());
//}

//// Third sample of code using Parallel class
//List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//Parallel.ForEach(numbers, (number) =>
//{
//    Console.WriteLine($"Processing number: {number}");
//});

//// Just waiting before starting next sample of code
//Thread.Sleep(2000);

//Console.WriteLine("Using Action class to run 2 parallel methods : Starting timer");
//timer.Start();

//Action task1 = () =>
//{
//    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//    Parallel.ForEach(numbers, (number) =>
//    {
//        Console.WriteLine($"Processing number: {number}");
//    });
//    Console.WriteLine("Task 1 is running.");
//    Thread.Sleep(1000);
//};

//Action task2 = () =>
//{
//    List<int> numbers = new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

//    Parallel.ForEach(numbers, (number) =>
//    {
//        Console.WriteLine($"Processing number: {number}");
//    });
//    Console.WriteLine("Task 2 is running.");
//    Thread.Sleep(1500);
//};

//// Use the Parallel.Invoke method to run the tasks concurrently.
//Parallel.Invoke(task1, task2);
//timer.Stop();

//Console.WriteLine("{0} Elapsed time to run 2 actions using Parallel.Invoke", timer.Elapsed.ToString());

//// Some other sample of code using Parallel class
//string[] words = { "Hello", "world", "how", "are", "you", "?" };

//// Use the Parallel.For method to process each string in the array concurrently.
//Parallel.For(0, words.Length, (i) =>
//{
//    Console.WriteLine($"Processing string: {words[i]}");
//});

//// Some other sample of code with a return value
//var sumNumbers = 0;
//Parallel.Invoke(() =>
//{
//    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//    sumNumbers = numbers.Aggregate((total, next) => total + next);
//});

//Console.WriteLine($"The sum of the numbers is: {sumNumbers}");

// Reading files asynchrounously
//List<string> filePaths = new List<string>
//{
//    "file1.txt",
//    "file2.txt",
//    "file3.txt"
//};

//Parallel.ForEach(filePaths, (filePath) =>
//{
//    string[] contents = File.ReadAllLines(filePath);

//    Console.WriteLine($"Processing file: {filePath}");

//    Parallel.ForEach(contents, (content) =>
//    {
//        Console.WriteLine(content);
//    });
//});

// Same but with Parallel.Invoke
// Task one do a ToUpper on all contents and put it in console
// Task two do a ToLower on the all the contents and put it in console
//Action task1 = () =>
//{
//    string[] contents = File.ReadAllLines(filePaths[0]);

//    Parallel.ForEach(contents, (content) =>
//    {
//        Console.WriteLine("Upper : {0}", content.ToUpper());
//    });
//};

//Action task2 = () =>
//{
//    string[] contents = File.ReadAllLines(filePaths[1]);

//    Parallel.ForEach(contents, (content) =>
//    {
//        Console.WriteLine("Lower : {0}", content.ToLower());
//    });
//};

//Parallel.Invoke(task1, task2);

// Parallel with Linq
//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//var evenNumbers = numbers.AsParallel().Where(n => n % 2 == 0);
//evenNumbers.ForAll(n => Console.WriteLine(n));

// Other sample of code using PLinq
List<Employee> employees = new List<Employee>
{
    new Employee { Name = "John", Salary = 50000 },
    new Employee { Name = "Jane", Salary = 60000 },
    new Employee { Name = "Adam", Salary = 70000 },
    new Employee { Name = "Eve", Salary = 80000 }
};

var highSalaryEmployees = employees.AsParallel().Where(e => e.Salary > 65000);

highSalaryEmployees.ForAll(e => Console.WriteLine("{0} has a high salary.", e.Name));