using Xunit;

namespace Calculations.Tests;

public class CollectionsTest
{
    [Fact]
    public void FiboDoesNotIncludeZero()
    {
        var col = new Collections();
        Assert.All(col.FiboNumbers, n => Assert.NotEqual(0, n)); //Check items one by one
    }

    [Fact]
    public void FiboIncludes13()
    {
        var col = new Collections();
        Assert.Contains(13, col.FiboNumbers);
    }

    [Fact]
    public void FiboDoesNotInclude4()
    {
        var col = new Collections();
        Assert.DoesNotContain(4, col.FiboNumbers); //Check all items at once
    }

    [Fact]
    public void CheckCollection()
    {
        var expectedCollection = new List<int>(){1, 1, 2, 3, 5, 8, 13};
        var col = new Collections();
        Assert.Equal(expectedCollection, col.FiboNumbers);
    }
}