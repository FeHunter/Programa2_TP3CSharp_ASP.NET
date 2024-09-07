using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Programa2_TP3CSharp_ASP.NET.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    PessoaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Nacionalidade = table.Column<string>(type: "TEXT", nullable: false),
                    Idade = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.PessoaId);
                });

            migrationBuilder.CreateTable(
                name: "Passaportes",
                columns: table => new
                {
                    PassaportId = table.Column<int>(type: "INTEGER", nullable: false),
                    PassaportType = table.Column<string>(type: "TEXT", nullable: false),
                    PaisDeOrigem = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passaportes", x => x.PassaportId);
                    table.ForeignKey(
                        name: "FK_Passaportes_Pessoas_PassaportId",
                        column: x => x.PassaportId,
                        principalTable: "Pessoas",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passaportes");

            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
