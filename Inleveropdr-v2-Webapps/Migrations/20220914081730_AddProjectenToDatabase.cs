using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inleveropdr_v2_Webapps.Migrations
{
    public partial class AddProjectenToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projecten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projectNaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    projectCategorie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    verdienstenBijAfronden = table.Column<int>(type: "int", nullable: false),
                    beschikbaarVanaf = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projecten", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projecten");
        }
    }
}
