namespace Mindbox.Models
{
    public class BaseCalculation
	{
        private const int POWER = 2;
        /// <summary>
        /// Получить полупериметр
        /// </summary>
        protected static double GetHalfPerimeter(double[] values)
            => values.Sum() / 2;

        /// <summary>
        /// Получить сумму квадратов массива чисел
        /// </summary>
        protected static double CalculateSumOfPow(double[] values)
        {
            return values.Sum(value => Math.Pow(value, POWER));
        }
    }
}