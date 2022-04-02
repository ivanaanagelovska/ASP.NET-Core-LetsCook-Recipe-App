using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LetsCook.Data.Migrations
{
    public partial class removePropertyFromRecipeIngredient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "RecipeIngredients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Test",
                table: "RecipeIngredients",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
