using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalShare.Migrations
{
    public partial class dropuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MentorMentee_User_MenteeId",
                table: "MentorMentee");

            migrationBuilder.DropForeignKey(
                name: "FK_MentorMentee_User_MentorId1",
                table: "MentorMentee");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Expertise_ExpertiseId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Mentor");

            migrationBuilder.RenameIndex(
                name: "IX_User_ExpertiseId",
                table: "Mentor",
                newName: "IX_Mentor_ExpertiseId");

            migrationBuilder.AlterColumn<int>(
                name: "Level",
                table: "Mentor",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExpertiseId",
                table: "Mentor",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mentor",
                table: "Mentor",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Mentee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentee", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Mentor_Expertise_ExpertiseId",
                table: "Mentor",
                column: "ExpertiseId",
                principalTable: "Expertise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MentorMentee_Mentee_MenteeId",
                table: "MentorMentee",
                column: "MenteeId",
                principalTable: "Mentee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MentorMentee_Mentor_MentorId1",
                table: "MentorMentee",
                column: "MentorId1",
                principalTable: "Mentor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mentor_Expertise_ExpertiseId",
                table: "Mentor");

            migrationBuilder.DropForeignKey(
                name: "FK_MentorMentee_Mentee_MenteeId",
                table: "MentorMentee");

            migrationBuilder.DropForeignKey(
                name: "FK_MentorMentee_Mentor_MentorId1",
                table: "MentorMentee");

            migrationBuilder.DropTable(
                name: "Mentee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mentor",
                table: "Mentor");

            migrationBuilder.RenameTable(
                name: "Mentor",
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_Mentor_ExpertiseId",
                table: "User",
                newName: "IX_User_ExpertiseId");

            migrationBuilder.AlterColumn<int>(
                name: "Level",
                table: "User",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ExpertiseId",
                table: "User",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "User",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MentorMentee_User_MenteeId",
                table: "MentorMentee",
                column: "MenteeId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MentorMentee_User_MentorId1",
                table: "MentorMentee",
                column: "MentorId1",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Expertise_ExpertiseId",
                table: "User",
                column: "ExpertiseId",
                principalTable: "Expertise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
