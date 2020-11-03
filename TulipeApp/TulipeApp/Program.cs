using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TulipeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("est ce qu'il fait beau");
            string response = Console.ReadLine();

            if (response == "o" || response == "oui"){
                Console.WriteLine("je plante les tulipe et j'enleve les mauvaise herbes");
            }else if(response == "n" || response == "nope"){
                Console.WriteLine("je reste chez moi au coin du roi demon feu");
            }else{
                Console.WriteLine("moi pas comprendre franssaiche");
            }

            
            /* Console.WriteLine("hello world et comment que c'est la mif on est bien (-_-) on pouuvait pas faire du phpgp de boo"); */

            Console.ReadKey();
            
        }
    }
}