using Xunit;

namespace xUnitPractice.Tests;

[CollectionDefinition("Customer")]
public class CustomerFixtureCollection : ICollectionFixture<CustomerFixture>
{
    
}