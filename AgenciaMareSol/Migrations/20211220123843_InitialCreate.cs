using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgenciaMareSol.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sobrenome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Destinos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cidade = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Preco = table.Column<double>(type: "float", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promoções",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataViagem = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promoções", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ContatoId = table.Column<int>(type: "int", nullable: true),
                    PromocaoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passagens_Contatos_ContatoId",
                        column: x => x.ContatoId,
                        principalTable: "Contatos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Passagens_Promoções_PromocaoId",
                        column: x => x.PromocaoId,
                        principalTable: "Promoções",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passagens_ContatoId",
                table: "Passagens",
                column: "ContatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Passagens_PromocaoId",
                table: "Passagens",
                column: "PromocaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinos");

            migrationBuilder.DropTable(
                name: "Passagens");

            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Promoções");
        }
    }
}
