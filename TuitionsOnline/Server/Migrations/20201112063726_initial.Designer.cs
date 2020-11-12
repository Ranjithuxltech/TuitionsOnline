﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TuitionsOnline.Server.DataAccessLayer;

namespace TuitionsOnline.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201112063726_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TuitionsOnline.Shared.Teacher", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AlternativeLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactPhoneNumber")
                        .HasColumnType("int");

                    b.Property<bool>("Doctorate")
                        .HasColumnType("bit");

                    b.Property<string>("DoctrateField")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExperienceInYears")
                        .HasColumnType("int");

                    b.Property<bool>("Graduate")
                        .HasColumnType("bit");

                    b.Property<string>("GraduateField")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PostGraduate")
                        .HasColumnType("bit");

                    b.Property<string>("PostGraduateField")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrefferedLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RatePerClassInRupees")
                        .HasColumnType("int");

                    b.Property<string>("ResidentialCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResidentialPinCode")
                        .HasColumnType("int");

                    b.Property<string>("SubjectYouWishToTeach")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeachersFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UploadYourIdentificationDocument")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfBirth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}