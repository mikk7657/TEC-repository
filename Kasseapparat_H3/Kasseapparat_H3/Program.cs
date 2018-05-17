using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasseapparat_H3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvad har kunden købt?: ");
            string vare = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Hvad koster varen?: ");
            string pris = Console.ReadLine();
            Console.Clear();

            Console.WriteLine(vare);
            Console.WriteLine(pris + " kr.");
            
            

            Console.ReadLine();
        }
    }
}
