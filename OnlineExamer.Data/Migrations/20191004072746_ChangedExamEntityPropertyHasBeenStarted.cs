using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExamer.Data.Migrations
{
    public partial class ChangedExamEntityPropertyHasBeenStarted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasBeenStarted",
                table: "Exams");

            migrationBuilder.AddColumn<bool>(
                name: "HasBeenStarted",
                table: "UserExams",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasBeenStarted",
                table: "UserExams");

            migrationBuilder.AddColumn<bool>(
                name: "HasBeenStarted",
                table: "Exams",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
