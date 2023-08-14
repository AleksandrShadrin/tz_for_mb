namespace Figures
{
    public class NotRealTriangleException 
        : FigureException
    {
        public NotRealTriangleException(double aSide,
            double bSide, 
            double cSide)
            : base($"Треугольника со сторонами: [{aSide}, {bSide}, {cSide}] не существует.")
        {
        }
    }
}
