﻿// <auto-generated />
using System;
using MyProjectDavitKldiashvili;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MyProjectDavitKldiashvili.Migrations
{
    [DbContext(typeof(MyProjectDavitKldiashviliContext))]
    [Migration("20220620112246_InicailCreate")]
    partial class InicailCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FinalProject_KhatiashviliGoga.Entities.Organization", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Adress")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<string>("ParentOrganization")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Organizations");
            });

            modelBuilder.Entity("FinalProject_KhatiashviliGoga.Entities.Person", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("DateOfBirth")
                    .HasColumnType("datetime2");

                b.Property<string>("Image")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Language")
                    .HasColumnType("int");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("nvarchar(20)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("nvarchar(20)");

                b.Property<Guid>("OrganizationId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("PersonalNumber")
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnType("nvarchar(11)");

                b.HasKey("Id");

                b.HasIndex("OrganizationId");

                b.ToTable("Persons");
            });

            modelBuilder.Entity("FinalProject_KhatiashviliGoga.Entities.Person", b =>
            {
                b.HasOne("FinalProject_KhatiashviliGoga.Entities.Organization", "Organization")
                    .WithMany()
                    .HasForeignKey("OrganizationId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Organization");
            });
#pragma warning restore 612, 618
        }
    }
}