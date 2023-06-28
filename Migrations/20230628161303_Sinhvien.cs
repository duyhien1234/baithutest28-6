using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace testtest.Migrations
{
    /// <inheritdoc />
    public partial class Sinhvien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sinhvien",
                columns: table => new
                {
                    Masinhvien = table.Column<string>(type: "TEXT", nullable: false),
                    Tensinhvien = table.Column<string>(type: "TEXT", nullable: false),
                    Tenlop = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinhvien", x => x.Masinhvien);
                    table.ForeignKey(
                        name: "FK_Sinhvien_Lophoc_Tenlop",
                        column: x => x.Tenlop,
                        principalTable: "Lophoc",
                        principalColumn: "Malop",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sinhvien_Tenlop",
                table: "Sinhvien",
                column: "Tenlop");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sinhvien");
        }
    }
}
