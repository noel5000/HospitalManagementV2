using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class dictionary2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Value" },
                values: new object[,]
                {
                   // { "billingStateR_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, "Full Paid" },
                    { "creditNoteInfo_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, "Add Credit Note" },
                    { "invoiceInfo_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, "Basic Information" },
                    { "newItems_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, "New Items" },
                   // { "search_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, "Search" },
                  //  { "billingStateR_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, "Pago Completado" },
                    { "creditNoteInfo_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, "Aplicar Nota de Crédito" },
                    { "invoiceInfo_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, "Información Básica" },
                    { "newItems_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, "Agregar Articulos" },
                  //  { "search_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, "Buscar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateR_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "creditNoteInfo_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invoiceInfo_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "newItems_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "search_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateR_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "creditNoteInfo_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invoiceInfo_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "newItems_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "search_btn", "ES" });
        }
    }
}
