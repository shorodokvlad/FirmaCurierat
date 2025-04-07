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

        public Comanda CautareDupaIDComanda(int idComanda)
        {
            List<Comanda> comenzi = GetComenzi();
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
            List<Comanda> comenzi = GetComenzi();
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