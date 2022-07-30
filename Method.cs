using System;

namespace MathLibrary
{
    public class Method
    {
        public static double TriangleSquare(double A, double B, double C)
        {
            double p = (A + B + C) / 2;
            double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return S;
        }

        public static double CircleSquare(double R)
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
