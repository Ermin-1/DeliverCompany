﻿// <auto-generated />
using System;
using DeliverCompany.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DeliverCompany.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241002125043_Initials")]
    partial class Initials
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DeliverCompany.Models.Driver", b =>
                {
                    b.Property<int>("DriverID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DriverID"));

                    b.Property<decimal>("BeloppIn")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BeloppUt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CarReg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NoteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoteDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponsibleEmployee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalBeloppIn")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalBeloppUt")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("DriverID");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            DriverID = 1,
                            BeloppIn = 500.00m,
                            BeloppUt = 200.00m,
                            CarReg = "ABC123",
                            DriverName = "Alice Smith",
                            NoteDate = new DateTime(2024, 10, 1, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(3893),
                            NoteDescription = "Completed delivery route",
                            ResponsibleEmployee = "John Doe",
                            TotalBeloppIn = 500.00m,
                            TotalBeloppUt = 200.00m
                        },
                        new
                        {
                            DriverID = 2,
                            BeloppIn = 0.00m,
                            BeloppUt = 100.00m,
                            CarReg = "XYZ789",
                            DriverName = "Bob Johnson",
                            NoteDate = new DateTime(2024, 9, 30, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(3938),
                            NoteDescription = "Vehicle maintenance",
                            ResponsibleEmployee = "Admin User",
                            TotalBeloppIn = 0.00m,
                            TotalBeloppUt = 100.00m
                        },
                        new
                        {
                            DriverID = 3,
                            BeloppIn = 400.00m,
                            BeloppUt = 150.00m,
                            CarReg = "LMN456",
                            DriverName = "Michael Brown",
                            NoteDate = new DateTime(2024, 9, 29, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(3943),
                            NoteDescription = "Delivered groceries",
                            ResponsibleEmployee = "Jane Doe",
                            TotalBeloppIn = 400.00m,
                            TotalBeloppUt = 150.00m
                        },
                        new
                        {
                            DriverID = 4,
                            BeloppIn = 600.00m,
                            BeloppUt = 200.00m,
                            CarReg = "JKL789",
                            DriverName = "Emma Wilson",
                            NoteDate = new DateTime(2024, 9, 28, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(3946),
                            NoteDescription = "Completed overnight delivery",
                            ResponsibleEmployee = "Tom Hardy",
                            TotalBeloppIn = 600.00m,
                            TotalBeloppUt = 200.00m
                        },
                        new
                        {
                            DriverID = 5,
                            BeloppIn = 700.00m,
                            BeloppUt = 300.00m,
                            CarReg = "OPQ123",
                            DriverName = "Oliver Martinez",
                            NoteDate = new DateTime(2024, 9, 27, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(3950),
                            NoteDescription = "Completed furniture delivery",
                            ResponsibleEmployee = "Emily Davis",
                            TotalBeloppIn = 700.00m,
                            TotalBeloppUt = 300.00m
                        },
                        new
                        {
                            DriverID = 6,
                            BeloppIn = 1000.00m,
                            BeloppUt = 400.00m,
                            CarReg = "RST456",
                            DriverName = "Lucas Green",
                            NoteDate = new DateTime(2024, 9, 26, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(3953),
                            NoteDescription = "Delivered medical supplies",
                            ResponsibleEmployee = "Sophia Turner",
                            TotalBeloppIn = 1000.00m,
                            TotalBeloppUt = 400.00m
                        },
                        new
                        {
                            DriverID = 7,
                            BeloppIn = 1200.00m,
                            BeloppUt = 500.00m,
                            CarReg = "UVW789",
                            DriverName = "Liam White",
                            NoteDate = new DateTime(2024, 9, 25, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(3956),
                            NoteDescription = "Delivered electronics",
                            ResponsibleEmployee = "Luke Perry",
                            TotalBeloppIn = 1200.00m,
                            TotalBeloppUt = 500.00m
                        });
                });

            modelBuilder.Entity("DeliverCompany.Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("DeliverCompany.Models.Event", b =>
                {
                    b.Property<int>("EventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventID"));

                    b.Property<decimal>("BeloppIn")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BeloppUt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DriverID")
                        .HasColumnType("int");

                    b.Property<DateTime>("NoteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoteDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventID");

                    b.HasIndex("DriverID");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventID = 1,
                            BeloppIn = 400.00m,
                            BeloppUt = 50.00m,
                            DriverID = 1,
                            NoteDate = new DateTime(2024, 10, 1, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(4102),
                            NoteDescription = "Delivered goods to customer"
                        },
                        new
                        {
                            EventID = 2,
                            BeloppIn = 0.00m,
                            BeloppUt = 300.00m,
                            DriverID = 2,
                            NoteDate = new DateTime(2024, 9, 30, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(4105),
                            NoteDescription = "Vehicle repaired"
                        },
                        new
                        {
                            EventID = 3,
                            BeloppIn = 0.00m,
                            BeloppUt = 100.00m,
                            DriverID = 1,
                            NoteDate = new DateTime(2024, 9, 29, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(4108),
                            NoteDescription = "Picked up supplies"
                        },
                        new
                        {
                            EventID = 4,
                            BeloppIn = 400.00m,
                            BeloppUt = 50.00m,
                            DriverID = 3,
                            NoteDate = new DateTime(2024, 9, 28, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(4110),
                            NoteDescription = "Delivered groceries"
                        },
                        new
                        {
                            EventID = 5,
                            BeloppIn = 600.00m,
                            BeloppUt = 100.00m,
                            DriverID = 4,
                            NoteDate = new DateTime(2024, 9, 27, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(4112),
                            NoteDescription = "Completed overnight delivery"
                        },
                        new
                        {
                            EventID = 6,
                            BeloppIn = 700.00m,
                            BeloppUt = 150.00m,
                            DriverID = 5,
                            NoteDate = new DateTime(2024, 9, 26, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(4114),
                            NoteDescription = "Furniture delivered"
                        },
                        new
                        {
                            EventID = 7,
                            BeloppIn = 1000.00m,
                            BeloppUt = 200.00m,
                            DriverID = 6,
                            NoteDate = new DateTime(2024, 9, 25, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(4116),
                            NoteDescription = "Delivered medical supplies"
                        },
                        new
                        {
                            EventID = 8,
                            BeloppIn = 1200.00m,
                            BeloppUt = 300.00m,
                            DriverID = 7,
                            NoteDate = new DateTime(2024, 9, 24, 14, 50, 43, 73, DateTimeKind.Local).AddTicks(4118),
                            NoteDescription = "Delivered electronics"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DeliverCompany.Models.Event", b =>
                {
                    b.HasOne("DeliverCompany.Models.Driver", "Driver")
                        .WithMany("Events")
                        .HasForeignKey("DriverID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DeliverCompany.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DeliverCompany.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DeliverCompany.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DeliverCompany.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DeliverCompany.Models.Driver", b =>
                {
                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}