using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class UpdateDiscountBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscFaiz",
                table: "DiscountBooks");

            migrationBuilder.DropColumn(
                name: "DiscText",
                table: "DiscountBooks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiscFaiz",
                table: "DiscountBooks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DiscText",
                table: "DiscountBooks",
                nullable: true);
        }
    }
}
