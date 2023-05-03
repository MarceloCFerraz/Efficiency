﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace back_end.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230503201755_added storeID 1 to admin")]
    partial class addedstoreID1toadmin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Efficiency.Models.Goal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int?>("StoreID")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("double");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("StoreID");

                    b.ToTable("Goals");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Month = 9,
                            StoreID = 1,
                            Value = 8481317.0,
                            Year = 2022
                        },
                        new
                        {
                            ID = 2,
                            Month = 10,
                            StoreID = 1,
                            Value = 7079055.0,
                            Year = 2022
                        },
                        new
                        {
                            ID = 3,
                            Month = 11,
                            StoreID = 1,
                            Value = 4581755.0,
                            Year = 2022
                        },
                        new
                        {
                            ID = 4,
                            Month = 12,
                            StoreID = 1,
                            Value = 6721971.0,
                            Year = 2022
                        },
                        new
                        {
                            ID = 5,
                            Month = 1,
                            StoreID = 1,
                            Value = 8239781.0,
                            Year = 2023
                        },
                        new
                        {
                            ID = 6,
                            Month = 2,
                            StoreID = 1,
                            Value = 1687245.0,
                            Year = 2023
                        },
                        new
                        {
                            ID = 7,
                            Month = 3,
                            StoreID = 1,
                            Value = 6932877.0,
                            Year = 2023
                        },
                        new
                        {
                            ID = 8,
                            Month = 4,
                            StoreID = 1,
                            Value = 7093967.0,
                            Year = 2023
                        });
                });

            modelBuilder.Entity("Efficiency.Models.Result", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("SellerID")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("ID");

                    b.HasIndex("SellerID");

                    b.ToTable("Results");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Date = new DateOnly(2022, 7, 30),
                            SellerID = 2,
                            Value = 10574m
                        },
                        new
                        {
                            ID = 2,
                            Date = new DateOnly(2023, 3, 17),
                            SellerID = 3,
                            Value = 12384m
                        },
                        new
                        {
                            ID = 3,
                            Date = new DateOnly(2023, 1, 16),
                            SellerID = 1,
                            Value = 114443m
                        },
                        new
                        {
                            ID = 4,
                            Date = new DateOnly(2022, 7, 20),
                            SellerID = 4,
                            Value = 1823m
                        },
                        new
                        {
                            ID = 5,
                            Date = new DateOnly(2023, 2, 15),
                            SellerID = 4,
                            Value = 176370m
                        },
                        new
                        {
                            ID = 6,
                            Date = new DateOnly(2022, 10, 29),
                            SellerID = 2,
                            Value = 147842m
                        },
                        new
                        {
                            ID = 7,
                            Date = new DateOnly(2022, 7, 9),
                            SellerID = 2,
                            Value = 23805m
                        },
                        new
                        {
                            ID = 8,
                            Date = new DateOnly(2023, 3, 7),
                            SellerID = 2,
                            Value = 156669m
                        },
                        new
                        {
                            ID = 9,
                            Date = new DateOnly(2022, 5, 6),
                            SellerID = 3,
                            Value = 73181m
                        },
                        new
                        {
                            ID = 10,
                            Date = new DateOnly(2023, 3, 29),
                            SellerID = 3,
                            Value = 124042m
                        });
                });

            modelBuilder.Entity("Efficiency.Models.Seller", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.Property<int>("RegistrationNumber")
                        .HasColumnType("int");

                    b.Property<int?>("StoreID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("StoreID");

                    b.ToTable("Sellers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Active = true,
                            Email = "tereza-lopes72@comdados.com",
                            FirstName = "Tereza Carla",
                            LastName = "Isabelly Lopes",
                            Phone = "81985172642",
                            RegistrationNumber = 5170971,
                            StoreID = 1
                        },
                        new
                        {
                            ID = 2,
                            Active = true,
                            Email = "claudia.sophia.dasneves@octagonbrasil.com.br",
                            FirstName = "Cláudia Sophia",
                            LastName = "Luciana das Neves",
                            Phone = "84992669321",
                            RegistrationNumber = 8377984,
                            StoreID = 1
                        },
                        new
                        {
                            ID = 3,
                            Active = true,
                            Email = "henry.guilherme.campos@integrasjc.com.br",
                            FirstName = "Henry Guilherme",
                            LastName = "Isaac Campos",
                            Phone = "42983716441",
                            RegistrationNumber = 2054591,
                            StoreID = 1
                        },
                        new
                        {
                            ID = 4,
                            Active = true,
                            Email = "danilo_dias@marithimaconstrutora.com.br",
                            FirstName = "Danilo Giovanni",
                            LastName = "Dias",
                            Phone = "45996347291",
                            RegistrationNumber = 2096378,
                            StoreID = 1
                        },
                        new
                        {
                            ID = 5,
                            Active = true,
                            Email = "jorge_mario_farias@yool.com.br",
                            FirstName = "Jorge Mário José",
                            LastName = "Farias",
                            Phone = "68983670574",
                            RegistrationNumber = 1328623,
                            StoreID = 1
                        });
                });

            modelBuilder.Entity("Efficiency.Models.Service", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("StoreID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("StoreID");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Extended Guarantee",
                            StoreID = 1
                        },
                        new
                        {
                            ID = 2,
                            Name = "Techinical Insurance",
                            StoreID = 1
                        });
                });

            modelBuilder.Entity("Efficiency.Models.ServiceGoal", b =>
                {
                    b.Property<int>("GoalID")
                        .HasColumnType("int");

                    b.Property<int>("ServiceID")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("GoalID", "ServiceID");

                    b.HasIndex("ServiceID");

                    b.ToTable("ServicesGoal");

                    b.HasData(
                        new
                        {
                            GoalID = 1,
                            ServiceID = 1,
                            Value = 676597m
                        },
                        new
                        {
                            GoalID = 1,
                            ServiceID = 2,
                            Value = 445315m
                        },
                        new
                        {
                            GoalID = 2,
                            ServiceID = 1,
                            Value = 912491m
                        },
                        new
                        {
                            GoalID = 2,
                            ServiceID = 2,
                            Value = 912491m
                        },
                        new
                        {
                            GoalID = 3,
                            ServiceID = 1,
                            Value = 549813m
                        },
                        new
                        {
                            GoalID = 3,
                            ServiceID = 2,
                            Value = 894390m
                        },
                        new
                        {
                            GoalID = 4,
                            ServiceID = 1,
                            Value = 472433m
                        },
                        new
                        {
                            GoalID = 4,
                            ServiceID = 2,
                            Value = 983652m
                        },
                        new
                        {
                            GoalID = 5,
                            ServiceID = 1,
                            Value = 237428m
                        },
                        new
                        {
                            GoalID = 5,
                            ServiceID = 2,
                            Value = 235060m
                        },
                        new
                        {
                            GoalID = 6,
                            ServiceID = 1,
                            Value = 131204m
                        },
                        new
                        {
                            GoalID = 6,
                            ServiceID = 2,
                            Value = 938524m
                        },
                        new
                        {
                            GoalID = 7,
                            ServiceID = 1,
                            Value = 877191m
                        },
                        new
                        {
                            GoalID = 7,
                            ServiceID = 2,
                            Value = 557740m
                        },
                        new
                        {
                            GoalID = 8,
                            ServiceID = 1,
                            Value = 500145m
                        },
                        new
                        {
                            GoalID = 8,
                            ServiceID = 2,
                            Value = 360438m
                        });
                });

            modelBuilder.Entity("Efficiency.Models.ServiceResult", b =>
                {
                    b.Property<int>("ResultID")
                        .HasColumnType("int");

                    b.Property<int>("ServiceID")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("ResultID", "ServiceID");

                    b.HasIndex("ServiceID");

                    b.ToTable("ServicesResult");

                    b.HasData(
                        new
                        {
                            ResultID = 1,
                            ServiceID = 1,
                            Value = 67784m
                        },
                        new
                        {
                            ResultID = 1,
                            ServiceID = 2,
                            Value = 173210m
                        },
                        new
                        {
                            ResultID = 2,
                            ServiceID = 1,
                            Value = 62121m
                        },
                        new
                        {
                            ResultID = 2,
                            ServiceID = 2,
                            Value = 12506m
                        },
                        new
                        {
                            ResultID = 3,
                            ServiceID = 1,
                            Value = 106495m
                        },
                        new
                        {
                            ResultID = 3,
                            ServiceID = 2,
                            Value = 12170m
                        },
                        new
                        {
                            ResultID = 4,
                            ServiceID = 1,
                            Value = 113523m
                        },
                        new
                        {
                            ResultID = 4,
                            ServiceID = 2,
                            Value = 173869m
                        },
                        new
                        {
                            ResultID = 5,
                            ServiceID = 1,
                            Value = 181087m
                        },
                        new
                        {
                            ResultID = 5,
                            ServiceID = 2,
                            Value = 106883m
                        },
                        new
                        {
                            ResultID = 6,
                            ServiceID = 1,
                            Value = 103405m
                        },
                        new
                        {
                            ResultID = 6,
                            ServiceID = 2,
                            Value = 197037m
                        },
                        new
                        {
                            ResultID = 7,
                            ServiceID = 1,
                            Value = 139618m
                        },
                        new
                        {
                            ResultID = 7,
                            ServiceID = 2,
                            Value = 36531m
                        },
                        new
                        {
                            ResultID = 8,
                            ServiceID = 1,
                            Value = 1906m
                        },
                        new
                        {
                            ResultID = 8,
                            ServiceID = 2,
                            Value = 1058m
                        },
                        new
                        {
                            ResultID = 9,
                            ServiceID = 1,
                            Value = 1215m
                        },
                        new
                        {
                            ResultID = 9,
                            ServiceID = 2,
                            Value = 1888m
                        },
                        new
                        {
                            ResultID = 10,
                            ServiceID = 1,
                            Value = 110m
                        },
                        new
                        {
                            ResultID = 10,
                            ServiceID = 2,
                            Value = 1312m
                        });
                });

            modelBuilder.Entity("Efficiency.Models.Store", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Complement")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<string>("District")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Observations")
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .HasColumnType("longtext");

                    b.Property<string>("Street")
                        .HasColumnType("longtext");

                    b.Property<string>("ZipCode")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            City = "São Paulo",
                            Complement = "Prédio público",
                            Country = "Brazil",
                            District = "Mooca",
                            Name = "EFFICIENCY STORE",
                            Observations = "This is where the observations should be inserted",
                            State = "São Paulo",
                            Street = "Praça Maria Cândida Freitas de Oliveira, 18",
                            ZipCode = "03168070"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser<int>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Efficiency.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser<int>");

                    b.Property<bool?>("FirstLogin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .HasColumnType("longtext");

                    b.Property<int?>("StoreID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SubscriptionBegin")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("SubscriptionExpiration")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SubscriptionType")
                        .HasColumnType("int");

                    b.HasIndex("StoreID");

                    b.HasDiscriminator().HasValue("User");

                    b.HasData(
                        new
                        {
                            Id = 9999,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "641c9919-6a9d-41e0-afd6-2f62b1d8772a",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAENkKRyWMj8YDnvtrartxu35KhRJMJ6fFzVJUCfgEolx+GX6U9iJAn0l4ZsYJ95Dpxg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "518b6760-899d-4a96-ba20-c959afd811d4",
                            TwoFactorEnabled = false,
                            UserName = "admin",
                            FirstLogin = true,
                            Role = "ADMIN",
                            StoreID = 1,
                            SubscriptionBegin = new DateTime(2023, 5, 3, 20, 17, 55, 410, DateTimeKind.Utc).AddTicks(2639),
                            SubscriptionExpiration = new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999),
                            SubscriptionType = 120000
                        });
                });

            modelBuilder.Entity("Efficiency.Models.Goal", b =>
                {
                    b.HasOne("Efficiency.Models.Store", "Store")
                        .WithMany("Goals")
                        .HasForeignKey("StoreID");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("Efficiency.Models.Result", b =>
                {
                    b.HasOne("Efficiency.Models.Seller", "Seller")
                        .WithMany("Results")
                        .HasForeignKey("SellerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("Efficiency.Models.Seller", b =>
                {
                    b.HasOne("Efficiency.Models.Store", "Store")
                        .WithMany("Sellers")
                        .HasForeignKey("StoreID");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("Efficiency.Models.Service", b =>
                {
                    b.HasOne("Efficiency.Models.Store", "Store")
                        .WithMany("Services")
                        .HasForeignKey("StoreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Store");
                });

            modelBuilder.Entity("Efficiency.Models.ServiceGoal", b =>
                {
                    b.HasOne("Efficiency.Models.Goal", "Goal")
                        .WithMany("ServicesGoal")
                        .HasForeignKey("GoalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Efficiency.Models.Service", "Service")
                        .WithMany("ServicesGoal")
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Goal");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Efficiency.Models.ServiceResult", b =>
                {
                    b.HasOne("Efficiency.Models.Result", "Result")
                        .WithMany("ResultsServices")
                        .HasForeignKey("ResultID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Efficiency.Models.Service", "Service")
                        .WithMany("ServicesResult")
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Result");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<int>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<int>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<int>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<int>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Efficiency.Models.User", b =>
                {
                    b.HasOne("Efficiency.Models.Store", "Store")
                        .WithMany("Users")
                        .HasForeignKey("StoreID");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("Efficiency.Models.Goal", b =>
                {
                    b.Navigation("ServicesGoal");
                });

            modelBuilder.Entity("Efficiency.Models.Result", b =>
                {
                    b.Navigation("ResultsServices");
                });

            modelBuilder.Entity("Efficiency.Models.Seller", b =>
                {
                    b.Navigation("Results");
                });

            modelBuilder.Entity("Efficiency.Models.Service", b =>
                {
                    b.Navigation("ServicesGoal");

                    b.Navigation("ServicesResult");
                });

            modelBuilder.Entity("Efficiency.Models.Store", b =>
                {
                    b.Navigation("Goals");

                    b.Navigation("Sellers");

                    b.Navigation("Services");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}