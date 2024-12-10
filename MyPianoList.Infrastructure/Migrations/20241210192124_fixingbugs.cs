using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPianoList.UI.Migrations
{
    /// <inheritdoc />
    public partial class fixingbugs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "PianoSheet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "PianoSheet",
                type: "NVARCHAR(2000)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "PianoSheet");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "PianoSheet");
        }
    }
}
