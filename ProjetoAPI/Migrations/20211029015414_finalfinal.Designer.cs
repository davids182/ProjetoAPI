﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoAPI.Data;

namespace ProjetoAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211029015414_finalfinal")]
    partial class finalfinal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("ProjetoAPI.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("categoria")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("descricao")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("divisao")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<int>("estoque")
                        .HasColumnType("integer");

                    b.Property<string>("fornecedor")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("imagem")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("nome")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<DateTime>("reg_alt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("tamanho")
                        .HasMaxLength(4)
                        .HasColumnType("varchar(4)");

                    b.Property<string>("usuario_alt")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
