using Xunit;
using Xunit.Abstractions;

namespace xUnitPractice.Tests;

public class TestCollectionOrderer : ITestCollectionOrderer
{
    public IEnumerable<ITestCollection> OrderTestCollections(IEnumerable<ITestCollection> testCollections)
    {
        return testCollections.OrderBy(x => x.DisplayName);
    }
}