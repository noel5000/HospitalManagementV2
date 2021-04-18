using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class fileAttachmentsName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "FileAttachments",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "FileAttachments");
        }
    }
}
