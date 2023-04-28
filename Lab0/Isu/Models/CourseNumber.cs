namespace Isu.Models;

public class CourseNumber
{
    public CourseNumber(char number)
    {
        if (!char.IsDigit(number))
        {
            throw new ArgumentException("Неверный номер курса");
        }

        Number = (int)number;
    }

    public int Number { get; private set; }

    public override bool Equals(object? obj)
    {
        if (obj is CourseNumber num)
        {
            return Number.Equals(num.Number);
        }

        return false;
    }

    public override int GetHashCode()
    {
        return Number.GetHashCode();
    }
}