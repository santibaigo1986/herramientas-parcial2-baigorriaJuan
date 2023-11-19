﻿// <auto-generated />
using System;
using BaigorriaJuan.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaigorriaJuan.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231119214138_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("BaigorriaJuan.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("BaigorriaJuan.Models.Actor_Movie", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MovieId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("Actors_Movies");
                });

            modelBuilder.Entity("BaigorriaJuan.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("BaigorriaJuan.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CinemaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MovieCategory")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("ProducerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("BaigorriaJuan.Models.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Prducers");
                });

            modelBuilder.Entity("BaigorriaJuan.Models.Actor_Movie", b =>
                {
                    b.HasOne("BaigorriaJuan.Models.Actor", "Actor")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaigorriaJuan.Models.Movie", "Movie")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("BaigorriaJuan.Models.Movie", b =>
                {
                    b.HasOne("BaigorriaJuan.Models.Cinema", "Cinema")
                        .WithMany("Movies")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaigorriaJuan.Models.Producer", "Producer")
                        .WithMany("Movies")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("BaigorriaJuan.Models.Actor", b =>
                {
                    b.Navigation("Actors_Movies");
                });

            modelBuilder.Entity("BaigorriaJuan.Models.Cinema", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("BaigorriaJuan.Models.Movie", b =>
                {
                    b.Navigation("Actors_Movies");
                });

            modelBuilder.Entity("BaigorriaJuan.Models.Producer", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
