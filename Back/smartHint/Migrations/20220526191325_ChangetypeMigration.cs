using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smartHint.Migrations
{
    public partial class ChangetypeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fisica_User_UserId",
                table: "Fisica");

            migrationBuilder.DropForeignKey(
                name: "FK_Juridico_User_UserId",
                table: "Juridico");

            migrationBuilder.DropForeignKey(
                name: "FK_Loja_User_UserId",
                table: "Loja");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Loja",
                table: "Loja");

            migrationBuilder.DropIndex(
                name: "IX_Loja_UserId",
                table: "Loja");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Juridico",
                table: "Juridico");

            migrationBuilder.DropIndex(
                name: "IX_Juridico_UserId",
                table: "Juridico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fisica",
                table: "Fisica");

            migrationBuilder.DropIndex(
                name: "IX_Fisica_UserId",
                table: "Fisica");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Loja");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Juridico");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Fisica");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Loja",
                newName: "Lojas");

            migrationBuilder.RenameTable(
                name: "Juridico",
                newName: "Juridicos");

            migrationBuilder.RenameTable(
                name: "Fisica",
                newName: "Fisicas");

            migrationBuilder.RenameColumn(
                name: "tipoPessoa",
                table: "Users",
                newName: "TipoPessoa");

            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "Users",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "nomeRazaoSocial",
                table: "Users",
                newName: "NomeRazaoSocial");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "dataCadastro",
                table: "Users",
                newName: "DataCadastro");

            migrationBuilder.RenameColumn(
                name: "bloqueado",
                table: "Users",
                newName: "Bloqueado");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_User_email",
                table: "Users",
                newName: "IX_Users_Email");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Lojas",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Lojas",
                newName: "LojaId");

            migrationBuilder.RenameColumn(
                name: "inscricaoEstadual",
                table: "Juridicos",
                newName: "InscricaoEstadual");

            migrationBuilder.RenameColumn(
                name: "cnpj",
                table: "Juridicos",
                newName: "Cnpj");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Juridicos",
                newName: "JuridicoId");

            migrationBuilder.RenameIndex(
                name: "IX_Juridico_cnpj_inscricaoEstadual",
                table: "Juridicos",
                newName: "IX_Juridicos_Cnpj_InscricaoEstadual");

            migrationBuilder.RenameColumn(
                name: "genero",
                table: "Fisicas",
                newName: "Genero");

            migrationBuilder.RenameColumn(
                name: "dataNascimento",
                table: "Fisicas",
                newName: "DataNascimento");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Fisicas",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Fisicas",
                newName: "FisicaId");

            migrationBuilder.RenameIndex(
                name: "IX_Fisica_cpf",
                table: "Fisicas",
                newName: "IX_Fisicas_Cpf");

            migrationBuilder.AlterColumn<int>(
                name: "TipoPessoa",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(18)",
                oldMaxLength: 18)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<int>(
                name: "Telefone",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)",
                oldMaxLength: 150)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "varchar(18)",
                maxLength: 18,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "NomeRazaoSocial",
                table: "Users",
                type: "varchar(150)",
                maxLength: 150,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AddColumn<long>(
                name: "FisicaId",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "JuridicoId",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LojaId",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<int>(
                name: "InscricaoEstadual",
                table: "Juridicos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(18)",
                oldMaxLength: 18)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<int>(
                name: "Cnpj",
                table: "Juridicos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Genero",
                table: "Fisicas",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(14)",
                oldMaxLength: 14)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<int>(
                name: "Cpf",
                table: "Fisicas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lojas",
                table: "Lojas",
                column: "LojaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Juridicos",
                table: "Juridicos",
                column: "JuridicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fisicas",
                table: "Fisicas",
                column: "FisicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_FisicaId",
                table: "Users",
                column: "FisicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_JuridicoId",
                table: "Users",
                column: "JuridicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_LojaId",
                table: "Users",
                column: "LojaId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Lojas_LojaId",
                table: "Users",
                column: "LojaId",
                principalTable: "Lojas",
                principalColumn: "LojaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Fisicas_FisicaId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Juridicos_JuridicoId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Lojas_LojaId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_FisicaId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_JuridicoId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_LojaId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lojas",
                table: "Lojas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Juridicos",
                table: "Juridicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fisicas",
                table: "Fisicas");

            migrationBuilder.DropColumn(
                name: "FisicaId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "JuridicoId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LojaId",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Lojas",
                newName: "Loja");

            migrationBuilder.RenameTable(
                name: "Juridicos",
                newName: "Juridico");

            migrationBuilder.RenameTable(
                name: "Fisicas",
                newName: "Fisica");

            migrationBuilder.RenameColumn(
                name: "TipoPessoa",
                table: "User",
                newName: "tipoPessoa");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "User",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "User",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "NomeRazaoSocial",
                table: "User",
                newName: "nomeRazaoSocial");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "User",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "DataCadastro",
                table: "User",
                newName: "dataCadastro");

            migrationBuilder.RenameColumn(
                name: "Bloqueado",
                table: "User",
                newName: "bloqueado");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "User",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Email",
                table: "User",
                newName: "IX_User_email");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Loja",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "LojaId",
                table: "Loja",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "InscricaoEstadual",
                table: "Juridico",
                newName: "inscricaoEstadual");

            migrationBuilder.RenameColumn(
                name: "Cnpj",
                table: "Juridico",
                newName: "cnpj");

            migrationBuilder.RenameColumn(
                name: "JuridicoId",
                table: "Juridico",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Juridicos_Cnpj_InscricaoEstadual",
                table: "Juridico",
                newName: "IX_Juridico_cnpj_inscricaoEstadual");

            migrationBuilder.RenameColumn(
                name: "Genero",
                table: "Fisica",
                newName: "genero");

            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "Fisica",
                newName: "dataNascimento");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Fisica",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "FisicaId",
                table: "Fisica",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Fisicas_Cpf",
                table: "Fisica",
                newName: "IX_Fisica_cpf");

            migrationBuilder.AlterColumn<string>(
                name: "tipoPessoa",
                table: "User",
                type: "varchar(18)",
                maxLength: 18,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "telefone",
                table: "User",
                type: "varchar(150)",
                maxLength: 150,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "User",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(18)",
                oldMaxLength: 18)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "nomeRazaoSocial",
                table: "User",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(150)",
                oldMaxLength: 150)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Loja",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "inscricaoEstadual",
                table: "Juridico",
                type: "varchar(18)",
                maxLength: 18,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cnpj",
                table: "Juridico",
                type: "varchar(255)",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Juridico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "genero",
                table: "Fisica",
                type: "varchar(14)",
                maxLength: 14,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "Fisica",
                type: "varchar(255)",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Fisica",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Loja",
                table: "Loja",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Juridico",
                table: "Juridico",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fisica",
                table: "Fisica",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Loja_UserId",
                table: "Loja",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Juridico_UserId",
                table: "Juridico",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Fisica_UserId",
                table: "Fisica",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fisica_User_UserId",
                table: "Fisica",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Juridico_User_UserId",
                table: "Juridico",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loja_User_UserId",
                table: "Loja",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
