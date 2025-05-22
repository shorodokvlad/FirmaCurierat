using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibrarieModele;

namespace NivelStocareDate
{
    public class GestionareColete_FisierText
    {
        private const int ID_COLET = 100;
        private const int INCREMENTARE_ID = 1;
        private string numeFisierColete;

        public GestionareColete_FisierText(string numeFisierColete)
        {
            this.numeFisierColete = numeFisierColete;
            Stream streamFisier = File.Open(numeFisierColete, FileMode.OpenOrCreate);
            streamFisier.Close();
        }

        public void AddColet(Colet colet)
        {
            using (StreamWriter streamWriter = new StreamWriter(numeFisierColete, true))
            {
                streamWriter.WriteLine(colet.ConversieLaSir_PentruFisier());
            }
        }
        public List<Colet> GetColete()
        {
            List<Colet> colete = new List<Colet>();
            using (StreamReader streamReader = new StreamReader(numeFisierColete))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    colete.Add(new Colet(linieFisier));
                }
            }

            return colete;
        }

        public int GetId()
        {
            int IDColet = ID_COLET;

            using (StreamReader streamReader = new StreamReader(numeFisierColete))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Colet colet = new Colet(linieFisier);
                    IDColet = colet.IDColet + INCREMENTARE_ID;
                }
            }

            return IDColet;
        }
        public Colet GetColet(int idColet)
        {
            using (StreamReader streamReader = new StreamReader(numeFisierColete))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Colet colet = new Colet(linieFisier);

                    if (colet.IDColet == idColet)
                        return colet;
                }
            }

            return null;
        }

        public List<Colet> GetColete(string descriere)
        {
            List<Colet> colete = new List<Colet>();
            using (StreamReader streamReader = new StreamReader(numeFisierColete))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Colet colet = new Colet(linieFisier);

                    if (!string.IsNullOrEmpty(colet.Descriere) &&
                        colet.Descriere.IndexOf(descriere, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        colete.Add(colet);
                    }
                }
            }

            return colete;
        }


        public bool UpdateColet(Colet coletActualizat)
        {
            List<Colet> colete = GetColete();
            bool actualizareCuSucces = false;

            using (StreamWriter streamWriter = new StreamWriter(numeFisierColete, false))
            {
                foreach (Colet colet in colete)
                {
                    Colet coletPentruScriereInFisier = colet;
                    if (colet.IDColet == coletActualizat.IDColet)
                    {
                        coletPentruScriereInFisier = coletActualizat;
                    }
                    streamWriter.WriteLine(coletPentruScriereInFisier.ConversieLaSir_PentruFisier());

                }
                actualizareCuSucces = true;
            }
            return actualizareCuSucces;
        }

        public bool DeleteColet(int idColet)
        {
            List<Colet> colete = GetColete();

            bool found = false;
            for (int i = 0; i < colete.Count; i++)
            {
                if (colete[i].IDColet == idColet)
                {
                    colete.RemoveAt(i);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                return false;
            }

            using (StreamWriter streamWriter = new StreamWriter(numeFisierColete, false))
            {
                foreach (Colet colet in colete)
                {
                    streamWriter.WriteLine(colet.ConversieLaSir_PentruFisier());
                }
            }
            return true;
        }
    }
}



