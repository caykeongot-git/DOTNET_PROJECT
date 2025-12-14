using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab04_01.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FixNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "FacultyID", "FacultyName" },
                values: new object[,]
                {
                    { "CK", "Cơ khí" },
                    { "CNTT", "Công nghệ thông tin" },
                    { "KT", "Kinh tế" },
                    { "NN", "Ngoại ngữ" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "FacultyID",
                keyValue: "CK");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "FacultyID",
                keyValue: "CNTT");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "FacultyID",
                keyValue: "KT");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "FacultyID",
                keyValue: "NN");
        }
    }
}
