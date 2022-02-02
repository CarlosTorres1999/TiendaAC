using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManagerAC.Data.Migrations
{
    public partial class Venta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescripcionVenta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volumen = table.Column<double>(type: "float", nullable: false),
                    VolumenEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecioUnitario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cantidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Venta");
        }
    }
}
