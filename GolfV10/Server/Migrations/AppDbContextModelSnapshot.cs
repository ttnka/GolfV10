﻿// <auto-generated />
using System;
using GolfV10.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GolfV10.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GolfV10.Shared.G120Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apodo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Bday")
                        .HasColumnType("datetime2");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int>("Ghin")
                        .HasColumnType("int");

                    b.Property<string>("Materno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Paterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<bool>("Temporal")
                        .HasColumnType("bit");

                    b.Property<int>("User")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("GolfV10.Shared.G128Hcp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BanderaId")
                        .HasColumnType("int");

                    b.Property<int?>("CampoId")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Hcp")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BanderaId");

                    b.HasIndex("CampoId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Hcps");
                });

            modelBuilder.Entity("GolfV10.Shared.G136Foto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grupo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Player")
                        .HasColumnType("int");

                    b.Property<int?>("PlayeresAllId")
                        .HasColumnType("int");

                    b.Property<bool>("Privada")
                        .HasColumnType("bit");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PlayeresAllId");

                    b.ToTable("Fotos");
                });

            modelBuilder.Entity("GolfV10.Shared.G170Campo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Corto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Campos");
                });

            modelBuilder.Entity("GolfV10.Shared.G172Bandera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CampoId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CampoId");

                    b.ToTable("Banderas");
                });

            modelBuilder.Entity("GolfV10.Shared.G176Hoyo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CampoId")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int>("HcpHombres")
                        .HasColumnType("int");

                    b.Property<int>("HcpMenores")
                        .HasColumnType("int");

                    b.Property<int>("HcpMujeres")
                        .HasColumnType("int");

                    b.Property<int>("HcpOtros")
                        .HasColumnType("int");

                    b.Property<int>("Hoyo")
                        .HasColumnType("int");

                    b.Property<int>("Par")
                        .HasColumnType("int");

                    b.Property<string>("Ruta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CampoId");

                    b.ToTable("Hoyos");
                });

            modelBuilder.Entity("GolfV10.Shared.G178Distancia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BanderaId")
                        .HasColumnType("int");

                    b.Property<int>("Distancia")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HoyoId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BanderaId");

                    b.HasIndex("HoyoId");

                    b.ToTable("Distancias");
                });

            modelBuilder.Entity("GolfV10.Shared.G190Bitacora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Accion")
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Sistema")
                        .HasColumnType("bit");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Bitacoras");
                });

            modelBuilder.Entity("GolfV10.Shared.G194Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FIni")
                        .HasColumnType("datetime2");

                    b.Property<string>("MasterId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Player")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("GolfV10.Shared.G200Torneo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreadorId")
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ejercicio")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int?>("FormatoId")
                        .HasColumnType("int");

                    b.Property<int?>("NombreId")
                        .HasColumnType("int");

                    b.Property<int>("Rondas")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreadorId");

                    b.HasIndex("FormatoId");

                    b.HasIndex("NombreId");

                    b.ToTable("Torneos");
                });

            modelBuilder.Entity("GolfV10.Shared.G202CapturaTorneo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContrincanteId")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("Rol")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("TorneoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContrincanteId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("TorneoId");

                    b.ToTable("CapturasTorneo");
                });

            modelBuilder.Entity("GolfV10.Shared.G204FechaTorneo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Ronda")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("TorneoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("TorneoId");

                    b.ToTable("FechasTorneo");
                });

            modelBuilder.Entity("GolfV10.Shared.G208CategoriaTorneo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BanderaId")
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<decimal>("HcpPiso")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("HcpTecho")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Players")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TorneoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BanderaId");

                    b.HasIndex("TorneoId");

                    b.ToTable("CategoriasTorneo");
                });

            modelBuilder.Entity("GolfV10.Shared.G220TeamTorneo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatergoriaId")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int>("Indice")
                        .HasColumnType("int");

                    b.Property<int>("Integrantes")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TorneoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CatergoriaId");

                    b.HasIndex("TorneoId");

                    b.ToTable("TeamsTorneo");
                });

            modelBuilder.Entity("GolfV10.Shared.G222PlayerTorneo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int>("HcpTorneo")
                        .HasColumnType("int");

                    b.Property<int?>("PlayerTorenoId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("TeamTorneoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerTorenoId");

                    b.HasIndex("TeamTorneoId");

                    b.ToTable("PlayerTorneo");
                });

            modelBuilder.Entity("GolfV10.Shared.G224RolTorneo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Indice")
                        .HasColumnType("int");

                    b.Property<int?>("PlayerTorneoId")
                        .HasColumnType("int");

                    b.Property<int>("Ronda")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.Property<int?>("TorneoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerTorneoId");

                    b.HasIndex("TeamId");

                    b.HasIndex("TorneoId");

                    b.ToTable("RolesTorneo");
                });

            modelBuilder.Entity("GolfV10.Shared.G240Score", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CapturoId")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("HoraCaptura")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HoyoId")
                        .HasColumnType("int");

                    b.Property<int?>("PlayerTorneoId")
                        .HasColumnType("int");

                    b.Property<int?>("RolId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CapturoId");

                    b.HasIndex("HoyoId");

                    b.HasIndex("PlayerTorneoId");

                    b.HasIndex("RolId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("GolfV10.Shared.G280FormatoTorneo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int>("Players")
                        .HasColumnType("int");

                    b.Property<int>("Rondas")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FormatosTorneo");
                });

            modelBuilder.Entity("GolfV10.Shared.G128Hcp", b =>
                {
                    b.HasOne("GolfV10.Shared.G172Bandera", "Bandera")
                        .WithMany()
                        .HasForeignKey("BanderaId");

                    b.HasOne("GolfV10.Shared.G170Campo", "Campo")
                        .WithMany()
                        .HasForeignKey("CampoId");

                    b.HasOne("GolfV10.Shared.G120Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId");

                    b.Navigation("Bandera");

                    b.Navigation("Campo");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("GolfV10.Shared.G136Foto", b =>
                {
                    b.HasOne("GolfV10.Shared.G120Player", "PlayeresAll")
                        .WithMany()
                        .HasForeignKey("PlayeresAllId");

                    b.Navigation("PlayeresAll");
                });

            modelBuilder.Entity("GolfV10.Shared.G172Bandera", b =>
                {
                    b.HasOne("GolfV10.Shared.G170Campo", "Campo")
                        .WithMany()
                        .HasForeignKey("CampoId");

                    b.Navigation("Campo");
                });

            modelBuilder.Entity("GolfV10.Shared.G176Hoyo", b =>
                {
                    b.HasOne("GolfV10.Shared.G170Campo", "Campo")
                        .WithMany()
                        .HasForeignKey("CampoId");

                    b.Navigation("Campo");
                });

            modelBuilder.Entity("GolfV10.Shared.G178Distancia", b =>
                {
                    b.HasOne("GolfV10.Shared.G172Bandera", "Bandera")
                        .WithMany()
                        .HasForeignKey("BanderaId");

                    b.HasOne("GolfV10.Shared.G176Hoyo", "Hoyo")
                        .WithMany()
                        .HasForeignKey("HoyoId");

                    b.Navigation("Bandera");

                    b.Navigation("Hoyo");
                });

            modelBuilder.Entity("GolfV10.Shared.G190Bitacora", b =>
                {
                    b.HasOne("GolfV10.Shared.G120Player", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("GolfV10.Shared.G200Torneo", b =>
                {
                    b.HasOne("GolfV10.Shared.G120Player", "Creador")
                        .WithMany()
                        .HasForeignKey("CreadorId");

                    b.HasOne("GolfV10.Shared.G280FormatoTorneo", "Formato")
                        .WithMany()
                        .HasForeignKey("FormatoId");

                    b.HasOne("GolfV10.Shared.G170Campo", "Nombre")
                        .WithMany()
                        .HasForeignKey("NombreId");

                    b.Navigation("Creador");

                    b.Navigation("Formato");

                    b.Navigation("Nombre");
                });

            modelBuilder.Entity("GolfV10.Shared.G202CapturaTorneo", b =>
                {
                    b.HasOne("GolfV10.Shared.G222PlayerTorneo", "Contrincante")
                        .WithMany()
                        .HasForeignKey("ContrincanteId");

                    b.HasOne("GolfV10.Shared.G120Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId");

                    b.HasOne("GolfV10.Shared.G200Torneo", "Torneo")
                        .WithMany()
                        .HasForeignKey("TorneoId");

                    b.Navigation("Contrincante");

                    b.Navigation("Player");

                    b.Navigation("Torneo");
                });

            modelBuilder.Entity("GolfV10.Shared.G204FechaTorneo", b =>
                {
                    b.HasOne("GolfV10.Shared.G208CategoriaTorneo", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");

                    b.HasOne("GolfV10.Shared.G200Torneo", "Torneo")
                        .WithMany()
                        .HasForeignKey("TorneoId");

                    b.Navigation("Categoria");

                    b.Navigation("Torneo");
                });

            modelBuilder.Entity("GolfV10.Shared.G208CategoriaTorneo", b =>
                {
                    b.HasOne("GolfV10.Shared.G172Bandera", "Bandera")
                        .WithMany()
                        .HasForeignKey("BanderaId");

                    b.HasOne("GolfV10.Shared.G200Torneo", "Torneo")
                        .WithMany()
                        .HasForeignKey("TorneoId");

                    b.Navigation("Bandera");

                    b.Navigation("Torneo");
                });

            modelBuilder.Entity("GolfV10.Shared.G220TeamTorneo", b =>
                {
                    b.HasOne("GolfV10.Shared.G208CategoriaTorneo", "Catergoria")
                        .WithMany()
                        .HasForeignKey("CatergoriaId");

                    b.HasOne("GolfV10.Shared.G200Torneo", "Torneo")
                        .WithMany()
                        .HasForeignKey("TorneoId");

                    b.Navigation("Catergoria");

                    b.Navigation("Torneo");
                });

            modelBuilder.Entity("GolfV10.Shared.G222PlayerTorneo", b =>
                {
                    b.HasOne("GolfV10.Shared.G120Player", "PlayerToreno")
                        .WithMany()
                        .HasForeignKey("PlayerTorenoId");

                    b.HasOne("GolfV10.Shared.G220TeamTorneo", "TeamTorneo")
                        .WithMany()
                        .HasForeignKey("TeamTorneoId");

                    b.Navigation("PlayerToreno");

                    b.Navigation("TeamTorneo");
                });

            modelBuilder.Entity("GolfV10.Shared.G224RolTorneo", b =>
                {
                    b.HasOne("GolfV10.Shared.G222PlayerTorneo", "PlayerTorneo")
                        .WithMany()
                        .HasForeignKey("PlayerTorneoId");

                    b.HasOne("GolfV10.Shared.G220TeamTorneo", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.HasOne("GolfV10.Shared.G200Torneo", "Torneo")
                        .WithMany()
                        .HasForeignKey("TorneoId");

                    b.Navigation("PlayerTorneo");

                    b.Navigation("Team");

                    b.Navigation("Torneo");
                });

            modelBuilder.Entity("GolfV10.Shared.G240Score", b =>
                {
                    b.HasOne("GolfV10.Shared.G120Player", "Capturo")
                        .WithMany()
                        .HasForeignKey("CapturoId");

                    b.HasOne("GolfV10.Shared.G176Hoyo", "Hoyo")
                        .WithMany()
                        .HasForeignKey("HoyoId");

                    b.HasOne("GolfV10.Shared.G222PlayerTorneo", "PlayerTorneo")
                        .WithMany()
                        .HasForeignKey("PlayerTorneoId");

                    b.HasOne("GolfV10.Shared.G224RolTorneo", "Rol")
                        .WithMany()
                        .HasForeignKey("RolId");

                    b.Navigation("Capturo");

                    b.Navigation("Hoyo");

                    b.Navigation("PlayerTorneo");

                    b.Navigation("Rol");
                });
#pragma warning restore 612, 618
        }
    }
}
