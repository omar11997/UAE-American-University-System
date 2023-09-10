using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UAE_American_University.Migrations
{
    /// <inheritdoc />
    public partial class fifth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<List<string>>(
                name: "Answers",
                table: "Questions",
                type: "text[]",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "QuetionScore",
                table: "Questions",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answers",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuetionScore",
                table: "Questions");
        }
    }
}
