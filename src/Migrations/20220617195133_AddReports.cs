using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Daycare.Migrations
{
    public partial class AddReports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyReports",
                columns: table => new
                {
                    DailyReportId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StudentId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyReports", x => x.DailyReportId);
                    table.ForeignKey(
                        name: "FK_DailyReports_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DailyReports_StudentId",
                table: "DailyReports",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyReports");
        }
    }
}
