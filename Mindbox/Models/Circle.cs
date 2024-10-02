using Mindbox.Interfaces;

namespace Mindbox.Models
{
    public class Circle : BaseCalculation, IArea
    {
        private const int POWER = 2;

        /// <summary>
        /// Получить площадь круга по радиусу
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <returns>Площадь</returns>
        public double Area(params double[] values)
        {
            var radius = values[0];
            return Math.PI * Math.Pow(radius, POWER);
        }
    }
}