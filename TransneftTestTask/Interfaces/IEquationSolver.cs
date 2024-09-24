
namespace TransneftTestTask.Interfaces
{
    /// <summary>
    /// Интерфес для решения уравнений.
    /// </summary>
    public interface IEquationSolver
    {

        /// <summary>
        /// Метод решения уравнений.
        /// </summary>
        /// <param name="mainFunction">Исходная функция.</param>
        /// <param name="firstDerivativeFunc">Первая производная исходной функции.</param>
        /// <param name="secondDerivativeFunc">Вторая производная исходной функции.</param>
        /// <param name="a">Начало отрезка.</param>
        /// <param name="b">Конец отрезка.</param>
        /// <param name="accuracy">Точность.</param>
        /// <returns>Решение уравнения.</returns>
        double Calculate(Func<double, double> mainFunction, Func<double, double> firstDerivativeFunc, Func<double, double> secondDerivativeFunc, double a, double b, double accuracy = 0.1);
    }
}
