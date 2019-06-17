using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = new Random().Next(1, 50); // Déclaration de la variable value de type int et attribut un chiffre au hasard.
            int numberTest = 0; // Déclare la variable numbertest de type int et lui donne pour valeur de départ 0.
            Console.WriteLine("Veuillez saisir un nombre entre 0 et 50"); //Affiche la demande de saisir un chiffre.
            while(true) // Boucle le temps tant que la valeur n'est pas trouvé.
            {
                bool choiceValue; //  Déclare la valeur choiceValue de type bool
                choiceValue = (double.TryParse(Console.ReadLine(), out double choice)); // Vérifie qu'il est possible de convertir en double.
                if (choiceValue == false) // Vérifie si choiceValue est faux.
                {
                    Console.WriteLine(" Entrer un chiffre valide");
                    numberTest++;
                }

                else if (choice < 0 || choice > 50)
                {
                    Console.WriteLine(" Veuillez entrer un nombre entre 0 et 50");
                }

                  
                else if (choice == value)
                {
                    Console.WriteLine("Bravo c'est le bon chiffre!.Vous avez essayé : " + numberTest + " fois");
                    break;
                }

                else if (choice <= value)
                {
                    Console.WriteLine("Le nombre à deviner est plus grand retentez votre chance.");
                    numberTest++;
                }

                else if (choice >= value)
                {
                    Console.WriteLine(" Le nombre à deviner est plus petit retentez votre chance.");
                    numberTest++;
                }
               
            }
        }
    }
}

