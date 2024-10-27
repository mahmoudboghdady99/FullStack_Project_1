using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstApp2.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeAllawances : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbAllawances",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbAllawances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAllawances",
                columns: table => new
                {
                    EmployeeAllawancesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    AllawancesId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAllawances", x => x.EmployeeAllawancesId);
                    table.ForeignKey(
                        name: "FK_EmployeeAllawances_TbAllawances_AllawancesId",
                        column: x => x.AllawancesId,
                        principalTable: "TbAllawances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeAllawances_TbEmployees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "TbEmployees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAllawances_AllawancesId",
                table: "EmployeeAllawances",
                column: "AllawancesId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAllawances_EmployeeId",
                table: "EmployeeAllawances",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeAllawances");

            migrationBuilder.DropTable(
                name: "TbAllawances");
        }
    }
}
