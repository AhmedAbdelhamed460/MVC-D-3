using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day2TaskCompany.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Departments_DepartmentNumber",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "DepartmentNumber",
                table: "Projects",
                newName: "DeptNum");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_DepartmentNumber",
                table: "Projects",
                newName: "IX_Projects_DeptNum");

            migrationBuilder.AlterColumn<string>(
                name: "Hours",
                table: "WorksOnProjects",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "deptId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "mngrSSN",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_deptId",
                table: "Employees",
                column: "deptId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_mngrSSN",
                table: "Departments",
                column: "mngrSSN",
                unique: true,
                filter: "[mngrSSN] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_mngrSSN",
                table: "Departments",
                column: "mngrSSN",
                principalTable: "Employees",
                principalColumn: "SSN");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_deptId",
                table: "Employees",
                column: "deptId",
                principalTable: "Departments",
                principalColumn: "Number");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Departments_DeptNum",
                table: "Projects",
                column: "DeptNum",
                principalTable: "Departments",
                principalColumn: "Number");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_mngrSSN",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_deptId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Departments_DeptNum",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Employees_deptId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Departments_mngrSSN",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "deptId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "mngrSSN",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "DeptNum",
                table: "Projects",
                newName: "DepartmentNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_DeptNum",
                table: "Projects",
                newName: "IX_Projects_DepartmentNumber");

            migrationBuilder.AlterColumn<string>(
                name: "Hours",
                table: "WorksOnProjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Departments_DepartmentNumber",
                table: "Projects",
                column: "DepartmentNumber",
                principalTable: "Departments",
                principalColumn: "Number");
        }
    }
}
