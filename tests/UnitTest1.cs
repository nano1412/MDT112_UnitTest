namespace tests;

public class UnitTest1
{
    [Fact]
    public void TestIsGradeA()
    {
        int score = 85;
        Assert.True(Program.IsGradeA(score));
    }

    [Fact]
    public void TestIsInCorrectGradeA()
    {
        int score = 75;
        Assert.False(Program.IsGradeA(score));
    }
}