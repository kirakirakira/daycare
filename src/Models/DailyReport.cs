using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Daycare.Models;

public class DailyReport
{
    [Key]
    public int DailyReportId { get; set; }
    public string? Behavior { get; set; }
    [Display(Name = "Number Of Poops")]
    public int? NumberOfPoops { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
}
