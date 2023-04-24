using Isu.Entities;
using Isu.Models;

namespace Isu.Services
{
    public class IsuService : IIsuService
    {
        private List<Group> _list;
        public IsuService()
        {
            _list = new List<Group>();
        }

        public int ElementCount()
        {
            return _list.Count;
        }

        public Group AddGroup(GroupName name)
        {
            var group = new Group(name);
            _list.Add(group);
            return group;
        }

        public Student AddStudent(Group group, string name)
        {
            var student = new Student(name);
            group.Students.Add(student);
            return student;
        }

        public void ChangeStudentGroup(Student student, Group newGroup)
        {
            
        }

        public Group? FindGroup(GroupName groupName)
        {
            throw new NotImplementedException();
        }

        public List<Group> FindGroups(CourseNumber courseNumber)
        {
            throw new NotImplementedException();
        }

        public Student? FindStudent(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> FindStudents(GroupName groupName)
        {
            throw new NotImplementedException();
        }

        public List<Student> FindStudents(CourseNumber courseNumber)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}
