﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stix.Data;

#nullable disable

namespace Stix.Migrations.Restaurant
{
    [DbContext(typeof(RestaurantContext))]
    [Migration("20230430092233_RestaurantDbCorrection")]
    partial class RestaurantDbCorrection
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Stix.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescriptionFood")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsVeganFood")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsVegetarianFood")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameFood")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("Stix.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("FoodId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Neighbourhood")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Provincia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.ToTable("Restaurant");
                });

            modelBuilder.Entity("Stix.Models.Restaurant", b =>
                {
                    b.HasOne("Stix.Models.Food", "Food")
                        .WithMany("Restaurants")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");
                });

            modelBuilder.Entity("Stix.Models.Food", b =>
                {
                    b.Navigation("Restaurants");
                });
#pragma warning restore 612, 618
        }
    }
}
