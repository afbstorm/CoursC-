using _06_SurchageOperateurs.Models;
    Console.WriteLine("-- Création des fruits --");
    Fruit pomme = new Fruit() { Nom = "Pomme", Poids = 0.2 };
    Fruit cerise = new Fruit() { Nom = "Cerise", Poids = 0.15 };
    Fruit ananas = new Fruit() { Nom = "Ananas", Poids = 0.5 };
    Fruit litchi = new Fruit() { Nom = "Litchi", Poids = 0.15 };
    Fruit poire = new Fruit() { Nom = "Poire", Poids = 0.3 };

    Console.WriteLine("-- Création des paniers --");
    Panier panier1 = new Panier();
    Panier panier2 = new Panier();

    Console.WriteLine("-- Ajout des fruits dans le panier1 --");
    panier1.AddFruit(pomme);
    panier1.AddFruit(poire);
    panier1.AddFruit(ananas);
    panier1.AddFruit(ananas);

    Console.WriteLine("-- Ajout des fruits dans le panier1 --");
    panier2.AddFruit(litchi);
    panier2.AddFruit(cerise);
    panier2.AddFruit(cerise);
    panier2.AddFruit(poire);

    Console.WriteLine("-- Parcours des paniers --");
    Console.WriteLine();
    Console.WriteLine("Panier 1");
    foreach (Fruit fruit in panier1.Fruits)
    {
        Console.WriteLine(fruit.Nom);
    }

    Console.WriteLine();
    Console.WriteLine("Panier 2");
    foreach (Fruit fruit in panier2.Fruits)
    {
        Console.WriteLine(fruit.Nom);
    }

