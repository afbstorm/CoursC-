using System;
using _05_Indexeurs.Models;

// Création du deck
Deck deck = new Deck();
// Initialisation du deck
    deck.InitDeck();


// Ajout d'un nombre de carte dans le deck
Card[] main = new Card[13];

// Boucle dans laquelle, à chaque passage, on vient remplir main avec la carte
// a l'index 0 du deck puis retire la carte du deck (ce qui passe la suivante à l'index 0)
for (int i = 0; i < main.Length; i++)
{
    main[i] = deck[0];
}

// Boucle qui Console.WriteLine chaque carte pour afficher sa valeur et son nom
foreach (Card card in main)
{
    Console.WriteLine($"Le {card.Valeur} de {card.Couleur}");
}

Console.WriteLine("");

// Création d'une carte dans le main directement via sa couleur et sa valeur
main[3] = deck[Couleurs.Pique, Valeurs.Neuf];

Console.WriteLine($"Le {main[3].Valeur} de {main[3].Couleur}");

foreach (Card card in main)
{
    Console.WriteLine($"Le {card.Valeur} de {card.Couleur}");
}

Console.WriteLine("");