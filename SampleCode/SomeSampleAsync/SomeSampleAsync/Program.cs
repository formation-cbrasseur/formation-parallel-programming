// See https://aka.ms/new-console-template for more information
using SomeSampleAsync;
using System.Diagnostics;

Console.WriteLine("Hello, World!");

// First sample using async and await, both calls are waited but done in the same time
//SimpleAsyncUsage.SimpleAsyncCall();

// Second sample comparing time of 4 different usage of async
try
{
    var timer = new Stopwatch();

    // Version 1
    Console.WriteLine("First way to use Async");
    timer.Start();
    Console.WriteLine("RandomNumber-UpperString : {0}", await WaysToUseAsync.DoTasksV1("Some string"));
    timer.Stop();
    Console.WriteLine("{0} Elapsed time V1", timer.Elapsed.ToString());

    // Version 2
    Console.WriteLine("Second way to use Async");
    timer.Reset();
    timer.Start();
    Console.WriteLine("RandomNumber-UpperString : {0}", await WaysToUseAsync.DoTasksV2("Some string"));
    timer.Stop();
    Console.WriteLine("{0} Elapsed time V2", timer.Elapsed.ToString());

    // Version 3
    Console.WriteLine("Thrird way to use Async");
    timer.Reset();
    timer.Start();
    Console.WriteLine("RandomNumber-UpperString : {0}", await WaysToUseAsync.DoTasksV3("Some string"));
    timer.Stop();
    Console.WriteLine("{0} Elapsed time V3", timer.Elapsed.ToString());

    // Version 4
    Console.WriteLine("Fourth way to use Async");
    timer.Reset();
    timer.Start();
    Console.WriteLine("RandomNumber-UpperString : {0}", await WaysToUseAsync.DoTasksV4("Some string"));
    timer.Stop();
    Console.WriteLine("{0} Elapsed time V4", timer.Elapsed.ToString());
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}