using System;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdventOfCode2022.Day3
{
	public class RucksackOrganiser
	{
		public char[][] RucksackItems;
		Dictionary<char, int> order = new Dictionary<char, int>();

        public RucksackOrganiser(string filepath)
		{
			List<char[]> rucksack_ = new List<char[]>();
			foreach (string line in File.ReadLines(filepath))
			{
				rucksack_.Add(line.ToCharArray());
            }
			RucksackItems = rucksack_.ToArray();

			//setup dictionary
			var letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

			foreach(char c in letters.ToCharArray())
			{
				var value = letters.IndexOf(c)+1;
				order.Add(c, value);
			}

        }

        public char[] GetCommon()
		{
			List<char> common = new List<char>();
			foreach (char[] rucksack_ in RucksackItems)
			{
				var firstComparment = rucksack_.Take(rucksack_.Length / 2).ToArray();
				var secondComparment = rucksack_.Skip(rucksack_.Length / 2).ToArray();

				foreach(char item in firstComparment)
				{
					if(Array.Exists(secondComparment, element => element == item))
					{
						common.Add(item);
						break;
					}
				}
			}
			var array = common.ToArray();
			//Array.Sort(array, CompareChars);

            return array;
        }

        public char[] GetBadges()
        {
            List<char> common = new List<char>();

            for(var i=0; i<RucksackItems.Length; i=i+3)
            {
				var firstElf = RucksackItems[i];
				var secondElf = RucksackItems[i + 1];
				var thirdElf = RucksackItems[i + 2];

                foreach (char item in firstElf)
                {
                    if (Array.Exists(secondElf, element => element == item) &&
						Array.Exists(thirdElf, element => element == item))
                    {
                        common.Add(item);
                        break;
                    }
                }
            }

            return common.ToArray();
        }

        public int GetCommonScore()
		{
			int score = 0;
			foreach(char c in GetCommon())
			{
				
				score += order.GetValueOrDefault(c);
				
			}
			return score;
		}

        public int GetBadgesScore()
        {
            int score = 0;
            foreach (char c in GetBadges())
            {

                score += order.GetValueOrDefault(c);

            }
            return score;
        }
    }
}

