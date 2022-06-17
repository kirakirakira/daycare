using Microsoft.EntityFrameworkCore;
using Daycare.Models;

public class Context : DbContext
{
    public Context() : base() { Database.EnsureCreated(); }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(@"Data Source=Daycare.db");
    }

    public DbSet<Student>? Students { get; set; }
    public DbSet<DailyReport>? DailyReports { get; set; }
}
