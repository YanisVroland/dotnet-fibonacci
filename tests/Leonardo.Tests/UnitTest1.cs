using Microsoft.EntityFrameworkCore;

namespace Leonardo.Tests;

public class UnitTest1
{
    [Fact]
    public async void Test1()
    {
        var builder = new DbContextOptionsBuilder<FibonacciDataContext>();
        
        var dataBaseName = Guid.NewGuid().ToString();
        builder.UseInMemoryDatabase(dataBaseName);

        var options = builder.Options;
        var fibonacciDataContext = new FibonacciDataContext(options);
        await fibonacciDataContext.Database.EnsureCreatedAsync();
        
        var result = await new Fibonacci(fibonacciDataContext).RunAsync(new[] { "10", "23" });
        Assert.Equal(55, result[0]);
        Assert.Equal(28657, result[1]);
    }
}