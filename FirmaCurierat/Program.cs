using System;
using System.Configuration;
using LibrarieModele;
using NivelStocareDate;

namespace FirmaCurierat
{
    class Program
    {
        static void Main()
        {
            // GestionareComenzi_Memorie gestiune = new GestionareComenzi_Memorie();

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            GestionareComenzi_FisierText gestiuneFisier = new GestionareComenzi_FisierText(numeFisier);
            ComandaLivrare comandaNoua = new ComandaLivrare();
            int nrComenzi = 0;

            string optiune;
            do
            {
                Console.WriteLine("C. Citire informatii comanda de la tastatura");
                Console.WriteLine("I. Afisarea informatiilor despre ultima comanda introdusa");
                Console.WriteLine("A. Afisare comenzi din fisier");
                Console.WriteLine("S. Salvare comanda in fisier");
                Console.WriteLine("F. Cautare comanda ");
                Console.WriteLine("X. Inchidere program");

                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "C":
                        comandaNoua = CitireComandaTastatura();
                        break;

                    case "I":
                        AfisareComanda(comandaNoua);
                        break;

                    case "A":
                        ComandaLivrare[] comenzi = gestiuneFisier.GetComenzi(out nrComenzi);
                        AfisareComenzi(comenzi, nrComenzi);
                        break;

                    case "S":
                        gestiuneFisier.AddComanda(comandaNoua);
                        break;

                    case "F":
                        string optiuneCautare;
                        do
                        {
                            Console.WriteLine("Cautare dupa: ");
                            Console.WriteLine("1. ID comanda");
                            Console.WriteLine("2. Nume client");
                            optiuneCautare = Console.ReadLine();
                            switch (optiuneCautare)
                            {
                                case "1":
                                    Console.WriteLine("Introduceti ID-ul comenzii cautate: ");
                                    int idComanda = int.Parse(Console.ReadLine());
                                    ComandaLivrare comandaCautata = gestiuneFisier.CautareDupaIDComanda(idComanda);
                                    if (comandaCautata != null)
                                    {
                                        Console.WriteLine("Comanda a fost gasita: ");
                                        AfisareComanda(comandaCautata);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Comanda cu ID-ul {idComanda} nu a fost gasita\n");
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Introduceti numele clientului cautat: ");
                                    string numeClient = Console.ReadLine();
                                    ComandaLivrare comandaCautataNume = gestiuneFisier.CautareDupaNumeClient(numeClient);
                                    if (comandaCautataNume != null)
                                    {
                                        Console.WriteLine("Comanda a fost gasita: ");
                                        AfisareComanda(comandaCautataNume);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Comanda cu numele {numeClient} nu a fost gasita\n");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Optiune invalida");
                                    break;
                            }
                        } while (optiuneCautare != "1" && optiuneCautare != "2");
                        break;

                    case "X":
                        return;

                    default:
                        Console.WriteLine("Optiune invalida");
                        break;
                }
            } while (optiune.ToUpper() != "X");

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
            string infoComanda = string.Format("\nComanda cu ID-ul #{0} are următoarele detalii:\n"
                                                  + "Nume client: {1}\n"
                                                  + "Adresa de livrare: {2}\n"
                                                  + "Data livrării: {3}\n"
                                                  + "Starea comenzii: {4}\n"
                                                  + "Descriere Colet: {5}\n"
                                                  + "Greutate Colet: {6} kg\n"
                                                  + "Dimensiune Colet: {7} cm\n",
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

        public static void AfisareComenzi(ComandaLivrare[] comenzi, int nrComenzi)
        {
            Console.WriteLine("Comenzile sunt:");
            for (int contor = 0; contor < nrComenzi; contor++)
            {
                AfisareComanda(comenzi[contor]);
            }
        }
    }
}
