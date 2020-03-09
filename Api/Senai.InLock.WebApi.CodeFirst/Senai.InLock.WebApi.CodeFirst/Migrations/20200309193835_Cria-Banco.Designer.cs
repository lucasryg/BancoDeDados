﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Senai.InLock.WebApi.CodeFirst.Contexts;

namespace Senai.InLock.WebApi.CodeFirst.Migrations
{
    [DbContext(typeof(InLockContext))]
    [Migration("20200309193835_Cria-Banco")]
    partial class CriaBanco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Senai.InLock.WebApi.CodeFirst.Domains.Estudio", b =>
                {
                    b.Property<int>("IdEstudio")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeEstudio")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("IdEstudio");

                    b.ToTable("Estudio");

                    b.HasData(
                        new { IdEstudio = 1, NomeEstudio = "Blizzard" },
                        new { IdEstudio = 2, NomeEstudio = "Rockstar Studios" },
                        new { IdEstudio = 3, NomeEstudio = "Square Enix" }
                    );
                });

            modelBuilder.Entity("Senai.InLock.WebApi.CodeFirst.Domains.Jogo", b =>
                {
                    b.Property<int>("IdJogo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDeLancamento")
                        .HasColumnType("DATE");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IdEstudio");

                    b.Property<string>("NomeJogo")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<decimal>("Valor")
                        .HasColumnName("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdJogo");

                    b.HasIndex("IdEstudio");

                    b.ToTable("Jogo");

                    b.HasData(
                        new { IdJogo = 1, DataDeLancamento = new DateTime(2012, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), Descricao = "É um jogo que contém bastante ação e é viciante, seja você gamer ou não", IdEstudio = 1, NomeJogo = "Diablo 3 ", Valor = 90.00m },
                        new { IdJogo = 2, DataDeLancamento = new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), Descricao = "Jogo eletrônico de ação-aventura western", IdEstudio = 2, NomeJogo = "Red Dead Redemption II", Valor = 120.00m }
                    );
                });

            modelBuilder.Entity("Senai.InLock.WebApi.CodeFirst.Domains.TipoUsuario", b =>
                {
                    b.Property<int>("IdTipoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(225)");

                    b.HasKey("IdTipoUsuario");

                    b.ToTable("TipoUsuario");

                    b.HasData(
                        new { IdTipoUsuario = 1, Titulo = "Administrador" },
                        new { IdTipoUsuario = 2, Titulo = "Cliente" }
                    );
                });

            modelBuilder.Entity("Senai.InLock.WebApi.CodeFirst.Domains.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("IdTipoUsuario");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(30);

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new { IdUsuario = 1, Email = "admin@admin.com", IdTipoUsuario = 1, Senha = "admin" },
                        new { IdUsuario = 2, Email = "cliente@cliente.com", IdTipoUsuario = 2, Senha = "clinete" }
                    );
                });

            modelBuilder.Entity("Senai.InLock.WebApi.CodeFirst.Domains.Jogo", b =>
                {
                    b.HasOne("Senai.InLock.WebApi.CodeFirst.Domains.Estudio", "estudio")
                        .WithMany("Jogos")
                        .HasForeignKey("IdEstudio")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}