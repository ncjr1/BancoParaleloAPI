﻿// <auto-generated />
using System;
using BancoParaleloAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BancoParaleloAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221009195638_UpdateTableEndereco")]
    partial class UpdateTableEndereco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BancoParaleloAPI.Entidades.Cidade", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<long>("IBGE")
                        .HasColumnType("bigint")
                        .HasColumnName("ibge");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.Property<long>("UF")
                        .HasColumnType("bigint")
                        .HasColumnName("uf");

                    b.HasKey("id");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("BancoParaleloAPI.Entidades.Endereco", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Cidade")
                        .HasColumnType("bigint");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Estado")
                        .HasColumnType("bigint");

                    b.Property<long>("Numero")
                        .HasColumnType("bigint");

                    b.Property<long?>("Pais")
                        .HasColumnType("bigint");

                    b.Property<string>("Rua")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("BancoParaleloAPI.Entidades.Estado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("DDD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ddd");

                    b.Property<int>("IBGE")
                        .HasColumnType("int")
                        .HasColumnName("ibge");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.Property<int>("Pais")
                        .HasColumnType("int")
                        .HasColumnName("pais");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("uf");

                    b.HasKey("id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("BancoParaleloAPI.Entidades.Pais", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("Bacen")
                        .HasColumnType("int")
                        .HasColumnName("bacen");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.Property<string>("NomeEmPortugues")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome_pt");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("sigla");

                    b.HasKey("id");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("BancoParaleloAPI.Entidades.Transacao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("ContaDestino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContaOrigem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Valor")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Transacoes");
                });

            modelBuilder.Entity("BancoParaleloAPI.Entidades.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("EnderecoId")
                        .HasColumnType("bigint");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("TipoDeConta")
                        .HasColumnType("bigint");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("BancoParaleloAPI.Entidades.Usuario", b =>
                {
                    b.HasOne("BancoParaleloAPI.Entidades.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.Navigation("Endereco");
                });
#pragma warning restore 612, 618
        }
    }
}
