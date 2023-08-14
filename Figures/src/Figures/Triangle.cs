namespace Figures
{
    public class Triangle : IFigure
    {
        public double ASide { get; }
        public double BSide { get; }
        public double CSide { get; }

        /// <summary>
        /// Создаёт треугольник по трем сторонам
        /// </summary>
        public Triangle(double aSide, double bSide, double cSide)
        {
            CheckTriangle(aSide, bSide, cSide);

            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }

        public double GetArea()
        {
            var semiPerimeter = GetPerimeter() / 2;
            var notSqrtResult = semiPerimeter * (semiPerimeter - ASide)
                * (semiPerimeter - BSide)
                * (semiPerimeter - CSide);

            return Math.Sqrt(notSqrtResult);
        }

        /// <summary>
        /// Проверка на прямоугольность треугольника
        /// </summary>
        /// <returns>возвращает true, если треугольник прямоугольный</returns>
        public bool TriangleIsRectangular()
        {
            var sides = new double[] { ASide * ASide, BSide * BSide, CSide * CSide };
            Array.Sort(sides);

            return sides[0] + sides[1] == sides[2];
        }

        private double GetPerimeter()
            => ASide + BSide + CSide;

        /// <summary>
        /// Проверка на существование треугольника
        /// </summary>
        /// <exception cref="NotRealTriangleException">Треугольника не существует</exception>
        private void CheckTriangle(double aSide,
            double bSide,
            double cSide)
        {
            if (aSide + bSide <= cSide
                || aSide + cSide <= bSide
                || bSide + cSide <= aSide)
                throw new NotRealTriangleException(aSide, bSide, cSide);
        }
    }
}
