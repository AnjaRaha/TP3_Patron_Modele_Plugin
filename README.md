# TP_Plugin

QUESTION 1 : Comment organisez votre solution?

Dans ce TP, j'ai crée 4 projet qui sont : 
 - AppWithPlugin 
 -PluginBase
 -HelloPlugin 
 -UsersPlugin 
 
le Projet AppWithPlugin est le squelette du projet lui même. le projet pluginBase contient une interface iCommand, cette dernière est heritée par chaque interface du  plugin qu'on va créer. Pour cela, j'ai crée deux différents projet pour illustrer l'utilisation des plugin dans une application : HelloPlugin( Tutoriel proposé par le prof) et UsersPlugin( une fonctionnalité qui permet de charger une liste d'utilisateurs à partir d'un fichier json.)

QUESTION 2 : Dans quel projet mettez-vous la class User? Celle-ci est composée d’un nom, d’un prénom et
d’une adresse mail.

J'ai mis la class User dans le projet UsersPlugin. 

Question 3 : En vous basant sur la documentation, à quoi ressemble l’interface d’un plugin dans notre
système? 

Dans ce même projet, j'ai crée une interface qui contient une méthode qui permet de lire un ensemble de fichier Json. 