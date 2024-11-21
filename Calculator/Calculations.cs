namespace Calculator;

public class Calculations
{
    private double[] nums;

    public Calculations(double[] nums)
    {
        this.nums = nums;
    }

    public Calculations()
    {
        
    }

    public double Add()
    {
        double result = 0;
        foreach (var num in nums)
        {
            result += num;
        }

        return result;
    }

    public double Sub()
    {
        double result = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            result -= nums[i];
        }

        return result;
    }

    public double Product()
    {
        double result = 1;
        foreach (var num in nums)
        {
            result *= num;
        }

        return result;
    }

    public double Quotient()
    {
        double result = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            result /= nums[i];
        }

        return result;
    }
    
    public void SetNums(double[] nums)
    {
        this.nums = nums;
    }
    
}