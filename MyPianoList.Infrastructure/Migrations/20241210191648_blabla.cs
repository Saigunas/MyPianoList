using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPianoList.UI.Migrations
{
    /// <inheritdoc />
    public partial class blabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "PianoSheet");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "PianoSheet");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "PianoSheet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "PianoSheet",
                type: "NVARCHAR(2000)",
                nullable: false,
                defaultValue: "");
        }
    }
}
