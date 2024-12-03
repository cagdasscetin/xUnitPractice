namespace xUnitPractice.Tests;

public static class TestDataShare
{
    public static IEnumerable<object[]> IsOddOrEvenData => 
        new List<object[]>{ 
            new object[] { 1, true }, 
            new object[] { 200, false }
        };
}