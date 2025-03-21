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
        private const int NR_MAX_COLETE = 100;
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

        public Colet[] GetColete(out int nrColete)
        {
            Colet[] colete = new Colet[NR_MAX_COLETE];
            using (StreamReader streamReader = new StreamReader(numeFisierColete))
            {
                string linieFisier;
                nrColete = 0;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    colete[nrColete++] = new Colet(linieFisier);
                }
            }
            return colete;
        }

        public Colet CautareDupaIDColet(int idColet)
        {
            Colet[] colete = GetColete(out int nrColete);
            foreach (var colet in colete)
            {
                if (colet != null && colet.IDColet == idColet)
                {
                    return colet;
                }
            }
            return null;
        }

        public Colet CautareDupaDescriere(string descriere)
        {
            Colet[] colete = GetColete(out int nrColete);
            foreach (var colet in colete)
            {
                if (colet != null && colet.Descriere == descriere)
                {
                    return colet;
                }
            }
            return null;
        }
    }
}



