﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YellowBucket.Data;

namespace YellowBucket.Migrations
{
    [DbContext(typeof(YellowBucketContext))]
    partial class YellowBucketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("YellowBucket.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("varchar(4096)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(128)");

                    b.HasKey("GenreId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("YellowBucket.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(32)");

                    b.HasKey("RatingId");

                    b.ToTable("Rating");
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

            modelBuilder.Entity("YellowBucket.Models.Genre", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("YellowBucket.Models.Rating", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
