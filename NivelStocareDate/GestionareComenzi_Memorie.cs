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
    }
}