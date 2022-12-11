# Exercice 1
- Réaliser des opérations simples avec la programmation parallèle

## Steps
### Step 1
- Ajoutez l'import pour System.Threading.Tasks à votre projet. 
- Dans la méthode main, créez une liste de nombre à procéder, par exemple, une liste de nombre de 1 à 10.
- Utilisez la méthode Parallel.ForEach pour afficher les nombres de la liste de manière concurrentielle.
- Ajoutez un Thread.Sleep(1000) à l'intérieur du ForEach.
- Démarrer votre programme et observez la sortie

### Step 2
- Ajoutez un Stopwatch pour analyser le temps nécessaire pour réaliser l'opération, sans programmation parallèle, l'opération durerait minimum 10 secondes.
```
var timer = new Stopwatch() // un import sera nécessaire
timer.Start();
// Opération ForEach Step 1
timer.Stop();
Console.WriteLine("{0} Elapsed time to process the list", timer.Elapsed.ToString());
```

### Step 3
- Réaliser des tâches concurrentielles grâce à la méthode Parallel.Invoke
- La première Action doit process les nombres de 1 à 10 avec un Thread.Sleep(1000);
- La seconde Action doit process les nombres de 10 à 20 avec un Thread.Sleep(1500);
- Ajouter la méthode Parallel.Invoke pour lancer en parallèle les deux actions créées précédemment.
- Ajouter autour de tout ça les méthodes permettant de calculer et afficher la durée, comme pour l'étape 2
- Pour redémarrer le timer utilisez : 
```
timer.Reset();
```
- Démarrer à nouveau votre programme et observez la sortie.