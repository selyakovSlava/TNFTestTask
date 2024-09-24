using TransneftTestTask.Interfaces;

namespace TransneftTestTask.Classes
{
    /// <summary>
    /// Решение уравнения методом Ньютона.
    /// </summary>
    public class NewtonMethod : IEquationSolver
    {
        public NewtonMethod() { }


        public double Calculate(Func<double, double> mainFunction, Func<double, double> firstDerivativeFunc, Func<double, double> secondDerivativeFunc, double a, double b, double accuracy)
        {
            double initialApproximation = 0;

            // Определение начального приближения.
            if (mainFunction(a) * secondDerivativeFunc(a) > 0)
            {
                initialApproximation = a;
            }
            else if (mainFunction(b) * secondDerivativeFunc(b) > 0)
            {
                initialApproximation = b;
            }
            else
            {
                Console.WriteLine("Ошибка! Неверно выбран начальный интервал.");
                return 0;
            }

            // Расчет.
            double result = initialApproximation - (mainFunction(initialApproximation) / firstDerivativeFunc(initialApproximation));

            while (Math.Abs(result - initialApproximation) >= accuracy)
            {
                try
                {
                    initialApproximation = result - (mainFunction(result) / firstDerivativeFunc(result));
                    result = initialApproximation - (mainFunction(initialApproximation) / firstDerivativeFunc(initialApproximation));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при вычислении: {ex.Message}");
                    initialApproximation = 0;
                    result = 0;
                }
            }

            return result;
        }
    }
}
