﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YellowBucket.Data;

namespace YellowBucket.Migrations
{
    [DbContext(typeof(YellowBucketContext))]
    [Migration("20210324001322_Kiosk")]
    partial class Kiosk
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YellowBucket.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Address2")
                        .HasColumnType("varchar(128)");

                    b.Property<string>("City")
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(128)");

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(128)");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Password")
                        .HasColumnType("varchar(128)");

                    b.Property<string>("State")
                        .HasColumnType("varchar(2)");

                    b.Property<DateTime?>("Updated_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Zip")
                        .HasColumnType("varchar(128)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("YellowBucket.Models.Customer_Review", b =>
                {
                    b.Property<int>("Customer_ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Kernals")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("varchar(4096)");

                    b.Property<DateTime?>("Updated_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Customer_ReviewId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("MovieId");

                    b.ToTable("Customer_Review");
                });

            modelBuilder.Entity("YellowBucket.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(4096)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(128)");

                    b.HasKey("GenreId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("YellowBucket.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BluRay")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Dvd")
                        .HasColumnType("int");

                    b.Property<int>("IsRented")
                        .HasColumnType("int");

                    b.Property<int>("KioskId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("InventoryId");

                    b.HasIndex("KioskId");

                    b.HasIndex("MovieId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("YellowBucket.Models.Kiosk", b =>
                {
                    b.Property<int>("KioskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Address2")
                        .HasColumnType("varchar(128)");

                    b.Property<string>("City")
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Location")
                        .HasColumnType("varchar(128)");

                    b.Property<string>("State")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Zip")
                        .HasColumnType("varchar(128)");

                    b.HasKey("KioskId");

                    b.ToTable("Kiosk");
                });

            modelBuilder.Entity("YellowBucket.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cover_Photo")
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(4096)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<bool>("Is_BluRay")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_Dvd")
                        .HasColumnType("bit");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int>("RatingId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Release_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime?>("Updated_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("MovieId");

                    b.HasIndex("GenreId");

                    b.HasIndex("RatingId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("YellowBucket.Models.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(4096)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(32)");

                    b.HasKey("RatingId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("YellowBucket.Models.Rentals", b =>
                {
                    b.Property<int>("RentalsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("InventoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Rental_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rental_KioskId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Return_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Return_KioskId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("RentalsId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("InventoryId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("YellowBucket.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(256)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(32)");

                    b.HasKey("ReviewId");

                    b.HasIndex("MovieId")
                        .IsUnique();

                    b.ToTable("Review");
                });

            modelBuilder.Entity("YellowBucket.Models.Wishlist", b =>
                {
                    b.Property<int>("WishlistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("WishlistId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("MovieId");

                    b.ToTable("Wishlist");
                });

            modelBuilder.Entity("YellowBucket.Models.Customer_Review", b =>
                {
                    b.HasOne("YellowBucket.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YellowBucket.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("YellowBucket.Models.Inventory", b =>
                {
                    b.HasOne("YellowBucket.Models.Kiosk", "Kiosk")
                        .WithMany()
                        .HasForeignKey("KioskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YellowBucket.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kiosk");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("YellowBucket.Models.Movie", b =>
                {
                    b.HasOne("YellowBucket.Models.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YellowBucket.Models.Rating", "Rating")
                        .WithMany("Movies")
                        .HasForeignKey("RatingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Rating");
                });

            modelBuilder.Entity("YellowBucket.Models.Rentals", b =>
                {
                    b.HasOne("YellowBucket.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YellowBucket.Models.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("YellowBucket.Models.Review", b =>
                {
                    b.HasOne("YellowBucket.Models.Movie", "Movie")
                        .WithOne("Review")
                        .HasForeignKey("YellowBucket.Models.Review", "MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("YellowBucket.Models.Wishlist", b =>
                {
                    b.HasOne("YellowBucket.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YellowBucket.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("YellowBucket.Models.Genre", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("YellowBucket.Models.Movie", b =>
                {
                    b.Navigation("Review");
                });

            modelBuilder.Entity("YellowBucket.Models.Rating", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
