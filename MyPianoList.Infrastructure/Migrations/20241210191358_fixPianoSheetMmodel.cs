using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPianoList.UI.Migrations
{
    /// <inheritdoc />
    public partial class fixPianoSheetMmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "PianoSheet",
                type: "NVARCHAR(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2083)",
                oldMaxLength: 2083);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "PianoSheet",
                type: "NVARCHAR(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Composer",
                table: "PianoSheet",
                type: "NVARCHAR(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "PianoSheet",
                type: "nvarchar(2083)",
                maxLength: 2083,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "PianoSheet",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(200)");

            migrationBuilder.AlterColumn<string>(
                name: "Composer",
                table: "PianoSheet",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(200)");
        }
    }
}
