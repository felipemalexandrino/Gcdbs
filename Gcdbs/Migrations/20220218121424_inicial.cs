using Microsoft.EntityFrameworkCore.Migrations;

namespace Gcdbs.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Montadoras",
                columns: table => new
                {
                    IdMontadora = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeMontadora = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Montadoras", x => x.IdMontadora);
                });

            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    IdModelo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeModelo = table.Column<string>(nullable: true),
                    MontadoraIdMontadora = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.IdModelo);
                    table.ForeignKey(
                        name: "FK_Modelos_Montadoras_MontadoraIdMontadora",
                        column: x => x.MontadoraIdMontadora,
                        principalTable: "Montadoras",
                        principalColumn: "IdMontadora",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_MontadoraIdMontadora",
                table: "Modelos",
                column: "MontadoraIdMontadora");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropTable(
                name: "Montadoras");
        }
    }
}
