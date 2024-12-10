using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPianoList.UI.Migrations
{
    /// <inheritdoc />
    public partial class fixingbugs7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Status",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Status_PianoSheetId",
                table: "Status",
                column: "PianoSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_Status_UserId",
                table: "Status",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_PianoSheetId",
                table: "Rating",
                column: "PianoSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_PianoSheetTag_PianoSheetId",
                table: "PianoSheetTag",
                column: "PianoSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_PianoSheetTag_TagId",
                table: "PianoSheetTag",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_PianoSheetTag_PianoSheet_PianoSheetId",
                table: "PianoSheetTag",
                column: "PianoSheetId",
                principalTable: "PianoSheet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PianoSheetTag_Tag_TagId",
                table: "PianoSheetTag",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_PianoSheet_PianoSheetId",
                table: "Rating",
                column: "PianoSheetId",
                principalTable: "PianoSheet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Status_AspNetUsers_UserId",
                table: "Status",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Status_PianoSheet_PianoSheetId",
                table: "Status",
                column: "PianoSheetId",
                principalTable: "PianoSheet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PianoSheetTag_PianoSheet_PianoSheetId",
                table: "PianoSheetTag");

            migrationBuilder.DropForeignKey(
                name: "FK_PianoSheetTag_Tag_TagId",
                table: "PianoSheetTag");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_PianoSheet_PianoSheetId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Status_AspNetUsers_UserId",
                table: "Status");

            migrationBuilder.DropForeignKey(
                name: "FK_Status_PianoSheet_PianoSheetId",
                table: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Status_PianoSheetId",
                table: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Status_UserId",
                table: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Rating_PianoSheetId",
                table: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_PianoSheetTag_PianoSheetId",
                table: "PianoSheetTag");

            migrationBuilder.DropIndex(
                name: "IX_PianoSheetTag_TagId",
                table: "PianoSheetTag");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Status",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
