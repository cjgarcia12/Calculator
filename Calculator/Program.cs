using System.Collections;
using System.Diagnostics;

namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        bool stop = false;
        
        Console.WriteLine("Welcome to our Console Calculator");
        do
        {
            stop = Menu();
        } 
        while (stop == false);
    }

    static bool Menu()
    {
        bool stop = false;
        Calculations calc;
        Console.WriteLine("Choose an Operation: ");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        Console.WriteLine("0. Exit");
        
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 0)
        {
            Console.WriteLine("Goodbye!");
            stop = true;
            return stop;
        }
        double[] nums = GetNums();
        calc = new Calculations(nums);
        
        switch (choice)
        {
            case 1:
                Console.WriteLine(calc.Add());
                break;
            case 2:
                Console.WriteLine(calc.Sub());              
                break;
            case 3:
                Console.WriteLine(calc.Product());           
                break;
            case 4:
                Console.WriteLine(calc.Quotient());          
                break;
        }
        return stop;
    }

    static double[] GetNums()
    {
        ArrayList nums = new ArrayList();
        
        bool stop = false;
        Console.WriteLine("Enter your numbers: \nPress enter or anything but a number to stop");
        while (stop == false)
        {
            string input = Console.ReadLine();
            if (!isDouble(input))
            {
                stop = true;
            }
            else
            {
                nums.Add(Convert.ToDouble(input));
            }
        }
        return (double[])nums.ToArray(typeof(double));
    }

    static bool isDouble(string input)
    {
        return double.TryParse(input, out _);
    }
}