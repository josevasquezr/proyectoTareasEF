using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoTareasEF.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[,]
                {
                    { new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac23"), null, "Actividades Laborales", 50 },
                    { new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac24"), null, "Actividades Personales", 30 },
                    { new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac25"), null, "Actividades Familiares", 20 },
                    { new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac26"), null, "Servicios Públicos", 80 }
                });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "FechaHoraRecordatorio", "PrioridadTarea", "Recordatorio", "Titulo" },
                values: new object[,]
                {
                    { new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac27"), new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac23"), null, new DateTime(2022, 5, 22, 5, 56, 0, 39, DateTimeKind.Local).AddTicks(429), null, 1, false, "Revisión de documentación SIISAR" },
                    { new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac28"), new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac24"), null, new DateTime(2022, 5, 22, 5, 56, 0, 39, DateTimeKind.Local).AddTicks(450), null, 0, false, "Ver pelicula Batman en HBO" },
                    { new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac29"), new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac25"), null, new DateTime(2022, 5, 22, 5, 56, 0, 39, DateTimeKind.Local).AddTicks(454), new DateTime(2022, 12, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 0, true, "Viaje Roatán" },
                    { new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac30"), new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac26"), null, new DateTime(2022, 5, 22, 5, 56, 0, 39, DateTimeKind.Local).AddTicks(562), new DateTime(2022, 5, 29, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, true, "Pago de energia eléctrica" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac27"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac28"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac29"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac30"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac23"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac24"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac25"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("c88ff4bc-6a99-48ee-95f5-848fc205ac26"));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
