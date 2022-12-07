﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using csharp_boolflix.Data;

#nullable disable

namespace csharp_boolflix.Migrations
{
    [DbContext(typeof(BoolflixContext))]
    [Migration("20221207100613_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ActorMediaExtended", b =>
                {
                    b.Property<int>("ActorsId")
                        .HasColumnType("int");

                    b.Property<int>("MediasId")
                        .HasColumnType("int");

                    b.HasKey("ActorsId", "MediasId");

                    b.HasIndex("MediasId");

                    b.ToTable("ActorMediaExtended");
                });

            modelBuilder.Entity("csharp_boolflix.Data.Models.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("PlaybackPoint")
                        .HasColumnType("int");

                    b.Property<int>("SeasonNumber")
                        .HasColumnType("int");

                    b.Property<int>("SerieId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SerieId");

                    b.ToTable("Episode");
                });

            modelBuilder.Entity("csharp_boolflix.Data.Models.MediaExtended", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Anno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("PlaybackPoint")
                        .HasColumnType("int");

                    b.Property<string>("Quality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MediaExtended");

                    b.HasDiscriminator<string>("Discriminator").HasValue("MediaExtended");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FristName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Features", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("FeaturesMediaExtended", b =>
                {
                    b.Property<int>("FeaturesId")
                        .HasColumnType("int");

                    b.Property<int>("MediasId")
                        .HasColumnType("int");

                    b.HasKey("FeaturesId", "MediasId");

                    b.HasIndex("MediasId");

                    b.ToTable("FeaturesMediaExtended");
                });

            modelBuilder.Entity("GenreMediaExtended", b =>
                {
                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.Property<int>("MediasId")
                        .HasColumnType("int");

                    b.HasKey("GenresId", "MediasId");

                    b.HasIndex("MediasId");

                    b.ToTable("GenreMediaExtended");
                });

            modelBuilder.Entity("csharp_boolflix.Data.Models.Serie", b =>
                {
                    b.HasBaseType("csharp_boolflix.Data.Models.MediaExtended");

                    b.Property<int>("SeasonsNumber")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Serie");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Film", b =>
                {
                    b.HasBaseType("csharp_boolflix.Data.Models.MediaExtended");

                    b.HasDiscriminator().HasValue("Film");
                });

            modelBuilder.Entity("ActorMediaExtended", b =>
                {
                    b.HasOne("csharp_boolflix.Models.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_boolflix.Data.Models.MediaExtended", null)
                        .WithMany()
                        .HasForeignKey("MediasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("csharp_boolflix.Data.Models.Episode", b =>
                {
                    b.HasOne("csharp_boolflix.Data.Models.Serie", "Serie")
                        .WithMany("Episodes")
                        .HasForeignKey("SerieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Serie");
                });

            modelBuilder.Entity("FeaturesMediaExtended", b =>
                {
                    b.HasOne("csharp_boolflix.Models.Features", null)
                        .WithMany()
                        .HasForeignKey("FeaturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_boolflix.Data.Models.MediaExtended", null)
                        .WithMany()
                        .HasForeignKey("MediasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenreMediaExtended", b =>
                {
                    b.HasOne("csharp_boolflix.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_boolflix.Data.Models.MediaExtended", null)
                        .WithMany()
                        .HasForeignKey("MediasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("csharp_boolflix.Data.Models.Serie", b =>
                {
                    b.Navigation("Episodes");
                });
#pragma warning restore 612, 618
        }
    }
}
