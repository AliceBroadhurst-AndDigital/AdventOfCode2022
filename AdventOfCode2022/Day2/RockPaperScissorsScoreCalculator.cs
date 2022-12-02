using System;
namespace AdventOfCode2022.Day2
{
	public class RockPaperScissorsScoreCalculator
	{
		public string[][] matches;

		public RockPaperScissorsScoreCalculator(string filepath)
		{
			List<string[]> matches = new List<string[]>();
			foreach(string line in File.ReadLines(filepath))
			{
				matches.Add(line.Split(' '));
			}
			this.matches = matches.ToArray();
		}

		public int GetMatchTotal()
		{
			int result = 0;
			foreach (string[] match in matches)
			{
				result += GetWinScore(match[0], match[1]);
			}
			return result;
		}

		public int GetStratergyTotal()
		{
            int result = 0;
            foreach (string[] match in matches)
            {
				match[1] = GetStratergyHand(match[0], match[1]);
                result += GetWinScore(match[0], match[1]);
            }
            return result;
        }

		private int GetHandScore(string hand)
		{
			switch (hand)
			{
				case "X": return 1;
				case "Y": return 2;
				case "Z": return 3;
				default: return 0;
			}
		}


		private string GetStratergyHand(string opp, string stratergy)
		{
			//draw
			if(stratergy == "Y")
			{
				switch (opp)
				{
					case "A":
						{
							return "X";
						}
					case "B":
						{
							return "Y";
						}
					case "C":
						{
							return "Z";
						}
				}
				return "";
				//win
			}else if(stratergy == "Z")
			{
                switch (opp)
                {
                    case "A":
                        {
                            return "Y";
                        }
                    case "B":
                        {
                            return "Z";
                        }
                    case "C":
                        {
                            return "X";
                        }
                }
				return "";
			}//lose
			else
			{
                switch (opp)
                {
                    case "A":
                        {
                            return "Z";
                        }
                    case "B":
                        {
                            return "X";
                        }
                    case "C":
                        {
                            return "Y";
                        }
                }
				return "";
            }
		}

		private int GetWinScore(string oppoentHand, string yourHand)
		{
			//ABC ROCK PAPER SCISSORS
			//XYZ ROCK PAPER SCISSORS

			bool draw = (
				(oppoentHand == "A" && yourHand == "X") ||
                (oppoentHand == "B" && yourHand == "Y") ||
                (oppoentHand == "C" && yourHand == "Z")
                );
            bool win = (
                (oppoentHand == "A" && yourHand == "Y") ||
                (oppoentHand == "B" && yourHand == "Z") ||
                (oppoentHand == "C" && yourHand == "X")
                );

			if (win)
			{
				return 6 + GetHandScore(yourHand);
			}
			if (draw)
			{
				return 3 + GetHandScore(yourHand);
			}
			//lost
			return 0 + GetHandScore(yourHand);


        }
	}
}

