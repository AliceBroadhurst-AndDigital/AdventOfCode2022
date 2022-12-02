using AdventOfCode2022;
using AdventOfCode2022.Day2;

namespace AdventOfCode2022_Tests;

public class RockPaperScissorsScoreCalculator_Tests
{
    string testFile = "../../../Day2/TestMatches.txt";
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void MatchesFile_CorrectOutput()
    {
        var calculator = new RockPaperScissorsScoreCalculator(testFile);
        var hand1 = new string[] { "A", "Y" };
        var hand2 = new string[] { "B", "X" };
        var hand3 = new string[] { "C", "Z" };
        string[][] match_results = new string[][] { hand1, hand2, hand3 };
        Assert.That(calculator.matches, Is.EqualTo(match_results));
    }

    [Test]
    public void MatchesFile_CorrectSumOutput()
    {
        var calculator = new RockPaperScissorsScoreCalculator(testFile);
        Assert.That(calculator.GetMatchTotal(), Is.EqualTo(15));
    }

    [Test]
    public void MatchesFile_CorrectStragetyOutput()
    {
        var calculator = new RockPaperScissorsScoreCalculator(testFile);
        Assert.That(calculator.GetStratergyTotal(), Is.EqualTo(12));
    }



}
