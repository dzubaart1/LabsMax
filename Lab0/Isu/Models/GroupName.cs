namespace Isu.Models;

public class GroupName
{
    public GroupName(string name)
    {
        if (name.Length <= 4)
        {
            throw new ArgumentException("������� �������� ���");
        }

        Faculty = new FacultyName(name[0]);
        Course = new CourseNumber(name[1]);
        Name = name;
    }

    public FacultyName Faculty { get; private set; }
    public string Name { get; private set; }
    public CourseNumber Course { get; private set; }

    public override bool Equals(object? obj)
    {
        if (obj is GroupName group)
        {
            return Name.Equals(group.Name);
        }

        return false;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}