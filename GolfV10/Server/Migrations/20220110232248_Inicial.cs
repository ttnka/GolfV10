using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfV10.Server.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Player = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Campos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Corto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormatosTorneo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rondas = table.Column<int>(type: "int", nullable: false),
                    Players = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormatosTorneo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Paterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Materno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apodo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ghin = table.Column<int>(type: "int", nullable: false),
                    Bday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Temporal = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banderas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampoId = table.Column<int>(type: "int", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banderas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Banderas_Campos_CampoId",
                        column: x => x.CampoId,
                        principalTable: "Campos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hoyos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampoId = table.Column<int>(type: "int", nullable: true),
                    Ruta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hoyo = table.Column<int>(type: "int", nullable: false),
                    Par = table.Column<int>(type: "int", nullable: false),
                    HcpHombres = table.Column<int>(type: "int", nullable: false),
                    HcpMujeres = table.Column<int>(type: "int", nullable: false),
                    HcpMenores = table.Column<int>(type: "int", nullable: false),
                    HcpOtros = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoyos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hoyos_Campos_CampoId",
                        column: x => x.CampoId,
                        principalTable: "Campos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bitacoras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Accion = table.Column<int>(type: "int", nullable: false),
                    Sistema = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bitacoras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bitacoras_Players_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fotos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Player = table.Column<int>(type: "int", nullable: false),
                    PlayeresAllId = table.Column<int>(type: "int", nullable: true),
                    Grupo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Privada = table.Column<bool>(type: "bit", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fotos_Players_PlayeresAllId",
                        column: x => x.PlayeresAllId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Torneos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ejercicio = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreadorId = table.Column<int>(type: "int", nullable: true),
                    FormatoId = table.Column<int>(type: "int", nullable: true),
                    Rondas = table.Column<int>(type: "int", nullable: false),
                    NombreId = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Torneos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Torneos_Campos_NombreId",
                        column: x => x.NombreId,
                        principalTable: "Campos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Torneos_FormatosTorneo_FormatoId",
                        column: x => x.FormatoId,
                        principalTable: "FormatosTorneo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Torneos_Players_CreadorId",
                        column: x => x.CreadorId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hcps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CampoId = table.Column<int>(type: "int", nullable: true),
                    BanderaId = table.Column<int>(type: "int", nullable: true),
                    Hcp = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hcps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hcps_Banderas_BanderaId",
                        column: x => x.BanderaId,
                        principalTable: "Banderas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hcps_Campos_CampoId",
                        column: x => x.CampoId,
                        principalTable: "Campos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hcps_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Distancias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BanderaId = table.Column<int>(type: "int", nullable: true),
                    HoyoId = table.Column<int>(type: "int", nullable: true),
                    Distancia = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distancias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Distancias_Banderas_BanderaId",
                        column: x => x.BanderaId,
                        principalTable: "Banderas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Distancias_Hoyos_HoyoId",
                        column: x => x.HoyoId,
                        principalTable: "Hoyos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CategoriasTorneo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TorneoId = table.Column<int>(type: "int", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BanderaId = table.Column<int>(type: "int", nullable: true),
                    Players = table.Column<int>(type: "int", nullable: false),
                    HcpTecho = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HcpPiso = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasTorneo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoriasTorneo_Banderas_BanderaId",
                        column: x => x.BanderaId,
                        principalTable: "Banderas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CategoriasTorneo_Torneos_TorneoId",
                        column: x => x.TorneoId,
                        principalTable: "Torneos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FechasTorneo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TorneoId = table.Column<int>(type: "int", nullable: true),
                    Ronda = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FechasTorneo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FechasTorneo_CategoriasTorneo_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "CategoriasTorneo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FechasTorneo_Torneos_TorneoId",
                        column: x => x.TorneoId,
                        principalTable: "Torneos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeamsTorneo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TorneoId = table.Column<int>(type: "int", nullable: true),
                    CatergoriaId = table.Column<int>(type: "int", nullable: true),
                    Indice = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Integrantes = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamsTorneo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamsTorneo_CategoriasTorneo_CatergoriaId",
                        column: x => x.CatergoriaId,
                        principalTable: "CategoriasTorneo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamsTorneo_Torneos_TorneoId",
                        column: x => x.TorneoId,
                        principalTable: "Torneos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayerTorneo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamTorneoId = table.Column<int>(type: "int", nullable: true),
                    PlayerTorenoId = table.Column<int>(type: "int", nullable: true),
                    HcpTorneo = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerTorneo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerTorneo_Players_PlayerTorenoId",
                        column: x => x.PlayerTorenoId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayerTorneo_TeamsTorneo_TeamTorneoId",
                        column: x => x.TeamTorneoId,
                        principalTable: "TeamsTorneo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CapturasTorneo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TorneoId = table.Column<int>(type: "int", nullable: true),
                    PlayerId = table.Column<int>(type: "int", nullable: true),
                    Rol = table.Column<int>(type: "int", nullable: false),
                    ContrincanteId = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapturasTorneo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CapturasTorneo_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CapturasTorneo_PlayerTorneo_ContrincanteId",
                        column: x => x.ContrincanteId,
                        principalTable: "PlayerTorneo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CapturasTorneo_Torneos_TorneoId",
                        column: x => x.TorneoId,
                        principalTable: "Torneos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RolesTorneo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TorneoId = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ronda = table.Column<int>(type: "int", nullable: false),
                    Indice = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    PlayerTorneoId = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesTorneo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolesTorneo_PlayerTorneo_PlayerTorneoId",
                        column: x => x.PlayerTorneoId,
                        principalTable: "PlayerTorneo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolesTorneo_TeamsTorneo_TeamId",
                        column: x => x.TeamId,
                        principalTable: "TeamsTorneo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolesTorneo_Torneos_TorneoId",
                        column: x => x.TorneoId,
                        principalTable: "Torneos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolId = table.Column<int>(type: "int", nullable: true),
                    PlayerTorneoId = table.Column<int>(type: "int", nullable: true),
                    HoyoId = table.Column<int>(type: "int", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: false),
                    CapturoId = table.Column<int>(type: "int", nullable: true),
                    HoraCaptura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scores_Hoyos_HoyoId",
                        column: x => x.HoyoId,
                        principalTable: "Hoyos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Scores_Players_CapturoId",
                        column: x => x.CapturoId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Scores_PlayerTorneo_PlayerTorneoId",
                        column: x => x.PlayerTorneoId,
                        principalTable: "PlayerTorneo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Scores_RolesTorneo_RolId",
                        column: x => x.RolId,
                        principalTable: "RolesTorneo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Banderas_CampoId",
                table: "Banderas",
                column: "CampoId");

            migrationBuilder.CreateIndex(
                name: "IX_Bitacoras_UsuarioId",
                table: "Bitacoras",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CapturasTorneo_ContrincanteId",
                table: "CapturasTorneo",
                column: "ContrincanteId");

            migrationBuilder.CreateIndex(
                name: "IX_CapturasTorneo_PlayerId",
                table: "CapturasTorneo",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_CapturasTorneo_TorneoId",
                table: "CapturasTorneo",
                column: "TorneoId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasTorneo_BanderaId",
                table: "CategoriasTorneo",
                column: "BanderaId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriasTorneo_TorneoId",
                table: "CategoriasTorneo",
                column: "TorneoId");

            migrationBuilder.CreateIndex(
                name: "IX_Distancias_BanderaId",
                table: "Distancias",
                column: "BanderaId");

            migrationBuilder.CreateIndex(
                name: "IX_Distancias_HoyoId",
                table: "Distancias",
                column: "HoyoId");

            migrationBuilder.CreateIndex(
                name: "IX_FechasTorneo_CategoriaId",
                table: "FechasTorneo",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_FechasTorneo_TorneoId",
                table: "FechasTorneo",
                column: "TorneoId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotos_PlayeresAllId",
                table: "Fotos",
                column: "PlayeresAllId");

            migrationBuilder.CreateIndex(
                name: "IX_Hcps_BanderaId",
                table: "Hcps",
                column: "BanderaId");

            migrationBuilder.CreateIndex(
                name: "IX_Hcps_CampoId",
                table: "Hcps",
                column: "CampoId");

            migrationBuilder.CreateIndex(
                name: "IX_Hcps_PlayerId",
                table: "Hcps",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Hoyos_CampoId",
                table: "Hoyos",
                column: "CampoId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTorneo_PlayerTorenoId",
                table: "PlayerTorneo",
                column: "PlayerTorenoId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTorneo_TeamTorneoId",
                table: "PlayerTorneo",
                column: "TeamTorneoId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesTorneo_PlayerTorneoId",
                table: "RolesTorneo",
                column: "PlayerTorneoId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesTorneo_TeamId",
                table: "RolesTorneo",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesTorneo_TorneoId",
                table: "RolesTorneo",
                column: "TorneoId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_CapturoId",
                table: "Scores",
                column: "CapturoId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_HoyoId",
                table: "Scores",
                column: "HoyoId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_PlayerTorneoId",
                table: "Scores",
                column: "PlayerTorneoId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_RolId",
                table: "Scores",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamsTorneo_CatergoriaId",
                table: "TeamsTorneo",
                column: "CatergoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamsTorneo_TorneoId",
                table: "TeamsTorneo",
                column: "TorneoId");

            migrationBuilder.CreateIndex(
                name: "IX_Torneos_CreadorId",
                table: "Torneos",
                column: "CreadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Torneos_FormatoId",
                table: "Torneos",
                column: "FormatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Torneos_NombreId",
                table: "Torneos",
                column: "NombreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Bitacoras");

            migrationBuilder.DropTable(
                name: "CapturasTorneo");

            migrationBuilder.DropTable(
                name: "Distancias");

            migrationBuilder.DropTable(
                name: "FechasTorneo");

            migrationBuilder.DropTable(
                name: "Fotos");

            migrationBuilder.DropTable(
                name: "Hcps");

            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropTable(
                name: "Hoyos");

            migrationBuilder.DropTable(
                name: "RolesTorneo");

            migrationBuilder.DropTable(
                name: "PlayerTorneo");

            migrationBuilder.DropTable(
                name: "TeamsTorneo");

            migrationBuilder.DropTable(
                name: "CategoriasTorneo");

            migrationBuilder.DropTable(
                name: "Banderas");

            migrationBuilder.DropTable(
                name: "Torneos");

            migrationBuilder.DropTable(
                name: "Campos");

            migrationBuilder.DropTable(
                name: "FormatosTorneo");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
