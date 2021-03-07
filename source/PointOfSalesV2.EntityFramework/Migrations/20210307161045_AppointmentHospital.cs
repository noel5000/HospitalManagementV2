using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class AppointmentHospital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "HospitalId",
                table: "Appointment",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_HospitalId",
                table: "Appointment",
                column: "HospitalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_BranchOffices_HospitalId",
                table: "Appointment",
                column: "HospitalId",
                principalTable: "BranchOffices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_BranchOffices_HospitalId",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_HospitalId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "HospitalId",
                table: "Appointment");
        }
    }
}
