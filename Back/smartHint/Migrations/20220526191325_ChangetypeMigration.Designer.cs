﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using smartHint;

#nullable disable

namespace smartHint.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220526191325_ChangetypeMigration")]
    partial class ChangetypeMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("smartHint.Models.Fisica", b =>
                {
                    b.Property<long>("FisicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("Cpf")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("FisicaId");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.ToTable("Fisicas");
                });

            modelBuilder.Entity("smartHint.Models.Juridico", b =>
                {
                    b.Property<long>("JuridicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("Cnpj")
                        .HasColumnType("int");

                    b.Property<int>("InscricaoEstadual")
                        .HasColumnType("int");

                    b.HasKey("JuridicoId");

                    b.HasIndex("Cnpj", "InscricaoEstadual")
                        .IsUnique();

                    b.ToTable("Juridicos");
                });

            modelBuilder.Entity("smartHint.Models.Loja", b =>
                {
                    b.Property<long>("LojaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("LojaId");

                    b.ToTable("Lojas");
                });

            modelBuilder.Entity("smartHint.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Bloqueado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<long>("FisicaId")
                        .HasColumnType("bigint");

                    b.Property<long>("JuridicoId")
                        .HasColumnType("bigint");

                    b.Property<long>("LojaId")
                        .HasColumnType("bigint");

                    b.Property<string>("NomeRazaoSocial")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("varchar(18)");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.Property<int>("TipoPessoa")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("FisicaId");

                    b.HasIndex("JuridicoId");

                    b.HasIndex("LojaId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("smartHint.Models.User", b =>
                {
                    b.HasOne("smartHint.Models.Fisica", "Fisica")
                        .WithMany()
                        .HasForeignKey("FisicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("smartHint.Models.Juridico", "Juridico")
                        .WithMany()
                        .HasForeignKey("JuridicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("smartHint.Models.Loja", "Loja")
                        .WithMany("Users")
                        .HasForeignKey("LojaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fisica");

                    b.Navigation("Juridico");

                    b.Navigation("Loja");
                });

            modelBuilder.Entity("smartHint.Models.Loja", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
