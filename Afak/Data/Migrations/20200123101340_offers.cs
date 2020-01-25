using Microsoft.EntityFrameworkCore.Migrations;

namespace Afak.Data.Migrations
{
    public partial class offers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Offers");

            migrationBuilder.AddColumn<string>(
                name: "photo",
                table: "Offers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Offers",
                table: "Offers",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Offers",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "photo",
                table: "Offers");

            migrationBuilder.RenameTable(
                name: "Offers",
                newName: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");
        }
    }
}
