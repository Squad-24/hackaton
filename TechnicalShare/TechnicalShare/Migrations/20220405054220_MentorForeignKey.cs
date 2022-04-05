using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalShare.Migrations
{
    public partial class MentorForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Expertise_ExpertiseId",
                table: "User");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Expertise_ExpertiseId",
                table: "User",
                column: "ExpertiseId",
                principalTable: "Expertise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Expertise_ExpertiseId",
                table: "User");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Expertise_ExpertiseId",
                table: "User",
                column: "ExpertiseId",
                principalTable: "Expertise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
