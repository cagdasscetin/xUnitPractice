using Xunit;

namespace xUnitPractice.Tests;

public class CustomerTest
{
    [Fact]
    public void CheckLegitForDiscount()
    {
        var customer = new Customer();
        Assert.InRange(customer.Age, 15, 24);
    }

    [Fact]
    public void GetOrdersByNameNotNull()
    {
        var customer = new Customer();
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