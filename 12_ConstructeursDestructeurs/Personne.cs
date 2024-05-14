using System;

namespace _12_ConstructeursDestructeurs
{
    public class Personne
    {

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public double Taille { get; set; }
        public double Poids { get; set; }

        // Constructeur par défaut = constructeur vide
        public Personne()
        {
            Console.WriteLine("Personne a été créée");
        }

        // Surcharge de constructeur
        // : this() => fait appel au constructeur vide repris en première position
        public Personne(string nom, string prenom) : this()
        {
            Nom = nom;
            Prenom = prenom;
        }

        // Surcharge de constructeur 
        // :this(nom, prenom) => fait appel au constructeur avec deux paramètres en deuxième position
        public Personne(string nom, string prenom, DateTime dateNaissance, double taille, double poids): this(nom, prenom)
        {
            DateNaissance = dateNaissance;
            Taille = taille;
            Poids = poids;
        }

        // Destructeur
        ~Personne()
        {
            Console.WriteLine("Objet personne détruit");
        }

        public override string ToString()
        {
            return $"{Nom} {Prenom} {DateNaissance} {Taille} {Poids}";
        }

    }
}
