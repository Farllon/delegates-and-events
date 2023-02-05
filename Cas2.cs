namespace DelegatesAndEvents;

class Case2
{
    public delegate void OperationWasOcurred(double operationResult);

    public static event OperationWasOcurred OnOperate;

    public delegate double Operate(double number1, double number2);

    public static double Sum(double number1, double number2)
    {
        double result = number1 + number2;

        OnOperate.Invoke(result);

        return result;
    }

    public static double Subtract(double number1, double number2)
    {
        double result = number1 - number2;

        OnOperate.Invoke(result);

        return result;
    }

    public static double Multiply(double number1, double number2)
    {
        double result = number1 * number2;

        OnOperate.Invoke(result);

        return result;
    }

    public static double Divide(double number1, double number2)
    {
        double result = number1 / number2;
        
        OnOperate.Invoke(result);

        return result;
    }
}