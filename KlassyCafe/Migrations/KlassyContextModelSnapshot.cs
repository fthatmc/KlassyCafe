﻿// <auto-generated />
using KlassyCafe.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KlassyCafe.Migrations
{
    [DbContext(typeof(KlassyContext))]
    partial class KlassyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("KlassyCafe.DAL.Entities.AboutUs", b =>
                {
                    b.Property<int>("AboutUsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AboutUsId"));

                    b.Property<int>("AboutUsImageId")
                        .HasColumnType("integer");

                    b.Property<int>("VideoId")
                        .HasColumnType("integer");

                    b.HasKey("AboutUsId");

                    b.HasIndex("AboutUsImageId");

                    b.HasIndex("VideoId");

                    b.ToTable("AboutUss");
                });

            modelBuilder.Entity("KlassyCafe.DAL.Entities.AboutUsImage", b =>
                {
                    b.Property<int>("AboutUsImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AboutUsImageId"));

                    b.Property<string>("Image1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image3")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AboutUsImageId");

                    b.ToTable("AboutUsImages");
                });

            modelBuilder.Entity("KlassyCafe.DAL.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("KlassyCafe.DAL.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsFeature")
                        .HasColumnType("boolean");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Total")
                        .HasColumnType("double precision");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("KlassyCafe.DAL.Entities.Slider", b =>
                {
                    b.Property<int>("SliderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SliderId"));

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsSlider")
                        .HasColumnType("boolean");

                    b.HasKey("SliderId");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("KlassyCafe.DAL.Entities.Video", b =>
                {
                    b.Property<int>("VideoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("VideoId"));

                    b.Property<string>("VideoURL")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("VideoId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("KlassyCafe.DAL.Entities.AboutUs", b =>
                {
                    b.HasOne("KlassyCafe.DAL.Entities.AboutUsImage", "Images")
                        .WithMany("AboutUss")
                        .HasForeignKey("AboutUsImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KlassyCafe.DAL.Entities.Video", "Videos")
                        .WithMany("AboutUss")
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Images");

                    b.Navigation("Videos");
                });

            modelBuilder.Entity("KlassyCafe.DAL.Entities.Product", b =>
                {
                    b.HasOne("KlassyCafe.DAL.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("KlassyCafe.DAL.Entities.AboutUsImage", b =>
                {
                    b.Navigation("AboutUss");
                });

            modelBuilder.Entity("KlassyCafe.DAL.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("KlassyCafe.DAL.Entities.Video", b =>
                {
                    b.Navigation("AboutUss");
                });
#pragma warning restore 612, 618
        }
    }
}