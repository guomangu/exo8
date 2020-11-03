using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passifloreApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string gadjeto = "n";
            do
            {
                Console.WriteLine("rentrer un nombre");
                double responseA = double.Parse(Console.ReadLine());
                Console.WriteLine("rentrer un autre nombre");
                double responseB = double.Parse(Console.ReadLine());

               double responseC = (responseA + responseB)/2;
               
                Console.WriteLine(responseC.ToString());


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
