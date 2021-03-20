using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class checkupPrescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "CheckupPrescriptions",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "MedicalSpecialityId",
                table: "CheckupPrescriptions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CheckupPrescriptions_MedicalSpecialityId",
                table: "CheckupPrescriptions",
                column: "MedicalSpecialityId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckupPrescriptions_MedicalSpecialities_MedicalSpecialityId",
                table: "CheckupPrescriptions",
                column: "MedicalSpecialityId",
                principalTable: "MedicalSpecialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckupPrescriptions_MedicalSpecialities_MedicalSpecialityId",
                table: "CheckupPrescriptions");

            migrationBuilder.DropIndex(
                name: "IX_CheckupPrescriptions_MedicalSpecialityId",
                table: "CheckupPrescriptions");

            migrationBuilder.DropColumn(
                name: "MedicalSpecialityId",
                table: "CheckupPrescriptions");

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "CheckupPrescriptions",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);
        }
    }
}
