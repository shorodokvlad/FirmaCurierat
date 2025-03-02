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
        public string DescriereColet { get; set; }
        public double GreutateColet { get; set; }
        public string DimensiuneColet { get; set; }
        public string DataLivrare { get; set; }
        public string StareComanda { get; set; }

        // Constructor fara parametri
        public ComandaLivrare()
        {
            IDComanda = 0;
            NumeClient = string.Empty;
            AdresaLivrare = string.Empty;
            DescriereColet = string.Empty;
            GreutateColet = 0;
            DimensiuneColet = string.Empty;
            DataLivrare = string.Empty;
            StareComanda = string.Empty;
        }

        // Constructor cu parametri
        public ComandaLivrare(int idComanda, string numeClient, string adresaLivrare, string descriereColet, double greutateColet, string dimensiuneColet, string dataLivrare, string stareComanda)
        {
            IDComanda = idComanda;
            NumeClient = numeClient;
            AdresaLivrare = adresaLivrare;
            DescriereColet = descriereColet;
            GreutateColet = greutateColet;
            DimensiuneColet = dimensiuneColet;
            DataLivrare = dataLivrare;
            StareComanda = stareComanda;
        }
        public string Info()
        {
            return $"ID Comanda: {IDComanda}, Nume Client: {NumeClient}, Adresa: {AdresaLivrare}, Descriere: {DescriereColet}, Greutate: {GreutateColet} kg, Dimensiune: {DimensiuneColet}, Data Livrare: {DataLivrare}, Stare: {StareComanda}";
        }
    }
}



