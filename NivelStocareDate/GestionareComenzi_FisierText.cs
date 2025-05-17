using System;
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
        private const int ID_COMANDA = 0;
        private const int INCREMENTARE_ID = 1;

        private string numeFisierComenzi;

        public GestionareComenzi_FisierText(string numeFisierComenzi)
        {
            this.numeFisierComenzi = numeFisierComenzi;
            Stream streamFisier = File.Open(numeFisierComenzi, FileMode.OpenOrCreate);
            streamFisier.Close();
        }
        public void AddComanda(Comanda comanda)
        {
            comanda.IDComanda = GetId();
            using (StreamWriter streamWriter = new StreamWriter(numeFisierComenzi, true))
            {
                streamWriter.WriteLine(comanda.ConversieLaSir_PentruFisier());
            }
        }

        public List<Comanda> GetComenzi()
        {
            List<Comanda> comenzi = new List<Comanda>();
            using (StreamReader streamReader = new StreamReader(numeFisierComenzi))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    comenzi.Add(new Comanda(linieFisier));
                }
            }
            return comenzi;
        }
  
        public int GetId()
        {
            int IDComanda = ID_COMANDA;

            using (StreamReader streamReader = new StreamReader(numeFisierComenzi))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Comanda comanda = new Comanda(linieFisier);
                    IDComanda = comanda.IDComanda + INCREMENTARE_ID;
                }
            }

            return IDComanda;
        }
        public Comanda GetComanda(int idComanda)
        {
            using (StreamReader streamReader = new StreamReader(numeFisierComenzi))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Comanda comanda = new Comanda(linieFisier);

                    if (comanda.IDComanda == idComanda)
                        return comanda;
                }
            }

            return null;
        }


        public List<Comanda> GetComenzi(string numeClient)
        {
            List<Comanda> comenzi = new List<Comanda>();
            using (StreamReader streamReader = new StreamReader(numeFisierComenzi))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Comanda comanda = new Comanda(linieFisier);
                    if (!string.IsNullOrEmpty(comanda.NumeClient) &&
                        comanda.NumeClient.IndexOf(numeClient, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        comenzi.Add(comanda);
                    }
                }
            }
            return comenzi;
        }

        public bool UpdateComanda(Comanda comandaActualizata)
        {
            List<Comanda> comenzi = GetComenzi();
            bool actualizareCuSucces = false;

            using (StreamWriter streamWriter = new StreamWriter(numeFisierComenzi, false))
            {
                foreach (Comanda comanda in comenzi)
                {
                    Comanda comandaPentruScriereInFisier = comanda;
                    if (comanda.IDComanda == comandaActualizata.IDComanda)
                    {
                        comandaPentruScriereInFisier = comandaActualizata;
                    }
                    streamWriter.WriteLine(comandaPentruScriereInFisier.ConversieLaSir_PentruFisier());

                }
                actualizareCuSucces = true;
            }
            return actualizareCuSucces;
        }
    }
}