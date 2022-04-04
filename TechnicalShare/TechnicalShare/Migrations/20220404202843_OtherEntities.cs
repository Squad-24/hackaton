using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalShare.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Expertises_ExpertiseId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Expertises",
                table: "Expertises");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Expertises",
                newName: "Expertise");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ExpertiseId",
                table: "User",
                newName: "IX_User_ExpertiseId");

            migrationBuilder.AddColumn<int>(
                name: "Mentor_ExpertiseId",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "User",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Expertise",
                table: "Expertise",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MentorMentee",
                columns: table => new
                {
                    MentorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MentorId1 = table.Column<int>(nullable: true),
                    MenteeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MentorMentee", x => x.MentorId);
                    table.ForeignKey(
                        name: "FK_MentorMentee_User_MenteeId",
                        column: x => x.MenteeId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MentorMentee_User_MentorId1",
                        column: x => x.MentorId1,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_Mentor_ExpertiseId",
                table: "User",
                column: "Mentor_ExpertiseId");

            migrationBuilder.CreateIndex(
                name: "IX_MentorMentee_MenteeId",
                table: "MentorMentee",
                column: "MenteeId");

            migrationBuilder.CreateIndex(
                name: "IX_MentorMentee_MentorId1",
                table: "MentorMentee",
                column: "MentorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Expertise_ExpertiseId",
                table: "User",
                column: "ExpertiseId",
                principalTable: "Expertise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Expertise_Mentor_ExpertiseId",
                table: "User",
                column: "Mentor_ExpertiseId",
                principalTable: "Expertise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Expertise_ExpertiseId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Expertise_Mentor_ExpertiseId",
                table: "User");

            migrationBuilder.DropTable(
                name: "MentorMentee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_Mentor_ExpertiseId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Expertise",
                table: "Expertise");

            migrationBuilder.DropColumn(
                name: "Mentor_ExpertiseId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Expertise",
                newName: "Expertises");

            migrationBuilder.RenameIndex(
                name: "IX_User_ExpertiseId",
                table: "Users",
                newName: "IX_Users_ExpertiseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Expertises",
                table: "Expertises",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Expertises_ExpertiseId",
                table: "Users",
                column: "ExpertiseId",
                principalTable: "Expertises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
