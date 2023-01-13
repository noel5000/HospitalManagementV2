using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class TenantId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Zones",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "WarehousesTransfers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "WarehousesMovements",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Warehouses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "UsersClaims",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "UserRoles",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Units",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "UnitProductsEquivalences",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "TRNsControl",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Taxes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "SuppliersReturns",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "SuppliersBalances",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Suppliers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "SequencesControl",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Sellers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Sections",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "SectionOperations",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Schools",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "SchoolContacts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "RoleSectionOperations",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Roles",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "ProductTaxes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "ProductSupplierCosts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "PaymentTypes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "PaymentDetails",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Payment",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "PatientCheckups",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Operations",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "OpeningsAmounts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "MovementTypes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Menus",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "MenuDetails",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "MedicalSpecialities",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "LeadsDetails",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Languages",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "LanguageKeys",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "InvoicesTaxes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "InvoicesLeads",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Invoices",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "InvoiceDetails",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "InventoryEntries",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Inventory",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "InsuranceServiceCoverages",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Insurances",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "InsurancePlans",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "FileAttachments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "ExpenseTaxes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "ExpensesPayments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Expenses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "ExceptionLogs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "CustomersReturns",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "CustomersReturnDetails",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "CustomersPayments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "CustomersBalance",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Currencies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "CreditNotes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "CompositeProducts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "CompanyPayments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "CheckupPrescriptions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "CheckupAttachments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "CashRegisters",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "CashRegisterOpenings",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "CashRegisterOpeningDetails",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "CashRegisterFlowDetails",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "BranchOffices",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Appointments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "AppointmentDetails",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 8L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 16L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 48L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 49L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 50L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 51L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 52L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 53L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 54L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 55L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 56L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 57L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 58L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 59L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 12L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 13L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 14L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 15L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 16L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 17L,
                column: "TenantId",
                value: "BaseTenant");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "TenantId",
                value: "BaseTenant");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Zones");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "WarehousesTransfers");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "WarehousesMovements");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "UsersClaims");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "UnitProductsEquivalences");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "TRNsControl");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Taxes");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "SuppliersReturns");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "SuppliersBalances");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "SequencesControl");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "SectionOperations");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "SchoolContacts");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "RoleSectionOperations");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "ProductTaxes");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "ProductSupplierCosts");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "PaymentTypes");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "PaymentDetails");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "PatientCheckups");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Operations");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "OpeningsAmounts");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "MovementTypes");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "MenuDetails");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "MedicalSpecialities");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "LeadsDetails");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "LanguageKeys");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "InvoicesTaxes");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "InvoicesLeads");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "InvoiceDetails");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "InventoryEntries");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "InsuranceServiceCoverages");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "InsurancePlans");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "FileAttachments");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "ExpenseTaxes");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "ExpensesPayments");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "ExceptionLogs");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "CustomersReturns");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "CustomersReturnDetails");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "CustomersPayments");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "CustomersBalance");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "CreditNotes");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "CompositeProducts");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "CompanyPayments");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "CheckupPrescriptions");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "CheckupAttachments");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "CashRegisters");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "CashRegisterOpenings");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "CashRegisterOpeningDetails");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "CashRegisterFlowDetails");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "BranchOffices");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "AppointmentDetails");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
