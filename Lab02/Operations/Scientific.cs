using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Logic
{
    public class Scientific
    {
        public static double Potency(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public static double Logarithm(double x, double y)
        {
            return Math.Log(x, y);
        }

        public static double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }

        public static double Factorial(double x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result = result * i;
            }
            return result;
        }

        public static double SineRadian(double x)
        {
            return Math.Round(Math.Sin(x));
        }

        public static double SineDegrees(double x)
        {
            return (180 * Math.Round(Math.Sin(x))) / Math.PI;
        }

        public static double CosineRadian(double x)
        {
            return Math.Round(Math.Cos(x));
        }

        public static double CosineDegrees(double x)
        {
            return ((180 * Math.Round(Math.Cos(x))) / Math.PI);
        }

        public static double TangentRadian(double x)
        {
            return Math.Round(Math.Tan(x));
        }

        public static double TangentDegrees(double x)
        {
            return ((180 * Math.Round(Math.Tan(x))) / Math.PI);
        }
    }
}
