namespace Leonardo.Tests;

public class UnitTest1
{
    [Fact]
    public async void Test1()
    {
        var result = await Fibonacci.RunAsync(new[] { "10", "23" });
        Assert.Equal(55, result[0]);
        Assert.Equal(28657, result[1]);
    }
}