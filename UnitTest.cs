using Xunit;

public class UnitTest
{
    [Fact]
    public void TestAddition()
    {
        Assert.Equal(30, Program.Add(10, 20));
    }
}
