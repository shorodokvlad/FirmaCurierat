using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Colet
    {
        // Constante pentru delimitarea în fișier
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int ID_COLET = 0;
        private const int DESCRIERE = 1;
        private const int GREUTATE = 2;
        private const int DIMENSIUNE = 3;

        public int IDColet { get; set; }
        public string Descriere { get; set; }
        public double Greutate { get; set; }
        public string Dimensiune { get; set; }

        // Constructor fara parametri
        public Colet()
        {
            IDColet = 0;
            Descriere = string.Empty;
            Greutate = 0;
            Dimensiune = string.Empty;
        }

        // Constructor cu parametri
        public Colet(int idColet, string descriere, double greutate, string dimensiune)
        {
            IDColet = idColet;
            Descriere = descriere;
            Greutate = greutate;
            Dimensiune = dimensiune;
        }


        // Constructor care preia date dintr-o linie de fișier
        public Colet(string linieFisier)
        {
            var date = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            IDColet = int.Parse(date[ID_COLET]);
            Descriere = date[DESCRIERE];
            Greutate = double.Parse(date[GREUTATE]);
            Dimensiune = date[DIMENSIUNE];
        }

        public string Info()
        {
            return $"ID Colet: {IDColet}\n Descriere: {Descriere ?? "NECUNOSCUT"}\n Greutate: {Greutate} kg\n Dimensiune: {Dimensiune ?? "NECUNOSCUT"}";
        }


        public string ConversieLaSir_PentruFisier()
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}",
                SEPARATOR_PRINCIPAL_FISIER,
                IDColet,
                Descriere,
                Greutate,
                Dimensiune);
        }
    }
}
