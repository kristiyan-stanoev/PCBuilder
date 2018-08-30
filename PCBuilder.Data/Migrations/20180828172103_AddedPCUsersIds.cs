using Microsoft.EntityFrameworkCore.Migrations;

namespace PCBuilder.Data.Migrations
{
    public partial class AddedPCUsersIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsersRatedIds",
                table: "PCs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsersRatedIds",
                table: "PCs");
        }
    }
}
