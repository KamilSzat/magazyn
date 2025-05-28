using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazyn magazyn = new Magazyn();
            magazyn.dodajProdukt("Mleko", 5);
            magazyn.dodajProdukt("Chleb", 10);
            magazyn.dodajProdukt("Jajka", 50);


            Console.WriteLine($"Stan ilości mleka w magazynie: {magazyn.sprawdzStan("Mleko")}");
            Console.WriteLine($"Stan ilości jaj w magazynie: {magazyn.sprawdzStan("Jajka")}");
            Console.WriteLine($"Stan ilości chleba w magazynie: {magazyn.sprawdzStan("Chleb")}\n");

            magazyn.zdejmijProdukt("Chleb", 3);
            magazyn.zdejmijProdukt("Mleko", 2);
            magazyn.zdejmijProdukt("Mleko1", 3);
            magazyn.zdejmijProdukt("Jajka", 20);
            Console.WriteLine($"Po zdjęciu 3 sztuk chleba: {magazyn.sprawdzStan("Chleb")}"); 
            Console.WriteLine($"Po zdjęciu 20 sztuk jajek: {magazyn.sprawdzStan("Jajka")}"); 
            Console.WriteLine($"Po zdjęciu 2 butelek mleka: {magazyn.sprawdzStan("Mleko")}\n" + $"oraz zdjęto 3 butelki mleka: {magazyn.sprawdzStan("Mleko1")}"); 


        }
    }
}
