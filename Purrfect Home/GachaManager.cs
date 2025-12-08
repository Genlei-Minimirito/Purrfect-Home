using System;
using System.Collections.Generic;

namespace Purrfect_Home
{
    public static class GachaManager
    {
        private static Random rng = new Random();

        // ----------------- WINTER POOLS -----------------
        private static readonly List<GachaResult> winter3 = new()
        {
            new GachaResult { Name = "SIAMESE CAT", Stars = 3, FilePath = @"C:\xampp\htdocs\gif\WINTER BANNER\SIAMESE CAT.gif" },
            new GachaResult { Name = "WHITE POSA",  Stars = 3, FilePath = @"C:\xampp\htdocs\gif\WINTER BANNER\WHITE POSA.gif" }
        };

        private static readonly List<GachaResult> winter4 = new()
        {
            new GachaResult { Name = "SANTA CAT",    Stars = 4, FilePath = @"C:\xampp\htdocs\gif\WINTER BANNER\POSANG PASKO.gif" },
            new GachaResult { Name = "REINDEER CAT", Stars = 4, FilePath = @"C:\xampp\htdocs\gif\WINTER BANNER\CHRISTMAS REINDEER IDLE.gif" }
        };

        private static readonly List<GachaResult> winter5 = new()
        {
            new GachaResult { Name = "CHRISTMAS TREE CAT", Stars = 5, FilePath = @"C:\xampp\htdocs\gif\WINTER BANNER\NAELAW NA POSA.gif" }
        };

        // ----------------- MAFIA POOLS -----------------
        private static readonly List<GachaResult> mafia3 = new()
        {
            new GachaResult { Name = "TIGER CAT", Stars = 3, FilePath = @"C:\xampp\htdocs\gif\MAFIA BANNER\TIGER CAT.gif" },
            new GachaResult { Name = "RED CAT",   Stars = 3, FilePath = @"C:\xampp\htdocs\gif\MAFIA BANNER\RED CAT.gif" }
        };

        private static readonly List<GachaResult> mafia4 = new()
        {
            new GachaResult { Name = "BATCAT",   Stars = 4, FilePath = @"C:\xampp\htdocs\gif\MAFIA BANNER\BATCAT.gif" },
            new GachaResult { Name = "EGYPT CAT",Stars = 4, FilePath = @"C:\xampp\htdocs\gif\MAFIA BANNER\EGYPT CAT.gif" }
        };

        private static readonly List<GachaResult> mafia5 = new()
        {
            new GachaResult { Name = "GATLIN CAT", Stars = 5, FilePath = @"C:\xampp\htdocs\gif\MAFIA BANNER\GATLIN CAT.gif" }
        };

        // Chances
        private const int chance3 = 75;
        private const int chance4 = 20;
        private const int chance5 = 5;

        // ✅ MAIN ROLL METHOD
        public static GachaResult Roll(GachaBanner banner)
        {
            int roll = rng.Next(1, 101);

            if (roll <= chance5)
                return Pick(banner == GachaBanner.Winter ? winter5 : mafia5);
            if (roll <= chance5 + chance4)
                return Pick(banner == GachaBanner.Winter ? winter4 : mafia4);
            return Pick(banner == GachaBanner.Winter ? winter3 : mafia3);
        }

        private static GachaResult Pick(List<GachaResult> list)
        {
            return list[rng.Next(list.Count)];
        }
    }
}
