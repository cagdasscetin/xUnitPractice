namespace xUnitPractice.Tests;

public static class TestDataShare
{
    public static IEnumerable<object[]> IsOddOrEvenData => 
        new List<object[]>{ 
            new object[] { 1, true }, 
            new object[] { 200, false }
        };
    
    public static IEnumerable<object[]> IsOddOrEvenExternalData {
        get
        {
            var allLines = System.IO.File.ReadAllLines("IsOddOrEvenTestData.txt");
            return allLines.Select(x => {
                var lineSplit = x.Split(",");
                return new object[] { int.Parse(lineSplit[0]), bool.Parse(lineSplit[1]) };
            });
        }
    }
}