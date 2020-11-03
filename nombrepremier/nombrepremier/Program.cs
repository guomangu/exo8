using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombrepremier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("s'il vous plait veuillez saisir un nombre entier");
            string lol = Console.ReadLine();
            double lol2 = Convert.ToDouble(lol);

            double i = 0;
            double result = 0;
            while (result != 1)
            {
                i = i + 1;
                result = lol2 / i;
                if (result != 0)
                {
                    tabresult[]= result;
                }

            }
        }
    }
}
