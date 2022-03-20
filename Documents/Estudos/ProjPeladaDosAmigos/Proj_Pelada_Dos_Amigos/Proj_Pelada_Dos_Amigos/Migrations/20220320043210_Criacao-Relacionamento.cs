using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proj_Pelada_Dos_Amigos.Migrations
{
    public partial class CriacaoRelacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Times",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "time_id",
                table: "Jogadores",
                newName: "timeId");

            migrationBuilder.RenameColumn(
                name: "pote_id",
                table: "Jogadores",
                newName: "poteId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogadores_poteId",
                table: "Jogadores",
                column: "poteId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogadores_timeId",
                table: "Jogadores",
                column: "timeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogadores_Potes_poteId",
                table: "Jogadores",
                column: "poteId",
                principalTable: "Potes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogadores_Times_timeId",
                table: "Jogadores",
                column: "timeId",
                principalTable: "Times",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Potes_poteId",
                table: "Jogadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Times_timeId",
                table: "Jogadores");

            migrationBuilder.DropIndex(
                name: "IX_Jogadores_poteId",
                table: "Jogadores");

            migrationBuilder.DropIndex(
                name: "IX_Jogadores_timeId",
                table: "Jogadores");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Times",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "timeId",
                table: "Jogadores",
                newName: "time_id");

            migrationBuilder.RenameColumn(
                name: "poteId",
                table: "Jogadores",
                newName: "pote_id");
        }
    }
}
