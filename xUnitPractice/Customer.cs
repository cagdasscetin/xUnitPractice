namespace xUnitPractice;

public class Customer
{
    public int GetOrdersByName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Hello");
        }

        return 100;
    }
    
    public int Age => 24;
}