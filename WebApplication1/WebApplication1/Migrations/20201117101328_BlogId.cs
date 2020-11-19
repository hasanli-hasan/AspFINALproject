using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class BlogId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commet_AspNetUsers_AppUserId",
                table: "Commet");

            migrationBuilder.DropForeignKey(
                name: "FK_Commet_Blogs_BlogId1",
                table: "Commet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Commet",
                table: "Commet");

            migrationBuilder.DropIndex(
                name: "IX_Commet_BlogId1",
                table: "Commet");

            migrationBuilder.DropColumn(
                name: "BlogId1",
                table: "Commet");

            migrationBuilder.RenameTable(
                name: "Commet",
                newName: "Commets");

            migrationBuilder.RenameIndex(
                name: "IX_Commet_AppUserId",
                table: "Commets",
                newName: "IX_Commets_AppUserId");

            migrationBuilder.AlterColumn<int>(
                name: "BlogId",
                table: "Commets",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Commets",
                table: "Commets",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Commets_BlogId",
                table: "Commets",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commets_AspNetUsers_AppUserId",
                table: "Commets",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commets_Blogs_BlogId",
                table: "Commets",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commets_AspNetUsers_AppUserId",
                table: "Commets");

            migrationBuilder.DropForeignKey(
                name: "FK_Commets_Blogs_BlogId",
                table: "Commets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Commets",
                table: "Commets");

            migrationBuilder.DropIndex(
                name: "IX_Commets_BlogId",
                table: "Commets");

            migrationBuilder.RenameTable(
                name: "Commets",
                newName: "Commet");

            migrationBuilder.RenameIndex(
                name: "IX_Commets_AppUserId",
                table: "Commet",
                newName: "IX_Commet_AppUserId");

            migrationBuilder.AlterColumn<string>(
                name: "BlogId",
                table: "Commet",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "BlogId1",
                table: "Commet",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Commet",
                table: "Commet",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Commet_BlogId1",
                table: "Commet",
                column: "BlogId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Commet_AspNetUsers_AppUserId",
                table: "Commet",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commet_Blogs_BlogId1",
                table: "Commet",
                column: "BlogId1",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
