using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Projet1Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
                //Déclaration du tableau stockant toutes les questions et réponses du QCM
                string[,] table = new string[10, 7] {
                {"À quoi sert le mot-clé using ?", "À importer un espace de noms", "À référencer une assembly du framework .NET", "À mettre une assembly dans le Global Assembly Cache (GAC)", "À commander un kebab", "À référencer une assembly du framework .NET", "" },
                {"L'instruction suivante est-elle correcte syntaxiquement ?\nConsole.WriteLine(\"Hello World !!\") //Affiche Hello World", "Non, il manque un point virgule à la fin de la ligne", "Oui, elle affiche une ligne à l’écran", "Oui, mais elle n’affiche rien car la ligne est en commentaires", "Le code ne complie pas", "Non, il manque un point virgule à la fin de la ligne", "" },
                {"Qu'affiche le code suivant?\nint i;\nfor (i = 0; i < 10; i++) ;\nConsole.WriteLine(i); ", "0123456789", "012345678910", "9", "Il ne compile pas", "0123456789", "" },
                {"Quelle est la syntaxe correcte pour déclarer le nom Nicolas dans une variable ?", "string nom = Nicolas;", "int nom=\"Nicolas\";", "string nom=\"Nicolas\";", "double nom = Nicolas", "string nom = \"Nicolas\";", "" },
                {"Parmi ces types de variables, lequel doit-on utiliser pour indiquer qu'une méthode ne renvoie rien ?", "return", "string.empty", "void", "int", "void", "" },
                {"À quoi sert le débogueur de Visual Studio ?", "À inspecter le contenu des variables pendant l’exécution", "À parcourir le code pas à pas", " À observer la pile d'appels", "Aux 3 fonctions ci-dessus", "À parcourir le code pas à pas", "" },
                {"Comment lire une phrase complète au clavier ?", "Console.ReadText()", "Console.Read()", "Console.ReadKey()", "Console.ReadLine()", "Console.ReadLine()", "" },
                {"Le code suivant est-il correct ? int i = 20; double d = i;", "Oui, nous avons un cast implicite", "Non, il faut écrire double d = (double)i; ", "Peut-être", "Je sais pas", "Non, il faut écrire double d = (double)i;", "" },
                {"Comment lire les paramètres de la ligne de commande ? ", "Il faut aller dans les propriétés du projet, dans l’onglet déboguer", "On peut utiliser la variable qui est en paramètre de la méthode Main", "On utilise la méthode Environment.GetCommandLineArg()", "xdebug", "Il faut aller dans les propriétés du projet, dans l’onglet déboguer", "" },
                {"Qu'est-ce que le C# ?", "Un compilateur qui transforme du code intermédiaire en binaire", "Un langage de programmation permettant de réaliser des applications informatiques", "Un framework permettant de réaliser des applications de toutes sortes", "Un langage de programmation binaire", "Un langage de programmation permettant de réaliser des applications informatiques", "" }
            };
                //Déclaration de la variable qui permettra de calculer le nombre de bonne(s) réponse(s) de l'utilisateur
                int score = 0;
                //Déclaration d'un booléen permettant de débuter le QCM en appuyant sur un bouton
                bool prgExe = true;
                //Déclaration d'une boucle qui permettra à l'utilisateur de commencer le QCM
                while (prgExe)
                {
                    Console.WriteLine("Bienvenue dans le questionnaire c#\nAppuyez sur \"p\" pour lancer le questionnaire, ou sur \"e\" pour le quitter");
                    //Déclaration de la variable qui permettra de savoir si l'utilisateur veut jouer ou quitter l'application
                    string playOrNot = Console.ReadLine().ToLower();
                    //Si l'utilisateur souhaite jouer, le QCM commence
                    if (playOrNot == "p")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        textCenter("Bienvenue dans le QCM C#");
                        Console.ResetColor();
                        //Initialisation d'une boucle qui permettra l'affichage de toutes les questions avec les 4 différentes réponses
                        for (int counter = 0; counter < 10; counter++)
                        {
                            //Déclaration d'une variable qui permettra d'identifier le numéro de la question
                            int questionNumber = counter;
                            //Déclaration de la variable answer qui sera égale à la colonne 5 du tableau contenant la réponse à la question
                            string answer = table[counter, 5];
                            //Déclaration des variables qui contiendront les réponses de chaques questions
                            string answerA, answerB, answerC, answerD;
                            answerA = table[counter, 1];
                            answerB = table[counter, 2];
                            answerC = table[counter, 3];
                            answerD = table[counter, 4];
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Question {counter}:\n\n{table[counter, 0]}\n");
                            Console.ResetColor();
                            Console.WriteLine($"A: {table[counter, 1]} \nB: {table[counter, 2]} \nC: {table[counter, 3]} \nD: {table[counter, 4]}\n");

                            //Déclaration de la variable qui enregistrera la saisi de l'utilisateur
                            string answerUser = Console.ReadLine().ToLower();
                            //Initialisation d'un switch de la réponse de l'utilisateur car plusieurs résultats sont possibles
                            switch (answerUser)
                            {
                                case "a":
                                    answerUser = answerA;
                                    break;
                                case "b":
                                    answerUser = answerB;
                                    break;
                                case "c":
                                    answerUser = answerC;
                                    break;
                                case "d":
                                    answerUser = answerD;
                                    break;
                                //En cas d'erreur dans la saisie, l'utilisateur en sera informé
                                default:
                                    counter--;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    textCenter("Veuillez choisir une réponse entre A et D.");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                    break;
                            }
                            //Si l'utilisateur trouve la bonne réponse à la question, son score s'incrémente
                            if (answerUser == answer)
                            {
                                score++;
                                table[questionNumber, 6] = "bon";
                            }
                            else
                            {
                                table[questionNumber, 6] = "faux";
                            }
                            Console.Clear();
                        }
                        //Initialisation d'une boucle for permettant de vérifier les bonnes et les mauvais réponses de l'utilisateur
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Clear();
                            //Affichage du numéro de la question + la question en elle même
                            Console.WriteLine($"Correction:\n\nQuestion n°{i}:\n\n{table[i, 0]}");
                            //Si la réponse à la question de l'utilisateur est correct alors sa réponse sera affichée en verte pendant la correction
                            if (table[i, 6] == "bon")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\n{table[i, 5]}\n\n");
                                Console.ResetColor();
                            }
                            //Sinon sa réponse sera affichée en rouge en cas d'erreur
                            else if (table[i, 6] == "faux")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"\n{table[i, 5]}\n\n");
                                Console.ResetColor();
                            }
                            Console.WriteLine("Appuyez sur une touche pour passer à la correction de la question suivante\n\n");
                            Console.ReadKey();
                        }
                        //Si le score de l'utilisateur est inférieur à 5, affichage de son résultat avec une couleur rouge
                        if (score < 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Vous avez {score} bonnes réponses sur 10.\n\n");
                            Console.ResetColor();
                        }
                        //Sinon si le score est supérieur ou égal à 5, affichage de son résultat avec une couleur verte, et déclenchement d'une musique appelée
                        else if (score >= 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Vous avez {score} bonnes réponses sur 10.\n\n");
                            Console.ResetColor();
                            playSong();
                        }
                    }
                    //Si l'utilisateur saisi la lettre e une fois le QCM terminé, quitte l'application
                    else if (playOrNot == "e")
                    {
                        prgExe = false;
                        break;
                    }
                    //Si l'utilisateur saisi autre chose que la lettre P ou E, un message d'avertissement apparaîtra
                    else
                    {
                        Console.Clear();
                        textCenter("Saisie incorrecte, saisissez une lettre proposé");
                    }
                }
            }
            //Initialisation d'une méthode permettant de centre le texte dans la console
            private static void textCenter(string texte)
            {
                int nbEspaces = (Console.WindowWidth - texte.Length) / 2;
                Console.SetCursorPosition(nbEspaces, Console.CursorTop);
                Console.WriteLine(texte);
            }

            //Initialisation d'une méthode permettant de jouer un son une fois que le QCM terminé
            private static void playSong()
            {
                Console.Beep(659, 125);
                Console.Beep(659, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(167);
                Console.Beep(523, 125);
                Console.Beep(659, 125);
                Thread.Sleep(125);
                Console.Beep(784, 125);
                Thread.Sleep(375);
                Console.Beep(392, 125);
                Thread.Sleep(375);
                Console.Beep(523, 125);
                Thread.Sleep(250);
                Console.Beep(392, 125);
                Thread.Sleep(250);
                Console.Beep(330, 125);
                Thread.Sleep(250);
                Console.Beep(440, 125);
                Thread.Sleep(125);
                Console.Beep(494, 125);
                Thread.Sleep(125);
                Console.Beep(466, 125);
                Thread.Sleep(42);
                Console.Beep(440, 125);
                Thread.Sleep(125);
                Console.Beep(392, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(125);
                Console.Beep(784, 125);
                Thread.Sleep(125);
                Console.Beep(880, 125);
                Thread.Sleep(125);
                Console.Beep(698, 125);
                Console.Beep(784, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(125);
                Console.Beep(523, 125);
                Thread.Sleep(125);
                Console.Beep(587, 125);
                Console.Beep(494, 125);
                Thread.Sleep(125);
                Console.Beep(523, 125);
                Thread.Sleep(250);
                Console.Beep(392, 125);
                Thread.Sleep(250);
                Console.Beep(330, 125);
                Thread.Sleep(250);
                Console.Beep(440, 125);
                Thread.Sleep(125);
                Console.Beep(494, 125);
                Thread.Sleep(125);
                Console.Beep(466, 125);
                Thread.Sleep(42);
                Console.Beep(440, 125);
                Thread.Sleep(125);
                Console.Beep(392, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(125);
                Console.Beep(784, 125);
                Thread.Sleep(125);
                Console.Beep(880, 125);
                Thread.Sleep(125);
                Console.Beep(698, 125);
                Console.Beep(784, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(125);
                Console.Beep(523, 125);
                Thread.Sleep(125);
                Console.Beep(587, 125);
                Console.Beep(494, 125);
                Thread.Sleep(375);
                Console.Beep(784, 125);
                Console.Beep(740, 125);
                Console.Beep(698, 125);
                Thread.Sleep(42);
                Console.Beep(622, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(167);
                Console.Beep(415, 125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Thread.Sleep(125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Console.Beep(587, 125);
                Thread.Sleep(250);
                Console.Beep(784, 125);
                Console.Beep(740, 125);
                Console.Beep(698, 125);
                Thread.Sleep(42);
                Console.Beep(622, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(167);
                Console.Beep(698, 125);
                Thread.Sleep(125);
                Console.Beep(698, 125);
                Console.Beep(698, 125);
                Thread.Sleep(625);
                Console.Beep(784, 125);
                Console.Beep(740, 125);
                Console.Beep(698, 125);
                Thread.Sleep(42);
                Console.Beep(622, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(167);
                Console.Beep(415, 125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Thread.Sleep(125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Console.Beep(587, 125);
                Thread.Sleep(250);
                Console.Beep(622, 125);
                Thread.Sleep(250);
                Console.Beep(587, 125);
                Thread.Sleep(250);
                Console.Beep(523, 125);
                Thread.Sleep(1125);
                Console.Beep(784, 125);
                Console.Beep(740, 125);
                Console.Beep(698, 125);
                Thread.Sleep(42);
                Console.Beep(622, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(167);
                Console.Beep(415, 125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Thread.Sleep(125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Console.Beep(587, 125);
                Thread.Sleep(250);
                Console.Beep(784, 125);
                Console.Beep(740, 125);
                Console.Beep(698, 125);
                Thread.Sleep(42);
                Console.Beep(622, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(167);
                Console.Beep(698, 125);
                Thread.Sleep(125);
                Console.Beep(698, 125);
                Console.Beep(698, 125);
                Thread.Sleep(625);
                Console.Beep(784, 125);
                Console.Beep(740, 125);
                Console.Beep(698, 125);
                Thread.Sleep(42);
                Console.Beep(622, 125);
                Thread.Sleep(125);
                Console.Beep(659, 125);
                Thread.Sleep(167);
                Console.Beep(415, 125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Thread.Sleep(125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Console.Beep(587, 125);
                Thread.Sleep(250);
                Console.Beep(622, 125);
                Thread.Sleep(250);
                Console.Beep(587, 125);
                Thread.Sleep(250);
                Console.Beep(523, 125);
                Thread.Sleep(625);
            }
        
    }
}
    
