using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NETCOREM3_CodeFirst.Migrations
{
    public partial class VehiculoFecha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "vehiculoFecha",
                table: "Vehiculos",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "vehiculoFecha",
                table: "Vehiculos");
        }
    }
}
