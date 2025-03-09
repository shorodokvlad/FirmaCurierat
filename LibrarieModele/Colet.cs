using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Colet
    {
        public string Descriere { get; set; }
        public double Greutate { get; set; }
        public string Dimensiune { get; set; }

        // Constructor fara parametri
        public Colet()
        {
            Descriere = string.Empty;
            Greutate = 0;
            Dimensiune = string.Empty;
        }

        // Constructor cu parametri
        public Colet(string descriere, double greutate, string dimensiune)
        {
            Descriere = descriere;
            Greutate = greutate;
            Dimensiune = dimensiune;
        }

        public string Info()
        {
            return $"Descriere: {Descriere}, Greutate: {Greutate} kg, Dimensiune: {Dimensiune}";
        }
    }
}
