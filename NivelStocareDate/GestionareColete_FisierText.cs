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

        public Colet CautareDupaIDColet(int idColet)
        {
            List<Colet> colete = GetColete();
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
            List<Colet> colete = GetColete();
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



