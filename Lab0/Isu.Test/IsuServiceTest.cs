using Isu.Models;
using Isu.Services;
using Xunit;

namespace Isu.Test;

public class IsuServiceTest
{
    [Fact]
    public void AddStudentToGroup_StudentHasGroupAndGroupContainsStudent() { }

    [Fact]
    public void ReachMaxStudentPerGroup_ThrowException() { }

    [Fact]
    public void CreateGroupWithInvalidName_ThrowException() { }

    [Fact]
    public void TransferStudentToAnotherGroup_GroupChanged() { }

    [Fact]
    public void CreateGroup_IsuServiceContainsGroup()
    {
        var service = new IsuService();
        var groupName = new GroupName("T2948");
        service.AddGroup(groupName);
        Assert.Equal(1, service.ElementCount());
    }

    [Fact]
    public void GreateStudent_GroupContainsStudent()
    {
        var service = new IsuService();
        var groupName = new GroupName("T2948");
        Entities.Group group1 = service.AddGroup(groupName);
        service.AddStudent(group1, "Ivanov");
        Assert.Equal(1, group1.GetCount());
    }
}