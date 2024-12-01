using Xunit;

namespace xUnitPractice.Tests;

[Collection("Customer")]
public class CustomerDetailsTest
{
    private readonly CustomerFixture _customerFixture;

    public CustomerDetailsTest(CustomerFixture customerFixture)
    {
        _customerFixture = customerFixture;
    }

    [Fact]
    public void GetFullName_GivenFirstAndLastName_ReturnsFullName()
    {
        var customer = _customerFixture.Cust;
        Assert.Equal("Cagdas Cetin", customer.GetFUllName("Cagdas", "Cetin"));
    }
}