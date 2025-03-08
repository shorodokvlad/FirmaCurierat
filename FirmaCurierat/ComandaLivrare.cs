using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaCurierat
{
    public class ComandaLivrare
    {
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
            IDComanda = idComanda;
            NumeClient = numeClient;
            AdresaLivrare = adresaLivrare;
            DataLivrare = dataLivrare;
            StareComanda = stareComanda;
            Colet = colet;
        }
        public string Info()
        {
            return $"ID Comanda: {IDComanda}, Nume Client: {NumeClient}, Adresa: {AdresaLivrare}, Data Livrare: {DataLivrare}, Stare: {StareComanda}, {Colet.Info()}";
        }
    }
}



