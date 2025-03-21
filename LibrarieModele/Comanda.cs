using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Comanda
    {
        // Constante pentru delimitarea în fișier
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int ID_COMANDA = 0;
        private const int NUME_CLIENT = 1;
        private const int ADRESA_LIVRARE = 2;
        private const int DATA_LIVRARE = 3;
        private const int STARE_COMANDA = 4;
        private const int ID_COLET = 5;

        public int IDComanda { get; set; }
        public string NumeClient { get; set; }
        public string AdresaLivrare { get; set; }
        public string DataLivrare { get; set; }
        public string StareComanda { get; set; }

        public int IDColet { get; set; }
        public string Colet { get; set; }

        // Constructor fara parametri
        public Comanda()
        {
            IDComanda = 0;
            NumeClient = string.Empty;
            AdresaLivrare = string.Empty;
            DataLivrare = string.Empty;
            StareComanda = string.Empty;
            IDColet = 0;
        }


        // Constructor cu parametri
        public Comanda(int idComanda, string numeClient, string adresaLivrare, string dataLivrare, string stareComanda, Colet colet, int idColet)
        {
            IDComanda = idComanda;
            NumeClient = numeClient;
            AdresaLivrare = adresaLivrare;
            DataLivrare = dataLivrare;
            StareComanda = stareComanda;
            IDColet = idColet;
        }

        // Constructor care preia date dintr-o linie de fișier
        public Comanda(string linieFisier)
        {
            var date = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            IDComanda = int.Parse(date[ID_COMANDA]);
            NumeClient = date[NUME_CLIENT];
            AdresaLivrare = date[ADRESA_LIVRARE];
            DataLivrare = date[DATA_LIVRARE];
            StareComanda = date[STARE_COMANDA];
            IDColet = int.Parse(date[ID_COLET]);
        }
        public string Info()
        {
            return $"ID Comanda: {IDComanda}, Nume Client: {NumeClient}, Adresa: {AdresaLivrare}, Data Livrare: {DataLivrare}, Stare: {StareComanda}, ID Colet: {IDColet}";
        }

        public string ConversieLaSir_PentruFisier()
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}",
                SEPARATOR_PRINCIPAL_FISIER,
                IDComanda,
                NumeClient,
                AdresaLivrare,
                DataLivrare,
                StareComanda,
                IDColet);
        }
    }
}
