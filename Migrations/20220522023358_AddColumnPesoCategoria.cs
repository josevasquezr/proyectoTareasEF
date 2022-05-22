using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyectoTareasEF.Migrations
{
    public partial class AddColumnPesoCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Peso",
                table: "Categoria",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Peso",
                table: "Categoria");
        }
    }
}
