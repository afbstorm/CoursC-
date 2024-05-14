using System;

namespace _07_Heritage
{
    // Class enfant, dérivée, sous-classe
    // sealed va permettre d'empêcher l'héritage d'une class
    // sealed
    internal class Rectangle : Forme
    {
        public double Largeur { get; set; }
        public double Longueur { get; set; }
        private int _X { get; set; }

        // Override permet de redéfinir une méthode virtual
        // Ici, Dessine()
        public override void Dessine()
        {
            base.Dessine();
            Console.WriteLine("qui est un rectangle");
        }
    }
}
