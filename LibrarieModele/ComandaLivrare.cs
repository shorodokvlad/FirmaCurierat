using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class ComandaLivrare
    {
        // Constante pentru delimitarea în fișier
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int ID_COMANDA = 0;
        private const int NUME_CLIENT = 1;
        private const int ADRESA_LIVRARE = 2;
        private const int DATA_LIVRARE = 3;
        private const int STARE_COMANDA = 4;
        private const int DESCRIERE_COLET = 5;
        private const int GREUTATE_COLET = 6;
        private const int DIMENSIUNE_COLET = 7;

        public int IDComanda { get; set; }
        public string NumeClient { get; set; }
        public string AdresaLivrare { get; set; }
        public string DataLivrare { get; set; }
        public string StareComanda { get; set; }
        public Colet Colet { get; set; }

        // Constructor fara parametri
        public ComandaLivrare()
        {
            IDComanda = 0;
            NumeClient = string.Empty;
            AdresaLivrare = string.Empty;
            DataLivrare = string.Empty;
            StareComanda = string.Empty;
            Colet = new Colet();
        }

        // Constructor cu parametri
        public ComandaLivrare(int idComanda, string numeClient, string adresaLivrare, string dataLivrare, string stareComanda, Colet colet)
        {
            this.IDComanda = idComanda;
            this.NumeClient = numeClient;
            this.AdresaLivrare = adresaLivrare;
            this.DataLivrare = dataLivrare;
            this.StareComanda = stareComanda;
            this.Colet = colet;
        }

        // Constructor care preia date dintr-o linie de fișier
        public ComandaLivrare(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            IDComanda = int.Parse(dateFisier[ID_COMANDA]);
            NumeClient = dateFisier[NUME_CLIENT];
            AdresaLivrare = dateFisier[ADRESA_LIVRARE];
            DataLivrare = dateFisier[DATA_LIVRARE];
            StareComanda = dateFisier[STARE_COMANDA];
            Colet = new Colet(dateFisier[DESCRIERE_COLET], double.Parse(dateFisier[GREUTATE_COLET]), dateFisier[DIMENSIUNE_COLET]);
        }
        public string Info()
        {
            return $"ID Comanda: {IDComanda}, Nume Client: {NumeClient}, Adresa: {AdresaLivrare}, Data Livrare: {DataLivrare}, Stare: {StareComanda}, {Colet.Info()}";
        }

        public string ConversieLaSir_PentruFisier()
        { 
            return string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}",
                SEPARATOR_PRINCIPAL_FISIER,
                IDComanda,
                NumeClient,
                AdresaLivrare,
                DataLivrare,
                StareComanda,
                Colet.Descriere,
                Colet.Greutate,
                Colet.Dimensiune);
        }
    }
}
