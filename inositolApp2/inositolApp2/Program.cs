using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inositolApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("le beau nombre A");
            double beamrayon = double.Parse(Console.ReadLine());
            Console.WriteLine("l'ultime nombre B");
            double supabeamrayon = double.Parse(Console.ReadLine());

            double chapeau = beamrayon;
            double magique = supabeamrayon;

            supabeamrayon = chapeau;
            beamrayon = magique;

            Console.WriteLine("Magique le A est "+beamrayon+" et le B est au "+ supabeamrayon+" ce que le gramme est a la belle propriete");
            Console.ReadKey();
        }
    }
}
