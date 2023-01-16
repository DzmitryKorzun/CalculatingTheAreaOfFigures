using AreaOfFiguresLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFiguresLib.Figures
{
    public class Circle : IFigure
    {
        private readonly float radius;
        private const string argumentExceptionMessage = "Radius must be positive";

        private Circle(float radius)
        {
            this.radius = radius;
        }
        /// <summary>
        /// Creates a circle based on its radius
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static Circle Create(float radius)
        {
            if (radius > 0)
            {
                return new Circle(radius);
            }
            else
            {
                throw new ArgumentException(argumentExceptionMessage);
            }
        }

        public float GetArea()
        {
            return MathF.PI * MathF.Pow(radius, 2);
        }
    }
}
