using Xunit;
using Daycare.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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

    [Fact]
    public void StudentHasAParentName()
    {
        Student student = new Student();
        string parentName = "555-555-1234";
        student.ParentName = parentName;

        Assert.Equal(parentName, student.ParentName);
    }

    [Fact]
    public void StudentCanHaveACollectionOfRecords()
    {
        Student student1 = new Student();
        student1.Name = "Kira";
        student1.BirthDate = new DateTime(2020, 01, 20);
        student1.PhoneNumber = "353-344-1235";
        student1.ParentName = "Joe";

        DailyReport report1 = new DailyReport();
        report1.Date = new DateTime(2020, 02, 20);
        report1.Behavior = "great";
        report1.NumberOfPoops = 3;
        report1.Student = student1;

        ICollection<DailyReport> reports = new List<DailyReport>();
        reports.Add(report1);

        student1.Reports = reports;

        Assert.Equal(report1, student1.Reports.FirstOrDefault());
    }
}
