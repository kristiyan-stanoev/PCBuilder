using Microsoft.EntityFrameworkCore.Migrations;

namespace PCBuilder.Data.Migrations
{
    public partial class AddedSocketToMemory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Socket",
                table: "Memory",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Socket",
                table: "Memory");
        }
    }
}
