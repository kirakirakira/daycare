using Xunit;
using Daycare.Models;

namespace tests;

public class StudentTests
{
    [Fact]
    public void StudentHasANameProperty()
    {
        Student student = new Student();
        string name = "Kira";
        student.Name = name;

        Assert.Equal(name, student.Name);
    }
}
