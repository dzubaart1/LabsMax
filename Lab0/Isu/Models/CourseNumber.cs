namespace Isu.Models;

public class CourseNumber
{
    public CourseNumber(int number)
    {
        Number = number;
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