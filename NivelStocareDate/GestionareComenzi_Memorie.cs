using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class GestionareComenzi_Memorie
    {
        private const int NR_MAX_COMENZI = 100;
        private Comanda[] comenzi;
        private int nrComenzi;

        public GestionareComenzi_Memorie()
        {
            comenzi = new Comanda[NR_MAX_COMENZI];
            nrComenzi = 0;
        }
        public void AddComanda(Comanda comanda)
        {
            comenzi[nrComenzi] = comanda;
            nrComenzi++;
        }

        public Comanda[] GetComenzi(out int nrComenzi)
        {
            nrComenzi = this.nrComenzi;
            return comenzi;
        }
        public Comanda CautareDupaIDComanda(int idComanda)
        {
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