﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibrarieModele;

namespace NivelStocareDate
{
    public class GestionareComenzi_FisierText
    {
        private const int NR_MAX_COMENZI = 100;
        private string numeFisier;

    public GestionareComenzi_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisier = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisier.Close();
        }
        public void AddComanda(ComandaLivrare comanda)
        {
            using (StreamWriter streamWriter = new StreamWriter(numeFisier, true))
            {
                streamWriter.WriteLine(comanda.ConversieLaSir_PentruFisier());
            }
        }

        public ComandaLivrare[] GetComenzi(out int nrComenzi)
        {
            ComandaLivrare[] comenzi = new ComandaLivrare[NR_MAX_COMENZI];
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrComenzi = 0;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    comenzi[nrComenzi++] = new ComandaLivrare(linieFisier);
                }
            }
            return comenzi;
        }

        public ComandaLivrare CautareDupaIDComanda(int idComanda)
        {
            ComandaLivrare[] comenzi = GetComenzi(out int nrComenzi);
            foreach (var comanda in comenzi)
            {
                if (comanda != null && comanda.IDComanda == idComanda)
                {
                    return comanda;
                }
            }
            return null;
        }

        public ComandaLivrare CautareDupaNumeClient(string numeClient)
        {
            ComandaLivrare[] comenzi = GetComenzi(out int nrComenzi);
            foreach (var comanda in comenzi)
            {
                if (comanda != null && comanda.NumeClient == numeClient)
                {
                    return comanda;
                }
            }
            return null;
        }
    }
}
