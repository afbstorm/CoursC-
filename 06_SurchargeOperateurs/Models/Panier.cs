
namespace _06_SurchageOperateurs.Models
{
    class Panier
    {
        private readonly List<Fruit> _fruits = new List<Fruit>();

        public List<Fruit> Fruits => _fruits;

        public void AddFruit(Fruit fruit)
        {
            if (fruit is null) return;
            _fruits.Add(fruit);
        }

        public static double GetWeight(Panier p)
        {
            double poids = 0;

            foreach(Fruit fruit in p.Fruits)
            {
                poids += fruit.Poids;
            }
            return poids;
        }

        // Permet de créer un nouveau panier avec les deux autres
        public static Panier operator +(Panier p1, Panier p2)
        {
            Panier panier = new Panier();
            // Ajout du premier panier dans le nouveau panier
            foreach (Fruit fruit in p1.Fruits)
            {
                panier.AddFruit(fruit);
            }

            // Ajout du second panier dans le nouveau panier
            foreach (Fruit fruit in p2.Fruits)
            {
                panier.AddFruit(fruit);
            }
            return panier;
        } 

        // COmpare le poids des deux paniers. S'il est identique, return true. 
        public static bool operator ==(Panier p1, Panier p2)
        {
            return GetWeight(p1) == GetWeight(p2);
        }

        // Vérifie que le contenu des deux paniers est bien différent. S'il l'est, return true
        public static bool operator !=(Panier p1, Panier p2)
        {
            return !(p1 == p2);
        }

        // vérifie si le panier 1 est plus petit que le 2. S'il l'est, return true
        public static bool operator <(Panier p1, Panier p2)
        {
            return GetWeight(p1) < GetWeight(p2);
        }

        // vérifie si le panier 1 est plus grand que le 2. S'il l'est, return true
        public static bool operator >(Panier p1, Panier p2)
        {
            return GetWeight(p1) > GetWeight(p2);
        }

        // Vérifie si le panier 1 est plus petit ou égal que le 2. S'il l'est return true
        public static bool operator <=(Panier p1, Panier p2)
        {
            return GetWeight(p1) <= GetWeight(p2);
        }

        // Vérifie si le panier 1 est plus grand ou égal que le 2. S'il l'est return true
        public static bool operator >=(Panier p1, Panier p2)
        {
            return GetWeight(p1) >= GetWeight(p2);
        }
    }
}
