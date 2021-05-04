using Microsoft.EntityFrameworkCore.Migrations;

namespace Transcription.Migrations
{
    public partial class RemovedRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_TransccriptionPrograms_ProgramId",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "TransccriptionPrograms",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "ProgramId",
                table: "Employees",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_TransccriptionPrograms_ProgramId",
                table: "Employees",
                column: "ProgramId",
                principalTable: "TransccriptionPrograms",
                principalColumn: "ProgramId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_TransccriptionPrograms_ProgramId",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "TransccriptionPrograms",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProgramId",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_TransccriptionPrograms_ProgramId",
                table: "Employees",
                column: "ProgramId",
                principalTable: "TransccriptionPrograms",
                principalColumn: "ProgramId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
