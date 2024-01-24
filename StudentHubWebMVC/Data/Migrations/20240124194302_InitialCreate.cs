using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentHubWebMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campus",
                columns: table => new
                {
                    IDCampus = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCampus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localita = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campus", x => x.IDCampus);
                });

            migrationBuilder.CreateTable(
                name: "Facolta",
                columns: table => new
                {
                    IDFacolta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFacolta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facolta", x => x.IDFacolta);
                });

            migrationBuilder.CreateTable(
                name: "SettoriScientificiDisciplinari",
                columns: table => new
                {
                    IDSettoreScientificoDisciplinare = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeSettoreScientificoDisciplinare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodiceSettoreScientificoDisciplinare = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettoriScientificiDisciplinari", x => x.IDSettoreScientificoDisciplinare);
                });

            migrationBuilder.CreateTable(
                name: "TipiCorso",
                columns: table => new
                {
                    IDTipoCorso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoCorsoNome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipiCorso", x => x.IDTipoCorso);
                });

            migrationBuilder.CreateTable(
                name: "Dipartimeti",
                columns: table => new
                {
                    IDDipartimento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDipartimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDFacolta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dipartimeti", x => x.IDDipartimento);
                    table.ForeignKey(
                        name: "FK_Dipartimeti_Facolta_IDFacolta",
                        column: x => x.IDFacolta,
                        principalTable: "Facolta",
                        principalColumn: "IDFacolta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Corsi",
                columns: table => new
                {
                    IDCorso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCorso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durata = table.Column<int>(type: "int", nullable: false),
                    CreditiTotaliCorso = table.Column<int>(type: "int", nullable: false),
                    IDDipartimento = table.Column<int>(type: "int", nullable: false),
                    IDTipoCorso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corsi", x => x.IDCorso);
                    table.ForeignKey(
                        name: "FK_Corsi_Dipartimeti_IDDipartimento",
                        column: x => x.IDDipartimento,
                        principalTable: "Dipartimeti",
                        principalColumn: "IDDipartimento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Corsi_TipiCorso_IDTipoCorso",
                        column: x => x.IDTipoCorso,
                        principalTable: "TipiCorso",
                        principalColumn: "IDTipoCorso",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materie",
                columns: table => new
                {
                    IDMateria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeMateria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodiceMateria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroOre = table.Column<int>(type: "int", nullable: false),
                    CreditiMateria = table.Column<int>(type: "int", nullable: false),
                    IDDipartimento = table.Column<int>(type: "int", nullable: false),
                    IDSettoreScientificoDisciplinare = table.Column<int>(type: "int", nullable: false),
                    AnnoUniversitario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materie", x => x.IDMateria);
                    table.ForeignKey(
                        name: "FK_Materie_Dipartimeti_IDDipartimento",
                        column: x => x.IDDipartimento,
                        principalTable: "Dipartimeti",
                        principalColumn: "IDDipartimento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Materie_SettoriScientificiDisciplinari_IDSettoreScientificoDisciplinare",
                        column: x => x.IDSettoreScientificoDisciplinare,
                        principalTable: "SettoriScientificiDisciplinari",
                        principalColumn: "IDSettoreScientificoDisciplinare",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Studenti",
                columns: table => new
                {
                    IDStudente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeStudente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CognomeStudente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LuogoNascita = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnnoUniversitario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDCorso = table.Column<int>(type: "int", nullable: false),
                    Specializzazione = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDCampus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studenti", x => x.IDStudente);
                    table.ForeignKey(
                        name: "FK_Studenti_Campus_IDCampus",
                        column: x => x.IDCampus,
                        principalTable: "Campus",
                        principalColumn: "IDCampus",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Studenti_Corsi_IDCorso",
                        column: x => x.IDCorso,
                        principalTable: "Corsi",
                        principalColumn: "IDCorso",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VotiMateria",
                columns: table => new
                {
                    IDVoto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDStudente = table.Column<int>(type: "int", nullable: false),
                    IDMateria = table.Column<int>(type: "int", nullable: false),
                    VotoMateriaValue = table.Column<int>(type: "int", nullable: false),
                    DataRegistrazioneVotoMateria = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VotiMateria", x => x.IDVoto);
                    table.ForeignKey(
                        name: "FK_VotiMateria_Materie_IDMateria",
                        column: x => x.IDMateria,
                        principalTable: "Materie",
                        principalColumn: "IDMateria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VotiMateria_Studenti_IDStudente",
                        column: x => x.IDStudente,
                        principalTable: "Studenti",
                        principalColumn: "IDStudente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VotiTesi",
                columns: table => new
                {
                    IDVotoTesi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDStudente = table.Column<int>(type: "int", nullable: false),
                    VotoTesiValue = table.Column<int>(type: "int", nullable: false),
                    DataRegistrazioneVotoTesi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VotiTesi", x => x.IDVotoTesi);
                    table.ForeignKey(
                        name: "FK_VotiTesi_Studenti_IDStudente",
                        column: x => x.IDStudente,
                        principalTable: "Studenti",
                        principalColumn: "IDStudente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Corsi_IDDipartimento",
                table: "Corsi",
                column: "IDDipartimento");

            migrationBuilder.CreateIndex(
                name: "IX_Corsi_IDTipoCorso",
                table: "Corsi",
                column: "IDTipoCorso");

            migrationBuilder.CreateIndex(
                name: "IX_Dipartimeti_IDFacolta",
                table: "Dipartimeti",
                column: "IDFacolta");

            migrationBuilder.CreateIndex(
                name: "IX_Materie_IDDipartimento",
                table: "Materie",
                column: "IDDipartimento");

            migrationBuilder.CreateIndex(
                name: "IX_Materie_IDSettoreScientificoDisciplinare",
                table: "Materie",
                column: "IDSettoreScientificoDisciplinare");

            migrationBuilder.CreateIndex(
                name: "IX_Studenti_IDCampus",
                table: "Studenti",
                column: "IDCampus");

            migrationBuilder.CreateIndex(
                name: "IX_Studenti_IDCorso",
                table: "Studenti",
                column: "IDCorso");

            migrationBuilder.CreateIndex(
                name: "IX_VotiMateria_IDMateria",
                table: "VotiMateria",
                column: "IDMateria");

            migrationBuilder.CreateIndex(
                name: "IX_VotiMateria_IDStudente",
                table: "VotiMateria",
                column: "IDStudente");

            migrationBuilder.CreateIndex(
                name: "IX_VotiTesi_IDStudente",
                table: "VotiTesi",
                column: "IDStudente",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VotiMateria");

            migrationBuilder.DropTable(
                name: "VotiTesi");

            migrationBuilder.DropTable(
                name: "Materie");

            migrationBuilder.DropTable(
                name: "Studenti");

            migrationBuilder.DropTable(
                name: "SettoriScientificiDisciplinari");

            migrationBuilder.DropTable(
                name: "Campus");

            migrationBuilder.DropTable(
                name: "Corsi");

            migrationBuilder.DropTable(
                name: "Dipartimeti");

            migrationBuilder.DropTable(
                name: "TipiCorso");

            migrationBuilder.DropTable(
                name: "Facolta");
        }
    }
}
