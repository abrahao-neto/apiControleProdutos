﻿// <auto-generated />
using System;
using ApiControleProdutos.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiControleProdutos.Infra.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230414023825_AlterTableFornecedor")]
    partial class AlterTableFornecedor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiControleProdutos.Domain.Entities.Fornecedor", b =>
                {
                    b.Property<Guid>("IdFornecedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IDFORNECEDOR");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("NVARCHAR(18)")
                        .HasColumnName("CNPJ");

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2")
                        .HasColumnName("DATAHORAALTERACAO");

                    b.Property<DateTime>("DataHoraCriacao")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2")
                        .HasColumnName("DATAHORACRIACAO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("NOME");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("NOMEFANTASIA");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("RAZAOSOCIAL");

                    b.HasKey("IdFornecedor");

                    b.ToTable("FORNECEDOR", (string)null);
                });

            modelBuilder.Entity("ApiControleProdutos.Domain.Entities.Produto", b =>
                {
                    b.Property<Guid>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IDPRODUTO");

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2")
                        .HasColumnName("DATAHORAALTERACAO");

                    b.Property<DateTime>("DataHoraCriacao")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2")
                        .HasColumnName("DATAHORACRIACAO");

                    b.Property<Guid>("IdFornecedor")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR(100)")
                        .HasColumnName("NOME");

                    b.Property<decimal?>("Preco")
                        .IsRequired()
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("PRECO");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER")
                        .HasColumnName("QUANTIDADE");

                    b.HasKey("IdProduto");

                    b.HasIndex("IdFornecedor");

                    b.ToTable("PRODUTO", (string)null);
                });

            modelBuilder.Entity("ApiControleProdutos.Domain.Entities.Produto", b =>
                {
                    b.HasOne("ApiControleProdutos.Domain.Entities.Fornecedor", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("IdFornecedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("ApiControleProdutos.Domain.Entities.Fornecedor", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
