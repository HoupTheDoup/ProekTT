using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLibrary.Data.Migrations
{
    public partial class FixName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookEntities_AuthorEntities_AuthorId",
                table: "BookEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BookEntities_PublisherEntity_PublisherId",
                table: "BookEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BookEntityGenreEntity_BookEntities_BooksId",
                table: "BookEntityGenreEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookEntities",
                table: "BookEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthorEntities",
                table: "AuthorEntities");

            migrationBuilder.RenameTable(
                name: "BookEntities",
                newName: "Books");

            migrationBuilder.RenameTable(
                name: "AuthorEntities",
                newName: "Authors");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Books",
                newName: "Title");

            migrationBuilder.RenameIndex(
                name: "IX_BookEntities_PublisherId",
                table: "Books",
                newName: "IX_Books_PublisherId");

            migrationBuilder.RenameIndex(
                name: "IX_BookEntities_AuthorId",
                table: "Books",
                newName: "IX_Books_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookEntityGenreEntity_Books_BooksId",
                table: "BookEntityGenreEntity",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_PublisherEntity_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "PublisherEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookEntityGenreEntity_Books_BooksId",
                table: "BookEntityGenreEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_PublisherEntity_PublisherId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "BookEntities");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "AuthorEntities");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "BookEntities",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Books_PublisherId",
                table: "BookEntities",
                newName: "IX_BookEntities_PublisherId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_AuthorId",
                table: "BookEntities",
                newName: "IX_BookEntities_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookEntities",
                table: "BookEntities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthorEntities",
                table: "AuthorEntities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookEntities_AuthorEntities_AuthorId",
                table: "BookEntities",
                column: "AuthorId",
                principalTable: "AuthorEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookEntities_PublisherEntity_PublisherId",
                table: "BookEntities",
                column: "PublisherId",
                principalTable: "PublisherEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookEntityGenreEntity_BookEntities_BooksId",
                table: "BookEntityGenreEntity",
                column: "BooksId",
                principalTable: "BookEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
