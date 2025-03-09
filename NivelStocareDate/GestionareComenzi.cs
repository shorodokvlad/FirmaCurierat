using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class GestionareComenzi
    {
        public ComandaLivrare[] Comenzi { get; set; }
        public int CapacitateMaxima { get; set; }

        // Constructor fara parametri
        public GestionareComenzi()
        {
            Comenzi = new ComandaLivrare[0];
            CapacitateMaxima = 0;
        }

        // Constructor cu parametri
        public GestionareComenzi(int capacitateMaxima)
        {
            Comenzi = new ComandaLivrare[capacitateMaxima];
            CapacitateMaxima = capacitateMaxima;
        }
    }
}
