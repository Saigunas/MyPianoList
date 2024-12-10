using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPianoList.UI.Migrations
{
    /// <inheritdoc />
    public partial class fixingbugs4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_Status_PianoSheet_PianoSheetId",
                table: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Status_PianoSheetId",
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

            migrationBuilder.DropColumn(
                name: "SheetId",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "RatingDate",
                table: "Rating");

            migrationBuilder.DropColumn(
                name: "SheetId",
                table: "Rating");

            migrationBuilder.DropColumn(
                name: "PianoSheetId",
                table: "PianoSheetTag");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Status",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Rating",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Status",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "SheetId",
                table: "Status",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Rating",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "RatingDate",
                table: "Rating",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SheetId",
                table: "Rating",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PianoSheetId",
                table: "PianoSheetTag",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Status_PianoSheetId",
                table: "Status",
                column: "PianoSheetId");

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
                name: "FK_Status_PianoSheet_PianoSheetId",
                table: "Status",
                column: "PianoSheetId",
                principalTable: "PianoSheet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
