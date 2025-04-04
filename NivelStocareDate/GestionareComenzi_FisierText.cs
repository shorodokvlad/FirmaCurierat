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
        private string numeFisierComenzi;

        public GestionareComenzi_FisierText(string numeFisierComenzi)
        {
            this.numeFisierComenzi = numeFisierComenzi;
            Stream streamFisier = File.Open(numeFisierComenzi, FileMode.OpenOrCreate);
            streamFisier.Close();
        }
        public void AddComanda(Comanda comanda)
        {
            using (StreamWriter streamWriter = new StreamWriter(numeFisierComenzi, true))
            {
                streamWriter.WriteLine(comanda.ConversieLaSir_PentruFisier());
            }
        }

        public Comanda[] GetComenzi(out int nrComenzi)
        {
            Comanda[] comenzi = new Comanda[NR_MAX_COMENZI];
            using (StreamReader streamReader = new StreamReader(numeFisierComenzi))
            {
                string linieFisier;
                nrComenzi = 0;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    comenzi[nrComenzi++] = new Comanda(linieFisier);
                }
            }
            Array.Resize(ref comenzi, nrComenzi);
            return comenzi;
        }

        public Comanda CautareDupaIDComanda(int idComanda)
        {
            Comanda[] comenzi = GetComenzi(out int nrComenzi);
            foreach (var comanda in comenzi)
            {
                if (comanda != null && comanda.IDComanda == idComanda)
                {
                    return comanda;
                }
            }
            return null;
        }

        public Comanda CautareDupaNumeClient(string numeClient)
        {
            Comanda[] comenzi = GetComenzi(out int nrComenzi);
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