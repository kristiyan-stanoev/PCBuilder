using Microsoft.EntityFrameworkCore.Migrations;

namespace PCBuilder.Data.Migrations
{
    public partial class AddedMemoryCapacityToDrives : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "MemoryCapacity",
                table: "SolidStateDrives",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MemoryCapacity",
                table: "HardDiskDrives",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemoryCapacity",
                table: "SolidStateDrives");

            migrationBuilder.DropColumn(
                name: "MemoryCapacity",
                table: "HardDiskDrives");
        }
    }
}
