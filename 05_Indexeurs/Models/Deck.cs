using _05_Indexeurs.Models;
using System;
using System.Collections.Generic;

namespace _05_Indexeurs.Models
{
    class Deck
    {
        // Création de notre nouvelle liste _deck qui va contenir un deck de cartes
        private readonly List<Card> _deck = new List<Card>();
        // Indexeur : Permet d'utiliser une classe possédant une liste
        // Comme un tableau avec choix du type de clé
        // Dans ce cas-ci, un int index
        public Card this[int index]
        {
            // Getter d'une carte, une fois jouée on la retire du deck
            get
            {
                // Initialisation d'une carte c
                Card c = null;

                // Si l'index est inférieur au total de carte dans _deck et qu'il est supérieur ou égal a 0
                if (index < _deck.Count && index >= 0)
                {
                    // On assigne l'index du deck à c
                    c = _deck[index];
                    // Et on supprime c du deck
                    _deck.Remove(c);
                }

                return c;
            }

            set
            {
                // Si l'index est inférieur au total de carte dans _deck et qu'il est supérieur ou égal à 0
                if (index < _deck.Count && index >= 0)
                {
                    // On assigne la valeur directement à l'index spécifié
                    _deck[index] = value;
                }
                else
                {
                    // Sinon, on ajoute la carte dans le deck
                    _deck.Add(value);
                }
            }
        }

        // En fournissant une couleur et une valeur
        public Card this[Couleurs couleur, Valeurs valeur]
        {
            get
            {
                Card c = null;
                for (int i = 0; i < _deck.Count; i++)
                {
                    if (_deck[i].Couleur == couleur && _deck[i].Valeur == valeur)
                    {
                        c = _deck[i];
                        _deck.Remove(c);
                    }
                }
                return c;
            }
            set
            {
                Card c = null;

                foreach (Card card in _deck)
                {
                    if (card.Couleur == couleur && card.Valeur == valeur)
                    {
                        c = card;
                    }

                    if (c is null)
                    {
                        _deck.Add(new Card() { Couleur = couleur, Valeur = valeur });
                    }
                }
            }
        }

            internal void InitDeck()
        {
            foreach(string colorName in Enum.GetNames(typeof(Couleurs)))
            {
                foreach(string valueName in Enum.GetNames(typeof(Valeurs)))
                {
                    Card card = new Card
                    {
                        Couleur = Enum.Parse<Couleurs>(colorName),
                        Valeur = Enum.Parse<Valeurs>(valueName)
                    };
                    _deck.Add(card);
                }
            }
        }
        
    }
}

