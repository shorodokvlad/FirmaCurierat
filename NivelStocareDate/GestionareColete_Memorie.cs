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
        private const int NR_MAX_COLETE = 100;
        private Colet[] colete;
        private int nrColete;

        public GestionareColete_Memorie()
        {
            colete = new Colet[NR_MAX_COLETE];
            nrColete = 0;
        }

        public void AddColet(Colet colet)
        {
            colete[nrColete] = colet;
            nrColete++;
        }

        public Colet[] GetColete(out int nrColete)
        {
            nrColete = this.nrColete;
            return colete;
        }

        public Colet CautareDupaIDColet(int idColet)
        {
            for (int i = 0; i < nrColete; i++)
            {
                if (colete[i] != null && colete[i].IDColet == idColet)
                {
                    return colete[i];
                }
            }
            return null;
        }

        public Colet CautareDupaDescriere(string descriere)
        {
            for (int i = 0; i < nrColete; i++)
            {
                if (colete[i] != null && colete[i].Descriere == descriere)
                {
                    return colete[i];
                }
            }
            return null;
        }
    }
}