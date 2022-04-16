using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstEFCoreConsoleApp.Migrations
{
    public partial class AddAuthorBiography : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BIographyy",
                table: "Authors",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BIographyy",
                table: "Authors");
        }
    }
}
