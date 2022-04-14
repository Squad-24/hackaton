using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalShare.Migrations
{
    public partial class populating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Mentor",
                maxLength: 220,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Schedule",
                table: "Mentor",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Slot10",
                table: "Mentor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slot11",
                table: "Mentor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slot12",
                table: "Mentor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slot13",
                table: "Mentor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slot7",
                table: "Mentor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slot8",
                table: "Mentor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slot9",
                table: "Mentor",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Schedule",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Slot10",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Slot11",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Slot12",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Slot13",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Slot7",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Slot8",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Slot9",
                table: "Mentor");
        }
    }
}
