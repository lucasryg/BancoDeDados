using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Senai.InLock.WebApi.CodeFirst.Migrations
{
    public partial class CriaBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudio",
                columns: table => new
                {
                    IdEstudio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeEstudio = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudio", x => x.IdEstudio);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuario",
                columns: table => new
                {
                    IdTipoUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "VARCHAR(225)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuario", x => x.IdTipoUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "varchar(255)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(255)", maxLength: 30, nullable: false),
                    IdTipoUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Jogo",
                columns: table => new
                {
                    IdJogo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeJogo = table.Column<string>(type: "varchar(255)", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    DataDeLancamento = table.Column<DateTime>(type: "DATE", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdEstudio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogo", x => x.IdJogo);
                    table.ForeignKey(
                        name: "FK_Jogo_Estudio_IdEstudio",
                        column: x => x.IdEstudio,
                        principalTable: "Estudio",
                        principalColumn: "IdEstudio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Estudio",
                columns: new[] { "IdEstudio", "NomeEstudio" },
                values: new object[,]
                {
                    { 1, "Blizzard" },
                    { 2, "Rockstar Studios" },
                    { 3, "Square Enix" }
                });

            migrationBuilder.InsertData(
                table: "TipoUsuario",
                columns: new[] { "IdTipoUsuario", "Titulo" },
                values: new object[,]
                {
                    { 1, "Administrador" },
                    { 2, "Cliente" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "Email", "IdTipoUsuario", "Senha" },
                values: new object[,]
                {
                    { 1, "admin@admin.com", 1, "admin" },
                    { 2, "cliente@cliente.com", 2, "clinete" }
                });

            migrationBuilder.InsertData(
                table: "Jogo",
                columns: new[] { "IdJogo", "DataDeLancamento", "Descricao", "IdEstudio", "NomeJogo", "Preco" },
                values: new object[] { 1, new DateTime(2012, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "É um jogo que contém bastante ação e é viciante, seja você gamer ou não", 1, "Diablo 3 ", 90.00m });

            migrationBuilder.InsertData(
                table: "Jogo",
                columns: new[] { "IdJogo", "DataDeLancamento", "Descricao", "IdEstudio", "NomeJogo", "Preco" },
                values: new object[] { 2, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jogo eletrônico de ação-aventura western", 2, "Red Dead Redemption II", 120.00m });

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_IdEstudio",
                table: "Jogo",
                column: "IdEstudio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogo");

            migrationBuilder.DropTable(
                name: "TipoUsuario");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Estudio");
        }
    }
}
