using Microsoft.EntityFrameworkCore.Migrations;

namespace PCBuilder.Data.Migrations
{
    public partial class FixedBindingModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Model",
                table: "SolidStateDrives",
                newName: "ModelName");

            migrationBuilder.RenameColumn(
                name: "Series",
                table: "Processors",
                newName: "ModelName");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Processors",
                newName: "Architecture");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "PowerSupplies",
                newName: "ModelName");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Motherboards",
                newName: "ModelName");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "HardDiskDrives",
                newName: "ModelName");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "GraphicsCards",
                newName: "ModelName");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Cases",
                newName: "ModelName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModelName",
                table: "SolidStateDrives",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "ModelName",
                table: "Processors",
                newName: "Series");

            migrationBuilder.RenameColumn(
                name: "Architecture",
                table: "Processors",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "ModelName",
                table: "PowerSupplies",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "ModelName",
                table: "Motherboards",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "ModelName",
                table: "HardDiskDrives",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "ModelName",
                table: "GraphicsCards",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "ModelName",
                table: "Cases",
                newName: "Model");
        }
    }
}
