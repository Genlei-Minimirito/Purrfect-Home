using System;
using System.Collections.Generic;
using System.Drawing;

namespace Purrfect_Home
{
    public static class GachaManager
    {
        private static Random rng = new Random();

        // DROP RATES
        private const int rate3 = 60; // 70%
        private const int rate4 = 25; // 25%
        private const int rate5 = 15;  // 5%

        // YOUR GACHA TABLE
        private static Dictionary<int, List<GachaEntry>> gachaTable =
            new Dictionary<int, List<GachaEntry>>()
            {
                {
                    3, new List<GachaEntry>()
                    {
                        new GachaEntry
                        {
                            Image = Properties.Resources.SIAMESE_CAT,
                            Name = "Siamese Cat"
                        },


                        new GachaEntry
                        {
                            Image = Properties.Resources.WHITE_POSA,
                            Name = "White Cat"
                        }
                    }
                },

                {
                    4, new List<GachaEntry>()
                    {
                        new GachaEntry
                        {
                            Image = Properties.Resources.POSANG_PASKO,
                            Name = "Christmas Cat"
                        },

                        new GachaEntry
                        {
                            Image = Properties.Resources.CHRISTMAS_REINDEER_IDLE,
                            Name = "Reindeer Cat"
                        }
                    }
                },

                {
                    5, new List<GachaEntry>()
                    {
                        new GachaEntry
                        {
                            Image = Properties.Resources.NAELAW_NA_POSA,
                            Name = "Christmas Tree Cat"
                        }
                    }
                }
            };

        public static GachaResult Roll()
        {
            int roll = rng.Next(1, 101);
            int rarity;

            if (roll <= rate3) rarity = 3;
            else if (roll <= rate3 + rate4) rarity = 4;
            else rarity = 5;

            List<GachaEntry> list = gachaTable[rarity];
            GachaEntry chosen = list[rng.Next(list.Count)];

            return new GachaResult
            {
                Stars = rarity,
                Image = chosen.Image,
                Name = chosen.Name
            };
        }
    }
}
