namespace Isu.Tools
{
    public class OutOfRangeStudentException : Exception
    {
        public OutOfRangeStudentException()
            : base("Достигнуто максимальное колличество студентов")
        {
        }
    }
}
