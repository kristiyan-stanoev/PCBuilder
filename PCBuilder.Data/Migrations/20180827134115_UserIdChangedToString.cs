using Microsoft.EntityFrameworkCore.Migrations;

namespace PCBuilder.Data.Migrations
{
    public partial class UserIdChangedToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PCs_AspNetUsers_UserId1",
                table: "PCs");

            migrationBuilder.DropTable(
                name: "PCsMemories");

            migrationBuilder.DropIndex(
                name: "IX_PCs_UserId1",
                table: "PCs");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "PCs");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "PCs",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "MemoryId",
                table: "PCs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfMemorySticks",
                table: "PCs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PCs_MemoryId",
                table: "PCs",
                column: "MemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PCs_UserId",
                table: "PCs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PCs_Memory_MemoryId",
                table: "PCs",
                column: "MemoryId",
                principalTable: "Memory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PCs_AspNetUsers_UserId",
                table: "PCs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PCs_Memory_MemoryId",
                table: "PCs");

            migrationBuilder.DropForeignKey(
                name: "FK_PCs_AspNetUsers_UserId",
                table: "PCs");

            migrationBuilder.DropIndex(
                name: "IX_PCs_MemoryId",
                table: "PCs");

            migrationBuilder.DropIndex(
                name: "IX_PCs_UserId",
                table: "PCs");

            migrationBuilder.DropColumn(
                name: "MemoryId",
                table: "PCs");

            migrationBuilder.DropColumn(
                name: "NumberOfMemorySticks",
                table: "PCs");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "PCs",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "PCs",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PCsMemories",
                columns: table => new
                {
                    MemoryId = table.Column<int>(nullable: false),
                    PCId = table.Column<int>(nullable: false),
                    NumberOfMemorySticks = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCsMemories", x => new { x.MemoryId, x.PCId });
                    table.ForeignKey(
                        name: "FK_PCsMemories_Memory_MemoryId",
                        column: x => x.MemoryId,
                        principalTable: "Memory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PCsMemories_PCs_PCId",
                        column: x => x.PCId,
                        principalTable: "PCs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PCs_UserId1",
                table: "PCs",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_PCsMemories_PCId",
                table: "PCsMemories",
                column: "PCId");

            migrationBuilder.AddForeignKey(
                name: "FK_PCs_AspNetUsers_UserId1",
                table: "PCs",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
