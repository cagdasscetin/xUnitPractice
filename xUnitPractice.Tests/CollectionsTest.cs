using Xunit;

namespace xUnitPractice.Tests;

public class CollectionsTest
{
    [Fact]
    [Trait("Category", "Fibo")]
    public void FiboDoesNotIncludeZero()
    {
        var col = new Collections();
        Assert.All(col.FiboNumbers, n => Assert.NotEqual(0, n)); //Check items one by one
    }

    [Fact]
    [Trait("Category", "Fibo")]
    public void FiboIncludes13()
    {
        var col = new Collections();
        Assert.Contains(13, col.FiboNumbers);
    }

    [Fact]
    [Trait("Category", "Fibo")]
    public void FiboDoesNotInclude4()
    {
        var col = new Collections();
        Assert.DoesNotContain(4, col.FiboNumbers); //Check all items at once
    }

    [Fact]
    [Trait("Category", "Fibo")]
    public void CheckCollection()
    {
        var expectedCollection = new List<int>(){1, 1, 2, 3, 5, 8, 13};
        var col = new Collections();
        Assert.Equal(expectedCollection, col.FiboNumbers);
    }
}