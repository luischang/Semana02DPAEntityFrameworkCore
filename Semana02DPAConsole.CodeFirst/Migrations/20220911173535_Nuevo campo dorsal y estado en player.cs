using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Semana02DPAConsole.CodeFirst.Migrations
{
    public partial class Nuevocampodorsalyestadoenplayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dorsal",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Player",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dorsal",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Player");
        }
    }
}
