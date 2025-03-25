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

            GestionareComenzi_Memorie gestiuneMemorieComenzi = new GestionareComenzi_Memorie();
            GestionareColete_Memorie gestiuneMemorieColete = new GestionareColete_Memorie();

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
                Console.WriteLine("M. Afisare comenzi din memorie");
                Console.WriteLine("S. Salvare comanda in fisier");
                Console.WriteLine("L. Salvare comanda in lista de comenzi");
                Console.WriteLine("F. Cautare comanda sau colet din fisier");
                Console.WriteLine("N. Cautare comanda sau colet din memorie");
                Console.WriteLine("X. Inchidere program");

                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "C":
                        (comandaNoua, coletNou) = CitireComandaSiColetTastatura();
                        break;

                    case "I":
                        AfisareComandaSiColet(comandaNoua, coletNou);
                        break;

                    case "A":
                        Comanda[] comenzi = gestiuneFisierComenzi.GetComenzi(out nrComenzi);
                        Colet[] colete = gestiuneFisierColete.GetColete(out nrColete);
                        AfisareComenziSiColete(comenzi, nrComenzi, colete);
                        break;

                    case "M":
                        Comanda[] comenziMemorie = gestiuneMemorieComenzi.GetComenzi(out nrComenzi);
                        Colet[] coleteMemorie = gestiuneMemorieColete.GetColete(out nrColete);
                        AfisareComenziSiColete(comenziMemorie, nrComenzi, coleteMemorie);
                        break;

                    case "S":
                        gestiuneFisierComenzi.AddComanda(comandaNoua);
                        gestiuneFisierColete.AddColet(coletNou);
                        break;
                    case "F":
                        string optiuneCautareFisier;
                        do
                        {
                            Console.WriteLine("Cautare dupa: ");
                            Console.WriteLine("1. ID comanda");
                            Console.WriteLine("2. Nume client");
                            Console.WriteLine("3. ID colet");
                            Console.WriteLine("4. Descriere colet");
                            Console.WriteLine("X. Iesire");

                            optiuneCautareFisier = Console.ReadLine();
                            switch (optiuneCautareFisier)
                            {
                                case "1":
                                    Console.WriteLine("Introduceti ID-ul comenzii cautate: ");
                                    if (int.TryParse(Console.ReadLine(), out int idComanda))
                                    {
                                        Comanda comandaCautata = gestiuneFisierComenzi.CautareDupaIDComanda(idComanda);
                                        if (comandaCautata != null)
                                        {
                                            Console.WriteLine("Comanda a fost gasita: ");
                                            AfisareComandaSiColet(comandaCautata, gestiuneFisierColete.CautareDupaIDColet(comandaCautata.IDColet));
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
                                        AfisareComandaSiColet(comandaCautataNume, gestiuneFisierColete.CautareDupaIDColet(comandaCautataNume.IDColet));
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Comanda cu numele {numeClient} nu a fost gasita\n");
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine("Introduceti ID-ul coletului cautat: ");
                                    if (int.TryParse(Console.ReadLine(), out int idColet))
                                    {
                                        Colet coletCautat = gestiuneFisierColete.CautareDupaIDColet(idColet);
                                        if (coletCautat != null)
                                        {
                                            Console.WriteLine($"Coletul cu ID-ul {idColet} a fost gasit: ");
                                            Console.WriteLine(coletCautat.Info());
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Coletul cu ID-ul {idColet} nu a fost gasit\n");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ID-ul introdus nu este valid.");
                                    }
                                    break;
                                case "4":
                                    Console.WriteLine("Introduceti descrierea coletului cautat: ");
                                    string descriereColet = Console.ReadLine();
                                    Colet coletCautatDescriere = gestiuneFisierColete.CautareDupaDescriere(descriereColet);
                                    if (coletCautatDescriere != null)
                                    {
                                        Console.WriteLine($"Coletul cu descrierea {descriereColet} a fost gasit: ");
                                        Console.WriteLine(coletCautatDescriere.Info());
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Coletul cu descrierea {descriereColet} nu a fost gasit\n");
                                    }
                                    break;
                                case "X":
                                    break;

                                default:
                                    Console.WriteLine("Optiune invalida");
                                    break;
                            }
                        } while (optiuneCautareFisier.ToUpper() != "X");
                        break;

                    case "L":
                        gestiuneMemorieComenzi.AddComanda(comandaNoua);
                        gestiuneMemorieColete.AddColet(coletNou);
                        break;
                    case "N":
                        string optiuneCautareMemorie;
                        do
                        {
                            Console.WriteLine("Cautare dupa: ");
                            Console.WriteLine("1. ID comanda");
                            Console.WriteLine("2. Nume client");
                            Console.WriteLine("3. ID colet");
                            Console.WriteLine("4. Descriere colet");
                            Console.WriteLine("X. Iesire");

                            optiuneCautareMemorie = Console.ReadLine();
                            switch (optiuneCautareMemorie)
                            {
                                case "1":
                                    Console.WriteLine("Introduceti ID-ul comenzii cautate: ");
                                    if (int.TryParse(Console.ReadLine(), out int idComanda))
                                    {
                                        Comanda comandaCautata = gestiuneMemorieComenzi.CautareDupaIDComanda(idComanda);
                                        if (comandaCautata != null)
                                        {
                                            Console.WriteLine("Comanda a fost gasita: ");
                                            AfisareComandaSiColet(comandaCautata, gestiuneMemorieColete.CautareDupaIDColet(comandaCautata.IDColet));
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
                                    Comanda comandaCautataNume = gestiuneMemorieComenzi.CautareDupaNumeClient(numeClient);
                                    if (comandaCautataNume != null)
                                    {
                                        Console.WriteLine("Comanda a fost gasita: ");
                                        AfisareComandaSiColet(comandaCautataNume, gestiuneMemorieColete.CautareDupaIDColet(comandaCautataNume.IDColet));
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Comanda cu numele {numeClient} nu a fost gasita\n");
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine("Introduceti ID-ul coletului cautat: ");
                                    if (int.TryParse(Console.ReadLine(), out int idColet))
                                    {
                                        Colet coletCautat = gestiuneMemorieColete.CautareDupaIDColet(idColet);
                                        if (coletCautat != null)
                                        {
                                            Console.WriteLine($"Coletul cu ID-ul {idColet} a fost gasit: ");
                                            Console.WriteLine(coletCautat.Info());
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Coletul cu ID-ul {idColet} nu a fost gasit\n");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ID-ul introdus nu este valid.");
                                    }
                                    break;
                                case "4":
                                    Console.WriteLine("Introduceti descrierea coletului cautat: ");
                                    string descriereColet = Console.ReadLine();
                                    Colet coletCautatDescriere = gestiuneMemorieColete.CautareDupaDescriere(descriereColet);
                                    if (coletCautatDescriere != null)
                                    {
                                        Console.WriteLine($"Coletul cu descrierea {descriereColet} a fost gasit: ");
                                        Console.WriteLine(coletCautatDescriere.Info());
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Coletul cu descrierea {descriereColet} nu a fost gasit\n");
                                    }
                                    break;
                                case "X":
                                    break;

                                default:
                                    Console.WriteLine("Optiune invalida");
                                    break;
                            }
                        } while (optiuneCautareMemorie.ToUpper() != "X");
                        break;

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

            Console.WriteLine("Selectati starea comenzii (introduceti numarul corespunzator): ");
            foreach (var stare in Enum.GetValues(typeof(StareComanda)))
            {
                Console.WriteLine($"{(int)stare} - {stare}");
            }
            int stareInput = int.Parse(Console.ReadLine());

            StareComanda stareComanda;
            while (!Enum.IsDefined(typeof(StareComanda), stareInput))
            {
                Console.WriteLine("Stare invalida! Introduceți un numar valid: ");
                stareInput = int.Parse(Console.ReadLine());
            }
            stareComanda = (StareComanda)stareInput;

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

        public static void AfisareComandaSiColet(Comanda comanda, Colet colet)
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
                                           comanda.StareComanda.ToString());

            Console.WriteLine(infoComanda);

            string infoColet = string.Format("Coletul asociat cu ID-ul #{0}:\n"
                                         + "Descriere: {1}\n"
                                         + "Greutate: {2} kg\n"
                                         + "Dimensiune: {3}\n",
                                         colet.IDColet,
                                         colet.Descriere ?? "NECUNOSCUT",
                                         colet.Greutate,
                                         colet.Dimensiune ?? "NECUNOSCUT");

            Console.WriteLine(infoColet);
        }

        public static void AfisareComenziSiColete(Comanda[] comenzi, int nrComenzi, Colet[] colete)
        {
            Console.WriteLine("Comenzile sunt:");
            for (int contor = 0; contor < nrComenzi; contor++)
            {
                AfisareComandaSiColet(comenzi[contor], colete[contor]);
            }
        }
    }
}
