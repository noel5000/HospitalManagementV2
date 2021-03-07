using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class Appointments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "MedicalSpecialityId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Appointment",
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
                    DoctorId = table.Column<Guid>(nullable: true),
                    MedicalSpecialityId = table.Column<long>(nullable: true),
                    ProductId = table.Column<long>(nullable: false),
                    PatientId = table.Column<long>(nullable: false),
                    InsuranceId = table.Column<long>(nullable: true),
                    CurrencyId = table.Column<long>(nullable: false),
                    InsurancePlanId = table.Column<long>(nullable: true),
                    BeforeTaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    InsuranceCoverage = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    State = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointment_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_Users_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_Insurances_InsuranceId",
                        column: x => x.InsuranceId,
                        principalTable: "Insurances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_InsurancePlans_InsurancePlanId",
                        column: x => x.InsurancePlanId,
                        principalTable: "InsurancePlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_MedicalSpecialities_MedicalSpecialityId",
                        column: x => x.MedicalSpecialityId,
                        principalTable: "MedicalSpecialities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_Customers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_MedicalSpecialityId",
                table: "Products",
                column: "MedicalSpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_CurrencyId",
                table: "Appointment",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_DoctorId",
                table: "Appointment",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_InsuranceId",
                table: "Appointment",
                column: "InsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_InsurancePlanId",
                table: "Appointment",
                column: "InsurancePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_MedicalSpecialityId",
                table: "Appointment",
                column: "MedicalSpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_PatientId",
                table: "Appointment",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ProductId",
                table: "Appointment",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MedicalSpecialities_MedicalSpecialityId",
                table: "Products",
                column: "MedicalSpecialityId",
                principalTable: "MedicalSpecialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_MedicalSpecialities_MedicalSpecialityId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Products_MedicalSpecialityId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MedicalSpecialityId",
                table: "Products");
        }
    }
}
