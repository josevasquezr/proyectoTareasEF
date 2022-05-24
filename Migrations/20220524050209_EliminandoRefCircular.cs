using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoTareasEF.Migrations
{
    public partial class EliminandoRefCircular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac27"),
                column: "FechaCreacion",
                value: new DateTime(2022, 5, 23, 23, 2, 8, 826, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac28"),
                column: "FechaCreacion",
                value: new DateTime(2022, 5, 23, 23, 2, 8, 826, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac29"),
                column: "FechaCreacion",
                value: new DateTime(2022, 5, 23, 23, 2, 8, 826, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac30"),
                column: "FechaCreacion",
                value: new DateTime(2022, 5, 23, 23, 2, 8, 826, DateTimeKind.Local).AddTicks(1353));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac27"),
                column: "FechaCreacion",
                value: new DateTime(2022, 5, 22, 5, 56, 0, 39, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac28"),
                column: "FechaCreacion",
                value: new DateTime(2022, 5, 22, 5, 56, 0, 39, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac29"),
                column: "FechaCreacion",
                value: new DateTime(2022, 5, 22, 5, 56, 0, 39, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac30"),
                column: "FechaCreacion",
                value: new DateTime(2022, 5, 22, 5, 56, 0, 39, DateTimeKind.Local).AddTicks(562));
        }
    }
}
