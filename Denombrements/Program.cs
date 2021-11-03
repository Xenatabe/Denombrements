using System;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            int n = 0, t = 0; // saisie des chiffres (durant les programmes) de l'utilisateur
            long r; // résultat du calcul
            string choix; // saisie du choix de l'utilisateur
            bool correct; // mémorise si la saisie est un entier

            choix = "1";
            while (choix != "0") //si différent de 0, lance un programme
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = Console.ReadLine();
                switch (choix) // programme en fonction de c
                {
                    case "0": // demande d'arrêt du programme
                        break; 
                    case "1": // programme de permutation
                        correct = false;
                        while (!correct) // vérification de la valeur saisie (nombre entier)
                        {
                            try
                            {
                                Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                                n = int.Parse(Console.ReadLine()); // saisir le nombre
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Saisissez un entier"); // message d'erreur
                            }
                        }
                            // calcul de r
                        r = 1;
                        for (int k = 1; k <= n; k++) 
                        r *= k;
                        Console.WriteLine(n + "! = " + r); // résultat de la permutation
                        break; // retour au début de l'application
                    case "2": // programme d'arrangement
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                Console.Write("nombre total d'éléments à gérer = "); 
                                t = int.Parse(Console.ReadLine()); 
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Saisissez un entier"); 
                            }
                        }
                        correct = false;
                        while (!correct) 
                        {
                            try
                            {
                                Console.Write("nombre d'éléments dans le sous ensemble = "); 
                                n = int.Parse(Console.ReadLine()); 
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Saisissez un entier"); 
                            }
                        }
                            // calcul de r
                        r = 1;
                        for (int k = t - n + 1; k <= t; k++)
                        r *= k;
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r); // résultat de l'arrangement
                        break; // retour au début de l'application
                    case "3" : // programme de combinaison
                        correct = false;
                        while (!correct) 
                        {
                            try 
                            {
                                Console.Write("nombre total d'éléments à gérer = "); 
                                t = int.Parse(Console.ReadLine()); 
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Saisissez un entier"); 
                            }
                        }
                        correct = false;
                        while (!correct) 
                        {
                            try
                            {
                                Console.Write("nombre d'éléments dans le sous ensemble = "); 
                                n = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Saisissez un entier"); 
                            }
                        }
                            // calcul de r1
                         long r1 = 1;
                         for (int k = (t - n + 1); k <= t; k++)
                         r1 *= k;
                            // calcul de r2
                         long r2 = 1;
                         for (int k = 1; k <= n; k++)
                         r2 *= k;
                           // calcul de r3
                           //Console.WriteLine("résultat = " + (r1 / r2));
                          Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2)); // résultat de la permutation
                         break;
                    default:
                        Console.WriteLine("Erreur de saisie"); // message d'erreur (si résultat != 0, 1, 2, 3)
                        break; 
                }
            }
            Console.ReadLine();
        }
    }
}
