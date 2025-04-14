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
        public StareComanda StareComanda { get; set; }

        public int IDColet { get; set; }
        public string Colet { get; set; }

        // Constructor fara parametri
        public Comanda()
        {
            IDComanda = 0;
            NumeClient = string.Empty;
            AdresaLivrare = string.Empty;
            DataLivrare = string.Empty;
            StareComanda = StareComanda.ComandaPlasata;
            IDColet = 0;
        }


        // Constructor cu parametri
        public Comanda(int idComanda, string numeClient, string adresaLivrare, string dataLivrare, StareComanda stareComanda, Colet colet, int idColet)
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
            StareComanda = (StareComanda)Enum.Parse(typeof(StareComanda), date[STARE_COMANDA]);
            IDColet = int.Parse(date[ID_COLET]);
        }

 
            public string GetStareComandaText()
            {
            switch (StareComanda)
            {
                case StareComanda.ComandaPlasata:
                    return "Comanda Plasata";
                case StareComanda.InAsteptareLaExpeditor:
                    return "In Asteptare La Expeditor";
                case StareComanda.PreluatDeCurier:
                    return "Preluat De Curier";
                case StareComanda.InProcesareLaCentruLogistic:
                    return "In Procesare La Centru Logistic";
                case StareComanda.InTranzit:
                    return "In Tranzit";
                case StareComanda.InTranzitRedirectionat:
                    return "In Tranzit Redirectionat";
                case StareComanda.InCursDeLivrare:
                    return "In Curs De Livrare";
                case StareComanda.Livrat:
                    return "Livrat";
                case StareComanda.AdresaIncorectaIncompleta:
                    return "Adresa Incorecta Incompleta";
                case StareComanda.DestinatarIndisponibil:
                    return "Destinatar Indisponibil";
                case StareComanda.RetinutInVama:
                    return "Retinut In Vama";
                case StareComanda.IntarziereConditiiMeteoLogistice:
                    return "Intarziere Conditii Meteo Logistice";
                case StareComanda.InProcesDeReturnare:
                    return "In Proces De Returnare";
                case StareComanda.ReturnatLaExpeditor:
                    return "Returnat La Expeditor";
                case StareComanda.ColetPierdut:
                    return "Colet Pierdut";
                case StareComanda.ColetDeteriorat:
                    return "Colet Deteriorat";
                default:
                    return "Stare Comanda necunoscuta";
            }
        }
      
        public string Info()
        {
            return $"ID Comanda: {IDComanda}\n Nume Client: {NumeClient}\n Adresa: {AdresaLivrare}\n Data Livrare: {DataLivrare}\n Stare: {GetStareComandaText()}\n ID Colet: {IDColet}\n";
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectComandaPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}",
                SEPARATOR_PRINCIPAL_FISIER,
                IDComanda,
                NumeClient,
                AdresaLivrare,
                DataLivrare,
                StareComanda,
                IDColet);

            return obiectComandaPentruFisier;
        }
    }
}
