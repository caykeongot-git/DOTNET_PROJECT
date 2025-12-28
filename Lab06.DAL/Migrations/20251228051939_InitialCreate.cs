using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab06.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiSachs",
                columns: table => new
                {
                    MaLoai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSachs", x => x.MaLoai);
                });

            migrationBuilder.CreateTable(
                name: "Sachs",
                columns: table => new
                {
                    MaSach = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    TenSach = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NamXB = table.Column<int>(type: "int", nullable: false),
                    MaLoai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sachs", x => x.MaSach);
                    table.ForeignKey(
                        name: "FK_Sachs_LoaiSachs_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "LoaiSachs",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LoaiSachs",
                columns: new[] { "MaLoai", "TenLoai" },
                values: new object[,]
                {
                    { 1, "Khoa Học" },
                    { 2, "Y học" },
                    { 3, "Đời sống" }
                });

            migrationBuilder.InsertData(
                table: "Sachs",
                columns: new[] { "MaSach", "MaLoai", "NamXB", "TenSach" },
                values: new object[,]
                {
                    { "KH0001", 1, 2018, "Khám phá sự sống" },
                    { "KH0002", 1, 2018, "Hải dương học" },
                    { "YH0001", 2, 2020, "Chuẩn đoán và điều trị" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sachs_MaLoai",
                table: "Sachs",
                column: "MaLoai");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sachs");

            migrationBuilder.DropTable(
                name: "LoaiSachs");
        }
    }
}
