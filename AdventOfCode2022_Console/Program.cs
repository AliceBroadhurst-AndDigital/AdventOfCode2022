//Day 1
using AdventOfCode2022;
using AdventOfCode2022.Day2;
using AdventOfCode2022.Day3;

//var counter = new CalorieCounter("../../../../AdventOfCode2022/Day1/ElfCalories.txt");
//Console.WriteLine("Highest Elf Calories:{0}", counter.GetHighestCalorieElf());
//Console.WriteLine("Sum of Top Three Highest Elf Calories:{0}", counter.GetSumOfHighestThreeElves());
//Console.WriteLine("Sum of all matches:{0}", new RockPaperScissorsScoreCalculator("../../../../AdventOfCode2022/Day2/RPSMatches.txt").GetMatchTotal());
//Console.WriteLine("Sum of all matches using correct stratergy:{0}", new RockPaperScissorsScoreCalculator("../../../../AdventOfCode2022/Day2/RPSMatches.txt").GetStratergyTotal());
Console.WriteLine("Rucksack P Value:{0}", new RucksackOrganiser("../../../../AdventOfCode2022/Day3/rucksack.txt").GetCommonScore());
Console.WriteLine("Rucksack badges Value:{0}", new RucksackOrganiser("../../../../AdventOfCode2022/Day3/rucksack.txt").GetBadgesScore());