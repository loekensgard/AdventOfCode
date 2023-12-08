using System.Text.RegularExpressions;

namespace AdventOfCode._2023.Day5
{
    public static class SoilHelper
    {
        public static List<long> GetSeeds(string input)
        {
            var regex = RegexHelper.GetSeedValues();
            List<long> seedsList = [];

            foreach (Match match in regex.Matches(input))
            {
                seedsList.Add(long.Parse(match.Value));
            }

            return seedsList;
        }

        public static List<AlmanacMap> GetMaps(string[] lines)
        {
            var maps = new List<AlmanacMap>();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(' ');

                if (parts.Length == 3)
                {
                    long dest = long.Parse(parts[0]);
                    long source = long.Parse(parts[1]);
                    long range = long.Parse(parts[2]);

                    // Add the values to the dictionary
                    maps.Add(new AlmanacMap(dest, source, range));
                }
            }
            return maps;
        }

        public static long FindLowestSeed(List<long> seeds, List<AlmanacMap> conversionMap)
        {
            long lowestSeed = long.MaxValue;

            foreach (var seed in seeds)
            {
                long currentSeed = seed;

                foreach (var map in conversionMap)
                {
                    if (currentSeed >= map.Source && currentSeed < (map.Source + map.Range))
                    {
                        currentSeed += (map.Dest - map.Dest);
                        continue;
                    }
                }

                if (currentSeed < lowestSeed)
                {
                    lowestSeed = currentSeed;
                }
            }

            return lowestSeed;
        }

    }
}
