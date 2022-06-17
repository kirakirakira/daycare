using System.ComponentModel.DataAnnotations;

namespace Daycare.Models;

public class DailyReport
{
    public int StudentId { get; set; }
    public Student? Student { get; set; }
}
