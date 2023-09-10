using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UAE_American_University.Migrations
{
    /// <inheritdoc />
    public partial class fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Exams");

            migrationBuilder.AddColumn<int>(
                name: "TotalDegree",
                table: "Exams",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalDegree",
                table: "Exams");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Exams",
                type: "text",
                nullable: true);
        }
    }
}
