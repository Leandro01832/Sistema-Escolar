using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaEscolar.Migrations
{
    public partial class removendo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_TurmaAluno_Id",
                table: "TurmaAluno");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TurmaAluno");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TurmaAluno",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_TurmaAluno_Id",
                table: "TurmaAluno",
                column: "Id");
        }
    }
}
