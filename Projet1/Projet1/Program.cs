using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] table = new string[10, 7] {

                { "À quoi sert le mot-clé using ?", "À importer un espace de noms", "À référencer une assembly du framework .NET", "À mettre une assembly dans le Global Assembly Cache (GAC)", "À commander un kebab", "À référencer une assembly du framework .NET", "" },
                { "L'instruction suivante est-elle correcte syntaxiquement ?\nConsole.WriteLine(\"Hello World !!\") //Affiche Hello World", "Non, il manque un point virgule à la fin de la ligne", "Oui, elle affiche une ligne à l’écran", "Oui, mais elle n’affiche rien car la ligne est en commentaires", "Le code ne complie pas", "Non, il manque un point virgule à la fin de la ligne", "" },
                { "Qu'affiche le code suivant?\nint i;\nfor (i = 0; i < 10; i++) ;\nConsole.WriteLine(i); ", "0123456789", "012345678910", "9", "Il ne compile pas", "0123456789", "" },
                { "Quelle est la syntaxe correcte pour déclarer le nom Nicolas dans une variable ?", "string nom = Nicolas;", "int nom=\"Nicolas\";", "string nom=\"Nicolas\";", "double nom = Nicolas", "string nom = \"Nicolas\";", "" },
                { "Parmi ces types de variables, lequel doit-on utiliser pour indiquer qu'une méthode ne renvoie rien ?", "return", "string.empty", "void", "int", "void", "" },
                { "À quoi sert le débogueur de Visual Studio ?", "À inspecter le contenu des variables pendant l’exécution", "À parcourir le code pas à pas", " À observer la pile d'appels", "Aux 3 fonctions ci-dessus", "À parcourir le code pas à pas", "" },
                { "Comment lire une phrase complète au clavier ?", "Console.ReadText()", "Console.Read()", "Console.ReadKey()", "Console.ReadLine()", "Console.ReadLine()", "" },
                { "Le code suivant est-il correct ? int i = 20; double d = i;", "Oui, nous avons un cast implicite", "Non, il faut écrire double d = (double)i; ", "Peut-être", "Je sais pas", "Non, il faut écrire double d = (double)i;", "" },
                { "Comment lire les paramètres de la ligne de commande ? ", "Il faut aller dans les propriétés du projet, dans l’onglet déboguer", "On peut utiliser la variable qui est en paramètre de la méthode Main", "On utilise la méthode Environment.GetCommandLineArg()", "xdebug", "Il faut aller dans les propriétés du projet, dans l’onglet déboguer", "" },
                { "Qu'est-ce que le C# ?", "Un compilateur qui transforme du code intermédiaire en binaire", "Un langage de programmation permettant de réaliser des applications informatiques", "Un framework permettant de réaliser des applications de toutes sortes", "Un langage de programmation binaire", "Un langage de programmation permettant de réaliser des applications informatiques", "" }
                };

            int score = 0;
            bool prgExe = true;
            while (prgExe)
            {
                Console.WriteLine("Bienvenue dans le questionnaire c#\nAppuyez sur \"p\" pour lancer le questionnaire, ou sur \"e\" pour le quitter");
                string playOrNot = Console.ReadLine().ToLower();
                if (playOrNot == "p")
                {
                    for (int counter = 0; counter< 10; counter++)
                    {
                        int questionNumber = counter;
                        string answer = table[counter, 5];
                        Console.WriteLine($"Question {counter}:\n{table[counter, 0]}");
                        Console.WriteLine($"A: {table[counter, 1]} \nB: {table[counter, 2]} \nC: {table[counter, 3]} \nD: {table[counter, 4]}");
                        string answerUser = Console.ReadLine().ToLower();
                        // tant que l'utilisateur ne saisie pas a ou b ou c ou d, reposer la question.
                        /*while (answerUser != "a" || answerUser != "b" || answerUser != "c" || answerUser != "d")
                        {
                            Console.Clear();
                            Console.WriteLine($"Question {counter}:\n{table[counter, 0]}");
                            Console.WriteLine($"A: {table[counter, 1]} \nB: {table[counter, 2]} \nC: {table[counter, 3]} \nD: {table[counter, 4]}");
                            answerUser = Console.ReadLine().ToLower();
                        }*/
                        switch (answerUser)
                        {
                            case "a":
                                answerUser = table[counter, 1];
                                break;
                            case "b":
                                answerUser = table[counter, 2];
                                break;
                            case "c":
                                answerUser = table[counter, 3];
                                break;
                            case "d":
                                answerUser = table[counter, 4];
                                break;
                            default:
                                counter--;
                                break;
                        }
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
                    for (int i = 0; i< 10; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"Correction:\nQuestion n°{i}:\n{table[i, 0]}");
                        if (table[i, 6] == "bon")
                        {
                            Console.WriteLine($"{table[i, 5]}\n");
                        }
                        else if (table[i, 6] == "faux")
                        {
                            Console.WriteLine($"{table[i, 5]}\n");
                        }
                        Console.WriteLine("Appuyez sur une touche pour passer à la correction de la question suivante");
                        Console.ReadKey();
                    }
                    if (score < 5)
                    {
                        Console.WriteLine($"Vous avez {score} bonnes réponses sur 10.");
                    }
                    else if (score >= 5)
                        Console.WriteLine($"Vous avez {score} bonnes réponses sur 10.");
                }
                else if (playOrNot == "e")
                {
                    prgExe = false;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Saisie incorrecte, saisissez une lettre proposé");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
            }

            
        }
    }     
}
