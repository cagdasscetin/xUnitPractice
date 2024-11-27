using Xunit;
using Xunit.Abstractions;

namespace xUnitPractice.Tests;

public class CalculatorFixture : IDisposable
{
    public Calculator Calc => new Calculator();
    public void Dispose()
    {
        // Clean
    }
}

public class CalculatorTest : IDisposable, IClassFixture<CalculatorFixture>
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly CalculatorFixture _calculatorFixture;
    private readonly MemoryStream _memoryStream;

    public CalculatorTest(ITestOutputHelper testOutputHelper, CalculatorFixture calculatorFixture)
    {
        _testOutputHelper = testOutputHelper;
        _calculatorFixture = calculatorFixture;
        _memoryStream = new MemoryStream();
    }

    [Fact]
    public void Add_GivenTwoIntValues_ReturnsInt()
    {
        var calc = new Calculator();
        var result = calc.Add(1, 2);
        Assert.Equal(3, result);
    }

    [Fact]
    public void AddDouble_GivenTwoDoubleValues_ReturnsDouble()
    {
        var calc = new Calculator();
        var result = calc.AddDouble(1.23, 3.55);
        Assert.Equal(4.7, result, 0);
    }

    [Fact]
    [Trait("Category", "Fibo")]
    public void CheckFiboIsNotZero()
    {
        _testOutputHelper.WriteLine("CheckFiboIsNotZero");
        var calc = _calculatorFixture.Calc;
        Assert.DoesNotContain(0, calc.FiboNumbers);
    }
    
    [Fact]
    [Trait("Category", "Fibo")]
    public void Check13Exists()
    {
        _testOutputHelper.WriteLine("Check13Exists");
        var calc = _calculatorFixture.Calc;
        Assert.Contains(13, calc.FiboNumbers);
    }

    [Fact]
    [Trait("Category", "Fibo")]
    public void CheckFiboNumbers()
    {
        _testOutputHelper.WriteLine($"CheckFiboNumbers. Test Starting at {DateTime.Now}");
        var expectedCollection = new List<int>(){1, 1, 2, 3, 5, 8, 13};
        
        _testOutputHelper.WriteLine("Creating an instance of calculator class..");
        var calc = _calculatorFixture.Calc;
        
        _testOutputHelper.WriteLine("Asserting...");
        Assert.Equal(expectedCollection, calc.FiboNumbers);
        
        _testOutputHelper.WriteLine("End");
    }

    public void Dispose() // xUnit calls automaticly
    {
        _memoryStream.Close();
    }
}