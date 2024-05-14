using System;

namespace _09_Enums
{
    public enum Race
    {
        Humain,
        Nain,
        Orc
    }

    public enum Class
    {
        Guerrier = 1,
        Sorcier,
        Archer
    }

    public enum Right
    {
        Execute,
        Write,
        Read
    }

    // Utilisation de [flags] fonctionne avec des puissances de 2
    [Flags]
    public enum RightFlag
    {
        Execute = 1,
        Write = 2,
        Read = 4,
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(" -> Affichage du type de l'enum");
            Console.WriteLine(typeof(Race));

            Race race1 = Race.Humain;
            Race race2 = Race.Nain;
            Race race3 = Race.Orc;

            Console.WriteLine(" -> Affichage des valeurs de l'enum");
            Console.WriteLine(race1);
            Console.WriteLine(race2);
            Console.WriteLine(race3);

            Console.WriteLine(" -> Affichage des valeurs de l'enum en string");
            Console.WriteLine(race1.ToString());
            Console.WriteLine(race2.ToString());
            Console.WriteLine(race3.ToString());

            Console.WriteLine(" -> Affichage des valeurs de l'enum en int");
            Console.WriteLine((int)race1);
            Console.WriteLine((int)race2);
            Console.WriteLine((int)race3);

            Console.WriteLine(" -> Affichage des classes");
            Class class1 = Class.Guerrier;
            Class class2 = Class.Sorcier;
            Class class3 = Class.Archer;

            Console.WriteLine((int)class1 + " " + class1);
            Console.WriteLine((int)class2 + " " + class2);
            Console.WriteLine((int)class3 + " " + class3);


            Console.WriteLine(" -> Affichage des droits");
            Right right1 = Right.Write;
            Right right2 = Right.Read | Right.Write;
            Right right3 = Right.Read | Right.Write | Right.Execute;

            Console.WriteLine((int)right1);
            Console.WriteLine((int)right2);
            Console.WriteLine((int)right3);

            RightFlag rightFlag1 = RightFlag.Write;
            RightFlag rightFlag2 = RightFlag.Read | RightFlag.Write;
            RightFlag rightFlag3 = RightFlag.Read | RightFlag.Write | RightFlag.Execute;

            Console.WriteLine((int)rightFlag1 + " " + rightFlag1);
            Console.WriteLine((int)rightFlag2 + " " + rightFlag2);
            Console.WriteLine((int)rightFlag3 + " " + rightFlag3);

            Console.WriteLine(" -> Vérification du droit d'action");

            if (rightFlag3.HasFlag(RightFlag.Execute)) Console.WriteLine(" -> Peut exécuter");
            if (rightFlag2.HasFlag(RightFlag.Read)) Console.WriteLine(" -> Peut lire");
            if (rightFlag1.HasFlag(RightFlag.Write)) Console.WriteLine(" -> Peut écrire");

            Console.WriteLine("\n -> Parcous d'un type");

            foreach (var droit in Enum.GetNames(typeof(Right))) Console.WriteLine(droit);        

        }
    }
}