using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExamer.Data.Migrations
{
    public partial class AddedDeletedOnToUserExams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "UserExams",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UserExams",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "UserExams");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UserExams");
        }
    }
}
