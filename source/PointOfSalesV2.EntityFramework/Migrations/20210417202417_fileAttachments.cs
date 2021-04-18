using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class fileAttachments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FileAttachments",
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
                    FileName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileAttachments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CheckupAttachments",
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
                    PatientChekupId = table.Column<long>(nullable: false),
                    FileAttachementId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckupAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckupAttachments_FileAttachments_FileAttachementId",
                        column: x => x.FileAttachementId,
                        principalTable: "FileAttachments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CheckupAttachments_PatientCheckups_PatientChekupId",
                        column: x => x.PatientChekupId,
                        principalTable: "PatientCheckups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckupAttachments_FileAttachementId",
                table: "CheckupAttachments",
                column: "FileAttachementId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckupAttachments_PatientChekupId",
                table: "CheckupAttachments",
                column: "PatientChekupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckupAttachments");

            migrationBuilder.DropTable(
                name: "FileAttachments");
        }
    }
}
