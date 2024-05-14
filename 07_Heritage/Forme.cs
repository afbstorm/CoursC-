using System;

namespace _07_Heritage
{
    // Classe parent qui fait hériter ses membres aux classes dérivées
    internal class Forme
    {
        private string _couleur;

        public string Couleur { get { return _couleur; } set { _couleur = value; } }
        // Simplification 
        // public string Couleur { get => _couleur; set => _couleur = value; }

        // Virtual : Permet la redéfinition de la méthode dans les types dérivés
        public virtual void Dessine()
        {
            Console.WriteLine("Dessine la forme");
        }
    }
}
