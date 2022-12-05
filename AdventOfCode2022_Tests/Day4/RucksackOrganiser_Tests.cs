using AdventOfCode2022;
using AdventOfCode2022.Day3;

namespace AdventOfCode2022_Tests;

public class RucksackOrganiser_Tests
{
    static string testFile = "../../../Day3/TestRucksack.txt";
    

    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void Rucksack_FindCommon()
    {
        RucksackOrganiser org = new RucksackOrganiser(testFile);
        var commonItems = new char[] { 'p', 'L', 'P', 'v', 't', 's'};
        Assert.That(org.GetCommon(), Is.EqualTo(commonItems));
    }

    [Test]
    public void Rucksack_GetScoreOfCommonItems()
    {
        RucksackOrganiser org = new RucksackOrganiser(testFile);
        Assert.That(org.GetCommonScore(), Is.EqualTo(157));
    }

    [Test]
    public void Rucksack_FindBadges()
    {
        RucksackOrganiser org = new RucksackOrganiser(testFile);
        var commonItems = new char[] { 'r', 'Z' };
        Assert.That(org.GetBadges(), Is.EqualTo(commonItems));
    }

    [Test]
    public void Rucksack_GetScoreOfBadges()
    {
        RucksackOrganiser org = new RucksackOrganiser(testFile);
        Assert.That(org.GetBadgesScore(), Is.EqualTo(70));
    }
}
