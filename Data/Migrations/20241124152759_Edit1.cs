using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Edit1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Disctiption",
                table: "Posts",
                newName: "Discription");

            migrationBuilder.RenameColumn(
                name: "Contect",
                table: "Posts",
                newName: "Content");

            migrationBuilder.AddColumn<int>(
                name: "AnswerId",
                table: "Comments",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "Discription",
                table: "Posts",
                newName: "Disctiption");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Posts",
                newName: "Contect");
        }
    }
}
