namespace xUnitPractice;

public class Calculator
{
    public List<int> FiboNumbers { get; set; } = [1, 1, 2, 3, 5, 8, 13];
    
    public int Add(int a, int b)
    {
        return a + b;
    }
    
    public double AddDouble(double a, double b)
    {
        return a + b;
    }
}