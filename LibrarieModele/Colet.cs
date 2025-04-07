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
            Dimensiune = GetDimensiuneFromText(date[DIMENSIUNE]);
        }

        private DimensiuneColet GetDimensiuneFromText(string dimensiuneText)
        {
            switch (dimensiuneText)
            {
                case "30x30x30 cm":
                    return DimensiuneColet.Mic;
                case "40x40x40 cm":
                    return DimensiuneColet.MediuMic;
                case "50x50x50 cm":
                    return DimensiuneColet.MediuStandard;
                case "60x60x60 cm":
                    return DimensiuneColet.MediuMare;
                case "70x70x70 cm":
                    return DimensiuneColet.MareMica;
                case "80x80x80 cm":
                    return DimensiuneColet.MareStandard;
                case "90x90x90 cm":
                    return DimensiuneColet.MareMare;
                case "100x100x100 cm":
                    return DimensiuneColet.ExtraMare;
                default:
                    throw new ArgumentException("Dimensiune necunoscuta");
            }
        }

        public string GetDimensiuneText()
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

        public string Info()
        {
            return $"ID Colet: {IDColet}\nDescriere: {Descriere ?? "NECUNOSCUT"}\nGreutate: {Greutate} kg\nDimensiune: {GetDimensiuneText()}";
        }

        public string ConversieLaSir_PentruFisier()
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}",
                SEPARATOR_PRINCIPAL_FISIER,
                IDColet,
                Descriere,
                Greutate,
                GetDimensiuneText());
        }
    }
}
