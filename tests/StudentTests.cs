using Xunit;
using Daycare.Models;
using System;

namespace tests;

public class StudentTests
{
    [Fact]
    public void StudentHasAName()
    {
        Student student = new Student();
        string name = "Kira";
        student.Name = name;

        Assert.Equal(name, student.Name);
    }

    [Fact]
    public void StudentHasABirthDate()
    {
        Student student = new Student();
        DateTime birthDate = new DateTime(2010, 01, 02);
        student.BirthDate = birthDate;

        Assert.Equal(birthDate, student.BirthDate);
    }

    [Fact]
    public void StudentHasAPhoneNumber()
    {
        Student student = new Student();
        string phoneNumber = "555-555-1234";
        student.PhoneNumber = phoneNumber;

        Assert.Equal(phoneNumber, student.PhoneNumber);
    }

    public void StudentHasAParentName()
    {
        Student student = new Student();
        string parentName = "555-555-1234";
        student.ParentName = parentName;

        Assert.Equal(parentName, student.ParentName);
    }

    public void StudentHasACollectionOfRecords()
    {
        Student student = new Student();
        DailyReport report1 = new DailyReport(
            1,
            new DateTime(2020, 02, 20),
            "great",
            3,
            student.StudentId,
            student
        );

        Assert.Equal(parentName, student.ParentName);
    }
}
