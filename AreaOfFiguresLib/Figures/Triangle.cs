using AreaOfFiguresLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFiguresLib.Figures
{
    public class Triangle: IFigure
    {
        private readonly float sideA;
        private readonly float sideB;
        private readonly float sideC;

        private const string argumentExceptionMessage = "There is no triangle with similar sides";

        private Triangle(float sideA, float sideB, float sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        /// <summary>
        /// Creates a "Triangle" object on three sides
        /// </summary>
        /// <param name="sideA">Triangle side A</param>
        /// <param name="sideB">Triangle side B</param>
        /// <param name="sideC">Triangle side C</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static Triangle Create(float sideA, float sideB, float sideC)
        {
            if (CheckTheCorrectnessOfArguments(sideA,sideB,sideC))
            {
                return new Triangle(sideA, sideB, sideC);
            }
            else
            {
                throw new ArgumentException(argumentExceptionMessage);
            }
        }

        public float GetArea()
        {
            float triangleHalfMeter = (sideA + sideB + sideC) / 2;
            var result = MathF.Sqrt(triangleHalfMeter * (triangleHalfMeter - sideA) * (triangleHalfMeter - sideB) * (triangleHalfMeter - sideC));
            return result;
        }

        private static bool CheckTheCorrectnessOfArguments(float sideA, float sideB, float sideC)
        {
            return
                sideA > 0 &&
                sideB > 0 &&
                sideC > 0 &&
                sideA + sideB >= sideC &&
                sideA + sideC >= sideB &&
                sideB + sideC >= sideA;
        }

        public bool IsRightTriangle()
        {
            double squaredSideA = Math.Pow(sideA, 2);
            double squaredSideB = Math.Pow(sideB, 2);
            double squaredSideC = Math.Pow(sideC, 2);
            if (squaredSideA + squaredSideB == squaredSideC)
            {
                return true;
            }
            else if (squaredSideA + squaredSideC == squaredSideB)
            {
                return true;
            }
            else if (squaredSideB + squaredSideC == squaredSideA)
            {
                return true;
            }
            return false;
        }

    }
}
