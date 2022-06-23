using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Daycare.Models;

public class Student
{
    [Key]
    public int StudentId { get; set; }
    public string? Name { get; set; }
    [Display(Name = "Birth Date")]
    public DateTime BirthDate { get; set; }
    [Display(Name = "Phone Number")]
    public string? PhoneNumber { get; set; }
    [Display(Name = "Parent Name")]
    public string? ParentName { get; set; }

    public ICollection<DailyReport>? Reports { get; set; }
}
