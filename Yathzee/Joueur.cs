using System;

namespace Yathzee
{
    public class Joueur
    {
        public string Nom {  get; set; }
        public int Tour { get; set; }
        private int _Score = 0;
        public int Score
        {
            get
            {
                return _Score;
            }
            set
            {
                _Score = value;
            }
        }

        // Ajouter pour le Yathzee
        // private List<int> _Dés = new List<int>();

        public Joueur(string nom)
        {
            Nom = nom;
        }

        public Joueur(string nom, int tour) : this(nom) 
        {
            Tour = tour;
        }

        // Ajout pour le Yathzee
        //public void KeepDices(List<int> dé)
        //{
        //    for(int i = 0; i < dé.Count; i++)
        //    {
        //        _Dés.Add(dé[i]);
        //    }
        //}

        public void UpdateScore(int score)
        {
            Console.WriteLine(score);
            Console.WriteLine(Score);
            if ((Score + score) > 21)
            {
                ResetScore();
                Console.WriteLine("Votre score dépasse 21, reset des points");
            } else
            {
                Score += score;
                Console.WriteLine($"{score} ont été ajoutés à votre score, il est à présent de : {Score}");
            }
        }

        public void ResetScore()
        {
            Score = 0;
        }

        public void Winner(string nomJoueur)
        {
            Console.WriteLine($"Bravo {nomJoueur} ! Vous avez gagné !");
        }



    }
}
