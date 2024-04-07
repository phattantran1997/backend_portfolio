using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend_portfolio.Migrations
{
    /// <inheritdoc />
    public partial class UpdateExperienceTableAdd2NewPropertiesTypeAndImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "Experiences",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "Experiences",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "type",
                table: "Experiences");
        }
    }
}
