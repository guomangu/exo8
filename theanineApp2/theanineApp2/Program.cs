using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theanineApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rentrer le rayon d'une sphere");
            double beamrayon = double.Parse(Console.ReadLine());

            /*double finalflash = (4 * 3.14) * (2 * beamrayon);*/
            double finalflash2 = (beamrayon * beamrayon) * 3.14;
            double finalrush = ((4 / 3) * (3.14)) * (3 * beamrayon);

            Console.WriteLine("votre cercle a un air de " + finalflash2);
            Console.WriteLine("votre cercle ecoute a un volume de " + finalrush);

            Console.ReadKey();
        }
    }
}
