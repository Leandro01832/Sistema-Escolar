using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaEscolar.Migrations
{
    public partial class NovoAtributo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumeroSala",
                table: "Turma",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroSala",
                table: "Turma");
        }
    }
}
