# TP_Plugin


Dans ce TP, j'ai crée 4 projet qui sont : -AppWithPlugin -PluginBase -HelloPlugin -UsersPlugin

Le projet AppWithPlugin est le squelette de l'application lui même. Ensuite, dans le projet PluginBase se trouve notre interface de base. Cette dernière est l'interface que tous les plugins implémenteront. On peut donc trouver dans le programme.cs la méthode qui permet de lire chaque path du plugin. Ce qui nous amène à expliquer les deux dernière projet qui sont : HelloPlugin et UsersPlugin. Tout d'abord, le projet HelloPlugin est un plugin simple qui permet  d'afficher un message. Ensuite, le projet UsersPlugin est un plugin avec dépendance de bibliothèque notamement le "Newtonsoft.Json" (package nuget). , il permet de charger un ensemble de fichier Json et d'afficher les utilisateurs dans ce fichier (Nom, prenom, mail).

J'ai choisi de mettre la classe User dans le projet PluginBase. Pour cela, la classe User pourra être réutilisée par d'autre plugin.

 D'autre part, j'ai crée une classe ReadUsers  et qui implémente l'interface ICommande. On peut trouver dans cette classe les fonctions et les méthodes (Execute(), ReadUser()) qui permet de lire un ensemble de fichier Json dans un dossier et d'afficher les utilisateurs.
