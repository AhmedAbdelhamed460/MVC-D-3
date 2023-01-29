using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day2TaskCompany.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SuperSSN",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "SupervisorSSN",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SupervisorSSN",
                table: "Employees",
                column: "SupervisorSSN");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_SupervisorSSN",
                table: "Employees",
                column: "SupervisorSSN",
                principalTable: "Employees",
                principalColumn: "SSN");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_SupervisorSSN",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_SupervisorSSN",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SupervisorSSN",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "SuperSSN",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
