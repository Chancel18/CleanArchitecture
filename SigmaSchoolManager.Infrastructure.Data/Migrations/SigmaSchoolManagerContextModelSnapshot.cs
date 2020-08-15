﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SigmaSchoolManager.Infrastructure.Data.Context;

namespace SigmaSchoolManager.Infrastructure.Data.Migrations
{
    [DbContext(typeof(SigmaSchoolManagerContext))]
    partial class SigmaSchoolManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SigmaSchoolManager.Domain.Entities.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .HasColumnType("Varchar(150)");

                    b.Property<string>("AdressTutor")
                        .HasColumnType("Varchar(150)");

                    b.Property<string>("AllergyFood")
                        .HasColumnType("VARCHAR(80)");

                    b.Property<string>("AllergyMedication")
                        .HasColumnType("VARCHAR(80)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime");

                    b.Property<string>("Disease")
                        .HasColumnType("Varchar(170)");

                    b.Property<string>("Email")
                        .HasColumnType("Varchar(60)");

                    b.Property<string>("EmailTutor")
                        .HasColumnType("Varchar(60)");

                    b.Property<string>("FamilySituation")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("FirstName")
                        .HasColumnType("Varchar(120)");

                    b.Property<string>("FirstNameTutor")
                        .HasColumnType("Varchar(120)");

                    b.Property<bool>("IsAutorisation")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("Varchar(120)");

                    b.Property<string>("LastNameTutor")
                        .IsRequired()
                        .HasColumnType("Varchar(120)");

                    b.Property<string>("PhoneStudent")
                        .HasColumnType("Varchar(15)");

                    b.Property<string>("PhoneTutor")
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("PhysicalState")
                        .IsRequired()
                        .HasColumnType("Char(6)");

                    b.Property<string>("PlaceOfBirth")
                        .HasColumnType("Varchar(150)");

                    b.Property<string>("ProfessionTutor")
                        .HasColumnType("Varchar(120)");

                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("Varchar(10)");

                    b.Property<string>("SchoolOrigine")
                        .HasColumnType("Varchar(150)");

                    b.Property<string>("Sexe")
                        .IsRequired()
                        .HasColumnType("Char(1)");

                    b.Property<DateTime>("UpdatedAt")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime");

                    b.Property<string>("UrgencyContact")
                        .HasColumnType("VARCHAR(60)");

                    b.HasKey("ID");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}