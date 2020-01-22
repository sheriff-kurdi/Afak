using Microsoft.EntityFrameworkCore.Migrations;

namespace Afak.Data.Migrations
{
    public partial class on : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImageFive",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImageFour",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImageOne",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImageThree",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImageTwo",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageFive",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageFour",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageOne",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageThree",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageTwo",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
