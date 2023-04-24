using Isu.Entities;
using Isu.Models;
using Isu.Services;
using Xunit;

namespace Isu.Test;

public class IsuServiceTest
{
    [Fact]
    public void AddStudentToGroup_StudentHasGroupAndGroupContainsStudent()
    {
    }

    [Fact]
    public void ReachMaxStudentPerGroup_ThrowException() { }

    [Fact]
    public void CreateGroupWithInvalidName_ThrowException() { }

    [Fact]
    public void TransferStudentToAnotherGroup_GroupChanged()
    {
        var service = new IsuService();
        var groupName = new GroupName("T2948");
        var groupName2 = new GroupName("V4948");
        Entities.Group group1 = service.AddGroup(groupName);
        Entities.Group group2 = service.AddGroup(groupName2);
        Student student = service.AddStudent(group1, "Ivanov");
        service.ChangeStudentGroup(student, group2);
        Assert.Equal(group2, student.Group);
        Assert.Contains(student, group2.Students);
        Assert.DoesNotContain(student, group1.Students);
    }

    [Fact]
    public void CreateGroup_IsuServiceContainsGroup()
    {
        var service = new IsuService();
        var groupName = new GroupName("T2948");
        service.AddGroup(groupName);
        Assert.Equal(1, service.Groups.Count);
    }

    [Fact]
    public void CreateStudent_GroupContainsStudent()
    {
        var service = new IsuService();
        var groupName = new GroupName("T2948");
        Entities.Group group1 = service.AddGroup(groupName);
        service.AddStudent(group1, "Ivanov");
        Assert.Equal(1, group1.Students.Count);
    }
}