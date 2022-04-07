using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LetsCook.Data.Migrations
{
    public partial class RemoveRecipeColumnRestTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestTime",
                table: "Recipes");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "CookingTime",
                table: "Recipes",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "CookingTime",
                table: "Recipes",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "RestTime",
                table: "Recipes",
                type: "time",
                nullable: true);
        }
    }
}
