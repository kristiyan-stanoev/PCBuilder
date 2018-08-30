using Microsoft.EntityFrameworkCore.Migrations;

namespace PCBuilder.Data.Migrations
{
    public partial class ChangedModelToModelNameInMemory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Memory",
                newName: "ModelName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModelName",
                table: "Memory",
                newName: "Model");
        }
    }
}
