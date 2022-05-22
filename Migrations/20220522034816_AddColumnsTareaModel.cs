using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoTareasEF.Migrations
{
    public partial class AddColumnsTareaModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaHoraRecordatorio",
                table: "Tarea",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Recordatorio",
                table: "Tarea",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaHoraRecordatorio",
                table: "Tarea");

            migrationBuilder.DropColumn(
                name: "Recordatorio",
                table: "Tarea");
        }
    }
}
