using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF02.Migrations
{
    /// <inheritdoc />
    public partial class instMangeDept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.AddColumn<int>(
                name: "Inst_id",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Inst_id",
                table: "Departments",
                column: "Inst_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Inst_id",
                table: "Departments",
                column: "Inst_id",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Inst_id",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Inst_id",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Inst_id",
                table: "Departments");

         
        }
    }
}
