using Microsoft.EntityFrameworkCore.Migrations;

namespace PCBuilder.Data.Migrations
{
    public partial class AddedModelNameIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BuildName",
                table: "PCs",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_SolidStateDrives_ModelName",
                table: "SolidStateDrives",
                column: "ModelName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Processors_ModelName",
                table: "Processors",
                column: "ModelName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PCs_BuildName",
                table: "PCs",
                column: "BuildName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Motherboards_ModelName",
                table: "Motherboards",
                column: "ModelName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Memory_ModelName",
                table: "Memory",
                column: "ModelName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HardDiskDrives_ModelName",
                table: "HardDiskDrives",
                column: "ModelName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GraphicsCards_ModelName",
                table: "GraphicsCards",
                column: "ModelName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cases_ModelName",
                table: "Cases",
                column: "ModelName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SolidStateDrives_ModelName",
                table: "SolidStateDrives");

            migrationBuilder.DropIndex(
                name: "IX_Processors_ModelName",
                table: "Processors");

            migrationBuilder.DropIndex(
                name: "IX_PCs_BuildName",
                table: "PCs");

            migrationBuilder.DropIndex(
                name: "IX_Motherboards_ModelName",
                table: "Motherboards");

            migrationBuilder.DropIndex(
                name: "IX_Memory_ModelName",
                table: "Memory");

            migrationBuilder.DropIndex(
                name: "IX_HardDiskDrives_ModelName",
                table: "HardDiskDrives");

            migrationBuilder.DropIndex(
                name: "IX_GraphicsCards_ModelName",
                table: "GraphicsCards");

            migrationBuilder.DropIndex(
                name: "IX_Cases_ModelName",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "BuildName",
                table: "PCs");
        }
    }
}
