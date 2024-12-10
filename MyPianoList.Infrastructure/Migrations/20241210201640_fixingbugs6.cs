using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPianoList.UI.Migrations
{
    /// <inheritdoc />
    public partial class fixingbugs6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SheetId",
                table: "PianoSheetTag",
                newName: "PianoSheetId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Rating",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_UserId",
                table: "Rating",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_AspNetUsers_UserId",
                table: "Rating",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rating_AspNetUsers_UserId",
                table: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_Rating_UserId",
                table: "Rating");

            migrationBuilder.RenameColumn(
                name: "PianoSheetId",
                table: "PianoSheetTag",
                newName: "SheetId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Rating",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
