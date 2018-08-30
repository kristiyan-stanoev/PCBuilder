using Microsoft.EntityFrameworkCore.Migrations;

namespace PCBuilder.Data.Migrations
{
    public partial class RemovedMemoryTypeFromProcessorEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemoryType",
                table: "Processors");

            migrationBuilder.AddColumn<double>(
                name: "SystemRating",
                table: "PCs",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "SystemSummary",
                table: "PCs",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "UserRating",
                table: "PCs",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SystemRating",
                table: "PCs");

            migrationBuilder.DropColumn(
                name: "SystemSummary",
                table: "PCs");

            migrationBuilder.DropColumn(
                name: "UserRating",
                table: "PCs");

            migrationBuilder.AddColumn<string>(
                name: "MemoryType",
                table: "Processors",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
