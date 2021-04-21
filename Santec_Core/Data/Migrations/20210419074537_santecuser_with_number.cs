using Microsoft.EntityFrameworkCore.Migrations;

namespace Santec_Core.Data.Migrations
{
    public partial class santecuser_with_number : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SantecNumber",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SantecNumber",
                table: "AspNetUsers");
        }
    }
}
