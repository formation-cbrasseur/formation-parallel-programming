# Exercice mise en place d'une API

- Pour cet exercice, vous allez devoir implémenter 3 nouveaux endpoints
- FacebookFollowers (retour un nombre en dur de followers en entier)
- InstagramFollowers (de même)
- TwitterFollowers (de même)
- Votre objectif est de faire 3 méthodes contenant un retour de followers, chacun des méthodes doit faire un await Task.Delay(1000); comme vu dans l'exemple test. Et retourner une valeur en dur d'entier dans HandleAsync via SendAsync()
- Côté projet Console, votre but est de remplir les informations d'une classe "User" (Name (setté par le constructeur), FacebookFollowers, TwitterFollowers, InstagramFollowers) en utilisant la programmation asynchrone (Task.WhenAll par exemple) pour réaliser l'opération de remplissage des infos de l'utilisateurs en 1 seconde (et non 3). Il vous faut donc un timer
- Vous devez afficher les informations de l'utilisateur dans la console après les avoir récupérées via une méthode override ToString() dans la classe User.
- Pour ceux qui veulent aller plus loin regardez la doc de FastEndpoint et essayez de faire des Endpoints avec Request + Response, c'est pas si dur ;)