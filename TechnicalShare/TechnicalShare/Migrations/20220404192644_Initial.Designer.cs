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
    [Migration("20220404192644_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TechnicalShare.Models.Expertise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Expertises");
                });

            modelBuilder.Entity("TechnicalShare.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<int?>("ExpertiseId");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.HasIndex("ExpertiseId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("TechnicalShare.Models.Mentee", b =>
                {
                    b.HasBaseType("TechnicalShare.Models.User");


                    b.ToTable("Mentee");

                    b.HasDiscriminator().HasValue("Mentee");
                });

            modelBuilder.Entity("TechnicalShare.Models.Mentor", b =>
                {
                    b.HasBaseType("TechnicalShare.Models.User");


                    b.ToTable("Mentor");

                    b.HasDiscriminator().HasValue("Mentor");
                });

            modelBuilder.Entity("TechnicalShare.Models.User", b =>
                {
                    b.HasOne("TechnicalShare.Models.Expertise", "Expertise")
                        .WithMany()
                        .HasForeignKey("ExpertiseId");
                });
#pragma warning restore 612, 618
        }
    }
}
