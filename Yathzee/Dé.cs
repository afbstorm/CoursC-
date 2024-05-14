using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yathzee
{
    public class Dé
    {
        public int De {  get; set; }

        public int Lancer()
        {
            De = new Random().Next(1,7);
            Console.WriteLine(De);
            return De;
        }
    }
}
