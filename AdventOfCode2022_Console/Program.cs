//Day 1
using AdventOfCode2022;

var counter = new CalorieCounter("../../../../AdventOfCode2022/Day1/ElfCalories.txt");
Console.WriteLine("Highest Elf Calories:{0}", counter.GetHighestCalorieElf());
Console.WriteLine("Sum of Top Three Highest Elf Calories:{0}", counter.GetSumOfHighestThreeElves());
