﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using demoexam.Models;

#nullable disable

namespace demoexam.Migrations
{
    [DbContext(typeof(AverinaAContext))]
    [Migration("20241203114734_Number1")]
    partial class Number1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("demoexam.Models.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("GuestId")
                        .HasColumnType("int")
                        .HasColumnName("guest_id");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("price");

                    b.Property<int?>("RentId")
                        .HasColumnType("int")
                        .HasColumnName("rent_id");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int")
                        .HasColumnName("service_id");

                    b.Property<string>("Sum")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("sum");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("demoexam.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly?>("Birthdate")
                        .HasColumnType("date")
                        .HasColumnName("birthdate");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("Passport")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("passport");

                    b.Property<string>("Patronym")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("patronym");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("surname");

                    b.HasKey("Id");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("demoexam.Models.Rent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("category");

                    b.Property<DateOnly?>("Checkin")
                        .HasColumnType("date")
                        .HasColumnName("checkin");

                    b.Property<DateOnly?>("Checkout")
                        .HasColumnType("date")
                        .HasColumnName("checkout");

                    b.Property<string>("Floor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("floor");

                    b.Property<int?>("GuestId")
                        .HasColumnType("int")
                        .HasColumnName("guest_id");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int")
                        .HasColumnName("room_id");

                    b.HasKey("Id");

                    b.ToTable("Rents");
                });

            modelBuilder.Entity("demoexam.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("category");

                    b.Property<string>("Floor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("floor");

                    b.Property<int?>("Room1")
                        .HasColumnType("int")
                        .HasColumnName("room");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("demoexam.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("demoexam.Models.Shift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cleaner")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cleaner");

                    b.Property<DateOnly?>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int")
                        .HasColumnName("room_id");

                    b.HasKey("Id");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("demoexam.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("role");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
