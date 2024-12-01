using Xunit;

namespace xUnitPractice.Tests;

[Collection("Customer")]
public class CustomerTest
{
    private readonly CustomerFixture _customerFixture;

    public CustomerTest(CustomerFixture customerFixture)
    {
        _customerFixture = customerFixture;
    }

    [Fact]
    public void CheckLegitForDiscount()
    {
        var customer = _customerFixture.Cust;
        Assert.InRange(customer.Age, 15, 24);
    }

    [Fact]
    public void GetOrdersByNameNotNull()
    {
        var customer = _customerFixture.Cust;
        var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(null));
        Assert.Equal("Hello", exceptionDetails.Message);
    }

    [Fact]
    public void LoyalCustomerForOrdersG100()
    {
        var customer = CustomerFactory.CreateCustomerInstance(102);
        var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
        Assert.Equal(10, loyalCustomer.Discount);
    }
}