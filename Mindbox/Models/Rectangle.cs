using Mindbox.Interfaces;

namespace Mindbox.Models
{
	public class Rectangle : IArea
    {
        /// <summary>
        /// Рассчитать площадь прямоугольника
        /// </summary>
        public double Area(params double[] values)
            => values[0] * values[1];
    }
}