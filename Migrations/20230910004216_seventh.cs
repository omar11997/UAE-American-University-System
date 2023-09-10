using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UAE_American_University.Migrations
{
    /// <inheritdoc />
    public partial class seventh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Answer",
                table: "Questions",
                newName: "RightAnswer");

            migrationBuilder.AddColumn<List<string>>(
                name: "Asnwers",
                table: "StudentExams",
                type: "text[]",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "OptionalAnswer",
                table: "Questions",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Asnwers",
                table: "StudentExams");

            migrationBuilder.DropColumn(
                name: "OptionalAnswer",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "RightAnswer",
                table: "Questions",
                newName: "Answer");
        }
    }
}
