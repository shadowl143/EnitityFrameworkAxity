
#nullable disable

namespace Axity.DataAccessEntity.Entities.Data.Migration
{
using Microsoft.EntityFrameworkCore.Migrations;
    public partial class Actualizaciondos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                schema: "act",
                table: "ActSubPages",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActSubPages",
                schema: "act",
                table: "ActSubPages",
                column: "Id");

            migrationBuilder.InsertData(
                schema: "act",
                table: "Actions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Alta" },
                    { 2, "Baja" },
                    { 3, "Cambios" },
                    { 4, "Actualizar" }
                });

            migrationBuilder.InsertData(
                table: "subMenus",
                columns: new[] { "Id", "Code", "Icon", "MenuId", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "submenu", "submenu", 1, "submenu", true },
                    { 2, "submenu 1", "submenu 1", 1, "submenu 1", true },
                    { 3, "submenu 4", "submenu 4", 2, "submenu 4", true },
                    { 4, "submenu 5", "submenu 5", 2, "submenu 5", true },
                    { 5, "submenu 6", "submenu 6", 3, "submenu 6", true },
                    { 6, "submenu 7", "submenu 7", 3, "submenu 7", true },
                    { 7, "submenu 8", "submenu 8", 4, "submenu 8", true },
                    { 8, "submenu 9", "submenu 9", 5, "submenu 9", true }
                });

            migrationBuilder.InsertData(
                schema: "act",
                table: "ActSubPages",
                columns: new[] { "Id", "ActionId", "ActionsId", "FkPage", "SubMenuId" },
                values: new object[,]
                {
                    { 1, 1, null, null, 1 },
                    { 2, 2, null, null, 1 },
                    { 3, 3, null, null, 1 },
                    { 4, 4, null, null, 1 },
                    { 5, 1, null, null, 2 },
                    { 6, 2, null, null, 2 },
                    { 7, 3, null, null, 2 },
                    { 8, 4, null, null, 2 },
                    { 9, 1, null, null, 3 },
                    { 10, 3, null, null, 3 },
                    { 11, 1, null, null, 4 },
                    { 12, 2, null, null, 4 },
                    { 13, 3, null, null, 4 },
                    { 14, 4, null, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Code", "Icon", "Name", "Status", "SubMenuId" },
                values: new object[,]
                {
                    { 1, "page", "page", "page", true, 4 },
                    { 2, "page 1", "page 1", "page 1", true, 4 },
                    { 3, "page 2", "page 2", "page 2", true, 4 },
                    { 4, "page 5", "page 5", "page 5", true, 4 },
                    { 5, "page 6", "page 6", "page 6", true, 4 },
                    { 6, "page 7", "page 7", "page 7", true, 4 }
                });

            migrationBuilder.InsertData(
                schema: "act",
                table: "ActSubPages",
                columns: new[] { "Id", "ActionId", "ActionsId", "FkPage", "SubMenuId" },
                values: new object[,]
                {
                    { 15, 1, null, 1, null },
                    { 16, 2, null, 1, null },
                    { 17, 3, null, 1, null },
                    { 18, 1, null, 2, null },
                    { 19, 2, null, 2, null },
                    { 20, 3, null, 2, null },
                    { 21, 4, null, 2, null },
                    { 22, 1, null, 3, null },
                    { 23, 2, null, 3, null },
                    { 24, 2, null, 4, null },
                    { 25, 3, null, 4, null },
                    { 26, 4, null, 4, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ActSubPages",
                schema: "act",
                table: "ActSubPages");

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "ActSubPages",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "Actions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "Actions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "Actions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "act",
                table: "Actions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "subMenus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "subMenus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "subMenus",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "subMenus",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "subMenus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "subMenus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "subMenus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "subMenus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Id",
                schema: "act",
                table: "ActSubPages");
        }
    }
}
