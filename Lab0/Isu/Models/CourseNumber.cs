namespace Isu.Models;

public class CourseNumber
{
    public CourseNumber(int number)
    {
        Number = number;
    }

    public int Number { get; private set; }
}