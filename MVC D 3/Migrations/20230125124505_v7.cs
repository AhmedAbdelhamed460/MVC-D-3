using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day2TaskCompany.Migrations
{
    /// <inheritdoc />
    public partial class v7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dependent_Employees_EmpSSN",
                table: "Dependent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dependent",
                table: "Dependent");

            migrationBuilder.RenameTable(
                name: "Dependent",
                newName: "Dependents");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dependents",
                table: "Dependents",
                columns: new[] { "EmpSSN", "Name" });

            migrationBuilder.AddForeignKey(
                name: "FK_Dependents_Employees_EmpSSN",
                table: "Dependents",
                column: "EmpSSN",
                principalTable: "Employees",
                principalColumn: "SSN",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dependents_Employees_EmpSSN",
                table: "Dependents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dependents",
                table: "Dependents");

            migrationBuilder.RenameTable(
                name: "Dependents",
                newName: "Dependent");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dependent",
                table: "Dependent",
                columns: new[] { "EmpSSN", "Name" });

            migrationBuilder.AddForeignKey(
                name: "FK_Dependent_Employees_EmpSSN",
                table: "Dependent",
                column: "EmpSSN",
                principalTable: "Employees",
                principalColumn: "SSN",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
