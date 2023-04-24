using Isu.Models;

namespace Isu.Entities;

public class Student
{
    public Student(string name)
    {
        Name = name;
        Id = IdGenerator.GenerateId();
    }

    public string Name { get; private set; }
    public int Id { get; private set; }
}