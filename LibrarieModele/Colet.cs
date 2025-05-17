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
        public DimensiuneColet Dimensiune { get; set; }

        // Constructor fara parametri
        public Colet()
        {
            IDColet = 0;
            Descriere = string.Empty;
            Greutate = 0;
            Dimensiune = DimensiuneColet.Mic;
        }

        // Constructor cu parametri
        public Colet(int idColet, string descriere, double greutate, DimensiuneColet dimensiune)
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
            Dimensiune = (DimensiuneColet)Enum.Parse(typeof(DimensiuneColet), date[DIMENSIUNE]);
        }

        public string DimensiuneToString()
        {
            switch (Dimensiune)
            {
                case DimensiuneColet.Mic:
                    return "30x30x30 cm";
                case DimensiuneColet.MediuMic:
                    return "40x40x40 cm";
                case DimensiuneColet.MediuStandard:
                    return "50x50x50 cm";
                case DimensiuneColet.MediuMare:
                    return "60x60x60 cm";
                case DimensiuneColet.MareMica:
                    return "70x70x70 cm";
                case DimensiuneColet.MareStandard:
                    return "80x80x80 cm";
                case DimensiuneColet.MareMare:
                    return "90x90x90 cm";
                case DimensiuneColet.ExtraMare:
                    return "100x100x100 cm";
                default:
                    return "Dimensiune necunoscuta";
            }
        }

        public string GreutateToString()
        {
            return Greutate.ToString() + " kg";
        }

        public string Info()
        {
            return $"ID Colet: {IDColet}\nDescriere: {Descriere ?? "NECUNOSCUT"}\nGreutate: {Greutate} kg\nDimensiune: {DimensiuneToString()}";
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiecteColetPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}",
                SEPARATOR_PRINCIPAL_FISIER,
                IDColet,
                Descriere,
                Greutate,
                Dimensiune);

            return obiecteColetPentruFisier;
        }
    }
}