using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst_FluentApi_LibraryManagementSystem.Migrations
{
    public partial class ChangeNameMemberDetailToMemberDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberDetail_Members_MemberID",
                table: "MemberDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MemberDetail",
                table: "MemberDetail");

            migrationBuilder.RenameTable(
                name: "MemberDetail",
                newName: "MembersDetails");

            migrationBuilder.RenameIndex(
                name: "IX_MemberDetail_MemberID",
                table: "MembersDetails",
                newName: "IX_MembersDetails_MemberID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MembersDetails",
                table: "MembersDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MembersDetails_Members_MemberID",
                table: "MembersDetails",
                column: "MemberID",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MembersDetails_Members_MemberID",
                table: "MembersDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MembersDetails",
                table: "MembersDetails");

            migrationBuilder.RenameTable(
                name: "MembersDetails",
                newName: "MemberDetail");

            migrationBuilder.RenameIndex(
                name: "IX_MembersDetails_MemberID",
                table: "MemberDetail",
                newName: "IX_MemberDetail_MemberID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MemberDetail",
                table: "MemberDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MemberDetail_Members_MemberID",
                table: "MemberDetail",
                column: "MemberID",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
