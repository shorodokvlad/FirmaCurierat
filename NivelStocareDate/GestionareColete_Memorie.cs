using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class GestionareColete_Memorie
    {
        private List<Colet> colete;

        public GestionareColete_Memorie()
        {
            colete = new List<Colet>();
        }

        public void AddColet(Colet colet)
        {
            colete.Add(colet);
        }

        public List<Colet> GetColete()
        {
            return colete;
        }

        public Colet CautareDupaIDColet(int idColet)
        {
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