using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace melisseApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string gadjeto = "n";
            do
            {

                Console.WriteLine("rentrer des nombres separés par des espace");
                string joseph = Console.ReadLine();
                string[] tabwords = joseph.Split(' ');
                double ensemble = 0;
                double i = 0;

                foreach (var calc in tabwords)
                {
                    double cacs =  Convert.ToInt16(calc);
                    ensemble = (cacs + ensemble);
                    i = i + 1;
                }
                ensemble = ensemble / i;
       
                Console.WriteLine(ensemble);

                Console.WriteLine("alors satisfait ? o pout quitter");
                gadjeto = Console.ReadLine();
                if (gadjeto == "o")
                {
                    Console.WriteLine("appuyez sur une touche pour quitter la touche de la touche");
                }
            }
            while (gadjeto == "n");

            Console.ReadKey();
        }
    }

}
