
#nullable disable

namespace Axity.DataAccessEntity.Entities.Data.Migration
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class Actions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Act");

            migrationBuilder.CreateTable(
                name: "Actions",
                schema: "Act",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActSubPages",
                schema: "Act",
                columns: table => new
                {
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    FkPage = table.Column<int>(type: "int", nullable: true),
                    SubModuleId = table.Column<int>(type: "int", nullable: true),
                    ActionsId = table.Column<int>(type: "int", nullable: true),
                    SubMenuId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ActSubPages_Actions_ActionsId",
                        column: x => x.ActionsId,
                        principalSchema: "Act",
                        principalTable: "Actions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ActSubPages_Pages_FkPage",
                        column: x => x.FkPage,
                        principalTable: "Pages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ActSubPages_subMenus_SubMenuId",
                        column: x => x.SubMenuId,
                        principalTable: "subMenus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActSubPages_ActionsId",
                schema: "Act",
                table: "ActSubPages",
                column: "ActionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ActSubPages_FkPage",
                schema: "Act",
                table: "ActSubPages",
                column: "FkPage");

            migrationBuilder.CreateIndex(
                name: "IX_ActSubPages_SubMenuId",
                schema: "Act",
                table: "ActSubPages",
                column: "SubMenuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActSubPages",
                schema: "Act");

            migrationBuilder.DropTable(
                name: "Actions",
                schema: "Act");
        }
    }
}
