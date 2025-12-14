using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab04_01.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FalcutyID",
                table: "Faculties",
                newName: "FacultyID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FacultyID",
                table: "Faculties",
                newName: "FalcutyID");
        }
    }
}
