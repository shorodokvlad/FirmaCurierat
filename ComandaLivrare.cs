public class ComandaLivrare
{
    // Propriet??i ?i constructori existen?i

    public ComandaLivrare(string linieFisier)
    {
        var date = linieFisier.Split(';');
        IDComanda = int.Parse(date[0]);
        NumeClient = date[1];
        AdresaLivrare = date[2];
        DataLivrare = date[3];
        StareComanda = date[4];
        Colet = new Colet(date[5], double.Parse(date[6]), date[7]);
    }

    public string ConversieLaSir_PentruFisier()
    {
        return $"{IDComanda};{NumeClient};{AdresaLivrare};{DataLivrare};{StareComanda};{Colet.Descriere};{Colet.Greutate};{Colet.Dimensiune}";
    }
}

