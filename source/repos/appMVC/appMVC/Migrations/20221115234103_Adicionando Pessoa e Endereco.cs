using Microsoft.EntityFrameworkCore.Migrations;

namespace appMVC.Migrations
{
    public partial class AdicionandoPessoaeEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "mdlPessoaId",
                table: "Enderecos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_mdlPessoaId",
                table: "Enderecos",
                column: "mdlPessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Pessoas_mdlPessoaId",
                table: "Enderecos",
                column: "mdlPessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Pessoas_mdlPessoaId",
                table: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_mdlPessoaId",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "mdlPessoaId",
                table: "Enderecos");
        }
    }
}
