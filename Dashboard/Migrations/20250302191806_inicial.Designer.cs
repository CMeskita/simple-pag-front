﻿// <auto-generated />
using Data.Conexao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dashboard.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20250302191806_inicial")]
    partial class inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("Dashboard.Models.Entity.Finalizadora", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Modalidade")
                        .HasColumnType("TEXT");

                    b.Property<int>("QtdParcelas")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Registro")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusPagamento")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Valor")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Finalizadoras");
                });

            modelBuilder.Entity("Dashboard.Models.Entity.FormaPagamento", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("CodFinalizadora")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Modalidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Registro")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Vencimento")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FormaPagamentos");
                });

            modelBuilder.Entity("Dashboard.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChavePrivada")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Registro")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
