using Microsoft.EntityFrameworkCore.Migrations;

namespace ITNews.Data.Implementation.Migrations
{
    public partial class UpdatedNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAllowed",
                table: "News",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAllowed",
                table: "News");
        }
    }
}
