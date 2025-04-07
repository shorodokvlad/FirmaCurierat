using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
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

    public enum DimensiuneColet
    {
        Mic = 1,             // 30x30x30 cm
        MediuMic = 2,        // 40x40x40 cm
        MediuStandard = 3,   // 50x50x50 cm
        MediuMare = 4,       // 60x60x60 cm
        MareMica = 5,        // 70x70x70 cm
        MareStandard = 6,    // 80x80x80 cm
        MareMare = 7,        // 90x90x90 cm
        ExtraMare = 8        // 100x100x100 cm
    }



}
