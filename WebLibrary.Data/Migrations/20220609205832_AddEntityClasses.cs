using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLibrary.Data.Migrations
{
    public partial class AddEntityClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PublisherId",
                table: "BookEntities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "GenreEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PublisherEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearOfPublshing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublisherEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookEntityGenreEntity",
                columns: table => new
                {
                    BooksId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenresId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookEntityGenreEntity", x => new { x.BooksId, x.GenresId });
                    table.ForeignKey(
                        name: "FK_BookEntityGenreEntity_BookEntities_BooksId",
                        column: x => x.BooksId,
                        principalTable: "BookEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookEntityGenreEntity_GenreEntity_GenresId",
                        column: x => x.GenresId,
                        principalTable: "GenreEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookEntities_PublisherId",
                table: "BookEntities",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_BookEntityGenreEntity_GenresId",
                table: "BookEntityGenreEntity",
                column: "GenresId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookEntities_PublisherEntity_PublisherId",
                table: "BookEntities",
                column: "PublisherId",
                principalTable: "PublisherEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookEntities_PublisherEntity_PublisherId",
                table: "BookEntities");

            migrationBuilder.DropTable(
                name: "BookEntityGenreEntity");

            migrationBuilder.DropTable(
                name: "PublisherEntity");

            migrationBuilder.DropTable(
                name: "GenreEntity");

            migrationBuilder.DropIndex(
                name: "IX_BookEntities_PublisherId",
                table: "BookEntities");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "BookEntities");
        }
    }
}
