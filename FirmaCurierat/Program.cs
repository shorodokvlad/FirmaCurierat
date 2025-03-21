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
            string numeFisierComenzi = ConfigurationManager.AppSettings["NumeFisierComenzi"];
            string numeFisierColete = ConfigurationManager.AppSettings["NumeFisierColete"];

            GestionareComenzi_FisierText gestiuneFisierComenzi = new GestionareComenzi_FisierText(numeFisierComenzi);
            GestionareColete_FisierText gestiuneFisierColete = new GestionareColete_FisierText(numeFisierColete);

            Comanda comandaNoua = new Comanda();
            int nrComenzi = 0;

            Colet coletNou = new Colet();
            int nrColete = 0;

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
                        (comandaNoua, coletNou) = CitireComandaSiColetTastatura();
                        break;

                    case "I":
                        AfisareComanda(comandaNoua, coletNou);
                        break;

                    case "A":
                        Comanda[] comenzi = gestiuneFisierComenzi.GetComenzi(out nrComenzi);
                        Colet[] colete = gestiuneFisierColete.GetColete(out nrColete);
                        AfisareComenzi(comenzi, nrComenzi, colete);
                        break;

                    case "S":
                        gestiuneFisierComenzi.AddComanda(comandaNoua);
                        gestiuneFisierColete.AddColet(coletNou);
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
                                    if (int.TryParse(Console.ReadLine(), out int idComanda))
                                    {
                                        Comanda comandaCautata = gestiuneFisierComenzi.CautareDupaIDComanda(idComanda);
                                        if (comandaCautata != null)
                                        {
                                            Console.WriteLine("Comanda a fost gasita: ");
                                            AfisareComanda(comandaCautata, gestiuneFisierColete.CautareDupaIDColet(comandaCautata.IDColet));
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Comanda cu ID-ul {idComanda} nu a fost gasita\n");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ID-ul introdus nu este valid.");
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Introduceti numele clientului cautat: ");
                                    string numeClient = Console.ReadLine();
                                    Comanda comandaCautataNume = gestiuneFisierComenzi.CautareDupaNumeClient(numeClient);
                                    if (comandaCautataNume != null)
                                    {
                                        Console.WriteLine("Comanda a fost gasita: ");
                                        AfisareComanda(comandaCautataNume, gestiuneFisierColete.CautareDupaIDColet(comandaCautataNume.IDColet));
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

        public static (Comanda comanda, Colet colet) CitireComandaSiColetTastatura()
        {
            Console.WriteLine("\n--- Introducere date comanda ---");
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

            Console.WriteLine("Introduceti ID-ul coletului: ");
            int idColet = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti descrierea coletului: ");
            string descriere = Console.ReadLine();

            Console.WriteLine("Introduceti greutatea coletului: ");
            double greutate = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti dimensiunea coletului: ");
            string dimensiune = Console.ReadLine();

            Colet colet = new Colet(idColet, descriere, greutate, dimensiune);
            Comanda comanda = new Comanda(idComanda, numeClient, adresaLivrare, dataLivrare, stareComanda, colet, idColet);

            return (comanda, colet);
        }

        public static void AfisareComanda(Comanda comanda, Colet colet)
        {
            if (comanda == null)
            {
                Console.WriteLine("Nu exista nicio comanda de afisat.");
                return;
            }

            string infoComanda = string.Format("Comanda cu ID-ul #{0}:\n"
                                           + "Nume client: {1}\n"
                                           + "Adresa de livrare: {2}\n"
                                           + "Data livrării: {3}\n"
                                           + "Starea comenzii: {4}",
                                           comanda.IDComanda,
                                           comanda.NumeClient ?? "NECUNOSCUT",
                                           comanda.AdresaLivrare ?? "NECUNOSCUT",
                                           comanda.DataLivrare ?? "NECUNOSCUT",
                                           comanda.StareComanda ?? "NECUNOSCUT");

            Console.WriteLine(infoComanda);

            string infoColet = string.Format("\nColetul cu ID-ul #{0}:\n"
                                         + "Descriere: {1}\n"
                                         + "Greutate: {2} kg\n"
                                         + "Dimensiune: {3}\n",
                                         colet.IDColet,
                                         colet.Descriere ?? "NECUNOSCUT",
                                         colet.Greutate,
                                         colet.Dimensiune ?? "NECUNOSCUT");

            Console.WriteLine(infoColet);
        }

        public static void AfisareComenzi(Comanda[] comenzi, int nrComenzi, Colet[] colete)
        {
            Console.WriteLine("Comenzile sunt:");
            for (int contor = 0; contor < nrComenzi; contor++)
            {
                AfisareComanda(comenzi[contor], colete[contor]);
            }
        }
    }
}
