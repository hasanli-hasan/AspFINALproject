using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Bioscreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    logo = table.Column<string>(nullable: true),
                    facebook = table.Column<string>(nullable: true),
                    instagram = table.Column<string>(nullable: true),
                    twitter = table.Column<string>(nullable: true),
                    github = table.Column<string>(nullable: true),
                    pinterest = table.Column<string>(nullable: true),
                    behance = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    number = table.Column<int>(nullable: false),
                    address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bios");
        }
    }
}
