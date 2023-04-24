using Isu.Models;

namespace Isu.Entities;

public class Group
{
    private List<Student> _student;
    public Group(GroupName groupName)
    {
        GroupName = groupName;
        _student = new List<Student>();
    }

    public IReadOnlyList<Student> Students => _student;
    public GroupName GroupName { get; private set; }

    public void AddStudent(Student student)
    {
        _student.Add(student);
    }

    public void RemoveStudent(Student student)
    {
        _student.Remove(student);
    }
}