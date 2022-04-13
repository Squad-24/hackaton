﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechnicalShare.Data;

namespace TechnicalShare.Migrations
{
    [DbContext(typeof(TechnicalShareContext))]
    [Migration("20220413053702_timeslots")]
    partial class timeslots
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TechnicalShare.Models.CalendarMentor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Finish");

                    b.Property<int>("MentorId");

                    b.Property<DateTime>("Start");

                    b.Property<DateTime>("dateTimeMentor");

                    b.HasKey("Id");

                    b.HasIndex("MentorId");

                    b.ToTable("CalendarMentor");
                });

            modelBuilder.Entity("TechnicalShare.Models.Expertise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Expertise");
                });

            modelBuilder.Entity("TechnicalShare.Models.Mentee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Mentee");
                });

            modelBuilder.Entity("TechnicalShare.Models.Mentor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Day");

                    b.Property<int>("Day1");

                    b.Property<int>("Day2");

                    b.Property<int>("Day3");

                    b.Property<int>("Day4");

                    b.Property<int>("Day5");

                    b.Property<int>("Day6");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("ExpertiseId");

                    b.Property<string>("ExpertiseName");

                    b.Property<int>("Level");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Position")
                        .IsRequired();

                    b.Property<int>("Slot");

                    b.Property<int>("Slot1");

                    b.Property<int>("Slot2");

                    b.Property<int>("Slot3");

                    b.Property<int>("Slot4");

                    b.Property<int>("Slot5");

                    b.HasKey("Id");

                    b.HasIndex("ExpertiseId");

                    b.ToTable("Mentor");
                });

            modelBuilder.Entity("TechnicalShare.Models.MentorMentee", b =>
                {
                    b.Property<int>("MentorId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ExpertiseId");

                    b.Property<int>("MenteeId");

                    b.Property<int?>("MentorId1");

                    b.HasKey("MentorId");

                    b.HasIndex("ExpertiseId");

                    b.HasIndex("MenteeId");

                    b.HasIndex("MentorId1");

                    b.ToTable("MentorMentee");
                });

            modelBuilder.Entity("TechnicalShare.Models.CalendarMentor", b =>
                {
                    b.HasOne("TechnicalShare.Models.Mentor", "Mentor")
                        .WithMany()
                        .HasForeignKey("MentorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TechnicalShare.Models.Mentor", b =>
                {
                    b.HasOne("TechnicalShare.Models.Expertise", "Expertise")
                        .WithMany()
                        .HasForeignKey("ExpertiseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TechnicalShare.Models.MentorMentee", b =>
                {
                    b.HasOne("TechnicalShare.Models.Expertise", "Expertise")
                        .WithMany()
                        .HasForeignKey("ExpertiseId");

                    b.HasOne("TechnicalShare.Models.Mentee", "Mentee")
                        .WithMany("Mentors")
                        .HasForeignKey("MenteeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TechnicalShare.Models.Mentor", "Mentor")
                        .WithMany("Mentees")
                        .HasForeignKey("MentorId1");
                });
#pragma warning restore 612, 618
        }
    }
}
