using AdventOfCode2022;

namespace AdventOfCode2022_Tests;

public class Tests
{
    string testFile = "../../../Day1/TestCalories.txt";
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CaloriesFileContentsCheck()
    {
        var counter = new CalorieCounter(testFile);
        var elf_results = new int[] { 6000,4000,11000,24000,10000};
        Assert.That(counter.GetResults(), Is.EqualTo(elf_results));
    }


    [Test]
    public void GetElfCarryingMostCaloriesCheck()
    {
        var counter = new CalorieCounter(testFile);
        var elfCalories = counter.GetHighestCalorieElf();
        Assert.That(elfCalories, Is.EqualTo(24000));
    }

    [Test]
    public void GetTotalOfFirstThreeElvesCarryingMostCalories()
    {
        var counter = new CalorieCounter(testFile);
        var elfCalories = counter.GetSumOfHighestThreeElves();
        Assert.That(elfCalories, Is.EqualTo(45000));
    }
}
