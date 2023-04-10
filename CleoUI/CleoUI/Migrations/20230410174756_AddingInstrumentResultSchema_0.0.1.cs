using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleoUI.Migrations
{
    public partial class AddingInstrumentResultSchema_001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InstrumentResults",
                columns: table => new
                {
                    ResultID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstrumentID = table.Column<int>(type: "int", nullable: false),
                    WeeklyResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthlyResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstrumentResults", x => x.ResultID);
                });

            migrationBuilder.CreateTable(
                name: "Instruments",
                columns: table => new
                {
                    InstrumentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstrumentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstrumentCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstrumentURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruments", x => x.InstrumentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstrumentResults");

            migrationBuilder.DropTable(
                name: "Instruments");
        }
    }
}
