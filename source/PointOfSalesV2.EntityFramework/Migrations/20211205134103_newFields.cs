using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class newFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Symptoms",
                table: "PatientCheckups",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Diagnoses",
                table: "PatientCheckups",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsultationReason",
                table: "PatientCheckups",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagesResults",
                table: "PatientCheckups",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LaboratoriesResults",
                table: "PatientCheckups",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MedicalBackground",
                table: "PatientCheckups",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhysicalExam",
                table: "PatientCheckups",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhysicalExamChest",
                table: "PatientCheckups",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhysicalExamExtremities",
                table: "PatientCheckups",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhysicalExamHeadNeck",
                table: "PatientCheckups",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhysicalExamHeart",
                table: "PatientCheckups",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhysicalExamLungs",
                table: "PatientCheckups",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhysicalExamStomach",
                table: "PatientCheckups",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Plan",
                table: "PatientCheckups",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Alergies",
                table: "Customers",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BloodTransfusions",
                table: "Customers",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FamilyIllnesses",
                table: "Customers",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Medications",
                table: "Customers",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SC",
                table: "Customers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Size",
                table: "Customers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Surgeries",
                table: "Customers",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Weight",
                table: "Customers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConsultationReason",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "ImagesResults",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "LaboratoriesResults",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "MedicalBackground",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "PhysicalExam",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "PhysicalExamChest",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "PhysicalExamExtremities",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "PhysicalExamHeadNeck",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "PhysicalExamHeart",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "PhysicalExamLungs",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "PhysicalExamStomach",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "Plan",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "Alergies",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "BloodTransfusions",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FamilyIllnesses",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Medications",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SC",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Surgeries",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "Symptoms",
                table: "PatientCheckups",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Diagnoses",
                table: "PatientCheckups",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);
        }
    }
}
