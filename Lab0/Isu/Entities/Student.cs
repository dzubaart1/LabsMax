using Isu.Models;

namespace Isu.Entities;

public class Student
{
    public Student(string name, Group group)
    {
        Name = name;
        Id = IdGenerator.GenerateId();
        Group = group;
    }

    public Group Group { get; private set; }
    public string Name { get; private set; }
    public int Id { get; private set; }

    public void ChangeGroup(Group group)
    {
        Group = group;
    }
}