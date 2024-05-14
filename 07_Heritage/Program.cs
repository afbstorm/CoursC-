namespace _07_Heritage
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Forme forme = new Forme();
            forme.Dessine();

            Rectangle rectangle = new Rectangle();
            rectangle.Dessine();

            Carre carre = new Carre();
            carre.Dessine();
        }
    }
}
