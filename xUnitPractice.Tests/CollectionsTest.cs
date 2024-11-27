using Xunit;
using Xunit.Abstractions;

namespace xUnitPractice.Tests;

public class CollectionsTest : IDisposable
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly MemoryStream _memoryStream;

    public CollectionsTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
        
        _testOutputHelper.WriteLine("Constructor");

        _memoryStream = new MemoryStream();
    }

    [Fact]
    [Trait("Category", "Fibo")]
    public void FiboDoesNotIncludeZero()
    {
        _testOutputHelper.WriteLine("FiboDoesNotIncludeZero");
        var col = new Collections();
        Assert.All(col.FiboNumbers, n => Assert.NotEqual(0, n)); //Check items one by one
    }

    [Fact]
    [Trait("Category", "Fibo")]
    public void FiboIncludes13()
    {
        _testOutputHelper.WriteLine("FiboIncludes13");
        var col = new Collections();
        Assert.Contains(13, col.FiboNumbers);
    }

    [Fact]
    [Trait("Category", "Fibo")]
    public void FiboDoesNotInclude4()
    {
        _testOutputHelper.WriteLine("FiboDoesNotInclude4");
        var col = new Collections();
        Assert.DoesNotContain(4, col.FiboNumbers); //Check all items at once
    }

    [Fact]
    [Trait("Category", "Fibo")]
    public void CheckCollection()
    {
        _testOutputHelper.WriteLine($"CheckCollection. Test Starting at {DateTime.Now}");
        var expectedCollection = new List<int>(){1, 1, 2, 3, 5, 8, 13};
        
        _testOutputHelper.WriteLine("Creating an instance of collection class..");
        var col = new Collections();
        
        _testOutputHelper.WriteLine("Asserting...");
        Assert.Equal(expectedCollection, col.FiboNumbers);
        
        _testOutputHelper.WriteLine("End");
    }

    public void Dispose() // xUnit calls automaticly
    {
        _memoryStream.Close();
    }
}