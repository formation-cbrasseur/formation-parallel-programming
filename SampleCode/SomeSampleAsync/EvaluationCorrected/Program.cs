// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
//-Faire un calcul de la somme de tous les nombres entre 1 et 3000 en opération parallèle
//- Ce premier calcul doit être effectué en amont (pas en parallèle des deux prochains)
//-Traiter deux fichiers pour compter le nombre de mots
//- Traiter deux fichiers pour compter d'occurences de "Lorem ipsum"
//- Afficher le cumul des mots des deux fichiers (séparateur " ")
//-Afficher le cumul d'occurences de "Lorem ipsum" (A vous de trouver un moyen de réaliser cette étape) ==> TODO, needs adaptation
//- Afficher le résultat du calcul de la somme des nombres entre 1 et 3000
//- Réaliser une opérations finale qui affiche le cumul des 3 nombres résultats précédents.
//- Afficher les informations pour chaque étape, celle du résultat finale attendu et le temps de traitement dans la Console

var timer = new Stopwatch();
timer.Start();

// Calculate somme between all numbers from 1 to 1000
var sumNumbers = 0;
Parallel.Invoke(() =>
{
    var numbers = Enumerable.Range(1,3000);

    sumNumbers = numbers.Aggregate((total, next) => total + next);
});

Console.WriteLine("Sum between all numbers from 1 to 3000 : {0}", sumNumbers);

// Doing calculation on files asynchronously
List<string> filePaths = new List<string>
{
    "Eval_file1.txt",
    "Eval_file2.txt"
};

Task<int> taskWordFile1 = Task.Factory.StartNew(() =>
{
    string[] contents = File.ReadAllLines(filePaths[0]);
    var number = 0;

    foreach(var content in contents)
    {
        var words = content.Split(" ");
        number += words.Length;
    }

    return number;
});


Task<int> taskWordFile2 = Task.Factory.StartNew(() =>
{
    string[] contents = File.ReadAllLines(filePaths[1]);
    var number = 0;

    foreach (var content in contents)
    {
        var words = content.Split(" ");
        number += words.Length;
    }

    return number;
});

Task<int> taskLineFile1 = Task.Factory.StartNew(() =>
{
    string[] contents = File.ReadAllLines(filePaths[0]);

    return contents.Length;
});


Task<int> taskLineFile2 = Task.Factory.StartNew(() =>
{
    string[] contents = File.ReadAllLines(filePaths[1]);

    return contents.Length;
});

await Task.WhenAll(taskWordFile1, taskLineFile1, taskWordFile2, taskLineFile2);

var numberOfWordsFile1 = taskWordFile1.Result;
var numberOfLinesFile1 = taskLineFile1.Result;
var numberOfWordsFile2 = taskWordFile2.Result;
var numberOfLinesFile2 = taskLineFile2.Result;

Console.WriteLine("Number of words for file 1 : {0}", numberOfWordsFile1.ToString());
Console.WriteLine("Number of lines for file 1 : {0}", numberOfLinesFile1.ToString());
Console.WriteLine("Number of words for file 2 : {0}", numberOfWordsFile2.ToString());
Console.WriteLine("Number of lines for file 2 : {0}", numberOfLinesFile2.ToString());

var fullResult = sumNumbers + numberOfWordsFile1 + numberOfLinesFile1 + numberOfWordsFile2 + numberOfLinesFile2;

Console.WriteLine("Result of sum of every results {0}", fullResult.ToString());

timer.Stop();
Console.WriteLine("Time elapsed : {0}", timer.ElapsedMilliseconds);

