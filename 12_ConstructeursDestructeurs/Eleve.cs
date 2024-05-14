using System;

namespace _12_ConstructeursDestructeurs
{
    public class Eleve : Personne
    {
        public string Matricule {  get; set; }
        public Eleve()
        {
            Console.WriteLine("Élève a été créé");
        }

        public Eleve(string matricule, string nom, string prenom): base(nom, prenom)
        {
            Matricule = matricule;
        }
        public Eleve(string matricule, string nom, string prenom, DateTime dateNaissance, double taille, double poids) : base(nom, prenom, dateNaissance, taille, poids)
        {
            Matricule = matricule;
        }

        // Destructeur
        ~Eleve()
        {
            Console.WriteLine("Objet élève détruit");
        }

        public override string ToString()
        {
            return base.ToString() + $"{Matricule}";
        }
    }
}
