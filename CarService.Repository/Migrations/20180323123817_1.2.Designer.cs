﻿// <auto-generated />
using CarService.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CarService.Repository.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20180323123817_1.2")]
    partial class _12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarService.Model.ConfirmReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ExpireDate");

                    b.Property<Guid>("Guid");

                    b.Property<bool>("IsConfirm");

                    b.Property<int?>("ReservationId");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId")
                        .IsUnique()
                        .HasFilter("[ReservationId] IS NOT NULL");

                    b.ToTable("ConfirmReservations");
                });

            modelBuilder.Entity("CarService.Model.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Info");

                    b.Property<int?>("ReservationId");

                    b.Property<string>("URL");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("CarService.Model.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BreakdownDetails");

                    b.Property<DateTime>("DateEnd");

                    b.Property<DateTime>("DateStart");

                    b.Property<string>("DesiredDiagnosis");

                    b.Property<string>("Purpose");

                    b.Property<int?>("WorkerId");

                    b.HasKey("Id");

                    b.HasIndex("WorkerId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("CarService.Model.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("SurName");

                    b.Property<string>("Telephone");

                    b.HasKey("Id");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("CarService.Model.WorkTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateEnd");

                    b.Property<DateTime>("DateStart");

                    b.Property<int?>("WorkerId");

                    b.HasKey("Id");

                    b.HasIndex("WorkerId");

                    b.ToTable("WorkTimes");
                });

            modelBuilder.Entity("CarService.Model.ConfirmReservation", b =>
                {
                    b.HasOne("CarService.Model.Reservation", "Reservation")
                        .WithOne("ConfirmReservation")
                        .HasForeignKey("CarService.Model.ConfirmReservation", "ReservationId");
                });

            modelBuilder.Entity("CarService.Model.Image", b =>
                {
                    b.HasOne("CarService.Model.Reservation", "Reservation")
                        .WithMany("Images")
                        .HasForeignKey("ReservationId");
                });

            modelBuilder.Entity("CarService.Model.Reservation", b =>
                {
                    b.HasOne("CarService.Model.Worker", "Worker")
                        .WithMany("Reservation")
                        .HasForeignKey("WorkerId");
                });

            modelBuilder.Entity("CarService.Model.WorkTime", b =>
                {
                    b.HasOne("CarService.Model.Worker", "Worker")
                        .WithMany("WorkTimes")
                        .HasForeignKey("WorkerId");
                });
#pragma warning restore 612, 618
        }
    }
}
