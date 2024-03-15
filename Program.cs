namespace LambdaExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two double value numbers:");

        double number1 = Convert.ToDouble(Console.ReadLine());
        double number2 = Convert.ToDouble(Console.ReadLine());

        Func<double, double, double> add = (x, y) => x + y;

        Func<double, double, double> multiply = (x, y) => x * y;

        Func<double, double, double> smallerValue = (x, y) =>
        {
            if (x < y)
                return x;
            else
                return y;
        };

        Console.WriteLine($"Sum of {number1} and {number2} is: {add(number1, number2)}");
        Console.WriteLine($"Product of {number1} and {number2} is: {multiply(number1, number2)}");
        Console.WriteLine($"Smaller value between {number1} and {number2} is: {smallerValue(number1, number2)}");
    }
}

