using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vib6App2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rentrer le rayon d'un cercle");
            double beamrayon = double.Parse(Console.ReadLine());
            Console.WriteLine("rentrer le angle d'un cercle");
            double supabeamrayon = double.Parse(Console.ReadLine());

            double finalflashor = (3.14 * (beamrayon * 2) * supabeamrayon / 360);

            Console.WriteLine("votre cercle a un air de secteur circulaire mdr de " + finalflashor);

            Console.ReadKey();
        }
    }
}
