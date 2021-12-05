using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class PrescriptionsResults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AdditionalData",
                table: "CheckupPrescriptions",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Results",
                table: "CheckupPrescriptions",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Results",
                table: "CheckupPrescriptions");

            migrationBuilder.AlterColumn<string>(
                name: "AdditionalData",
                table: "CheckupPrescriptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);
        }
    }
}
