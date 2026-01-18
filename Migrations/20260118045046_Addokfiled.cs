using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfcorePractice.Migrations
{
    /// <inheritdoc />
    public partial class Addokfiled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ok",
                table: "students_details",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ok",
                table: "students_details");
        }
    }
}
