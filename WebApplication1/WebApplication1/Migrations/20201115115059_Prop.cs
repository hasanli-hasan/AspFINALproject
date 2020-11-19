using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Prop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sale_AspNetUsers_AppUserId",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleBook_Books_BookId",
                table: "SaleBook");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleBook_Sale_SaleId",
                table: "SaleBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleBook",
                table: "SaleBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sale",
                table: "Sale");

            migrationBuilder.RenameTable(
                name: "SaleBook",
                newName: "SaleBooks");

            migrationBuilder.RenameTable(
                name: "Sale",
                newName: "Sales");

            migrationBuilder.RenameIndex(
                name: "IX_SaleBook_SaleId",
                table: "SaleBooks",
                newName: "IX_SaleBooks_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_SaleBook_BookId",
                table: "SaleBooks",
                newName: "IX_SaleBooks_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_AppUserId",
                table: "Sales",
                newName: "IX_Sales_AppUserId");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Sales",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleBooks",
                table: "SaleBooks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sales",
                table: "Sales",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleBooks_Books_BookId",
                table: "SaleBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleBooks_Sales_SaleId",
                table: "SaleBooks",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_AspNetUsers_AppUserId",
                table: "Sales",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleBooks_Books_BookId",
                table: "SaleBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleBooks_Sales_SaleId",
                table: "SaleBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_AspNetUsers_AppUserId",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sales",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleBooks",
                table: "SaleBooks");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Sales");

            migrationBuilder.RenameTable(
                name: "Sales",
                newName: "Sale");

            migrationBuilder.RenameTable(
                name: "SaleBooks",
                newName: "SaleBook");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_AppUserId",
                table: "Sale",
                newName: "IX_Sale_AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_SaleBooks_SaleId",
                table: "SaleBook",
                newName: "IX_SaleBook_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_SaleBooks_BookId",
                table: "SaleBook",
                newName: "IX_SaleBook_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sale",
                table: "Sale",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleBook",
                table: "SaleBook",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_AspNetUsers_AppUserId",
                table: "Sale",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleBook_Books_BookId",
                table: "SaleBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleBook_Sale_SaleId",
                table: "SaleBook",
                column: "SaleId",
                principalTable: "Sale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
