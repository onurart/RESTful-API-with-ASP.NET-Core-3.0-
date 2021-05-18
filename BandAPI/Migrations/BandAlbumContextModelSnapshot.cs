﻿// <auto-generated />
using System;
using BandAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BandAPI.Migrations
{
    [DbContext(typeof(BandAlbumContext))]
    partial class BandAlbumContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BandAPI.Entities.Album", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("BandId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3cfb608a-0b3b-4781-adb4-76042d236d97"),
                            BandId = new Guid("66d91052-69ba-44cd-a5d9-1c369e5fbc74"),
                            Description = "onur",
                            Title = "Master"
                        });
                });

            modelBuilder.Entity("BandAPI.Entities.Band", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Founded")
                        .HasColumnType("datetime2");

                    b.Property<string>("MainGenre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Bands");

                    b.HasData(
                        new
                        {
                            Id = new Guid("66d91052-69ba-44cd-a5d9-1c369e5fbc74"),
                            Founded = new DateTime(1880, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MainGenre = "Heavy Metal",
                            Name = "Metallica"
                        },
                        new
                        {
                            Id = new Guid("c66b75f1-b1dd-4d29-9d58-0fd581bcbef2"),
                            Founded = new DateTime(1880, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MainGenre = "Heavy Metal",
                            Name = "Metallica"
                        },
                        new
                        {
                            Id = new Guid("c76b75f1-b1dd-4d29-9d58-0fd581bcb2f2"),
                            Founded = new DateTime(1880, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MainGenre = "Heavy Metal",
                            Name = "Metallica"
                        });
                });

            modelBuilder.Entity("BandAPI.Entities.Album", b =>
                {
                    b.HasOne("BandAPI.Entities.Band", "Band")
                        .WithMany("Albums")
                        .HasForeignKey("BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
