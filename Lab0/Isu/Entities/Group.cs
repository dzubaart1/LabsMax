using Isu.Models;
using Isu.Tools;

namespace Isu.Entities;

public class Group
{
    private const int MAXSTUDENTS = 30;
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
        if (Students.Count == MAXSTUDENTS)
        {
            throw new OutOfRangeStudentException();
        }

        _student.Add(student);
    }

    public void RemoveStudent(Student student)
    {
        _student.Remove(student);
    }
}