using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Migrations
{
    public partial class AddedTableReaderLibraries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReaderLibrary_Libraries_LibraryId",
                table: "ReaderLibrary");

            migrationBuilder.DropForeignKey(
                name: "FK_ReaderLibrary_Readers_ReaderId",
                table: "ReaderLibrary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReaderLibrary",
                table: "ReaderLibrary");

            migrationBuilder.RenameTable(
                name: "ReaderLibrary",
                newName: "ReaderLibraries");

            migrationBuilder.RenameIndex(
                name: "IX_ReaderLibrary_LibraryId",
                table: "ReaderLibraries",
                newName: "IX_ReaderLibraries_LibraryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReaderLibraries",
                table: "ReaderLibraries",
                columns: new[] { "ReaderId", "LibraryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ReaderLibraries_Libraries_LibraryId",
                table: "ReaderLibraries",
                column: "LibraryId",
                principalTable: "Libraries",
                principalColumn: "LibraryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReaderLibraries_Readers_ReaderId",
                table: "ReaderLibraries",
                column: "ReaderId",
                principalTable: "Readers",
                principalColumn: "ReaderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReaderLibraries_Libraries_LibraryId",
                table: "ReaderLibraries");

            migrationBuilder.DropForeignKey(
                name: "FK_ReaderLibraries_Readers_ReaderId",
                table: "ReaderLibraries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReaderLibraries",
                table: "ReaderLibraries");

            migrationBuilder.RenameTable(
                name: "ReaderLibraries",
                newName: "ReaderLibrary");

            migrationBuilder.RenameIndex(
                name: "IX_ReaderLibraries_LibraryId",
                table: "ReaderLibrary",
                newName: "IX_ReaderLibrary_LibraryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReaderLibrary",
                table: "ReaderLibrary",
                columns: new[] { "ReaderId", "LibraryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ReaderLibrary_Libraries_LibraryId",
                table: "ReaderLibrary",
                column: "LibraryId",
                principalTable: "Libraries",
                principalColumn: "LibraryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReaderLibrary_Readers_ReaderId",
                table: "ReaderLibrary",
                column: "ReaderId",
                principalTable: "Readers",
                principalColumn: "ReaderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
