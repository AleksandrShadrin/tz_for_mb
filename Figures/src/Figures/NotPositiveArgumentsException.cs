namespace Figures
{
    public class NotPositiveArgumentsException
        : FigureException
    {
        public NotPositiveArgumentsException(string type,
            params double[] args)
            : base($"{type} не может иметь аргументы [{string.Join(", ", args)}].")
        {
        }
    }
}
