using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PZ101.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    IDDoctors = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FIODoctors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberDoctors = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.IDDoctors);
                });

            migrationBuilder.CreateTable(
                name: "Pacients",
                columns: table => new
                {
                    IDPacient = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FIOPacient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderPacient = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacients", x => x.IDPacient);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Pacients");
        }
    }
}
