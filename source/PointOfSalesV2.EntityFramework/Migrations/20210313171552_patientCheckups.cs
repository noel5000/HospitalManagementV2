using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class patientCheckups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatientCheckups",
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
                    PatientId = table.Column<long>(nullable: false),
                    DoctorId = table.Column<Guid>(nullable: false),
                    InsuranceId = table.Column<long>(nullable: true),
                    InsurancePlanId = table.Column<long>(nullable: true),
                    AppointmentId = table.Column<long>(nullable: false),
                    Symptoms = table.Column<string>(nullable: true),
                    Diagnoses = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientCheckups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientCheckups_Appointment_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientCheckups_Users_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientCheckups_Insurances_InsuranceId",
                        column: x => x.InsuranceId,
                        principalTable: "Insurances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientCheckups_InsurancePlans_InsurancePlanId",
                        column: x => x.InsurancePlanId,
                        principalTable: "InsurancePlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientCheckups_Customers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CheckupPrescriptions",
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
                    ProductId = table.Column<long>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Type = table.Column<string>(nullable: false),
                    PatientCheckupId = table.Column<long>(nullable: false),
                    WhenToTake = table.Column<string>(nullable: true),
                    EmptyStomach = table.Column<bool>(nullable: false),
                    AdditionalData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckupPrescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckupPrescriptions_PatientCheckups_PatientCheckupId",
                        column: x => x.PatientCheckupId,
                        principalTable: "PatientCheckups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CheckupPrescriptions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckupPrescriptions_PatientCheckupId",
                table: "CheckupPrescriptions",
                column: "PatientCheckupId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckupPrescriptions_ProductId",
                table: "CheckupPrescriptions",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientCheckups_AppointmentId",
                table: "PatientCheckups",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientCheckups_DoctorId",
                table: "PatientCheckups",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientCheckups_InsuranceId",
                table: "PatientCheckups",
                column: "InsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientCheckups_InsurancePlanId",
                table: "PatientCheckups",
                column: "InsurancePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientCheckups_PatientId",
                table: "PatientCheckups",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckupPrescriptions");

            migrationBuilder.DropTable(
                name: "PatientCheckups");
        }
    }
}
