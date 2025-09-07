using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF02.Migrations
{
    /// <inheritdoc />
    public partial class instworkDept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkDepartmentID",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_WorkDepartmentID",
                table: "Instructors",
                column: "WorkDepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_WorkDepartmentID",
                table: "Instructors",
                column: "WorkDepartmentID",
                principalTable: "Departments",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_WorkDepartmentID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_WorkDepartmentID",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "WorkDepartmentID",
                table: "Instructors");
        }
    }
}
