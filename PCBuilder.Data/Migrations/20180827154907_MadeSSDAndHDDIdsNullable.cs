using Microsoft.EntityFrameworkCore.Migrations;

namespace PCBuilder.Data.Migrations
{
    public partial class MadeSSDAndHDDIdsNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PCs_HardDiskDrives_HardDiskDriveId",
                table: "PCs");

            migrationBuilder.DropForeignKey(
                name: "FK_PCs_SolidStateDrives_SolidStateDriveId",
                table: "PCs");

            migrationBuilder.AlterColumn<int>(
                name: "SolidStateDriveId",
                table: "PCs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "HardDiskDriveId",
                table: "PCs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_PCs_HardDiskDrives_HardDiskDriveId",
                table: "PCs",
                column: "HardDiskDriveId",
                principalTable: "HardDiskDrives",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PCs_SolidStateDrives_SolidStateDriveId",
                table: "PCs",
                column: "SolidStateDriveId",
                principalTable: "SolidStateDrives",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PCs_HardDiskDrives_HardDiskDriveId",
                table: "PCs");

            migrationBuilder.DropForeignKey(
                name: "FK_PCs_SolidStateDrives_SolidStateDriveId",
                table: "PCs");

            migrationBuilder.AlterColumn<int>(
                name: "SolidStateDriveId",
                table: "PCs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HardDiskDriveId",
                table: "PCs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PCs_HardDiskDrives_HardDiskDriveId",
                table: "PCs",
                column: "HardDiskDriveId",
                principalTable: "HardDiskDrives",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PCs_SolidStateDrives_SolidStateDriveId",
                table: "PCs",
                column: "SolidStateDriveId",
                principalTable: "SolidStateDrives",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
