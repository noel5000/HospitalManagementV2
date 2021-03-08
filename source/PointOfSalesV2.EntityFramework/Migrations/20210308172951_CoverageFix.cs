using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class CoverageFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InsuranceCoverage",
                table: "Appointment",
                newName: "PatientPaymentAmount");

            migrationBuilder.AddColumn<decimal>(
                name: "InsuranceCoverageAmount",
                table: "Appointment",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsuranceCoverageAmount",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "PatientPaymentAmount",
                table: "Appointment",
                newName: "InsuranceCoverage");
        }
    }
}
