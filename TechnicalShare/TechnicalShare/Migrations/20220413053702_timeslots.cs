using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalShare.Migrations
{
    public partial class timeslots : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Mentor",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Mentor",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mentor",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Mentor",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "Mentor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Day1",
                table: "Mentor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Day2",
                table: "Mentor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Day3",
                table: "Mentor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Day4",
                table: "Mentor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Day5",
                table: "Mentor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Day6",
                table: "Mentor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Slot",
                table: "Mentor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Slot1",
                table: "Mentor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Slot2",
                table: "Mentor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Slot3",
                table: "Mentor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Slot4",
                table: "Mentor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Slot5",
                table: "Mentor",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Day1",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Day2",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Day3",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Day4",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Day5",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Day6",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Slot",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Slot1",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Slot2",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Slot3",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Slot4",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Slot5",
                table: "Mentor");

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Mentor",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Mentor",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mentor",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Mentor",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
