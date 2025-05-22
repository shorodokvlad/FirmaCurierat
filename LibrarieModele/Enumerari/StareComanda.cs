using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele.Enumerari
{
    public enum StareComanda
    {
        ComandaPlasata = 1,
        InAsteptareLaExpeditor = 2,
        PreluatDeCurier = 3,
        InProcesareLaCentruLogistic = 4,
        InTranzit = 5,
        InTranzitRedirectionat = 6,
        InCursDeLivrare = 7,
        Livrat = 8,
        AdresaIncorectaIncompleta = 9,
        DestinatarIndisponibil = 10,
        RetinutInVama = 11,
        IntarziereConditiiMeteoLogistice = 12,
        InProcesDeReturnare = 13,
        ReturnatLaExpeditor = 14,
        ColetPierdut = 15,
        ColetDeteriorat = 16
    }
}
