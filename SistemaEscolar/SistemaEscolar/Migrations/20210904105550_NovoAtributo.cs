using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaEscolar.Migrations
{
    public partial class NovoAtributo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "Horario",
                table: "Turma",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "Materias",
                table: "Turma",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Horario",
                table: "Turma");

            migrationBuilder.DropColumn(
                name: "Materias",
                table: "Turma");
        }
    }
}
