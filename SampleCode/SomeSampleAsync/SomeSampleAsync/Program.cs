﻿// See https://aka.ms/new-console-template for more information
using SomeSampleAsync;
using System.Diagnostics;
using WebApi.Model;
using static SomeSampleAsync.ApiAsyncMethods;

var timer = new Stopwatch();
//// First sample using async and await, both calls are waited but done in the same time
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

//// Do Parallel operations with a limit on how many processors should be used
//List<int> numberList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

//ParallelOptions opt = new ParallelOptions();
//opt.MaxDegreeOfParallelism = 4;

//Parallel.ForEach(numberList, opt, i =>
//{
//    Console.WriteLine("Writing {0} operation", i);
//});


//Action task2 = () =>
//{
//    string[] contents = File.ReadAllLines(filePaths[1]);

//    Parallel.ForEach(contents, (content) =>
//    {
//        Console.WriteLine("Lower : {0}", content.ToLower());
//    });
//};

//Parallel.Invoke(task1, task2);

// Doing a sample computation using Factory.StartNew and doig Tasks in a for loop.
//Task<Double>[] taskArray = {
//    Task<Double>.Factory.StartNew(() => DoComputation(1.0)),
//    Task<Double>.Factory.StartNew(() => DoComputation(100.0)),
//    Task<Double>.Factory.StartNew(() => DoComputation(1000.0))
//};

//var results = new Double[taskArray.Length];
//Double sum = 0;

//for (int i = 0; i < taskArray.Length; i++)
//{
//    results[i] = taskArray[i].Result;
//    Console.Write("{0:N1} {1}", results[i], i == taskArray.Length - 1 ? "= " : "+ ");
//    sum += results[i];
//}
//Console.WriteLine("{0:N1}", sum);

//double DoComputation(double start)
//{
//    Double sum = 0;
//    for (var value = start; value <= start + 10; value += .1)
//        sum += value;

//    return sum;
//}

// Parallel with Linq
//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//var evenNumbers = numbers.AsParallel().Where(n => n % 2 == 0);
//evenNumbers.ForAll(n => Console.WriteLine(n));

//// Other sample of code using PLinq
//List<Employee> employees = new List<Employee>
//{
//    new Employee { Name = "John", Salary = 50000 },
//    new Employee { Name = "Jane", Salary = 60000 },
//    new Employee { Name = "Adam", Salary = 70000 },
//    new Employee { Name = "Eve", Salary = 80000 }
//};

////var highSalaryEmployees = employees.AsParallel().Where(e => e.Salary > 65000);

////highSalaryEmployees.ForAll(e => Console.WriteLine("{0} has a high salary.", e.Name));

//// Combine PLinq and Task
//var highSalaryEmployeesTask = Task.Factory.StartNew(() =>
//{
//    var highSalaryEmployees = employees.AsParallel().Where(e => e.Salary > 65000);
//    return highSalaryEmployees.ToList();
//});

//await highSalaryEmployeesTask.ContinueWith(task =>
//{
//    foreach (var employee in task.Result)
//    {
//        Console.WriteLine("{0} has a high salary.", employee.Name);
//    }
//});

//HttpClient client = new HttpClient();

//var stopwatch = new Stopwatch();
//stopwatch.Start();

////// Way to wait on each task to be done one by one, should use at least 3000 ms
////var facebookFollowers = await ApiAsyncMethods.GetFacebookFollowers(client);
////var twitterFollowers = await ApiAsyncMethods.GetTwitterFollowers(client);
////var instagramFollowers = await ApiAsyncMethods.GetInstagramFollowers(client);

//// Way to do all call asynchronously, should use around 1000ms because all operations are done at the same time
//var facebookFollowersTask = ApiAsyncMethods.GetFacebookFollowers(client);
//var twitterFollowersTask = ApiAsyncMethods.GetTwitterFollowers(client);
//var instagramFollowersTask = ApiAsyncMethods.GetInstagramFollowers(client);

//await Task.WhenAll(facebookFollowersTask, twitterFollowersTask, instagramFollowersTask);

////var facebookFollowers = await facebookFollowersTask;
////var twitterFollowers = await twitterFollowersTask;
////var instagramFollowers = await instagramFollowersTask;

//// Other way with .Result
//var facebookFollowers = facebookFollowersTask.Result;
//var twitterFollowers = twitterFollowersTask.Result;
//var instagramFollowers = instagramFollowersTask.Result;

//var user = new User("UserName", facebookFollowers, twitterFollowers, instagramFollowers);
//Console.WriteLine(user.ToString());

//// Forecast sample code, done 100 times
//for (int i = 0; i <= 100; i++)
//{
//    var weatherTask = ApiAsyncMethods.GetWeatherRandom(client);
//    var weatherResult = await weatherTask;
//    Console.WriteLine($"Iteration {i}, Result {weatherResult}");
//}

//// Forecast sample code, done 100 times in parallel, be carefull in this case it's not always faster
//// And this can cause deadlocks !!!!!!!!!!!
//Parallel.For(0, 100, async (i) =>
//{
//    var weatherResult = await ApiAsyncMethods.GetWeatherRandom(client);
//    Console.WriteLine($"Iteration {i}, Result {weatherResult}");
//});

//stopwatch.Stop();
//Console.WriteLine("Time elapsed : {0}", stopwatch.ElapsedMilliseconds);

//// Handling Exceptions when we do asynchronous calls :
//// Doing it like this won't give us all exceptions that happens, only the first one.
//try
//{
//    var task = new TaskCompletionSource<int>();
//    task.TrySetException(new Exception[]
//    {
//        new Exception("First exception"),
//        new Exception("Second exception")
//    });

//    var result = await Task.WhenAll(task.Task);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//// This way is going to give us all the exceptions that happens at once, so we can handle multiple errors at once
//try
//{
//    var task = new TaskCompletionSource<int>();
//    task.TrySetException(new Exception[]
//    {
//        new Exception("First exception"),
//        new Exception("Second exception")
//    });

//    var result = await TaskExceptionGetAll.WhenAll(task.Task);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

