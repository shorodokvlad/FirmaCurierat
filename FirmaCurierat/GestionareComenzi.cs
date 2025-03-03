using System;

namespace FirmaCurierat
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
