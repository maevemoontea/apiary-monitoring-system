﻿// <auto-generated />
using System;
using ApiaryMonitoringSystem.DAL.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiaryMonitoringSystem.DAL.Migrations
{
    [DbContext(typeof(ApiaryContext))]
    [Migration("20200430094844_WithoutChanges2")]
    partial class WithoutChanges2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiaryMonitoringSystem.DAL.Entities.Apiary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("apiary_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Beekeeper")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("apiary_title")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Apiaries");
                });

            modelBuilder.Entity("ApiaryMonitoringSystem.DAL.Entities.BeeHive", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("hive_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ApiaryId")
                        .HasColumnName("apiary_id")
                        .HasColumnType("int");

                    b.Property<int>("FamilyClass")
                        .HasColumnType("int");

                    b.Property<string>("HiveType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnName("hive_number")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("QueenbeeAge")
                        .HasColumnType("int");

                    b.Property<string>("QueenbeeBreed")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApiaryId");

                    b.ToTable("Bee_hives");
                });

            modelBuilder.Entity("ApiaryMonitoringSystem.DAL.Entities.HealthStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("health_status_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BeehiveId")
                        .IsRequired()
                        .HasColumnName("hive_id")
                        .HasColumnType("int");

                    b.Property<int>("Humidity")
                        .HasColumnType("int");

                    b.Property<int>("IntensityOnHigh")
                        .HasColumnType("int");

                    b.Property<int>("IntensityOnLow")
                        .HasColumnType("int");

                    b.Property<int>("IntensityOnMediate")
                        .HasColumnType("int");

                    b.Property<int>("MaxIntensityFrequency")
                        .HasColumnType("int");

                    b.Property<string>("SoundFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Temperature")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BeehiveId");

                    b.ToTable("Health_statuses");
                });

            modelBuilder.Entity("ApiaryMonitoringSystem.DAL.Entities.Inspection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("inspection_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte?>("AggressivenessEstimation")
                        .HasColumnType("tinyint");

                    b.Property<bool?>("BabyQueensExist")
                        .HasColumnType("bit");

                    b.Property<int?>("BeehiveId")
                        .IsRequired()
                        .HasColumnName("hive_id")
                        .HasColumnType("int");

                    b.Property<byte?>("BeesFlightEstimation")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("BroodFrames")
                        .HasColumnType("tinyint");

                    b.Property<byte>("BroodFramesAdded")
                        .HasColumnType("tinyint");

                    b.Property<byte>("BroodFramesRemoved")
                        .HasColumnType("tinyint");

                    b.Property<bool?>("DailyBroodExist")
                        .HasColumnType("bit");

                    b.Property<byte>("EmptyFramesAdded")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("HoneyFrames")
                        .HasColumnType("tinyint");

                    b.Property<byte>("HoneyFramesAdded")
                        .HasColumnType("tinyint");

                    b.Property<byte>("HoneyFramesRemoved")
                        .HasColumnType("tinyint");

                    b.Property<bool?>("QueenExist")
                        .HasColumnType("bit");

                    b.Property<bool?>("Swarming")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<byte>("TotalFrames")
                        .HasColumnType("tinyint");

                    b.Property<byte>("TotalFramesAdded")
                        .HasColumnType("tinyint");

                    b.Property<byte>("TotalFramesRemoved")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("BeehiveId");

                    b.ToTable("Inspections");
                });

            modelBuilder.Entity("ApiaryMonitoringSystem.DAL.Entities.BeeHive", b =>
                {
                    b.HasOne("ApiaryMonitoringSystem.DAL.Entities.Apiary", "Apiary")
                        .WithMany("BeeHives")
                        .HasForeignKey("ApiaryId");
                });

            modelBuilder.Entity("ApiaryMonitoringSystem.DAL.Entities.HealthStatus", b =>
                {
                    b.HasOne("ApiaryMonitoringSystem.DAL.Entities.BeeHive", "Beehive")
                        .WithMany("HealthStatuses")
                        .HasForeignKey("BeehiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiaryMonitoringSystem.DAL.Entities.Inspection", b =>
                {
                    b.HasOne("ApiaryMonitoringSystem.DAL.Entities.BeeHive", "Beehive")
                        .WithMany("Inspections")
                        .HasForeignKey("BeehiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
