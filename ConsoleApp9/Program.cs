using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma Firma = new Firma();
            Firma.FName = "Nike";
            Firma.FAdres = "США: Бивертон(Орегон)";
            Firma.FGod = 1964;
            Console.WriteLine($"{Firma.FName}  {Firma.FAdres}  {Firma.FGod}");
            Firma fir1 = new Firma("Adidas", "GeBruder Dassler Schuhfabrik", 2020);
            Console.WriteLine($"{Firma.FName}  {Firma.FAdres}  {Firma.FGod}");
            Console.ReadKey();
        }
    }
}
