using System.Reflection;
using Xunit.Sdk;

namespace xUnitPractice.Tests;

public class IsOddOrEvenDataAttribute : DataAttribute
{
    public override IEnumerable<object[]> GetData(MethodInfo testMethod)
    {
        yield return new object[] { 1, true };
        yield return new object[] { 200, false };
    }
}