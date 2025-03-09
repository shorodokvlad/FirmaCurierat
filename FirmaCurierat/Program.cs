using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NivelStocareDate;
using LibrarieModele;

namespace FirmaCurierat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantierea unui obiect de tip Colet
            var colet1 = new Colet("Laptop", 2.5, "20x20x20");

            // Instantierea uniu obiecte de tip ComandaLivrare
            var comanda1 = new ComandaLivrare(045213, "Popescu Alexandru", "Str. Universitatii 13", "12.03.2025", "In tranzit", colet1);
            string s = comanda1.Info();
            Console.WriteLine(s);

            // Instantierea unui obiect de gestionare a comenzilor cu capacitatea de 5 comenzi
            GestionareComenzi gestiune = new GestionareComenzi(5);
        }

    }
}
