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

        public static Triangle Create(float side_A, float side_B, float side_C)
        {
            if (side_A + side_B > side_C && side_A + side_C > side_B && side_B + side_C > side_A)
            {
                if (side_A > 0 && side_B > 0 && side_C > 0)
                {
                    return new Triangle(side_A, side_B, side_C);
                }
                else
                {
                    throw new ArgumentException(argumentExceptionMessage);
                }
            }
            else
            {
                throw new ArgumentException(argumentExceptionMessage);
            }
        }

        public float Square()
        {
            var squaredSide_A = MathF.Pow(sideA, 2);
            var squaredSide_B = MathF.Pow(sideB, 2);
            var squaredSide_C = MathF.Pow(sideC, 2);
            if (squaredSide_A + squaredSide_B == squaredSide_C)
            {
                return sideA * sideB / 2;
            }
            else if (squaredSide_A + squaredSide_C == squaredSide_B)
            { 
                return sideA * sideC / 2;
            }
            else if (squaredSide_B + squaredSide_C == squaredSide_A)
            {
                return sideB * sideC / 2;
            }
            var triangleHalfMeter = (sideA + sideB + sideC) / 2;

            return MathF.Sqrt(triangleHalfMeter * (triangleHalfMeter - sideA) * (triangleHalfMeter - sideB) * (triangleHalfMeter - sideC));
        }
    }
}
