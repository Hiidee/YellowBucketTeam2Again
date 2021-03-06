// <auto-generated />
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
    [Migration("20201217212541_CreateGenres")]
    partial class CreateGenres
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("YellowBucket.Models.Genre", b =>
                {
                    b.Property<int>("Genre_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("varchar(4096)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(128)");

                    b.HasKey("Genre_ID");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("YellowBucket.Models.Movie", b =>
                {
                    b.Property<int>("Movie_ID")
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

                    b.Property<int>("Genre_ID")
                        .HasColumnType("int");

                    b.Property<bool>("Is_BluRay")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_Dvd")
                        .HasColumnType("bit");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int>("Rating_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Release_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime?>("Updated_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Movie_ID");

                    b.ToTable("Movie");
                });
#pragma warning restore 612, 618
        }
    }
}
