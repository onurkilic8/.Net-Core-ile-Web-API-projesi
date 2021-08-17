using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Urunlers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    grup_no = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    urun_no = table.Column<int>(type: "int", nullable: false),
                    urun_adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    marka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gramaj = table.Column<int>(type: "int", nullable: false),
                    fiyat = table.Column<int>(type: "int", nullable: false),
                    puan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunlers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Urunlers");
        }
    }
}
