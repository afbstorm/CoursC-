using System;

namespace _12_ConstructeursDestructeurs;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Début du programme");

        // Création de 50.000 élèves pour vérifier la bonne utilisation du Garbage Collector
        for (int i = 0; i < 50000; i++)
        {
            Eleve eleve = new Eleve("L007", "Freyling", "Aurélien", DateTime.Now, 188, 91);
            Console.WriteLine(eleve);
        }

        Console.WriteLine("Fin du programme");
        
    }
}