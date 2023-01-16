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


        public float Square()
        {
            return MathF.PI * MathF.Pow(radius, 2);
        }
    }
}
