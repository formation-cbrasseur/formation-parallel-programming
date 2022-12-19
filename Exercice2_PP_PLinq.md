# Exercice 2
- Réaliser des opérations en PLinq, juste pour pratiquer ce que l'on a vu

## Steps
### Step 1 : Simple PLinq operation
- Réaliser une opération de listing des éléments qui sont des multiples de 10 ou des multiples de 4 en PLinq, sur les nombres entre 1 et 2000. (Utilisez Enumerable.Range())
- Ici un simple AsParallel doit suffire
- Vous devez afficher ces nombres dans la console.
- Mais notez bien que les données retournées ne seront pas ordonnées
- Faire l'opération avec un ForAll() comme dans l'exemple sur slides
- Faire l'opération avec un ToList().ForEach() (plus optimisé surtout depuis le Framework 7.0)
- Mettez en place un timer

### Step 2 : Ordered PLinq operation
- Réalisé la même opération que l'étape précédente mais cette fois-ci faites en sortes que la liste reste ordonnées
- Faites l'opération d'affichage en Linq avec .ToList().ForEach()
- Faites aussi l'opération avec un foreach classique.
- Mettez en place un timer
- Comparez le temps de réalisation des opérations entre l'étape 1 et l'étape 2. (Je dois avouer que sur mon corrigé, le temps d'exécution est plus rapide pour la liste ordonnée que la désordonnée et je ne sais pas expliquer pourquoi ! Normalement, ça devrait être l'inverse...)

### Step 3 : Combine PLinq and Task with method ContinueWith()
- Créer une classe Formation (string Name, int Cost)
- Créer une liste de 5 formations, dont 2 ont un prix supérieur à 500 et 3 dont le prix est inférieur à 500
- En combinant Task.Factory.StartNew() et ContinueWith, faites en sorte d'afficher les formations qui ont un prix supérieur à 500. Ceci se fait en deux étapes : 
    - Une ou l'on utilise AsParallel().Where() pour retourner la liste des éléments concernés
    - L'autre ou l'on utilise le retour de la Task avec ContinueWith pour afficher les éléments
