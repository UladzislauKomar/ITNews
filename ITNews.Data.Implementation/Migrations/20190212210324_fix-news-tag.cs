using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITNews.Data.Implementation.Migrations
{
    public partial class fixnewstag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
