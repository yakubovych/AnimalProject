﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AnimalContext))]
    [Migration("20200215104522_initDb")]
    partial class initDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Berlin"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Hamburg"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Munich"
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Cologne"
                        },
                        new
                        {
                            Id = 5L,
                            Name = "Frankfurt"
                        },
                        new
                        {
                            Id = 6L,
                            Name = "Stuttgart"
                        },
                        new
                        {
                            Id = 7L,
                            Name = "Dusseldorf"
                        },
                        new
                        {
                            Id = 8L,
                            Name = "Dortmund"
                        },
                        new
                        {
                            Id = 9L,
                            Name = "Essen"
                        },
                        new
                        {
                            Id = 10L,
                            Name = "Leipzig"
                        });
                });

            modelBuilder.Entity("Domain.Models.Animal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AddressId")
                        .HasColumnType("bigint");

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<long>("ChipNumber")
                        .HasColumnType("bigint");

                    b.Property<bool>("ContinuatitonOfTreatment")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<long>("FoodId")
                        .HasColumnType("bigint");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsAdopted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("NeckCircumference")
                        .HasColumnType("float");

                    b.Property<int>("Sterialization")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("WithersHeight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FoodId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            Id = 2L,
                            AddressId = 2L,
                            CategoryId = 2L,
                            ChipNumber = 13345678L,
                            ContinuatitonOfTreatment = false,
                            DateOfBirth = new DateTime(2017, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 2L,
                            Gender = 1,
                            IsAdopted = true,
                            NeckCircumference = 9.1999999999999993,
                            Sterialization = 2,
                            Weight = 25.5,
                            WithersHeight = 45.0
                        },
                        new
                        {
                            Id = 3L,
                            AddressId = 1L,
                            CategoryId = 1L,
                            ChipNumber = 12245678L,
                            ContinuatitonOfTreatment = true,
                            DateOfBirth = new DateTime(2018, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 1L,
                            Gender = 0,
                            IsAdopted = false,
                            NeckCircumference = 10.199999999999999,
                            Sterialization = 0,
                            Weight = 15.5,
                            WithersHeight = 15.0
                        },
                        new
                        {
                            Id = 4L,
                            AddressId = 4L,
                            CategoryId = 3L,
                            ChipNumber = 12445678L,
                            ContinuatitonOfTreatment = false,
                            DateOfBirth = new DateTime(2014, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 3L,
                            Gender = 0,
                            IsAdopted = false,
                            NeckCircumference = 10.199999999999999,
                            Sterialization = 1,
                            Weight = 5.5,
                            WithersHeight = 5.0
                        },
                        new
                        {
                            Id = 5L,
                            AddressId = 1L,
                            CategoryId = 1L,
                            ChipNumber = 12355678L,
                            ContinuatitonOfTreatment = false,
                            DateOfBirth = new DateTime(2018, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 1L,
                            Gender = 1,
                            IsAdopted = false,
                            NeckCircumference = 10.199999999999999,
                            Sterialization = 0,
                            Weight = 2.5,
                            WithersHeight = 15.0
                        },
                        new
                        {
                            Id = 6L,
                            AddressId = 6L,
                            CategoryId = 2L,
                            ChipNumber = 12346678L,
                            ContinuatitonOfTreatment = true,
                            DateOfBirth = new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 2L,
                            Gender = 0,
                            IsAdopted = false,
                            NeckCircumference = 1.2,
                            Sterialization = 0,
                            Weight = 25.5,
                            WithersHeight = 45.0
                        },
                        new
                        {
                            Id = 7L,
                            AddressId = 6L,
                            CategoryId = 1L,
                            ChipNumber = 12345778L,
                            ContinuatitonOfTreatment = true,
                            DateOfBirth = new DateTime(2018, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 1L,
                            Gender = 0,
                            IsAdopted = false,
                            NeckCircumference = 10.199999999999999,
                            Sterialization = 2,
                            Weight = 25.5,
                            WithersHeight = 45.0
                        },
                        new
                        {
                            Id = 8L,
                            AddressId = 2L,
                            CategoryId = 1L,
                            ChipNumber = 12345688L,
                            ContinuatitonOfTreatment = true,
                            DateOfBirth = new DateTime(2018, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 1L,
                            Gender = 0,
                            IsAdopted = false,
                            NeckCircumference = 10.199999999999999,
                            Sterialization = 0,
                            Weight = 2.5,
                            WithersHeight = 15.0
                        },
                        new
                        {
                            Id = 9L,
                            AddressId = 2L,
                            CategoryId = 2L,
                            ChipNumber = 12345681L,
                            ContinuatitonOfTreatment = false,
                            DateOfBirth = new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 1L,
                            Gender = 1,
                            IsAdopted = false,
                            NeckCircumference = 1.2,
                            Sterialization = 1,
                            Weight = 12.5,
                            WithersHeight = 5.0
                        },
                        new
                        {
                            Id = 10L,
                            AddressId = 5L,
                            CategoryId = 1L,
                            ChipNumber = 33345688L,
                            ContinuatitonOfTreatment = true,
                            DateOfBirth = new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 3L,
                            Gender = 0,
                            IsAdopted = false,
                            NeckCircumference = 10.199999999999999,
                            Sterialization = 0,
                            Weight = 2.5,
                            WithersHeight = 15.0
                        },
                        new
                        {
                            Id = 11L,
                            AddressId = 4L,
                            CategoryId = 3L,
                            ChipNumber = 11145688L,
                            ContinuatitonOfTreatment = true,
                            DateOfBirth = new DateTime(2016, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 2L,
                            Gender = 1,
                            IsAdopted = false,
                            NeckCircumference = 10.199999999999999,
                            Sterialization = 0,
                            Weight = 21.5,
                            WithersHeight = 5.0
                        },
                        new
                        {
                            Id = 12L,
                            AddressId = 1L,
                            CategoryId = 1L,
                            ChipNumber = 444445688L,
                            ContinuatitonOfTreatment = false,
                            DateOfBirth = new DateTime(2018, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 1L,
                            Gender = 0,
                            IsAdopted = false,
                            NeckCircumference = 10.199999999999999,
                            Sterialization = 0,
                            Weight = 222.5,
                            WithersHeight = 15.0
                        },
                        new
                        {
                            Id = 13L,
                            AddressId = 2L,
                            CategoryId = 1L,
                            ChipNumber = 12342138L,
                            ContinuatitonOfTreatment = true,
                            DateOfBirth = new DateTime(2018, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 1L,
                            Gender = 0,
                            IsAdopted = false,
                            NeckCircumference = 10.199999999999999,
                            Sterialization = 0,
                            Weight = 2.5,
                            WithersHeight = 15.0
                        },
                        new
                        {
                            Id = 14L,
                            AddressId = 2L,
                            CategoryId = 1L,
                            ChipNumber = 32132688L,
                            ContinuatitonOfTreatment = true,
                            DateOfBirth = new DateTime(2018, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 1L,
                            Gender = 0,
                            IsAdopted = false,
                            NeckCircumference = 10.199999999999999,
                            Sterialization = 0,
                            Weight = 42.5,
                            WithersHeight = 125.0
                        },
                        new
                        {
                            Id = 15L,
                            AddressId = 4L,
                            CategoryId = 2L,
                            ChipNumber = 88885688L,
                            ContinuatitonOfTreatment = false,
                            DateOfBirth = new DateTime(2012, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 3L,
                            Gender = 1,
                            IsAdopted = true,
                            NeckCircumference = 0.20000000000000001,
                            Sterialization = 0,
                            Weight = 2.5,
                            WithersHeight = 15.0
                        },
                        new
                        {
                            Id = 16L,
                            AddressId = 3L,
                            CategoryId = 2L,
                            ChipNumber = 12345611L,
                            ContinuatitonOfTreatment = true,
                            DateOfBirth = new DateTime(2014, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FoodId = 2L,
                            Gender = 0,
                            IsAdopted = true,
                            NeckCircumference = 10.199999999999999,
                            Sterialization = 0,
                            Weight = 2.5,
                            WithersHeight = 15.0
                        });
                });

            modelBuilder.Entity("Domain.Models.AnimalAttitudeTo", b =>
                {
                    b.Property<long>("AnimalId")
                        .HasColumnType("bigint");

                    b.Property<long>("AttitudeId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnimalId", "AttitudeId");

                    b.HasIndex("AttitudeId");

                    b.ToTable("AnimalAttitudeTo");
                });

            modelBuilder.Entity("Domain.Models.AnimalDefects", b =>
                {
                    b.Property<long>("AnimalId")
                        .HasColumnType("bigint");

                    b.Property<long>("DefectsId")
                        .HasColumnType("bigint");

                    b.HasKey("AnimalId", "DefectsId");

                    b.HasIndex("DefectsId");

                    b.ToTable("AnimalDefects");
                });

            modelBuilder.Entity("Domain.Models.AnimalKeeping", b =>
                {
                    b.Property<long>("AnimalId")
                        .HasColumnType("bigint");

                    b.Property<long>("KeepingId")
                        .HasColumnType("bigint");

                    b.HasKey("AnimalId", "KeepingId");

                    b.HasIndex("KeepingId");

                    b.ToTable("AnimalKeeping");
                });

            modelBuilder.Entity("Domain.Models.AnimalNeeds", b =>
                {
                    b.Property<long>("AnimalId")
                        .HasColumnType("bigint");

                    b.Property<long>("NeedsId")
                        .HasColumnType("bigint");

                    b.HasKey("AnimalId", "NeedsId");

                    b.HasIndex("NeedsId");

                    b.ToTable("AnimalNeeds");
                });

            modelBuilder.Entity("Domain.Models.AnimalProcessing", b =>
                {
                    b.Property<long>("AnimalId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProcessingId")
                        .HasColumnType("bigint");

                    b.HasKey("AnimalId", "ProcessingId");

                    b.HasIndex("ProcessingId");

                    b.ToTable("AnimalProcessing");
                });

            modelBuilder.Entity("Domain.Models.AnimalVaccination", b =>
                {
                    b.Property<long>("AnimalId")
                        .HasColumnType("bigint");

                    b.Property<long>("VaccinationId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnimalId", "VaccinationId");

                    b.HasIndex("VaccinationId");

                    b.ToTable("AnimalVaccination");
                });

            modelBuilder.Entity("Domain.Models.AttitudeTo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AttitudeTo");
                });

            modelBuilder.Entity("Domain.Models.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Dog"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Cat"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Others"
                        });
                });

            modelBuilder.Entity("Domain.Models.Defect", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Defects");
                });

            modelBuilder.Entity("Domain.Models.Food", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Premium feed"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Medical feed"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Natural feed"
                        });
                });

            modelBuilder.Entity("Domain.Models.Image", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<long?>("AnimalId1")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Img")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId1");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Domain.Models.Keeping", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Keepings");
                });

            modelBuilder.Entity("Domain.Models.Needs", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Needs");
                });

            modelBuilder.Entity("Domain.Models.Processing", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Processings");
                });

            modelBuilder.Entity("Domain.Models.Vaccination", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vaccinations");
                });

            modelBuilder.Entity("Domain.Models.Animal", b =>
                {
                    b.HasOne("Domain.Models.Address", "Address")
                        .WithMany("Animals")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Category", "Category")
                        .WithMany("Animals")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Food", "Food")
                        .WithMany("Animals")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.AnimalAttitudeTo", b =>
                {
                    b.HasOne("Domain.Models.Animal", "Animal")
                        .WithMany("AnimalAttitudes")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.AttitudeTo", "AttitudeTo")
                        .WithMany("AnimalAttitudes")
                        .HasForeignKey("AttitudeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.AnimalDefects", b =>
                {
                    b.HasOne("Domain.Models.Animal", "Animal")
                        .WithMany("AnimalDefects")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Defect", "Defect")
                        .WithMany("AnimalDefects")
                        .HasForeignKey("DefectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.AnimalKeeping", b =>
                {
                    b.HasOne("Domain.Models.Animal", "Animal")
                        .WithMany("AnimalKeepings")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Keeping", "Keeping")
                        .WithMany("AnimalKeepings")
                        .HasForeignKey("KeepingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.AnimalNeeds", b =>
                {
                    b.HasOne("Domain.Models.Animal", "Animal")
                        .WithMany("AnimalNeeds")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Needs", "Needs")
                        .WithMany("AnimalNeeds")
                        .HasForeignKey("NeedsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.AnimalProcessing", b =>
                {
                    b.HasOne("Domain.Models.Animal", "Animal")
                        .WithMany("AnimalProcessings")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Processing", "Processing")
                        .WithMany("AnimalProcessings")
                        .HasForeignKey("ProcessingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.AnimalVaccination", b =>
                {
                    b.HasOne("Domain.Models.Animal", "Animal")
                        .WithMany("AnimalVaccinations")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Vaccination", "Vaccination")
                        .WithMany("AnimalVaccinations")
                        .HasForeignKey("VaccinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Image", b =>
                {
                    b.HasOne("Domain.Models.Animal", "Animal")
                        .WithMany("Images")
                        .HasForeignKey("AnimalId1");
                });
#pragma warning restore 612, 618
        }
    }
}
