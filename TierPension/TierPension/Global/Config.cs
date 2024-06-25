using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierPension.Global
{
    public static class Config
    {

        public static string FilePathKundenDaten
        {
            get
            {
                if (!Directory.Exists(_FPKundenDaten))
                {
                    throw new DirectoryNotFoundException($"Das Verzeichnis {_FPKundenDaten} wurde nicht gefunden");
                }
                return _FPKundenDaten;
            }
        }

        public static string FilePathTiereDaten
        {
            get
            {
                if (!Directory.Exists(_FPTiereDaten))
                {
                    throw new DirectoryNotFoundException($"Das Verzeichnis {_FPTiereDaten} wurde nicht gefunden");
                }
                return _FPTiereDaten;
            }
        }

        public static string FilePathPensionierungDaten
        {
            get
            {
                if (!Directory.Exists(_FPPensionierungDaten))
                {
                    throw new DirectoryNotFoundException($"Das Verzeichnis {_FPPensionierungDaten} wurde nicht gefunden");
                }
                return _FPPensionierungDaten;
            }
        }
        
        public static string FilePathImages
        {
            get
            {
                if (!Directory.Exists(_FPImages))
                {
                    throw new DirectoryNotFoundException($"Das Verzeichnis {_FPImages} wurde nicht gefunden");
                }
                return _FPImages;
            }
        }

        private static readonly string _FPKundenDaten = @"..\..\..\..\Daten\KundenDaten";
        private const string _FPTiereDaten = @"..\..\..\..\Daten\TiereDaten";
        private const string _FPPensionierungDaten = @"..\..\..\..\Daten\PensionierungDaten";
        private const string _FPImages = @"..\..\..\..\Daten\Images";
    }
}
