using Microsoft.EntityFrameworkCore.Migrations;

namespace PCBuilder.Data.Migrations
{
    public partial class AddedIndexToPowerSupply : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PowerSupplies_ModelName",
                table: "PowerSupplies",
                column: "ModelName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PowerSupplies_ModelName",
                table: "PowerSupplies");
        }
    }
}
