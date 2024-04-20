﻿// <auto-generated />
using System;
using BibliotecaImpacta.Models.SqlContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BibliotecaImpacta.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240225202128_initialMigration")]
    partial class initialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BibliotecaImpacta.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Terror"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Infanto Juvenil"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Romance"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Auto Ajuda"
                        });
                });

            modelBuilder.Entity("BibliotecaImpacta.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Endereço")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("BibliotecaImpacta.Models.Emprestimo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Confirmado")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<int>("LivroId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LivroId");

                    b.ToTable("Emprestimos");
                });

            modelBuilder.Entity("BibliotecaImpacta.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Editora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Livros");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ano = 2021,
                            Autor = "George Orwell",
                            CategoriaId = 2,
                            Editora = "Companhia das Letras",
                            Nome = "Revolução dos Bichos"
                        },
                        new
                        {
                            Id = 2,
                            Ano = 2012,
                            Autor = "Charles Duhigg",
                            CategoriaId = 4,
                            Editora = "Objetiva",
                            Nome = "O poder do hábito"
                        },
                        new
                        {
                            Id = 3,
                            Ano = 2017,
                            Autor = "Charlie Donlea",
                            CategoriaId = 1,
                            Editora = "Faro Editorial",
                            Nome = "A garota do lago"
                        });
                });

            modelBuilder.Entity("BibliotecaImpacta.Models.Cliente", b =>
                {
                    b.HasOne("BibliotecaImpacta.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("BibliotecaImpacta.Models.Emprestimo", b =>
                {
                    b.HasOne("BibliotecaImpacta.Models.Livro", "Livro")
                        .WithMany()
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("BibliotecaImpacta.Models.Livro", b =>
                {
                    b.HasOne("BibliotecaImpacta.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });
#pragma warning restore 612, 618
        }
    }
}
