namespace Ardalis.Extensions.Math
{
    // Naming: https://en.wikipedia.org/wiki/Template:Arithmetic_operations
    public static partial class MathExtensions
    {
        public static double Pow(this double leftSide, double rightSide)
        {
            double result = System.Math.Pow(leftSide, rightSide);
            return result;
        }
    }
}