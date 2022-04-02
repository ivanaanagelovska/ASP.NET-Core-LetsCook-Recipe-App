using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LetsCook.Data.Migrations
{
    public partial class UpdatedRecipeEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructions_SubRecipes_SubRecipeId",
                table: "Instructions");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_SubRecipes_SubRecipeId",
                table: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "SubRecipes");

            migrationBuilder.RenameColumn(
                name: "SubRecipeId",
                table: "RecipeIngredients",
                newName: "RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeIngredients_SubRecipeId",
                table: "RecipeIngredients",
                newName: "IX_RecipeIngredients_RecipeId");

            migrationBuilder.RenameColumn(
                name: "SubRecipeId",
                table: "Instructions",
                newName: "RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructions_SubRecipeId",
                table: "Instructions",
                newName: "IX_Instructions_RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructions_Recipes_RecipeId",
                table: "Instructions",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Recipes_RecipeId",
                table: "RecipeIngredients",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructions_Recipes_RecipeId",
                table: "Instructions");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Recipes_RecipeId",
                table: "RecipeIngredients");

            migrationBuilder.RenameColumn(
                name: "RecipeId",
                table: "RecipeIngredients",
                newName: "SubRecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeIngredients_RecipeId",
                table: "RecipeIngredients",
                newName: "IX_RecipeIngredients_SubRecipeId");

            migrationBuilder.RenameColumn(
                name: "RecipeId",
                table: "Instructions",
                newName: "SubRecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructions_RecipeId",
                table: "Instructions",
                newName: "IX_Instructions_SubRecipeId");

            migrationBuilder.CreateTable(
                name: "SubRecipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubRecipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubRecipes_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubRecipes_RecipeId",
                table: "SubRecipes",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructions_SubRecipes_SubRecipeId",
                table: "Instructions",
                column: "SubRecipeId",
                principalTable: "SubRecipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_SubRecipes_SubRecipeId",
                table: "RecipeIngredients",
                column: "SubRecipeId",
                principalTable: "SubRecipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
