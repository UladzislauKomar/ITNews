using Microsoft.EntityFrameworkCore.Migrations;

namespace ITNews.Data.Implementation.Migrations
{
    public partial class UpdatedNewsAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OutUrl",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OutUrl",
                table: "News");
        }
    }
}
