using Microsoft.EntityFrameworkCore.Migrations;

namespace Directory.DAL.Migrations
{
    public partial class ChangeYazarlarToKisiler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Yazarlar",
                table: "Yazarlar");

            migrationBuilder.RenameTable(
                name: "Yazarlar",
                newName: "Kişiler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kişiler",
                table: "Kişiler",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Kişiler",
                table: "Kişiler");

            migrationBuilder.RenameTable(
                name: "Kişiler",
                newName: "Yazarlar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Yazarlar",
                table: "Yazarlar",
                column: "Id");
        }
    }
}
