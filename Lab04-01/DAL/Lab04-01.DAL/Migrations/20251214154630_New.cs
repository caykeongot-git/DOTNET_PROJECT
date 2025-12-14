using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab04_01.DAL.Migrations
{
    /// <inheritdoc />
    public partial class New : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "FacultyID",
                keyValue: "CK");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "FacultyID",
                keyValue: "KT");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "FacultyID",
                keyValue: "NN");

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyID",
                keyValue: "CNTT",
                column: "FacultyName",
                value: "Công Nghệ Thông Tin");

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "FacultyID", "FacultyName" },
                values: new object[,]
                {
                    { "DAAH", "DO ALL AT HOME" },
                    { "NNA", "Ngôn Ngữ Anh" },
                    { "QTKD", "Quản Trị Kinh Doanh" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "FacultyID",
                keyValue: "DAAH");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "FacultyID",
                keyValue: "NNA");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "FacultyID",
                keyValue: "QTKD");

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyID",
                keyValue: "CNTT",
                column: "FacultyName",
                value: "Công nghệ thông tin");

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "FacultyID", "FacultyName" },
                values: new object[,]
                {
                    { "CK", "Cơ khí" },
                    { "KT", "Kinh tế" },
                    { "NN", "Ngoại ngữ" }
                });
        }
    }
}
