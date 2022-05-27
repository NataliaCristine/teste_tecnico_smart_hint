using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smartHint.Migrations
{
    public partial class Alterlongs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Fisicas_FisicaId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Juridicos_JuridicoId",
                table: "Users");

            migrationBuilder.AlterColumn<long>(
                name: "Telefone",
                table: "Users",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "JuridicoId",
                table: "Users",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "FisicaId",
                table: "Users",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "InscricaoEstadual",
                table: "Juridicos",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "Cnpj",
                table: "Juridicos",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "Cpf",
                table: "Fisicas",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Fisicas_FisicaId",
                table: "Users",
                column: "FisicaId",
                principalTable: "Fisicas",
                principalColumn: "FisicaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Juridicos_JuridicoId",
                table: "Users",
                column: "JuridicoId",
                principalTable: "Juridicos",
                principalColumn: "JuridicoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Fisicas_FisicaId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Juridicos_JuridicoId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "Telefone",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "JuridicoId",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "FisicaId",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InscricaoEstadual",
                table: "Juridicos",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Cnpj",
                table: "Juridicos",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Cpf",
                table: "Fisicas",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Fisicas_FisicaId",
                table: "Users",
                column: "FisicaId",
                principalTable: "Fisicas",
                principalColumn: "FisicaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Juridicos_JuridicoId",
                table: "Users",
                column: "JuridicoId",
                principalTable: "Juridicos",
                principalColumn: "JuridicoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
