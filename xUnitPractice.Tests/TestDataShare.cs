namespace xUnitPractice.Tests;

public static class TestDataShare
{
    public static IEnumerable<object[]> IsOddOrEvenData { 
        get {
            yield return [1, true];
            yield return [200, false];
        }
    }
    
}