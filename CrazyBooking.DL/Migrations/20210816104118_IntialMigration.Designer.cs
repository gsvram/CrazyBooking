﻿// <auto-generated />
using System;
using CrazyBooking.DL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrazyBooking.DL.Migrations
{
    [DbContext(typeof(CarzyBookingContext))]
    [Migration("20210816104118_IntialMigration")]
    partial class IntialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrazyBooking.Model.BookingDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GuestDetailId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDt")
                        .HasColumnType("datetime2");

                    b.Property<string>("SeatNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShowId")
                        .HasColumnType("int");

                    b.Property<int>("TotalTickets")
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("GuestDetailId");

                    b.HasIndex("ShowId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("CrazyBooking.Model.Gallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDt")
                        .HasColumnType("datetime2");

                    b.Property<int>("GallaryType")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParkDetailsId")
                        .HasColumnType("int");

                    b.Property<int>("TotalTickets")
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ParkDetailsId");

                    b.ToTable("Galleries");
                });

            modelBuilder.Entity("CrazyBooking.Model.GuestDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdult")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMainTicketHolder")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("GuestDetails");
                });

            modelBuilder.Entity("CrazyBooking.Model.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AllowedAge")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RunningDuration")
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("CrazyBooking.Model.ParkDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ParkDetails");
                });

            modelBuilder.Entity("CrazyBooking.Model.Seating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDt")
                        .HasColumnType("datetime2");

                    b.Property<int>("RowNumber")
                        .HasColumnType("int");

                    b.Property<int?>("ScreenId")
                        .HasColumnType("int");

                    b.Property<string>("SeatNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ScreenId");

                    b.ToTable("Seating");
                });

            modelBuilder.Entity("CrazyBooking.Model.Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookingDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<int?>("ScreenId")
                        .HasColumnType("int");

                    b.Property<string>("TimeEnd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeStart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BookingDetailsId");

                    b.HasIndex("MovieId");

                    b.HasIndex("ScreenId");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("CrazyBooking.Model.BookingDetails", b =>
                {
                    b.HasOne("CrazyBooking.Model.GuestDetails", "GuestDetails")
                        .WithMany()
                        .HasForeignKey("GuestDetailId");

                    b.HasOne("CrazyBooking.Model.Show", "Show")
                        .WithMany()
                        .HasForeignKey("ShowId");

                    b.Navigation("GuestDetails");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("CrazyBooking.Model.Gallery", b =>
                {
                    b.HasOne("CrazyBooking.Model.ParkDetails", "Prak")
                        .WithMany("Galleries")
                        .HasForeignKey("ParkDetailsId");

                    b.Navigation("Prak");
                });

            modelBuilder.Entity("CrazyBooking.Model.Seating", b =>
                {
                    b.HasOne("CrazyBooking.Model.Gallery", "Screen")
                        .WithMany("Seatings")
                        .HasForeignKey("ScreenId");

                    b.Navigation("Screen");
                });

            modelBuilder.Entity("CrazyBooking.Model.Show", b =>
                {
                    b.HasOne("CrazyBooking.Model.BookingDetails", null)
                        .WithMany("ShowDetails")
                        .HasForeignKey("BookingDetailsId");

                    b.HasOne("CrazyBooking.Model.Movie", "Movie")
                        .WithMany("ShowDetails")
                        .HasForeignKey("MovieId");

                    b.HasOne("CrazyBooking.Model.Gallery", "Screen")
                        .WithMany("ShowDetails")
                        .HasForeignKey("ScreenId");

                    b.Navigation("Movie");

                    b.Navigation("Screen");
                });

            modelBuilder.Entity("CrazyBooking.Model.BookingDetails", b =>
                {
                    b.Navigation("ShowDetails");
                });

            modelBuilder.Entity("CrazyBooking.Model.Gallery", b =>
                {
                    b.Navigation("Seatings");

                    b.Navigation("ShowDetails");
                });

            modelBuilder.Entity("CrazyBooking.Model.Movie", b =>
                {
                    b.Navigation("ShowDetails");
                });

            modelBuilder.Entity("CrazyBooking.Model.ParkDetails", b =>
                {
                    b.Navigation("Galleries");
                });
#pragma warning restore 612, 618
        }
    }
}
