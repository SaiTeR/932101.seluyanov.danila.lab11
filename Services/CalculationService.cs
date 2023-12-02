using Lab11.Models;

public interface ICalculationService
{
    int Add(int a, int b);
    int Subtract(int a, int b);
    int Multiply(int a, int b);
    double Divide(int a, int b);

    public CalcModel createCalcModel()
    {
        Random rnd = new Random();
        int a = rnd.Next(0, 11);
        int b = rnd.Next(0, 11);

        var Calc = new CalcModel
        {
            Sum = Add(a, b),
            Difference = Subtract(a, b),
            Product = Multiply(a, b),
            Quotient = Divide(a, b)
        };

        return Calc;
    }
}

public class CalculationService : ICalculationService
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Деление на 0!!!");
        }
        return (double)a / b;
    }

    
}



