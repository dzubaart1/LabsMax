using Isu.Entities;
using Isu.Models;

namespace Isu.Services
{
    public class IsuService : IIsuService
    {
        private List<Group> _groupList;
        private List<Student> _studentList;
        public IsuService()
        {
            _groupList = new List<Group>();
            _studentList = new List<Student>();
        }

        public IReadOnlyList<Student> Students { get { return _studentList; } }
        public IReadOnlyList<Group> Groups { get { return _groupList; } }

        public Group AddGroup(GroupName name)
        {
            var group = new Group(name);
            _groupList.Add(group);
            return group;
        }

        public Student AddStudent(Group group, string name)
        {
            var student = new Student(name, group);
            group.AddStudent(student);
            _studentList.Add(student);
            return student;
        }

        public void ChangeStudentGroup(Student student, Group newGroup)
        {
            student.Group.RemoveStudent(student);
            newGroup.AddStudent(student);
            student.ChangeGroup(newGroup);
        }

        public Group? FindGroup(GroupName groupName)
        {
            return Groups.FirstOrDefault(group => group.GroupName.Equals(groupName));
        }

        public List<Group> FindGroups(CourseNumber courseNumber)
        {
            var listOfGroups = new List<Group>();
            listOfGroups.Add(Groups.First(group => group.GroupName.Course.Equals(courseNumber)));
            return listOfGroups;
        }

        public Student? FindStudent(int id)
        {
            return Students.FirstOrDefault(student => student.Id.Equals(id));
        }

        public List<Student> FindStudents(GroupName groupName)
        {
            var listOfStudents = new List<Student>();
            listOfStudents.Add(Students.First(student => student.Group.GroupName.Equals(groupName)));
            return listOfStudents;
        }

        public List<Student> FindStudents(CourseNumber courseNumber)
        {
            var listOfStudents = new List<Student>();
            listOfStudents.Add(Students.First(student => student.Group.GroupName.Course.Equals(courseNumber)));
            return listOfStudents;
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}
