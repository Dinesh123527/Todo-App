using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.API.Migrations
{
    /// <inheritdoc />
    public partial class Addeddeletepropertyfields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isCompleted",
                table: "Todos",
                newName: "IsCompleted");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Todos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Todos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Todos");

            migrationBuilder.RenameColumn(
                name: "IsCompleted",
                table: "Todos",
                newName: "isCompleted");
        }
    }
}
