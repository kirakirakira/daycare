using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Daycare.Models;

public class DailyReport
{
    public int DailyReportId { get; set; }

    [ForeignKey("StudentId")]
    public Student? Student { get; set; }
}
