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
        private ComandaLivrare[] comenzi;
        private int nrComenzi;

        public GestionareComenzi_Memorie()
        {
            comenzi = new ComandaLivrare[NR_MAX_COMENZI];
            nrComenzi = 0;
        }
        public void AddComanda(ComandaLivrare comanda)
        { 
            comenzi[nrComenzi] = comanda;
            nrComenzi++;
        }

        public ComandaLivrare[] GetComenzi(out int nrComenzi)
        {
            nrComenzi = this.nrComenzi;
            return comenzi;
        }

        public ComandaLivrare CautareDupaIDComanda(int idComanda)
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

        public ComandaLivrare CautareDupaNumeClient(string numeClient)
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
