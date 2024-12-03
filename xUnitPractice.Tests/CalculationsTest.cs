using Xunit;
using Xunit.Abstractions;

namespace xUnitPractice.Tests;

public class CalculationsTest
{
    [Fact]
    public void FiboDoesNotIncludeZero()
    {
        var calc = new Calculations();
        Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n)); //Check items one by one
    }

    [Fact]
    public void FiboIncludes13()
    {
        var calc = new Calculations();
        Assert.Contains(13, calc.FiboNumbers);
    }

    [Fact]
    public void FiboDoesNotInclude4()
    {
        var calc = new Calculations();
        Assert.DoesNotContain(4, calc.FiboNumbers); //Check all items at once
    }

    [Fact]
    public void CheckCollection()
    {
        var expectedCollection = new List<int>(){1, 1, 2, 3, 5, 8, 13};
        var calc = new Calculations();
        Assert.Equal(expectedCollection, calc.FiboNumbers);
    }

    [Fact]
    public void IsOdd_GivenOddValue_ReturnsTrue()
    {
        var calc = new Calculations();
        var result = calc.IsOdd(1);
        Assert.True(result);
    }
    
    [Fact]
    public void IsOdd_GivenEvenValue_ReturnsFalse()
    {
        var calc = new Calculations();
        var result = calc.IsOdd(2);
        Assert.False(result);
    }

    [Theory]
    [MemberData(nameof(TestDataShare.IsOddEventExternalData), MemberType = typeof(TestDataShare))]
    public void IsOdd_TestOddAndEven(int value, bool expected)
    {
        var calc = new Calculations();
        var result = calc.IsOdd(value);
        Assert.Equal(expected, result);
    }
}