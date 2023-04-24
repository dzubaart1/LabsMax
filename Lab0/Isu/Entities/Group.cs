using Isu.Models;

namespace Isu.Entities;

public class Group
{
    public Group(GroupName groupName)
    {
        GroupName = groupName;
        Students = new List<Student>();
    }

    public List<Student> Students { get; set; } // IReadOnlyList<Student> Students => _student;
    public GroupName GroupName { get; private set; }

    public int GetCount()
    {
        return Students.Count;
    }
}