using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgenciaMareSol.Migrations
{
    public partial class Foreignkeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinoId",
                table: "Promoções",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Destino_Id",
                table: "Promoções",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Contato_Id",
                table: "Passagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Promocao_Id",
                table: "Passagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Promoções_DestinoId",
                table: "Promoções",
                column: "DestinoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Promoções_Destinos_DestinoId",
                table: "Promoções",
                column: "DestinoId",
                principalTable: "Destinos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Promoções_Destinos_DestinoId",
                table: "Promoções");

            migrationBuilder.DropIndex(
                name: "IX_Promoções_DestinoId",
                table: "Promoções");

            migrationBuilder.DropColumn(
                name: "DestinoId",
                table: "Promoções");

            migrationBuilder.DropColumn(
                name: "Destino_Id",
                table: "Promoções");

            migrationBuilder.DropColumn(
                name: "Contato_Id",
                table: "Passagens");

            migrationBuilder.DropColumn(
                name: "Promocao_Id",
                table: "Passagens");
        }
    }
}
