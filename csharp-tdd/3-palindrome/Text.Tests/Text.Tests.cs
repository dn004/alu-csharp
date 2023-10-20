using Text;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(" ")]
    [TestCase("level")]
    [TestCase("racecar")]
    [TestCase("lol")]
    public void TestPalidrome(string val)
    {
        bool IsPal = Str.IsPalindrome(val);
        Assert.IsTrue(IsPal);
    }

    [TestCase("shoes")]
    [TestCase("bread")]
    [TestCase("rocks")]
    [TestCase("try")]
    public void TestPalidromeNon(string val)
    {
        bool IsPal = Str.IsPalindrome(val);
        Assert.IsFalse(IsPal);
    }
}