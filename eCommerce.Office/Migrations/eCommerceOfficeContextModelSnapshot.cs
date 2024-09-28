﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eCommerce.Office;

#nullable disable

namespace eCommerce.Office.Migrations
{
    [DbContext(typeof(eCommerceOfficeContext))]
    partial class eCommerceOfficeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ColaboradorTurma", b =>
                {
                    b.Property<int>("ColaboradoresId")
                        .HasColumnType("int");

                    b.Property<int>("TurmasId")
                        .HasColumnType("int");

                    b.HasKey("ColaboradoresId", "TurmasId");

                    b.HasIndex("TurmasId");

                    b.ToTable("ColaboradorTurma");
                });

            modelBuilder.Entity("eCommerce.Office.Models.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colaboradores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "José"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Maria"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Felipe"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Tiago"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Mariano"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Jessica"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Vivian"
                        });
                });

            modelBuilder.Entity("eCommerce.Office.Models.ColaboradorSetor", b =>
                {
                    b.Property<int>("ColaboradorId")
                        .HasColumnType("int");

                    b.Property<int>("SetorId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("Criado")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("ColaboradorId", "SetorId");

                    b.HasIndex("SetorId");

                    b.ToTable("ColaboradoresSetores");

                    b.HasData(
                        new
                        {
                            ColaboradorId = 1,
                            SetorId = 1,
                            Criado = new DateTimeOffset(new DateTime(2024, 9, 28, 10, 59, 41, 358, DateTimeKind.Unspecified).AddTicks(890), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            ColaboradorId = 6,
                            SetorId = 1,
                            Criado = new DateTimeOffset(new DateTime(2024, 9, 28, 10, 59, 41, 358, DateTimeKind.Unspecified).AddTicks(919), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            ColaboradorId = 5,
                            SetorId = 2,
                            Criado = new DateTimeOffset(new DateTime(2024, 9, 28, 10, 59, 41, 358, DateTimeKind.Unspecified).AddTicks(921), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            ColaboradorId = 4,
                            SetorId = 2,
                            Criado = new DateTimeOffset(new DateTime(2024, 9, 28, 10, 59, 41, 358, DateTimeKind.Unspecified).AddTicks(922), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            ColaboradorId = 7,
                            SetorId = 3,
                            Criado = new DateTimeOffset(new DateTime(2024, 9, 28, 10, 59, 41, 358, DateTimeKind.Unspecified).AddTicks(924), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            ColaboradorId = 2,
                            SetorId = 4,
                            Criado = new DateTimeOffset(new DateTime(2024, 9, 28, 10, 59, 41, 358, DateTimeKind.Unspecified).AddTicks(925), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            ColaboradorId = 3,
                            SetorId = 4,
                            Criado = new DateTimeOffset(new DateTime(2024, 9, 28, 10, 59, 41, 358, DateTimeKind.Unspecified).AddTicks(926), new TimeSpan(0, -3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("eCommerce.Office.Models.ColaboradorVeiculo", b =>
                {
                    b.Property<int>("ColaboradorId")
                        .HasColumnType("int");

                    b.Property<int>("VeiculoId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("DataInicioDeVinculo")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("ColaboradorId", "VeiculoId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("ColaboradorVeiculo");
                });

            modelBuilder.Entity("eCommerce.Office.Models.Setor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Setores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Logística"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Separação"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Financeiro"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Adminstrativo"
                        });
                });

            modelBuilder.Entity("eCommerce.Office.Models.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Turmas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Turma A1"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Turma A2"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Turma A3"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Turma A4"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Turma A5"
                        });
                });

            modelBuilder.Entity("eCommerce.Office.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Veiculos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "FIAT - Argo",
                            Placa = "ABC-1234"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "FIAT - Mobi",
                            Placa = "DFG-1234"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "FIAT - Siena",
                            Placa = "HIJ-1234"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "FIAT - Idea",
                            Placa = "LMN-1234"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "FIAT - Toro",
                            Placa = "OPQ-1234"
                        });
                });

            modelBuilder.Entity("ColaboradorTurma", b =>
                {
                    b.HasOne("eCommerce.Office.Models.Colaborador", null)
                        .WithMany()
                        .HasForeignKey("ColaboradoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerce.Office.Models.Turma", null)
                        .WithMany()
                        .HasForeignKey("TurmasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eCommerce.Office.Models.ColaboradorSetor", b =>
                {
                    b.HasOne("eCommerce.Office.Models.Colaborador", "Colaborador")
                        .WithMany("ColaboradorSetores")
                        .HasForeignKey("ColaboradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerce.Office.Models.Setor", "Setor")
                        .WithMany("ColaboradoresSetores")
                        .HasForeignKey("SetorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colaborador");

                    b.Navigation("Setor");
                });

            modelBuilder.Entity("eCommerce.Office.Models.ColaboradorVeiculo", b =>
                {
                    b.HasOne("eCommerce.Office.Models.Colaborador", "Colaborador")
                        .WithMany("ColaboradoresVeiculos")
                        .HasForeignKey("ColaboradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerce.Office.Models.Veiculo", "Veiculo")
                        .WithMany("ColaboradoresVeiculos")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colaborador");

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("eCommerce.Office.Models.Colaborador", b =>
                {
                    b.Navigation("ColaboradorSetores");

                    b.Navigation("ColaboradoresVeiculos");
                });

            modelBuilder.Entity("eCommerce.Office.Models.Setor", b =>
                {
                    b.Navigation("ColaboradoresSetores");
                });

            modelBuilder.Entity("eCommerce.Office.Models.Veiculo", b =>
                {
                    b.Navigation("ColaboradoresVeiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
