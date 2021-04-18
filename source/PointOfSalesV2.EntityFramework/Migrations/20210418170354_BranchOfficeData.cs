using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class BranchOfficeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "BranchOffices",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NRC",
                table: "BranchOffices",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "BranchOffices",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "BranchOffices");

            migrationBuilder.DropColumn(
                name: "NRC",
                table: "BranchOffices");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "BranchOffices");
        }
    }
}
