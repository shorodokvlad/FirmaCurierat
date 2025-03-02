using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaCurierat
{
    class GestionareComenzi
    {
        public ComandaLivrare[] Comenzi;

        // Constructor fara parametri
        public GestionareComenzi(int capacitate)
        {
            Comenzi = new ComandaLivrare[capacitate];
        }

        // Constructor cu parametri
        public GestionareComenzi(ComandaLivrare[] comenzi)
        {
            Comenzi = comenzi;
        }
    }
}
