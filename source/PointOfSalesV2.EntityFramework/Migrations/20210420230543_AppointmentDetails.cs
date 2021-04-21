using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class AppointmentDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Currencies_CurrencyId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Users_DoctorId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_BranchOffices_HospitalId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Insurances_InsuranceId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_InsurancePlans_InsurancePlanId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_MedicalSpecialities_MedicalSpecialityId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Customers_PatientId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Products_ProductId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientCheckups_Appointment_AppointmentId",
                table: "PatientCheckups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_DoctorId",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_MedicalSpecialityId",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_ProductId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "MedicalSpecialityId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Appointment");

            migrationBuilder.RenameTable(
                name: "Appointment",
                newName: "Appointments");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_PatientId",
                table: "Appointments",
                newName: "IX_Appointments_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_InsurancePlanId",
                table: "Appointments",
                newName: "IX_Appointments_InsurancePlanId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_InsuranceId",
                table: "Appointments",
                newName: "IX_Appointments_InsuranceId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_HospitalId",
                table: "Appointments",
                newName: "IX_Appointments_HospitalId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_CurrencyId",
                table: "Appointments",
                newName: "IX_Appointments_CurrencyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AppointmentDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    AppointmentId = table.Column<long>(nullable: false),
                    DoctorId = table.Column<Guid>(nullable: true),
                    MedicalSpecialityId = table.Column<long>(nullable: true),
                    ProductId = table.Column<long>(nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    BeforeTaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PatientPaymentAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    InsuranceCoverageAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppointmentDetails_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppointmentDetails_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppointmentDetails_Users_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppointmentDetails_MedicalSpecialities_MedicalSpecialityId",
                        column: x => x.MedicalSpecialityId,
                        principalTable: "MedicalSpecialities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppointmentDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetails_AppointmentId",
                table: "AppointmentDetails",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetails_CurrencyId",
                table: "AppointmentDetails",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetails_DoctorId",
                table: "AppointmentDetails",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetails_MedicalSpecialityId",
                table: "AppointmentDetails",
                column: "MedicalSpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetails_ProductId",
                table: "AppointmentDetails",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Currencies_CurrencyId",
                table: "Appointments",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_BranchOffices_HospitalId",
                table: "Appointments",
                column: "HospitalId",
                principalTable: "BranchOffices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Insurances_InsuranceId",
                table: "Appointments",
                column: "InsuranceId",
                principalTable: "Insurances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_InsurancePlans_InsurancePlanId",
                table: "Appointments",
                column: "InsurancePlanId",
                principalTable: "InsurancePlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Customers_PatientId",
                table: "Appointments",
                column: "PatientId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientCheckups_Appointments_AppointmentId",
                table: "PatientCheckups",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Currencies_CurrencyId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_BranchOffices_HospitalId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Insurances_InsuranceId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_InsurancePlans_InsurancePlanId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Customers_PatientId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientCheckups_Appointments_AppointmentId",
                table: "PatientCheckups");

            migrationBuilder.DropTable(
                name: "AppointmentDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "Appointment");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointment",
                newName: "IX_Appointment_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_InsurancePlanId",
                table: "Appointment",
                newName: "IX_Appointment_InsurancePlanId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_InsuranceId",
                table: "Appointment",
                newName: "IX_Appointment_InsuranceId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_HospitalId",
                table: "Appointment",
                newName: "IX_Appointment_HospitalId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_CurrencyId",
                table: "Appointment",
                newName: "IX_Appointment_CurrencyId");

            migrationBuilder.AddColumn<Guid>(
                name: "DoctorId",
                table: "Appointment",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MedicalSpecialityId",
                table: "Appointment",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProductId",
                table: "Appointment",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Appointment",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_DoctorId",
                table: "Appointment",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_MedicalSpecialityId",
                table: "Appointment",
                column: "MedicalSpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ProductId",
                table: "Appointment",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Currencies_CurrencyId",
                table: "Appointment",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Users_DoctorId",
                table: "Appointment",
                column: "DoctorId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_BranchOffices_HospitalId",
                table: "Appointment",
                column: "HospitalId",
                principalTable: "BranchOffices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Insurances_InsuranceId",
                table: "Appointment",
                column: "InsuranceId",
                principalTable: "Insurances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_InsurancePlans_InsurancePlanId",
                table: "Appointment",
                column: "InsurancePlanId",
                principalTable: "InsurancePlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_MedicalSpecialities_MedicalSpecialityId",
                table: "Appointment",
                column: "MedicalSpecialityId",
                principalTable: "MedicalSpecialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Customers_PatientId",
                table: "Appointment",
                column: "PatientId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Products_ProductId",
                table: "Appointment",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientCheckups_Appointment_AppointmentId",
                table: "PatientCheckups",
                column: "AppointmentId",
                principalTable: "Appointment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
