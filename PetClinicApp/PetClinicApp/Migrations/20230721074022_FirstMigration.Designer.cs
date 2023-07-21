﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PetClinicApp.Migrations
{
    [DbContext(typeof(ClinicContextDb))]
    [Migration("20230721074022_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PassportSerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("PassportSerialNumber")
                        .IsUnique();

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("Passport", b =>
                {
                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("OwnerPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SerialNumber");

                    b.ToTable("Passports");
                });

            modelBuilder.Entity("PetClinicApp.Models.AnimalAid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("AnimalAids");
                });

            modelBuilder.Entity("PetClinicApp.Models.Procedure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("VetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("VetId");

                    b.ToTable("Procedures");
                });

            modelBuilder.Entity("PetClinicApp.Models.ProcedureAnimalAid", b =>
                {
                    b.Property<int>("ProcedureId")
                        .HasColumnType("int");

                    b.Property<int>("AnimalAidId")
                        .HasColumnType("int");

                    b.HasKey("ProcedureId", "AnimalAidId");

                    b.HasIndex("AnimalAidId");

                    b.ToTable("ProcedureAnimalAids");
                });

            modelBuilder.Entity("PetClinicApp.Models.Vet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Vets");
                });

            modelBuilder.Entity("Animal", b =>
                {
                    b.HasOne("Passport", "Passport")
                        .WithOne("Animal")
                        .HasForeignKey("Animal", "PassportSerialNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Passport");
                });

            modelBuilder.Entity("PetClinicApp.Models.Procedure", b =>
                {
                    b.HasOne("Animal", "Animal")
                        .WithMany("Procedures")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetClinicApp.Models.Vet", "Vet")
                        .WithMany("Procedures")
                        .HasForeignKey("VetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Vet");
                });

            modelBuilder.Entity("PetClinicApp.Models.ProcedureAnimalAid", b =>
                {
                    b.HasOne("PetClinicApp.Models.AnimalAid", "AnimalAid")
                        .WithMany("AnimalAidProcedures")
                        .HasForeignKey("AnimalAidId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetClinicApp.Models.Procedure", "Procedure")
                        .WithMany("ProcedureAnimalAids")
                        .HasForeignKey("ProcedureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnimalAid");

                    b.Navigation("Procedure");
                });

            modelBuilder.Entity("Animal", b =>
                {
                    b.Navigation("Procedures");
                });

            modelBuilder.Entity("Passport", b =>
                {
                    b.Navigation("Animal")
                        .IsRequired();
                });

            modelBuilder.Entity("PetClinicApp.Models.AnimalAid", b =>
                {
                    b.Navigation("AnimalAidProcedures");
                });

            modelBuilder.Entity("PetClinicApp.Models.Procedure", b =>
                {
                    b.Navigation("ProcedureAnimalAids");
                });

            modelBuilder.Entity("PetClinicApp.Models.Vet", b =>
                {
                    b.Navigation("Procedures");
                });
#pragma warning restore 612, 618
        }
    }
}