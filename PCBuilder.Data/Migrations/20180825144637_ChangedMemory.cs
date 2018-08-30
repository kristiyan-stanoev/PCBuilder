using Microsoft.EntityFrameworkCore.Migrations;

namespace PCBuilder.Data.Migrations
{
    public partial class ChangedMemory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PCsMemories_Memories_MemoryId",
                table: "PCsMemories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Memories",
                table: "Memories");

            migrationBuilder.RenameTable(
                name: "Memories",
                newName: "Memory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Memory",
                table: "Memory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PCsMemories_Memory_MemoryId",
                table: "PCsMemories",
                column: "MemoryId",
                principalTable: "Memory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PCsMemories_Memory_MemoryId",
                table: "PCsMemories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Memory",
                table: "Memory");

            migrationBuilder.RenameTable(
                name: "Memory",
                newName: "Memories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Memories",
                table: "Memories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PCsMemories_Memories_MemoryId",
                table: "PCsMemories",
                column: "MemoryId",
                principalTable: "Memories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
