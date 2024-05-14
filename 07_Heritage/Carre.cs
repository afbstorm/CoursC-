using System;

namespace _07_Heritage
{
    internal class Carre : Rectangle
    {
        // New permet la dissimulation de la méthode Dessine()
        public new void Dessine()
        {
            Console.WriteLine("Dessine un carré");
        }
    }
}
