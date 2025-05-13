using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace LibrarieModele
{
    public class Comanda
    {
        // Constante pentru delimitarea în fișier
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';

        private const int ID_COMANDA = 0;
        private const int NUME_CLIENT = 1;
        private const int ADRESA_LIVRARE = 2;
        private const int DATA_LIVRARE = 3;
        private const int STARE_COMANDA = 4;
        private const int OPTIUNI_LIVRARE = 5;
        private const int ID_COLET = 6;

        public int IDComanda { get; set; }
        public string NumeClient { get; set; }
        public string AdresaLivrare { get; set; }
        public string DataLivrare { get; set; }
        public StareComanda StareComanda { get; set; }
        public int IDColet { get; set; }
        public string Colet { get; set; }

        public ArrayList OptiuniLivrare { get; set; } 

        public string OptiuniLivrareAsString
        {
            get
            {
                return string.Join(SEPARATOR_SECUNDAR_FISIER.ToString(), OptiuniLivrare.ToArray());
            }
        }

        // Constructor fără parametri
        public Comanda()
        {
            IDComanda = 0;
            NumeClient = string.Empty;
            AdresaLivrare = string.Empty;
            DataLivrare = string.Empty;
            StareComanda = StareComanda.ComandaPlasata;
            IDColet = 0;
            OptiuniLivrare = new ArrayList();
        }

        // Constructor cu parametri
        public Comanda(int idComanda, string numeClient, string adresaLivrare, string dataLivrare, StareComanda stareComanda, ArrayList optiuniLivrare, int idColet)
        {
            IDComanda = idComanda;
            NumeClient = numeClient;
            AdresaLivrare = adresaLivrare;
            DataLivrare = dataLivrare;
            StareComanda = stareComanda;
            IDColet = idColet;
            OptiuniLivrare = optiuniLivrare;
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

            OptiuniLivrare = new ArrayList();
            OptiuniLivrare.AddRange(date[OPTIUNI_LIVRARE].Split(SEPARATOR_SECUNDAR_FISIER));
        }

        public string OptiuniLivrareToString()
        {
            return string.Join(", ", OptiuniLivrare.ToArray());

        }

        public string StareComandaToString()
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
            return $"ID Comanda: {IDComanda}\nNume Client: {NumeClient}\nAdresa: {AdresaLivrare}\nData Livrare: {DataLivrare}\nStare: {StareComanda}\nOptiuni Livrare: {OptiuniLivrareAsString}\nID Colet: {IDColet}\n";
        }

        public string ConversieLaSir_PentruFisier()
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}",
                SEPARATOR_PRINCIPAL_FISIER,
                IDComanda,
                NumeClient,
                AdresaLivrare,
                DataLivrare,
                StareComanda,
                OptiuniLivrareAsString,
                IDColet);
        }
    }
}