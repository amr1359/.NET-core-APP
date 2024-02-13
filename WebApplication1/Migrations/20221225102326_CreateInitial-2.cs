using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class CreateInitial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Place",
                table: "SuperHeroes",
                newName: "Username");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Jdate",
                table: "SuperHeroes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "SuperHeroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "SuperHeroes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Jdate",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "SuperHeroes");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "SuperHeroes",
                newName: "Place");
        }
    }
}
