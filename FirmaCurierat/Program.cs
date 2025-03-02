using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaCurierat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantierea uniu obiecte de tip ComandaLivrare
            var comanda1 = new ComandaLivrare(045213, "Popescu Alexandru", "Str. Universitatii 13", "Laptop", 2, "40x30x20", "12.03.2025", "In tranzit");
            string s = comanda1.Info();
            Console.WriteLine(s);

            // Instantierea unui obiect de gestionare a comenzilor cu capacitatea de 5 comenzi
            GestionareComenzi gestiune = new GestionareComenzi(5);
        }

    }
}
