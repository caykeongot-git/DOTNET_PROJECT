using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab04_01.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NewMorning : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalProfessor",
                table: "Faculties",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyID",
                keyValue: "CNTT",
                column: "TotalProfessor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyID",
                keyValue: "DAAH",
                column: "TotalProfessor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyID",
                keyValue: "NNA",
                column: "TotalProfessor",
                value: null);

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyID",
                keyValue: "QTKD",
                column: "TotalProfessor",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalProfessor",
                table: "Faculties");
        }
    }
}
