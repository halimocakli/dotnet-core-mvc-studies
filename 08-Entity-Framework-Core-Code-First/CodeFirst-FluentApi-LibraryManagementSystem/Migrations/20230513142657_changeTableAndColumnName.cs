using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst_FluentApi_LibraryManagementSystem.Migrations
{
    public partial class changeTableAndColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Authors_AuthorID",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Books_BookID",
                table: "BookAuthors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "BookAuthors",
                newName: "KitapYazar");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Yazarlar");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthors_AuthorID",
                table: "KitapYazar",
                newName: "IX_KitapYazar_AuthorID");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Yazarlar",
                newName: "Soyisim");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Yazarlar",
                newName: "Isim");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KitapYazar",
                table: "KitapYazar",
                columns: new[] { "BookID", "AuthorID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Yazarlar",
                table: "Yazarlar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KitapYazar_Books_BookID",
                table: "KitapYazar",
                column: "BookID",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KitapYazar_Yazarlar_AuthorID",
                table: "KitapYazar",
                column: "AuthorID",
                principalTable: "Yazarlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KitapYazar_Books_BookID",
                table: "KitapYazar");

            migrationBuilder.DropForeignKey(
                name: "FK_KitapYazar_Yazarlar_AuthorID",
                table: "KitapYazar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Yazarlar",
                table: "Yazarlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KitapYazar",
                table: "KitapYazar");

            migrationBuilder.RenameTable(
                name: "Yazarlar",
                newName: "Authors");

            migrationBuilder.RenameTable(
                name: "KitapYazar",
                newName: "BookAuthors");

            migrationBuilder.RenameColumn(
                name: "Soyisim",
                table: "Authors",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Isim",
                table: "Authors",
                newName: "FirstName");

            migrationBuilder.RenameIndex(
                name: "IX_KitapYazar_AuthorID",
                table: "BookAuthors",
                newName: "IX_BookAuthors_AuthorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors",
                columns: new[] { "BookID", "AuthorID" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Authors_AuthorID",
                table: "BookAuthors",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Books_BookID",
                table: "BookAuthors",
                column: "BookID",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
