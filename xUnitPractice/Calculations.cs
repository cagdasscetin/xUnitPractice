namespace xUnitPractice;

public class Calculations
{
    public List<int> FiboNumbers { get; set; } = [1, 1, 2, 3, 5, 8, 13];
    
    public bool IsOdd(int value)
    {
        return (value % 2) == 1;
    }
}