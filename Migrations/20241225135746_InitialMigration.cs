using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PolimedicaSite.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriaDescripition = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarcaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarcaDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagemMarca = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProduto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detalhes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Preco = table.Column<long>(type: "bigint", nullable: false),
                    Estoque = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateOnly>(type: "date", nullable: false),
                    Imagem1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagem2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagem3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagem4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagem5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
