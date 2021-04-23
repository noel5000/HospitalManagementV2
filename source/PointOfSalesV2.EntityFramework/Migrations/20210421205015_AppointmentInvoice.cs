using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class AppointmentInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AppointmentId",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "InsuranceCoverageAmount",
                table: "Invoices",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PatientPaymentAmount",
                table: "Invoices",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<Guid>(
                name: "DoctorId",
                table: "InvoiceDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceApprovalCode",
                table: "InvoiceDetails",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "InsuranceCoverageAmount",
                table: "InvoiceDetails",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<long>(
                name: "MedicalSpecialityId",
                table: "InvoiceDetails",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "NoCoverage",
                table: "InvoiceDetails",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "PatientPaymentAmount",
                table: "InvoiceDetails",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "InvoiceDetails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_AppointmentId",
                table: "Invoices",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_DoctorId",
                table: "InvoiceDetails",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_MedicalSpecialityId",
                table: "InvoiceDetails",
                column: "MedicalSpecialityId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_Users_DoctorId",
                table: "InvoiceDetails",
                column: "DoctorId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_MedicalSpecialities_MedicalSpecialityId",
                table: "InvoiceDetails",
                column: "MedicalSpecialityId",
                principalTable: "MedicalSpecialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Appointments_AppointmentId",
                table: "Invoices",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_Users_DoctorId",
                table: "InvoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_MedicalSpecialities_MedicalSpecialityId",
                table: "InvoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Appointments_AppointmentId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_AppointmentId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceDetails_DoctorId",
                table: "InvoiceDetails");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceDetails_MedicalSpecialityId",
                table: "InvoiceDetails");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "InsuranceCoverageAmount",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "PatientPaymentAmount",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "InvoiceDetails");

            migrationBuilder.DropColumn(
                name: "InsuranceApprovalCode",
                table: "InvoiceDetails");

            migrationBuilder.DropColumn(
                name: "InsuranceCoverageAmount",
                table: "InvoiceDetails");

            migrationBuilder.DropColumn(
                name: "MedicalSpecialityId",
                table: "InvoiceDetails");

            migrationBuilder.DropColumn(
                name: "NoCoverage",
                table: "InvoiceDetails");

            migrationBuilder.DropColumn(
                name: "PatientPaymentAmount",
                table: "InvoiceDetails");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "InvoiceDetails");
        }
    }
}
