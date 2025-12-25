using Xunit;

public class UnitTest
{
    [Fact]
    public void TestAddition()
    {
        // Убедитесь что метод Add существует и public
        Assert.Equal(30, Add(10, 20));
    }
    
    // Добавьте метод если его нет
    static int Add(int a, int b) => a + b;
}
