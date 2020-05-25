﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using biograf01.Model;

namespace biograf01.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    partial class BlogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.2.20159.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("biograf01.Model.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Genres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("biograf01.Model.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genrenumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainActors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Runtime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Theater")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("biograf01.Model.MovieGenre", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("MovieGenre");
                });

            modelBuilder.Entity("biograf01.Model.Show", b =>
                {
                    b.Property<int>("showId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<int?>("TheaterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("runtime")
                        .HasColumnType("datetime2");

                    b.HasKey("showId");

                    b.HasIndex("MovieId");

                    b.HasIndex("TheaterId");

                    b.ToTable("Show");
                });

            modelBuilder.Entity("biograf01.Model.Theater", b =>
                {
                    b.Property<int>("TheaterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("row")
                        .HasColumnType("int");

                    b.Property<int>("seat")
                        .HasColumnType("int");

                    b.HasKey("TheaterId");

                    b.ToTable("Theater");
                });

            modelBuilder.Entity("biograf01.Model.TheaterSeats", b =>
                {
                    b.Property<int>("TheaterId")
                        .HasColumnType("int");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.HasKey("TheaterId", "SeatId");

                    b.HasIndex("SeatId");

                    b.ToTable("theaterSeats");
                });

            modelBuilder.Entity("biograf01.Model.UserZipCode", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.Property<int?>("zipcodeId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ZipCode");

                    b.HasIndex("zipcodeId");

                    b.ToTable("userZipCode");
                });

            modelBuilder.Entity("biograf01.Model.Users", b =>
                {
                    b.Property<int>("usersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ZipCodeId")
                        .HasColumnType("int");

                    b.Property<string>("firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("usersId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("biograf01.Model.ZipCode", b =>
                {
                    b.Property<int>("zipcodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Zipcode")
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("zipcodeId");

                    b.ToTable("zipCode");
                });

            modelBuilder.Entity("biograf01.Model.seats", b =>
                {
                    b.Property<int>("seatsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Avalible")
                        .HasColumnType("bit");

                    b.Property<int>("row")
                        .HasColumnType("int");

                    b.Property<int>("seat")
                        .HasColumnType("int");

                    b.HasKey("seatsId");

                    b.ToTable("seats");
                });

            modelBuilder.Entity("biograf01.Model.MovieGenre", b =>
                {
                    b.HasOne("biograf01.Model.Genre", "genre")
                        .WithMany("moviegenre")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("biograf01.Model.Movie", "movie")
                        .WithMany("Moviegenre")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("biograf01.Model.Show", b =>
                {
                    b.HasOne("biograf01.Model.Movie", "movie")
                        .WithMany("shows")
                        .HasForeignKey("MovieId");

                    b.HasOne("biograf01.Model.Theater", null)
                        .WithMany("shows")
                        .HasForeignKey("TheaterId");
                });

            modelBuilder.Entity("biograf01.Model.TheaterSeats", b =>
                {
                    b.HasOne("biograf01.Model.seats", "seat")
                        .WithMany("Theatersseats")
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("biograf01.Model.Theater", "theater")
                        .WithMany("Theatersseats")
                        .HasForeignKey("TheaterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("biograf01.Model.UserZipCode", b =>
                {
                    b.HasOne("biograf01.Model.Users", "User")
                        .WithMany("UserZipCode")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("biograf01.Model.ZipCode", "zipcode")
                        .WithMany("UserZipCode")
                        .HasForeignKey("zipcodeId");
                });
#pragma warning restore 612, 618
        }
    }
}
