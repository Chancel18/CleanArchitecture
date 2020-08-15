using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace SigmaSchoolManager.Infrastructure.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RegistrationNumber = table.Column<string>(type: "Varchar(10)", nullable: true),
                    LastName = table.Column<string>(type: "Varchar(120)", nullable: true),
                    FirstName = table.Column<string>(type: "Varchar(120)", nullable: true),
                    Sexe = table.Column<string>(type: "Char(1)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "Varchar(150)", nullable: true),
                    Adress = table.Column<string>(type: "Varchar(150)", nullable: true),
                    PhoneStudent = table.Column<string>(type: "Varchar(15)", nullable: true),
                    Email = table.Column<string>(type: "Varchar(60)", nullable: true),
                    SchoolOrigine = table.Column<string>(type: "Varchar(150)", nullable: true),
                    PhysicalState = table.Column<string>(type: "Char(6)", nullable: false),
                    Disease = table.Column<string>(type: "Varchar(170)", nullable: true),
                    LastNameTutor = table.Column<string>(type: "Varchar(120)", nullable: false),
                    FirstNameTutor = table.Column<string>(type: "Varchar(120)", nullable: true),
                    PhoneTutor = table.Column<string>(type: "Varchar(20)", nullable: true),
                    EmailTutor = table.Column<string>(type: "Varchar(60)", nullable: true),
                    ProfessionTutor = table.Column<string>(type: "Varchar(120)", nullable: true),
                    AdressTutor = table.Column<string>(type: "Varchar(150)", nullable: true),
                    FamilySituation = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    AllergyMedication = table.Column<string>(type: "VARCHAR(80)", nullable: true),
                    AllergyFood = table.Column<string>(type: "VARCHAR(80)", nullable: true),
                    IsAutorisation = table.Column<bool>(nullable: false),
                    UrgencyContact = table.Column<string>(type: "VARCHAR(60)", nullable: true),
                    IsDisabled = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
