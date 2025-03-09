using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NivelStocareDate;
using LibrarieModele;

namespace FirmaCurierat
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionareComenzi gestiune = new GestionareComenzi();
            ComandaLivrare comanda2 = CitireComandaTastatura();

            gestiune.AddComanda(comanda2);
            AfisareComanda(comanda2);


            Console.ReadKey();


        }

        public static ComandaLivrare CitireComandaTastatura() 
        {
            Console.WriteLine("Introduceti ID comanda: ");
            int idComanda = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti numele clientului: ");
            string numeClient = Console.ReadLine();

            Console.WriteLine("Introduceti adresa de livrare: ");
            string adresaLivrare = Console.ReadLine();

            Console.WriteLine("Introduceti data livrarii: ");
            string dataLivrare = Console.ReadLine();

            Console.WriteLine("Introduceti starea comenzii: ");
            string stareComanda = Console.ReadLine();

            Console.WriteLine("Introduceti descrierea coletului: ");
            string descriere = Console.ReadLine();

            Console.WriteLine("Introduceti greutatea coletului: ");
            double greutate = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti dimensiunea coletului: ");
            string dimensiune = Console.ReadLine();

            Colet colet = new Colet(descriere, greutate, dimensiune);
            ComandaLivrare comanda = new ComandaLivrare(idComanda, numeClient, adresaLivrare, dataLivrare, stareComanda, colet);

            return comanda;
        }
        public static void AfisareComanda(ComandaLivrare comanda)
        {
            string infoComanda = string.Format("Comanda cu ID-ul #{0} are următoarele detalii:\n"
                                                      + "Nume client: {1}\n"
                                                      + "Adresa de livrare: {2}\n"
                                                      + "Data livrării: {3}\n"
                                                      + "Starea comenzii: {4}\n"
                                                      + "Descriere Colet: {5}\n"
                                                      + "Greutate Colet: {6} kg\n"
                                                      + "Dimensiune Colet: {7}",
                                                      comanda.IDComanda,
                                                      comanda.NumeClient ?? "NECUNOSCUT",
                                                      comanda.AdresaLivrare ?? "NECUNOSCUT",
                                                      comanda.DataLivrare ?? "NECUNOSCUT",
                                                      comanda.StareComanda ?? "NECUNOSCUT",
                                                      comanda.Colet.Descriere ?? "NECUNOSCUT",
                                                      comanda.Colet.Greutate,
                                                      comanda.Colet.Dimensiune ?? "NECUNOSCUT");

            Console.WriteLine(infoComanda);
        }


    }
}
