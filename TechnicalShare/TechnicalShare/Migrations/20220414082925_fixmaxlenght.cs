using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalShare.Migrations
{
    public partial class fixmaxlenght : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Mentor",
                maxLength: 220,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 120);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Mentor",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 220);
        }
    }
}
