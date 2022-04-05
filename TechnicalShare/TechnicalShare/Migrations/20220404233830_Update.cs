using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalShare.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Expertise_Mentor_ExpertiseId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_Mentor_ExpertiseId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Mentor_ExpertiseId",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "ExpertiseName",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpertiseName",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "Mentor_ExpertiseId",
                table: "User",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Mentor_ExpertiseId",
                table: "User",
                column: "Mentor_ExpertiseId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Expertise_Mentor_ExpertiseId",
                table: "User",
                column: "Mentor_ExpertiseId",
                principalTable: "Expertise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
