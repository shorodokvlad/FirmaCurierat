using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibrarieModele;

namespace NivelStocareDate
{
    public class GestionareComenzi_FisierText
    {
        private const int ID_COMANDA = 0;
        private const int INCREMENTARE_ID = 1;

        private string numeFisierComenzi;

        public GestionareComenzi_FisierText(string numeFisierComenzi)
        {
            this.numeFisierComenzi = numeFisierComenzi;
            Stream streamFisier = File.Open(numeFisierComenzi, FileMode.OpenOrCreate);
            streamFisier.Close();
        }
        public void AddComanda(Comanda comanda)
        {
            comanda.IDComanda = GetId();
            using (StreamWriter streamWriter = new StreamWriter(numeFisierComenzi, true))
            {
                streamWriter.WriteLine(comanda.ConversieLaSir_PentruFisier());
            }
        }

        public List<Comanda> GetComenzi()
        {
            List<Comanda> comenzi = new List<Comanda>();
            using (StreamReader streamReader = new StreamReader(numeFisierComenzi))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    comenzi.Add(new Comanda(linieFisier));
                }
            }
            return comenzi;
        }

        public Comanda CautareDupaIDComanda(int idComanda)
        {
            List<Comanda> comenzi = GetComenzi();
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
            List<Comanda> comenzi = GetComenzi();
            foreach (var comanda in comenzi)
            {
                if (comanda != null && comanda.NumeClient == numeClient)
                {
                    return comanda;
                }
            }
            return null;
        }
        public int GetId()
        {
            int IDComanda = ID_COMANDA;

            // instructiunea 'using' va apela sr.Close()
            using (StreamReader streamReader = new StreamReader(numeFisierComenzi))
            {
                string linieFisier;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Comanda comanda = new Comanda(linieFisier);
                    IDComanda = comanda.IDComanda + INCREMENTARE_ID;
                }
            }

            return IDComanda;
        }
        public Comanda GetComanda(int idComanda)
        {
            // Folosește 'using' pentru a închide automat StreamReader
            using (StreamReader streamReader = new StreamReader(numeFisierComenzi))
            {
                string linieFisier;

                // Citește fiecare linie din fișier
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    // Creează un obiect de tip Comanda pe baza liniei citite
                    Comanda comanda = new Comanda(linieFisier);

                    // Verifică dacă ID-ul comenzii corespunde
                    if (comanda.IDComanda == idComanda)
                        return comanda;
                }
            }

            // Returnează null dacă nu a fost găsită nicio comandă cu ID-ul specificat
            return null;
        }

        public Comanda GetComanda(string numeClient)
        {
            // Folosește 'using' pentru a închide automat StreamReader
            using (StreamReader streamReader = new StreamReader(numeFisierComenzi))
            {
                string linieFisier;

                // Citește fiecare linie din fișier
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    // Creează un obiect de tip Comanda pe baza liniei citite
                    Comanda comanda = new Comanda(linieFisier);

                    // Verifică dacă ID-ul comenzii corespunde
                    if (comanda.NumeClient == numeClient)
                        return comanda;
                }
            }

            // Returnează null dacă nu a fost găsită nicio comandă cu ID-ul specificat
            return null;
        }
    }
}