using Microsoft.EntityFrameworkCore.Migrations;

namespace appMVC.Migrations
{
    public partial class RelacionandoPessoaeEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_telefones",
                table: "telefones");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Pessoas");

            migrationBuilder.RenameTable(
                name: "telefones",
                newName: "Telefones");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Pessoas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TelefoneId",
                table: "Pessoas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefones",
                table: "Telefones",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_EnderecoId",
                table: "Pessoas",
                column: "EnderecoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_TelefoneId",
                table: "Pessoas",
                column: "TelefoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Enderecos_EnderecoId",
                table: "Pessoas",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Telefones_TelefoneId",
                table: "Pessoas",
                column: "TelefoneId",
                principalTable: "Telefones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Enderecos_EnderecoId",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Telefones_TelefoneId",
                table: "Pessoas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefones",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_EnderecoId",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_TelefoneId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "TelefoneId",
                table: "Pessoas");

            migrationBuilder.RenameTable(
                name: "Telefones",
                newName: "telefones");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Pessoas",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Pessoas",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_telefones",
                table: "telefones",
                column: "Id");
        }
    }
}
