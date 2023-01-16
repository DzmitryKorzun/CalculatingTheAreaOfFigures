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
        private readonly float squaredSideA;
        private readonly float squaredSideB;
        private readonly float squaredSideC;
        private const string argumentExceptionMessage = "There is no triangle with similar sides";

        private Triangle(float sideA, float sideB, float sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.squaredSideA = MathF.Pow(sideA, 2);
            this.squaredSideB = MathF.Pow(sideB, 2);
            this.squaredSideC = MathF.Pow(sideC, 2);
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
            if (CheckingTheCorrectnessOfArguments(sideA,sideB,sideC))
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
            if (squaredSideA + squaredSideB == squaredSideC)
            {
                return sideA * sideB / 2;
            }
            else if (squaredSideA + squaredSideC == squaredSideB)
            { 
                return sideA * sideC / 2;
            }
            else if (squaredSideB + squaredSideC == squaredSideA)
            {
                return sideB * sideC / 2;
            }
            var triangleHalfMeter = (sideA + sideB + sideC) / 2;

            return CalculationAreaAccordingToHeronsFormula();
        }

        private static bool CheckingTheCorrectnessOfArguments(float sideA, float sideB, float sideC)
        {
            if (sideA + sideB > sideC &&
                sideA + sideC > sideB &&
                sideB + sideC > sideA &&
                sideA > 0 &&
                sideB > 0 &&
                sideC > 0)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        private float CalculationAreaAccordingToHeronsFormula()
        {
            var triangleHalfMeter = (sideA + sideB + sideC) / 2;
            var result = MathF.Sqrt(triangleHalfMeter * (triangleHalfMeter - sideA) * (triangleHalfMeter - sideB) * (triangleHalfMeter - sideC));
            return result;
        }

    }
}
