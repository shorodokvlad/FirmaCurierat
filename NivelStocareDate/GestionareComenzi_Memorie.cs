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
        private List<Comanda> comenzi;

        public GestionareComenzi_Memorie()
        {
            comenzi = new List<Comanda>();
        }
        public void AddComanda(Comanda comanda)
        {
            comenzi.Add(comanda);
        }

        public List<Comanda> GetComenzi()
        {
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