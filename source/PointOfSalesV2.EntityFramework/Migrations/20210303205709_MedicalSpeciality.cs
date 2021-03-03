using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class MedicalSpeciality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "MedicalSpecialityId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Users",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "MedicalSpecialities",
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
                    TranslationData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalSpecialities", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "Type",
                value: "U");

            migrationBuilder.CreateIndex(
                name: "IX_Users_MedicalSpecialityId",
                table: "Users",
                column: "MedicalSpecialityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_MedicalSpecialities_MedicalSpecialityId",
                table: "Users",
                column: "MedicalSpecialityId",
                principalTable: "MedicalSpecialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_MedicalSpecialities_MedicalSpecialityId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "MedicalSpecialities");

            migrationBuilder.DropIndex(
                name: "IX_Users_MedicalSpecialityId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MedicalSpecialityId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Users");
        }
    }
}
