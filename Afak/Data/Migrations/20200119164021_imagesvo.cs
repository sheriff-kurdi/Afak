using Microsoft.EntityFrameworkCore.Migrations;

namespace Afak.Data.Migrations
{
    public partial class imagesvo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageFive",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageFour",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFive",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImageFour",
                table: "Products");
        }
    }
}
