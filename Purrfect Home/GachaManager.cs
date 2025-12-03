using System;
using System.Collections.Generic;

namespace Purrfect_Home
{
    public static class GachaManager
    {
        private static Random rng = new Random();

        // Pools
        private static readonly List<GachaResult> pool3 = new List<GachaResult>()
        {
            new GachaResult { Name = "SIAMESE CAT", Stars = 3, FilePath = @"C:\xampp\htdocs\gif\WINTER BANNER\SIAMESE CAT.gif" },
            
            
            new GachaResult { Name = "WHITE POSA",      Stars = 3, FilePath = @"C:\xampp\htdocs\gif\WINTER BANNER\WHITE POSA.gif" }
        };

        private static readonly List<GachaResult> pool4 = new List<GachaResult>()
        {new GachaResult { Name = "SANTA CAT",    Stars = 4, FilePath = @"C:\xampp\htdocs\gif\WINTER BANNER\POSANG PASKO.gif" },
         new GachaResult { Name = "REINDEER CAT", Stars = 4, FilePath = @"C:\xampp\htdocs\gif\WINTER BANNER\CHRISTMAS REINDEER IDLE.gif" }
        };

        private static readonly List<GachaResult> pool5 = new List<GachaResult>()
        {
            new GachaResult { Name = "CHRISTMAS TREE CAT", Stars = 5, FilePath = @"C:\xampp\htdocs\gif\WINTER BANNER\NAELAW NA POSA.gif" }
        };

        // Chances (sum should be 100 or be interpreted sequentially)
        private const int chance3 = 75;
        private const int chance4 = 20;
        private const int chance5 = 5;

        public static GachaResult Roll()
        {
            int roll = rng.Next(1, 101);

            if (roll <= chance5)
                return Pick(pool5);
            if (roll <= chance5 + chance4)
                return Pick(pool4);
            return Pick(pool3);
        }

        private static GachaResult Pick(List<GachaResult> list)
        {
            return list[rng.Next(list.Count)];
        }
    }
}
