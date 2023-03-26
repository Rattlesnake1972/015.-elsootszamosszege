using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015.elsootszamosszege
{
    class Program
    {
        static void Main(string[] args)
        {
            int osszeadelsoot = 0;

            for (int i = 0; i < 6; i++)
            {
                osszeadelsoot = osszeadelsoot + i;
            }
            Console.WriteLine("Az első öt szám összege: " + osszeadelsoot + ".");

            Console.ReadKey();
        }
    }
}
