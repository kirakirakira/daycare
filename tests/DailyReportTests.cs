using Xunit;
using Daycare.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace tests;

public class DailyReportTests
{
   [Fact]
   public void HasADate()
   {
      DailyReport report = new DailyReport();
      DateTime date = new DateTime(2022, 7, 21);

      report.Date = date;
      Assert.Equal(date, report.Date);
   }

   [Fact]
   public void HasBehavior()
   {
      DailyReport report = new DailyReport();
      string? behavior = "obstinate";

      report.Behavior = behavior;
      Assert.Equal(behavior, report.Behavior);
   }

   [Fact]
   public void HasANumberOfPoops()
   {
      DailyReport report = new DailyReport();
      int? numberOfPoops = 3;

      report.NumberOfPoops = numberOfPoops;
      Assert.Equal(numberOfPoops, report.NumberOfPoops);
   }

   [Fact]
   public void HasAStudent()
   {
      DailyReport report = new DailyReport();
      Student student = new Student();

      report.Student = student;
      Assert.Equal(student, report.Student);
   }
}
