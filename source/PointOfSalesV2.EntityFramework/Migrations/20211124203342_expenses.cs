using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class expenses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "insuranceCoveragesReport_menu" },
                column: "Value",
                value: "Reporte de Coberturas");

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "totalInsuranceCoverage_lbl" },
                column: "Value",
                value: "Monto total de Cobertura");

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "LanguageCode", "Key", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Value" },
                values: new object[,]
                {
                    { "EN", "0-0-1", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, "Night" },
                    { "EN", "0-1-1", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, "Afternoon - Night" },
                    { "EN", "0-1-0", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, "Afternoon" },
                    { "EN", "1-1-1", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, "Morning - Afternoon - Night" },
                    { "EN", "1-1-0", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, "Morning - Afternoon" },
                    { "EN", "1-0-1", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, "Morning - Night" },
                    { "ES", "0-0-1", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, "Noche" },
                    { "ES", "0-1-1", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, "Tarde - Noche" },
                    { "ES", "0-1-0", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, "Tarde" },
                    { "ES", "1-1-1", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, "Mañana - Tarde - Noche" },
                    { "ES", "1-0-1", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, "Mañana - Noche" },
                    { "ES", "1-1-0", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, "Mañana - Tarde" },
                    { "EN", "1-0-0", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, "Morning" },
                    { "ES", "1-0-0", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, "Mañana" }
                });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TranslationData",
                value: "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Efectivo\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Cash\"}]}");

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "TranslationData",
                value: "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Cheque\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Check\"}]}");

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "TranslationData",
                value: "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Tarjeta de Crédito\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Credit Card\"}]}");

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "TranslationData",
                value: "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Transferencia Bancaria\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Bank Transfer\"}]}");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "0-0-1" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "0-1-0" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "0-1-1" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "1-0-0" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "1-0-1" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "1-1-0" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "1-1-1" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "0-0-1" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "0-1-0" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "0-1-1" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "1-0-0" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "1-0-1" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "1-1-0" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "1-1-1" });

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "insuranceCoveragesReport_menu" },
                column: "Value",
                value: "Reporte de coverturas");

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "totalInsuranceCoverage_lbl" },
                column: "Value",
                value: "Monto total de covertura");

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TranslationData",
                value: "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CASH\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CASH\"}]}");

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "TranslationData",
                value: "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CHECK\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CHECK\"}]}");

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "TranslationData",
                value: "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CREDITCARD\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CREDITCARD\"}]}");

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "TranslationData",
                value: "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"BANKTRANSFER\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"BANKTRANSFER\"}]}");
        }
    }
}
