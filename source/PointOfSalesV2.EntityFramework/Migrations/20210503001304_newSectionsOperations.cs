using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class newSectionsOperations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READ\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READ\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ADD\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ADD\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UPDATE\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UPDATE\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DELETE\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DELETE\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"READALL\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"READALL\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"EXPORT\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"EXPORT\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ALL\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ALL\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"NONE\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"NONE\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ACCOUNTSTATEREPORT\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ACCOUNTSTATEREPORT\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"RECEIPTSREPORT\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"RECEIPTSREPORT\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DEBTSTOPAYREPORT\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DEBTSTOPAYREPORT\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"MENU\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"MENU\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"INVENTORYREPORT\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"INVENTORYREPORT\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ACCOUNTRECEIVABLES\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ACCOUNTRECEIVABLES\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SALESREPORT\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SALESREPORT\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"TAXREPORT\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"TAXREPORT\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"GENERATEDICTIONARY\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"GENERATEDICTIONARY\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"COMISSIONSREPORT\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"COMISSIONSREPORT\"}]}" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PRODUCTMOVEMENTS\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PRODUCTMOVEMENTS\"}]}" });

            migrationBuilder.InsertData(
                table: "Operations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TranslationData" },
                values: new object[,]
                {
                    { 20L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PATIENSHISTORY\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PATIENSHISTORY\"}]}" },
                    { 21L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ATTENDPATIENT\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ATTENDPATIENT\"}]}" }
                });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Permissions\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Permissions\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerRates\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerRates\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Products\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Products\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Currencies\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Currencies\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Taxes\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Taxes\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Warehouses\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Warehouses\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"All\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"All\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Inventories\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Inventories\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"TRNControl\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"TRNControl\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"BranchOffices\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"BranchOffices\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Suppliers\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Suppliers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Units\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Units\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Users\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Users\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentTypes\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentTypes\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisters\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisters\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpenings\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpenings\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpeningsAmounts\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpeningsAmounts\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeMovements\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeMovements\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SuppliersReturns\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SuppliersReturns\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductUnits\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductUnits\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Roles\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Roles\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sections\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sections\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Operations\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Operations\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DashBoard\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DashBoard\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SalesReport\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SalesReport\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountsReceivable\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountsReceivable\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeReceipts\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeReceipts\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Commisions\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Commisions\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductMovements\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductMovements\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DebstToPay\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DebstToPay\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PriceList\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PriceList\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersList\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersList\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountState\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountState\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ResultState\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ResultState\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"TaxesReport\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"TaxesReport\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CompanyPayments\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CompanyPayments\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Menu\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Menu\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"School\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"School\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SchoolMenu\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SchoolMenu\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InvoiceLeads\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InvoiceLeads\"}]}" });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Active", "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TranslationData" },
                values: new object[,]
                {
                    { 56L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Appointment\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Appointment\"}]}" },
                    { 55L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InsuranceCoverage\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InsuranceCoverage\"}]}" },
                    { 54L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InsurancePlan\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InsurancePlan\"}]}" },
                    { 53L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Insurance\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Insurance\"}]}" },
                    { 58L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"MedicalSpecialities\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"MedicalSpecialities\"}]}" },
                    { 57L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PatientCheckup\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PatientCheckup\"}]}" },
                    { 59L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InsurancesCoveragesReport\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InsurancesCoveragesReport\"}]}" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""LEER""}],""EN"":[{""PropertyName"":""Name"",""Value"":""READ""}]}
" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""AGREGAR""}],""EN"":[{""PropertyName"":""Name"",""Value"":""ADD""}]}
" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""ACTUALIZAR""}],""EN"":[{""PropertyName"":""Name"",""Value"":""UPDATE""}]}
" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""BORRAR""}],""EN"":[{""PropertyName"":""Name"",""Value"":""DELETE""}]}
" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""LEER TODOS""}],""EN"":[{""PropertyName"":""Name"",""Value"":""READ ALL""}]}
" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""EXPORTAR""}],""EN"":[{""PropertyName"":""Name"",""Value"":""EXPORT""}]}
" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""TODO""}],""EN"":[{""PropertyName"":""Name"",""Value"":""ALL""}]}
" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""NINGUNO""}],""EN"":[{""PropertyName"":""Name"",""Value"":""NONE""}]}
" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""REPORTE ESTADO DE CUENTA""}],""EN"":[{""PropertyName"":""Name"",""Value"":""ACCOUNT STATE REPORT""}]}
" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""REPORTE RECIBOS INGRESOS""}],""EN"":[{""PropertyName"":""Name"",""Value"":""RECEIPTS REPORT""}]}
" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""CUENTAS POR PAGAR""}],""EN"":[{""PropertyName"":""Name"",""Value"":""DEBTS TO PAY REPORT""}]}
" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""MENU""}],""EN"":[{""PropertyName"":""Name"",""Value"":""MENU""}]}
" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""REPORTE DE INVENTARIO""}],""EN"":[{""PropertyName"":""Name"",""Value"":""INVENTORY REPORT""}]}
" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""CUENTAS POR COBRAR""}],""EN"":[{""PropertyName"":""Name"",""Value"":""ACCOUNT RECEIVABLES""}]}
" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""REPORTE DE VENTAS""}],""EN"":[{""PropertyName"":""Name"",""Value"":""SALES REPORT""}]}
" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""REPORTE IMPUESTOS""}],""EN"":[{""PropertyName"":""Name"",""Value"":""TAX REPORT""}]}
" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""GENERAR DICCIONARIO""}],""EN"":[{""PropertyName"":""Name"",""Value"":""GENERATE DICTIONARY""}]}
" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""REPORTE COMISIONES""}],""EN"":[{""PropertyName"":""Name"",""Value"":""COMISSIONS REPORT""}]}
" });

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""MOVIMIENTOS DE PRODUCTO""}],""EN"":[{""PropertyName"":""Name"",""Value"":""PRODUCT MOVEMENTS""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "User,UserClaims,Role,RoleSection,Section,SectionOperation", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Permisos""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Permissions""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Customer,CustomerRate", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Tarifas de clientes""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Customer Rates""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Product,ProductTax,ProductUnit,CompositeProduct,ProductCost", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Productos""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Products""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Customer,CustomerPayment", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Pagos de clientes""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Customer Payments""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Currency", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Monedas""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Currencies""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Tax", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Impuestos""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Taxes""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Invoice,InvoiceDetail,TRNControl,Unit,UnitProductEquivalence,Seller,BranchOffice,Warehouse,CreditNote,Currency,Customer,Inventory,PaymentType", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Facturas""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Invoices""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Invoice,InvoiceDetail,Unit,UnitProductEquivalence,Seller,Currency,Customer", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Cotizaciones""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Quotes""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Customer,BranchOffice,Warehouse,TRNControl,Zone", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""CLientes""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Customers""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "BranchOffice,Warehouse", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Almacenes""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Warehouses""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "*", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Todos""}],""EN"":[{""PropertyName"":""Name"",""Value"":""All""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Inventory,Product,BranchOffice,Warehouse,Supplier", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Inventarios""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Inventories""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "TRNControl", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Control NCF""}],""EN"":[{""PropertyName"":""Name"",""Value"":""TRN Control""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Supplier,Expense,Tax,ExpenseTax,Currency", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Gastos""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Expenses""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "BranchOffice,Warehouse", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Oficinas""}],""EN"":[{""PropertyName"":""Name"",""Value"":""BranchOffices""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "ExpensesPayment,Supplier,BranchOffice,User,Currency,Tax", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Pagos a suplidores""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Expenses Payments""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Supplier", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Suplidores""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Suppliers""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Unit", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Unidades""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Units""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "User,BranchOffice,Warehouse,CashRegister", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Usuarios""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Users""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "PaymentType", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Tipos de pagos""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Payment Types""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "CashRegister,BranchOffice", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Cajas registradoras""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Cash Registers""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "CashRegister,User,CashRegisterOpening,CashRegisterOpeningDetail", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Aperturas / cierre de cajas""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Cash Register Openings""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "CashRegister,User,CashRegisterOpening,CashRegisterOpeningDetail", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Montos de aperturas""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Cash Register Openings Amounts""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Supplier,Product,Tax,User", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Movimientos de entrada""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Income Movements""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Invoice,Product,InvoiceDetail,Customer", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Devolucion de clientes""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Customers Returns""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Supplier,Expense,Tax,Currency,SupplierReturn", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Devoluciones a suplidor""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Suppliers Returns""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "BranchOffice,Warehouse,User,Product,Unit,WarehouseTransfer", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Transferencias entre almacenes""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Warehouse Transfers""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Product,Unit,ProductUnit", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Unidades de productos""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Product Units""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Role", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Roles""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Roles""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Section", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Secciones""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Sections""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Operation", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Operaciones""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Operations""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Seller,Zone,BranchOffice", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Vendedores""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Sellers""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Zone", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Zonas""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Zones""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Users,Role,UserRole", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Roles de usuarios""}],""EN"":[{""PropertyName"":""Name"",""Value"":""User Roles""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Pantalla principal""}],""EN"":[{""PropertyName"":""Name"",""Value"":""DashBoard""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Invoice", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Reporte de ventas""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Sales Report""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Invoice", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Cuentas por cobrar""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Accounts Receivable""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "CustomerPayment", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Recibos de ingresos""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Income Receipts""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Invoice,CustomerPayment,Seller", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Comisiones""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Commisions""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Product,Inventory,WarehouseMovement", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Movimientos de productos""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Product Movements""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Expense", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Cuentas por pagar""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Debst To Pay""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Product", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Listado de precios""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Price List""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Customer", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Listado de clientes""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Customers List""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Invoice,Expense,CustomerPayment", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Estado de cuentas""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Account State""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Invoice,Expense,CompanyState", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Estado compania""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Result State""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Tax,Invoice,InvoiceTax", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Reportes de impuestos""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Taxes Report""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "InventoryEntry", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Entrada de inventarios""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Inventory Incomes""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Expense,Payment", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Pagos a suplidores""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Company Payments""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Menu""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Menu""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "School,BranchOffice,Zone,Customer", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Escuelas""}],""EN"":[{""PropertyName"":""Name"",""Value"":""School""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "Product,Inventory,BranchOffice,Menu", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Menu escolar""}],""EN"":[{""PropertyName"":""Name"",""Value"":""School Menu""}]}
" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "TranslationData" },
                values: new object[] { "InvoiceLead,Product,Customer,BranchOffice", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"{""ES"":[{""PropertyName"":""Name"",""Value"":""Conduces""}],""EN"":[{""PropertyName"":""Name"",""Value"":""Invoice Lead""}]}
" });
        }
    }
}
