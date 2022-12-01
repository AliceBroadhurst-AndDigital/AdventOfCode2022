namespace AdventOfCode2022;
public class CalorieCounter
{
    private int[] elf_calories = new int[] { };

    public CalorieCounter(string filepath)
    {
        List<int> elves = new List<int>();
        int elf = 0;
        foreach(string line in File.ReadLines(filepath))
        {
            if(line.Trim() == "")
            {
                elves.Add(elf);
                elf = 0;
                continue;
            }

            elf += int.Parse(line);
        }
        elves.Add(elf);
        elf_calories = elves.ToArray();
    }

    public int[] GetResults()
    {
        return elf_calories;
    }

    public int GetHighestCalorieElf()
    {
        Array.Sort(elf_calories);
        return elf_calories[elf_calories.Length-1];
    }

    public object GetSumOfHighestThreeElves()
    {
        Array.Sort(elf_calories);
        return elf_calories.TakeLast(3).Sum();
    }
}

