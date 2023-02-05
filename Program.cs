namespace DelegatesAndEvents;

class Program
{
    static void Main(string[] args)
    {
        Case1.Operate operation = new Case1.Operate(Case1.Sum);

        operation += Case1.Subtract;
        operation += Case1.Multiply;
        operation += Case1.Divide;

        operation(2, 2);

        Case2.OnOperate += result => Console.WriteLine($"The result of operation is {result}");
        Case2.Operate operation2 = new Case2.Operate(Case2.Sum);

        operation2 += Case2.Subtract;
        operation2 += Case2.Multiply;
        operation2 += Case2.Divide;

        operation2(2, 2);
    }
}
