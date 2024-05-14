using System;
using Yathzee;

namespace _Game_421.Interface
{
    //class GameSolo 
    //{
    //    public Joueur Joueur;
    //    public Dé De;
    //    public int TourCount = 0;

    //    public GameSolo(string nomJoueur)
    //    {
    //       Joueur = new Joueur(nomJoueur);
    //       De = new Dé();
    //    }

    //    public void StartGame()
    //    {
    //        if (Joueur.Score == 0)
    //        {
    //            Console.WriteLine(" ---- Début de la partie ---- ");

    //            TourDeJeu();

    //            while (Joueur.Score < 21)
    //            {
    //                if (TourCount == 5)
    //                { 
    //                    Console.WriteLine($"Vous êtes arrivés au bout de vos tours de {TourCount} jeu, voici votre score final : {Joueur.Score}");
    //                    break;
    //                }
    //                Console.WriteLine(" ---- Nouveau tour ---- ");
    //                TourDeJeu();
    //                TourCount++;
    //            }
    //        }
    //    }

    //    public static void Main(string[] args)
    //    {
    //        GameSolo Game = new GameSolo("Aurélien");
    //        Game.StartGame();
    //    }

    //    public void TourDeJeu()
    //    {
    //        int Score = 0;
    //        int Count = 0;

    //        for (int i = 0; i < 3; i++)
    //        {
    //            Score += De.Lancer();
    //            Count++;
    //        }

    //        if (Count == 3)
    //        {
    //            Joueur.UpdateScore(Score);

    //            if (Joueur.Score == 21)
    //            {
    //                Joueur.Winner(Joueur.Nom);
    //            }
    //        }
    //    }
    //}

    public class Game : IGame
    {
        public List<Joueur> Joueurs { get; private set; } = new List<Joueur>();
        public Dé De { get; private set; }
        public List<int> TourCount { get; private set; } = new List<int>();

        public Game(List<string> nomJoueur)
        {
            foreach (string nom in nomJoueur)
            {
                Joueurs.Add(new Joueur(nom, 0));
            }
            De = new Dé();
        }

        public void StartGame()
        {
            bool gameRunning = true;

            while (gameRunning)
            {
                gameRunning = false;

                foreach (Joueur joueur in Joueurs)
                {
                    if (joueur.Score < 21 && joueur.Tour < 5)
                    {
                        Console.WriteLine($" ---- Tour de {joueur.Nom} ---- ");
                        TourDeJeu(joueur);

                        if (joueur.Score >= 21)
                        {
                            joueur.Winner(joueur.Nom);
                            gameRunning = false;
                            break;
                        }

                        joueur.Tour++;
                        gameRunning = true; 
                    }
                }
                foreach (Joueur joueur in Joueurs)
                {
                    Console.WriteLine($"{joueur.Nom} ! Vous avez terminé avec un score de : {joueur.Score} en {joueur.Tour} tours.");
                }
            }
        }

        public static void Main(string[] args)
        {
            Game Game = new Game(["Aurélien", "Tania"]);
            Game.StartGame();
        }

        public void TourDeJeu(Joueur joueur)
        {
            int Score = 0;

            for (int i = 0; i < 3; i++)
            {
                Score += De.Lancer();
            }

            joueur.UpdateScore(Score);

            if (joueur.Score == 21)
            {
                joueur.Winner(joueur.Nom);
            }
        }
    }

}