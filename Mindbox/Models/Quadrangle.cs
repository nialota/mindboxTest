using Mindbox.Interfaces;

namespace Mindbox.Models
{
    public class Quadrangle : BaseCalculation, IArea
    {
        /// <summary>
        /// Рассчитать формуле Брахмагупты
        /// </summary>
        public double Area(params double[] values)
        {
            double halfPerimeter = GetHalfPerimeter(values);
            if (values.Any(value => value > halfPerimeter))
                throw new Exception("Для данной фигуры не реализован расчет площади");

            var area = Math.Sqrt((halfPerimeter - values[0]) * (halfPerimeter - values[1]) * (halfPerimeter - values[2]) * (halfPerimeter - values[3]));
            return area;
        }
    }
}