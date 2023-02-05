namespace DelegatesAndEvents;

class Case1 
{
    public delegate double Operate(double number1, double number2);

    public static double Sum(double number1, double number2)
    {
        double result = number1 + number2;

        Console.WriteLine($"The result of {number1} + {number2} = {result}");

        return result;
    }

    public static double Subtract(double number1, double number2)
    {
        double result = number1 - number2;

        Console.WriteLine($"The result of {number1} - {number2} = {result}");

        return result;
    }

    public static double Multiply(double number1, double number2)
    {
        double result = number1 * number2;

        Console.WriteLine($"The result of {number1} x {number2} = {result}");

        return result;
    }

    public static double Divide(double number1, double number2)
    {
        double result = number1 / number2;

        Console.WriteLine($"The result of {number1} / {number2} = {result}");

        return result;
    }
}