
namespace TransneftTestTask.Classes
{
    /// <summary>
    /// Определяет набор функций.
    /// </summary>
    public static class Functions
    {
        /// <summary>
        /// Изначальная функция.
        /// </summary>
        /// <param name="x">Значение точки.</param>
        /// <returns>Значение функции в точке x.</returns>
        public static double MainFunction(double x)
        {
            return Math.Pow(x, 3) - 2 * x + 2;
        }

        /// <summary>
        /// Первая производная изначальной функции.
        /// </summary>
        /// <param name="x">Значение точки.</param>
        /// <returns>Значение функции в точке x.</returns>
        public static double FirstDerivative(double x)
        {
            return 3 * Math.Pow(x, 2) - 2;
        }

        /// <summary>
        /// Вторая производная изначальной функции.
        /// </summary>
        /// <param name="x">Значение точки.</param>
        /// <returns>Значение функции в точке x.</returns>
        public static double SecondDerivative(double x)
        {
            return 6 * x;
        }
    }
}
