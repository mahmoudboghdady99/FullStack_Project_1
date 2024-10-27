using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstApp2.Migrations
{
    /// <inheritdoc />
    public partial class departmentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "TbEmployees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TbDepartments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbDepartments", x => x.DepartmentId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbEmployees_DepartmentId",
                table: "TbEmployees",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_TbEmployees_TbDepartments_DepartmentId",
                table: "TbEmployees",
                column: "DepartmentId",
                principalTable: "TbDepartments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbEmployees_TbDepartments_DepartmentId",
                table: "TbEmployees");

            migrationBuilder.DropTable(
                name: "TbDepartments");

            migrationBuilder.DropIndex(
                name: "IX_TbEmployees_DepartmentId",
                table: "TbEmployees");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "TbEmployees");
        }
    }
}
