using Microsoft.EntityFrameworkCore.Migrations;

namespace ITNews.Data.Implementation.Migrations
{
    public partial class fixnewstagagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewsTags_Tags_NewsId",
                table: "NewsTags");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsTags_News_TagId",
                table: "NewsTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NewsTags",
                table: "NewsTags");

            migrationBuilder.DropIndex(
                name: "IX_NewsTags_NewsId",
                table: "NewsTags");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewsTags",
                table: "NewsTags",
                columns: new[] { "NewsId", "TagId" });

            migrationBuilder.CreateIndex(
                name: "IX_NewsTags_TagId",
                table: "NewsTags",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsTags_News_NewsId",
                table: "NewsTags",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "NewsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsTags_Tags_TagId",
                table: "NewsTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewsTags_News_NewsId",
                table: "NewsTags");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsTags_Tags_TagId",
                table: "NewsTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NewsTags",
                table: "NewsTags");

            migrationBuilder.DropIndex(
                name: "IX_NewsTags_TagId",
                table: "NewsTags");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewsTags",
                table: "NewsTags",
                columns: new[] { "TagId", "NewsId" });

            migrationBuilder.CreateIndex(
                name: "IX_NewsTags_NewsId",
                table: "NewsTags",
                column: "NewsId");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsTags_Tags_NewsId",
                table: "NewsTags",
                column: "NewsId",
                principalTable: "Tags",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsTags_News_TagId",
                table: "NewsTags",
                column: "TagId",
                principalTable: "News",
                principalColumn: "NewsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
