using System;
using Yathzee;

namespace _Game_421.Interface
{
    internal interface IGame
    {
        List<Joueur> Joueurs { get; }
        Dé De {  get; }
        List<int> TourCount { get; }

        void StartGame();
        void TourDeJeu(Joueur joueur);

    }
}
