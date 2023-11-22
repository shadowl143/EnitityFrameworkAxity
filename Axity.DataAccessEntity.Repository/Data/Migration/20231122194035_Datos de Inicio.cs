
#nullable disable

namespace Axity.DataAccessEntity.Entities.Data.Migration
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class DatosdeInicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Roles");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "subMenus",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Pages",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Menus",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Code", "Icon", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "menu", "menu", "menu", true },
                    { 2, "menu 1", "menu 1", "menu 1", true },
                    { 3, "menu 2", "menu 2", "menu 2", true },
                    { 4, "menu 3", "menu 3", "menu 3", true },
                    { 5, "menu 4", "menu 4", "menu 4", true }
                });

            migrationBuilder.InsertData(
                table: "UserRols",
                columns: new[] { "RolId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "LastName", "Mail", "Name", "Password", "Phone", "RegisterDate", "SecondLastName", "Status", "UserName" },
                values: new object[,]
                {
                    { 1, "user", "user", "user", "user", "123456789", new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "user", true, "user" },
                    { 2, "user1", "user1", "user1", "user1", "123456788", new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1", true, "user1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserRols",
                keyColumns: new[] { "RolId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "UserRols",
                keyColumns: new[] { "RolId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "UserRols",
                keyColumns: new[] { "RolId", "UserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "subMenus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
