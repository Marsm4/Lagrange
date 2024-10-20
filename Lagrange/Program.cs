using System;

class Program
{
    // Метод для вычисления многочлена Лагранжа
    static double Lagrange(double[] x, double[] y, double xValue)
    {
        double result = 0;
        int n = x.Length;

        for (int i = 0; i < n; i++)
        {
            double term = y[i];

            for (int j = 0; j < n; j++)
            {
                if (i != j)
                {
                    term *= (xValue - x[j]) / (x[i] - x[j]);
                }
            }

            result += term;
        }

        return result;
    }



    static void Main(string[] args)
    {
        // Заданные точки (x, y)
        double[] x = { 0.27, 0.93, 1.46, 2.11, 2.87};
        double[] y = { 2.60, 2.43, 2.06, 0.25, -2.60 };

        // Точка, для которой нужно вычислить значение
        double xValue = 2.34;

        // Вычисляем значение многочлена Лагранжа в точке xValue
        double interpolatedValue = Lagrange(x, y, xValue);

        Console.WriteLine($"Значение многочлена Лагранжа в точке {xValue}: {interpolatedValue}");
        Console.ReadLine();
    }
    
}