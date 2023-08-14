namespace Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; }

        /// <summary>
        /// Создание круга по радиусу
        /// </summary>
        public Circle(double radius)
        {
            CheckCircle(radius);
            Radius = radius;
        }

        public double GetArea()
            => Math.PI * Radius * Radius;

        private void CheckCircle(double radius)
        {
            if (radius <= 0)
                throw new NotPositiveArgumentsException(nameof(Circle), radius);
        }
    }
}
