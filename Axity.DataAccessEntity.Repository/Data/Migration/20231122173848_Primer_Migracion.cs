

#nullable disable

namespace Axity.DataAccessEntity.Entities.Data.Migration
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class Primer_Migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Pk_Rol = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", maxLength: 150, nullable: true),
                    Estado = table.Column<bool>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Pk_Rol);
                });

            migrationBuilder.CreateTable(
                name: "UserRols",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    RolId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRols", x => new { x.UserId, x.RolId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    SecondLastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Mail = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserRols");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
