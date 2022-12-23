// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.Diagnostics;

////// Step 1
//Console.WriteLine("--------------------");
//Console.WriteLine("STEP 1 :");
var timer = new Stopwatch();

var numbers = Enumerable.Range(1, 2000);
//timer.Start();

//var concerned = numbers.AsParallel().Where(n => n % 10 == 0 || n % 4 == 0);
////concerned.ForAll(number => Console.WriteLine("number : {0}", number));
//concerned.ToList().ForEach(number => Console.WriteLine("number : {0}", number));

//timer.Stop();
//Console.WriteLine("Time elapsed StepOne: {0}", timer.ElapsedMilliseconds);

//// Step 2
//Console.WriteLine("--------------------");
//Console.WriteLine("STEP 2 :");
//timer.Reset();
//timer.Start();

//var orderedQuery = numbers.AsParallel().AsOrdered().Where(n => n % 10 == 0 || n % 4 == 0);
////orderedQuery.ForAll(number => Console.WriteLine("number : {0}", number));
////orderedQuery.ToList().ForEach(number => Console.WriteLine("number : {0}", number));

//foreach (var number in orderedQuery)
//{
//    Console.WriteLine("number : {0}", number);
//}

//timer.Stop();
//Console.WriteLine("Time elapsed StepTwo: {0}", timer.ElapsedMilliseconds);

//// Step 3
Console.WriteLine("--------------------");
Console.WriteLine("STEP 3 :");
List<Formation> formations = new List<Formation>
{
    new Formation { Name = "Maths", Cost = 200 },
    new Formation { Name = "Français", Cost = 300 },
    new Formation { Name = "Info", Cost = 700 },
    new Formation { Name = "Géographie", Cost = 800 },
    new Formation { Name = "Histoire", Cost = 300 }
};

//var highSalaryFormationsTask = Task.Factory.StartNew(() =>
//{
//    // Modify list content with complex calculation
//    var highSalarySalaries = formations.AsParallel().AsOrdered().Where(e => e.Cost > 500);
//    return highSalarySalaries.ToList();
//});

//await highSalaryFormationsTask.ContinueWith(element =>
//{
//    // Sum()
//    foreach (var formations in element.Result)
//    {
//        Console.WriteLine("{0} has a high cost.", formations.Name);
//    }
//});

var salariesFormations = formations.AsParallel().Where(e => e.Cost > 500);
salariesFormations.ForAll((element) =>
{
    Console.WriteLine("{0} has a high cost.", element.Name);
});

public class Formation
{
    public string Name { get; set; }
    public int Cost { get; set; }
}