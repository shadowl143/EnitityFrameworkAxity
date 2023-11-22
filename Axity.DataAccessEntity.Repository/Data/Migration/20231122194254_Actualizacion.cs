

#nullable disable

namespace Axity.DataAccessEntity.Entities.Data.Migration
{
    using Microsoft.EntityFrameworkCore.Migrations;
    public partial class Actualizacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastName", "Mail", "Name", "Password", "SecondLastName", "UserName" },
                values: new object[] { "Last", "Mail", "Name", "Password", "SecondLastName", "Mail" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastName", "Mail", "Name", "Password", "SecondLastName", "UserName" },
                values: new object[] { "user", "user", "user", "user", "user", "user" });
        }
    }
}
