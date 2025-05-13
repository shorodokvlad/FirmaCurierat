using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibrarieModele;

namespace NivelStocareDate
{
    public class GestionareColete_FisierText
    {
        private const int ID_COLET = 0;
        private const int INCREMENTARE_ID = 1;
        private string numeFisierColete;

        public GestionareColete_FisierText(string numeFisierColete)
        {
            this.numeFisierColete = numeFisierColete;
            Stream streamFisier = File.Open(numeFisierColete, FileMode.OpenOrCreate);
            streamFisier.Close();
        }

        public void AddColet(Colet colet)
        {
            colet.IDColet = GetId();
            using (StreamWriter streamWriter = new StreamWriter(numeFisierColete, true))
            {
                streamWriter.WriteLine(colet.ConversieLaSir_PentruFisier());
            }
        }
        public List<Colet> GetColete()
        {
            List<Colet> colete = new List<Colet>();
            using (StreamReader streamReader = new StreamReader(numeFisierColete))
            {
                string linieFisier;
 
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    colete.Add(new Colet(linieFisier));
                }
            }

            return colete;
        }

        public Colet CautareDupaIDColet(int idColet)
        {
            List<Colet> colete = GetColete();
            foreach (var colet in colete)
            {
                if (colet != null && colet.IDColet == idColet)
                {
                    return colet;
                }
            }
            return null;
        }

        public Colet CautareDupaDescriere(string descriere)
        {
            List<Colet> colete = GetColete();
            foreach (var colet in colete)
            {
                if (colet != null && colet.Descriere == descriere)
                {
                    return colet;
                }
            }
            return null;
        }
        public int GetId()
        {
            int IDColet = ID_COLET;

            // instructiunea 'using' va apela sr.Close()
            using (StreamReader streamReader = new StreamReader(numeFisierColete))
            {
                string linieFisier;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Colet colet = new Colet(linieFisier);
                    IDColet = colet.IDColet + INCREMENTARE_ID;
                }
            }

            return IDColet;
        }
        public Colet GetColet(int idColet)
        {
            // Folosește 'using' pentru a închide automat StreamReader
            using (StreamReader streamReader = new StreamReader(numeFisierColete))
            {
                string linieFisier;

                // Citește fiecare linie din fișier
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    // Creează un obiect de tip Colet pe baza liniei citite
                    Colet colet = new Colet(linieFisier);

                    // Verifică dacă ID-ul comenzii corespunde
                    if (colet.IDColet == idColet)
                        return colet;
                }
            }

            // Returnează null dacă nu a fost găsită nicio comandă cu ID-ul specificat
            return null;
        }

        public Colet GetColet(string descriere)
        {
            // Folosește 'using' pentru a închide automat StreamReader
            using (StreamReader streamReader = new StreamReader(numeFisierColete))
            {
                string linieFisier;

                // Citește fiecare linie din fișier
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    // Creează un obiect de tip Colet pe baza liniei citite
                    Colet colet = new Colet(linieFisier);

                    // Verifică dacă ID-ul comenzii corespunde
                    if (colet.Descriere == descriere)
                        return colet;
                }
            }

            // Returnează null dacă nu a fost găsită nicio comandă cu ID-ul specificat
            return null;
        }

        public bool UpdateColet(Colet coletActualizat)
        {
            List<Colet> colete = GetColete();
            bool actualizareCuSucces = false;

            //instructiunea 'using' va apela la final swFisierText.Close();
            //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
            using (StreamWriter streamWriter = new StreamWriter(numeFisierColete, false))
            {
                foreach (Colet colet in colete)
                {
                    //informatiile despre comanda actualizata vor fi preluate din parametrul "comandaActualizata"
                    Colet coletPentruScriereInFisier = colet;
                    if (colet.IDColet == coletActualizat.IDColet)
                    {
                        coletPentruScriereInFisier = coletActualizat;
                    }
                    streamWriter.WriteLine(coletPentruScriereInFisier.ConversieLaSir_PentruFisier());

                }
                actualizareCuSucces = true;
            }
            return actualizareCuSucces;
        }


        public Colet GetColetByIndex(int index)
        {
            try
            {
                using (StreamReader sr = new StreamReader(numeFisierColete))
                {
                    string linie;
                    while ((linie = sr.ReadLine()) != null)
                    {
                        Colet colet = new Colet(linie);
                        if (colet.IDColet == index)
                        {
                            return colet;
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Optionally log or handle the exception
            }
            return null;
        }
    }
}



