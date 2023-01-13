using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class permissions_changes_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleSectionOperations_SectionOperations_SectionOperationId",
                table: "RoleSectionOperations");

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "0-0-1", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "0-1-0", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "0-1-1", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "1-0-0", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "1-0-1", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "1-1-0", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "1-1-1", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "accountNumber_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "actions_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "additionalInfo_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "addMedicine_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "address_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "addRole_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "addSector_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "administration_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "age_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "all_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "AlreadyExist_error", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "alreadyNull_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "amount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "amountIsGreater_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "appliedCreditNoteAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "appointment_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "appointmentAlreadyProcessed_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "appointmentExist_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "AppointmentIsProcess_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "appointmentNotValid_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "appointmentNulled_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "appointmentNumber_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "appointments_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "appointmentType_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "april_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "areadyClosed_error", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "areYouSure_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "assignedWarehouse_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "attachments_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "attend_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "attendedBy_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "aug_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "auth_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "balance_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "banktransfer_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "baseProducts_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "beforeTaxAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "beforeTaxesAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "bill_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billConfirm_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billedBy_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billing_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingAmountLimit_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingDate_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateB_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateC_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateD_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateE_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateF_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateG_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateI_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateJ_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateM_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateN_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateO_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateP_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateQ_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateR_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateS_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "birthDate_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "birthDay_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "bloodType_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "branchOffice_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "branchOffice_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cancel_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CannotDeleteExpense_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cannotDeleteTax_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cannotEraseUnit_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cannotRemoveBaseProduct_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CannotUpdateExpense_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cannotUpdatePayment_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CantCloseWithZero_error", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cardId_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cardIdAlreadyExist_error", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cash_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cashRegister_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cashRegister_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cashRegisterManteinance_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cashRegisterOpeningHours_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cashRegisterOpeningIsClosed_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cashROpenClose_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "changePass_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "check_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CheckbookNumber_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "checkupNumber_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "closeCashRegister_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "closing_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "closureAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "closureDate_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "code_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "comissionAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "comissionByProduct_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "comissionRate_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "commissions_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "companyDebt_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CompanyOwedAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "consultation_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "consultation_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "consultations_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "consultationType_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "contact1_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "contact2_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "contact3_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "contacts_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "core_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cost_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "coverageAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "createLead_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "Credit_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "creditAmountLimit_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "creditCard_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "creditLimitReached_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "creditNote_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "creditNoteAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "creditNoteApplied_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "creditNoteInfo_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "creditNoteNotExist_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "credits_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "currencies_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "currency_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CurrencyCode_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CurrencyId_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CurrencyName_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CurrentBalance_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "customer_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "customerDebt_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CustomerName_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "customerPayment_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "customerReturns_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "customers_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "customersList_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CustomersOwedAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "customersReturns_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "dashboard_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "date_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "day_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "daysAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "DaysCount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "Debit_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "debits_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "debtsToPay_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "dec_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "defWarehouseNotExit_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "delete_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "deleteConfirm_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "deliverdBy_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "deliverLead_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "description_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "destinyBranchOffice_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "destinyWarehouse_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "details_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "details_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "detailsRequired_error", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "diagnoses_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "differentCurrency_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "discountAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "discountRate_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "dispatchInventory_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "doctor_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "doctorRequired_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "documentDoesntExist_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "documentNumber_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "edit_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "editAppointment_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "email_input", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "email_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "emptyAppointment_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "emptyInvoice_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "emptyStomach_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "endDate_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "equivalence_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "error_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "errorDictionary_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "especializedImages_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "exchangeRate_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "ExchangeRateAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "existence_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "exo_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "expensePayments_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "ExpenseReference_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "expenses_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "expensesPayment_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "expensesRegister_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "export_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "feb_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "female_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "fieldsRequired_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "fixedComission_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "forgotPass_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "friday_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "gender_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "GivenAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "history_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "hospital_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "hospitals_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "id_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "incomeAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "incomeReceipts_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "insurance_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "insuranceApprovalCode_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "insuranceCard_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "insuranceCardId_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "insuranceCoverage_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "insuranceCoverageAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "insuranceCoveragesReport_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "insurancePlan_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "insurances_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invalidConsultationAppointment_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invalidInvoice_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invalidInvoiceStateReturn_error", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "inventory_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "inventoryDoesntExist_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "inventoryIn_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "InvoiceCurrency_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invoiceDoesNotExist_error", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invoiceDueDays_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "InvoiceId_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invoiceInfo_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invoiceLeads_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invoiceNumber_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invoiceNumberRequired_error", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invoicePaid_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invoices_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "isActive_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "isCompositeProduct_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "isDefective_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "isLocalCurrency_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "isPrimary_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "isService_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "jan_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "jul_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "jun_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "laboratory_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "labTests_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "language_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "lastName_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "leadDueDays_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "leadNumber_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "login_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "logOut_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "logOut_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "male_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "march_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "markAsDeliveredConfirm_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "maxClosureDate_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "may_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "medicalConsultation_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "medicalSpecialities_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "medicalSpeciality_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "medicalSpecialty_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "medication_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "medications_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "medicine_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "medicineWarehouse_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "menu_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "mobile_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "monday_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "month_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "movements_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "movementType_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "name_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "NameAndCode_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "nameRequired_error", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "newItems_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "no_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "noCoverage_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "notExistingClass_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "notFound_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "notValid_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "nov_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "nrc_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "null_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "NumberOfDays_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "numericControl_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "observations_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "oct_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "ok_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "ok_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "onlyOneConsultationPerAppointment_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "opening_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "openingAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "openingDate_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "operations_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "originBranchOffice_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "originQuantity_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "originWarehouse_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "outcomeAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "outOfStock_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "OutstandingAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "owedAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "owedAmountOutdated_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "paidAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "parentUnitDoesntExist_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "password_input", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "password_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "patient_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "patientAppointments_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "patientCheckups_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "patientPaymentAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "patients_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "pay_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "paymentNotValid_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "paymentsComission_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "paymentType_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "permissions_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "phone_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "phoneNumber_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "plans_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "pleaseSelect_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "position_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "positiveBalance_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "prescriptionTypes_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "price_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "Price2_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "price3_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "pricesList_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "primaryUnitRequired_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "print_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "print_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "product_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "productCost_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "productNeedsPrimaryUnit_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "productNeedsTaxes_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "productNeedsUnits_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "products_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "productsMovements_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "profile_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "quantity_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "quotes_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "rate_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "receiptsReport_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "receivedAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "receivedBy_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "recordedRate_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "reference_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "remember_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "reports_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "reportType_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "required_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "resetPass_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "resultState_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "returnAlreadyApplied_error", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "returnedAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "reverse_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "role_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "roles_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "sales_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "salesComission_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "salesReport_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "save_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "savedFormData_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "school_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "schools_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "search_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "search_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "section_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "sector_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "selectColumns_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "selectedDate_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "selectedlabTests_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "seller_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "SellerName_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "sellerRate_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "sellers_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "sep_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "sequence_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "sequenceError_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "serie_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "series_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "sessionTimeOut_error", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "specializedImages_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "start_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "startDate_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "state_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "subTotal_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "success_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "supplier_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "supplierCosts_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "suppliers_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "suppliersReturns_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "symptoms_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "tax_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "taxAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "taxes_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "taxes_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "taxesAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "taxesReport_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "TaxId_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "taxIsReq_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "thisIsABaseProduct_error", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "thursday_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "time_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "totalAmount_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "totalBilled_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "totalCompanyDebt_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "totalCustomersDebt_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "totalIncome_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "totalInsuranceCoverage_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "totalOutcome_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "totalOwed_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "totalPaid_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "trn_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "trnControl_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "TRNControl_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "trnNotAvailable_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "TRNType_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "tusday_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "type_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "unit_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "unitCost_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "unitDoesntExist_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "unitNotExist_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "unitPrice_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "units_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "upload_btn", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "user_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "user_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "userName_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "users_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "warehouse_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "warehouse_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "warehouseError_msg", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "warehouseTransfers_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "week_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "wendsday_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "whenToTake_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "yes_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "zone_lbl", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "zones_menu", "EN" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "0-0-1", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "0-1-0", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "0-1-1", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "1-0-0", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "1-0-1", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "1-1-0", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "1-1-1", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "accountNumber_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "accountsReceivable_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "accountState_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "actions_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "add_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "additionalInfo_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "addMedicine_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "address_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "addRole_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "addSector_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "administration_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "age_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "all_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "AlreadyExist_error", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "alreadyNull_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "amount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "amountIsGreater_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "appliedCreditNoteAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "appointment_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "appointmentAlreadyProcessed_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "appointmentExist_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "AppointmentIsProcess_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "appointmentNotValid_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "appointmentNulled_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "appointmentNumber_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "appointments_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "appointmentType_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "april_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "areadyClosed_error", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "areYouSure_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "assignedWarehouse_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "attachments_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "attend_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "attendedBy_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "aug_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "auth_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "balance_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "banktransfer_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "baseProducts_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "beforeTaxAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "beforeTaxesAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "bill_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billConfirm_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billedBy_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billing_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingAmountLimit_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingDate_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateB_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateC_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateD_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateE_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateF_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateG_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateI_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateJ_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateM_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateN_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateO_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateP_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateQ_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateR_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "billingStateS_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "birthDate_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "birthDay_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "bloodType_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "branchOffice_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "branchOffice_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cancel_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CannotDeleteExpense_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cannotDeleteTax_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cannotEraseUnit_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cannotRemoveBaseProduct_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CannotUpdateExpense_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cannotUpdatePayment_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CantCloseWithZero_error", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cardId_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cardIdAlreadyExist_error", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cash_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cashRegister_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cashRegister_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cashRegisterManteinance_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cashRegisterOpeningHours_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cashRegisterOpeningIsClosed_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cashROpenClose_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "changePass_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "check_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CheckbookNumber_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "checkupNumber_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "closeCashRegister_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "closing_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "closureAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "closureDate_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "code_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "comissionAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "comissionByProduct_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "comissionRate_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "commissions_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "companyDebt_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CompanyOwedAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "consultation_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "consultation_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "consultations_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "consultationType_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "contact1_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "contact2_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "contact3_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "contacts_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "core_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "cost_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "coverageAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "createLead_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "Credit_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "creditAmountLimit_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "creditCard_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "creditLimitReached_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "creditNote_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "creditNoteAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "creditNoteApplied_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "creditNoteInfo_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "creditNoteNotExist_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "credits_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "currencies_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "currency_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CurrencyCode_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CurrencyId_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CurrencyName_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CurrentBalance_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "customer_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "customerDebt_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CustomerName_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "customerPayment_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "customerReturns_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "customers_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "customersList_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "CustomersOwedAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "customersReturns_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "dashboard_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "date_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "day_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "daysAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "DaysCount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "Debit_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "debits_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "debtsToPay_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "dec_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "defWarehouseNotExit_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "delete_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "deleteConfirm_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "deliverdBy_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "deliverLead_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "description_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "destinyBranchOffice_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "destinyWarehouse_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "details_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "details_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "detailsRequired_error", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "diagnoses_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "differentCurrency_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "discountAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "discountRate_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "dispatchInventory_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "doctor_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "doctorRequired_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "documentDoesntExist_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "documentNumber_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "edit_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "editAppointment_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "email_input", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "email_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "emptyAppointment_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "emptyInvoice_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "emptyStomach_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "endDate_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "equivalence_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "error_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "errorDictionary_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "especializedImages_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "exchangeRate_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "ExchangeRateAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "existence_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "exo_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "expensePayments_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "ExpenseReference_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "expenses_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "expensesPayment_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "expensesRegister_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "export_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "feb_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "female_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "fieldsRequired_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "fixedComission_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "forgotPass_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "friday_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "gender_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "GivenAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "history_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "hospital_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "hospitals_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "id_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "incomeAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "incomeReceipts_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "insurance_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "insuranceApprovalCode_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "insuranceCard_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "insuranceCardId_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "insuranceCoverage_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "insuranceCoverageAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "insuranceCoveragesReport_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "insurancePlan_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "insurances_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invalidConsultationAppointment_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invalidInvoice_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invalidInvoicestáteReturn_error", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "inventory_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "inventoryDoesntExist_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "inventoryIn_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "InvoiceCurrency_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invoiceDoesNotExist_error", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invoiceDueDays_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "InvoiceId_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invoiceInfo_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invoiceLeads_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invoiceNumber_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invoiceNumberRequired_error", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invoicePaid_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "invoices_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "isActive_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "isCompositeProduct_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "isDefective_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "isLocalCurrency_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "isPrimary_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "isService_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "jan_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "jul_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "jun_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "laboratory_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "labTests_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "language_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "lastName_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "leadDueDays_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "leadNumber_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "login_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "logOut_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "logOut_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "male_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "march_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "markAsDeliveredConfirm_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "maxClosureDate_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "may_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "medicalConsultation_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "medicalSpecialities_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "medicalSpeciality_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "medicalSpecialty_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "medication_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "medications_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "medicine_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "medicineWarehouse_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "menu_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "mobile_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "monday_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "month_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "movements_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "movementType_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "name_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "NameAndCode_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "nameRequired_error", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "newItems_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "no_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "noCoverage_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "notExistingClass_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "notFound_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "notValid_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "nov_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "nrc_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "null_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "NumberOfDays_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "numericControl_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "observations_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "oct_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "ok_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "ok_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "onlyOneConsultationPerAppointment_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "opening_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "openingAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "openingDate_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "operations_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "originBranchOffice_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "originQuantity_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "originWarehouse_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "outcomeAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "outOfStock_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "OutstandingAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "owedAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "owedAmountOutdated_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "paidAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "parentUnitDoesntExist_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "password_input", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "password_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "patient_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "patientAppointments_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "patientCheckups_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "patientPaymentAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "patients_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "pay_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "paymentNotValid_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "paymentsComission_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "paymentType_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "permissions_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "phone_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "phoneNumber_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "plans_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "pleaseSelect_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "position_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "positiveBalance_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "prescriptionTypes_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "price_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "Price2_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "price3_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "pricesList_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "primaryUnitRequired_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "print_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "print_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "product_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "productCost_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "productNeedsPrimaryUnit_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "productNeedsTaxes_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "productNeedsUnits_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "products_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "productsMovements_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "profile_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "quantity_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "quotes_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "rate_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "receiptsReport_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "receivedAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "receivedBy_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "recordedRate_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "reference_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "remember_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "reports_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "reportType_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "required_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "resetPass_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "resultState_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "returnAlreadyApplied_error", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "returnedAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "reverse_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "role_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "roles_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "sales_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "salesComission_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "salesReport_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "save_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "savedFormData_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "school_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "schools_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "search_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "search_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "section_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "sector_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "selectColumns_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "selectedDate_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "selectedlabTests_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "seller_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "SellerName_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "sellerRate_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "sellers_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "sep_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "sequence_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "sequenceError_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "serie_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "series_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "sessionTimeOut_error", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "specializedImages_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "start_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "startDate_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "state_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "subTotal_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "success_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "supplier_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "supplierCosts_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "suppliers_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "suppliersReturns_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "symptoms_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "tax_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "taxAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "taxes_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "taxes_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "taxesAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "taxesReport_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "TaxId_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "taxIsReq_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "thisIsABaseProduct_error", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "thursday_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "time_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "totalAmount_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "totalBilled_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "totalCompanyDebt_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "totalCustomersDebt_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "totalIncome_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "totalInsuranceCoverage_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "totalOutcome_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "totalOwed_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "totalPaid_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "trn_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "trnControl_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "TRNControl_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "trnNotAvailable_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "TRNType_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "tusday_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "type_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "unit_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "unitCost_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "unitDoesntExist_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "unitNotExist_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "unitPrice_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "units_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "upload_btn", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "user_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "user_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "userName_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "users_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "warehouse_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "warehouse_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "warehouseError_msg", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "warehouseTransfers_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "week_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "wendsday_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "whenToTake_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "yes_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "zone_lbl", "ES" });

            migrationBuilder.DeleteData(
                table: "LanguageKeys",
                keyColumns: new[] { "Key", "LanguageCode" },
                keyValues: new object[] { "zones_menu", "ES" });

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "RoleSectionOperations",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 296L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 303L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 304L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 308L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 309L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 310L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 312L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 313L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 314L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 315L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 316L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 317L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 318L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 319L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 321L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 322L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 323L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 324L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 326L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 328L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 329L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 330L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 331L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 332L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 333L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 334L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 335L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 336L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 337L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 338L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 339L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 341L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 342L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 343L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 344L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 346L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 348L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 349L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 350L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 351L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 352L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 353L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 354L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 355L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 356L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 357L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 358L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 359L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 361L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 362L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 363L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 364L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 366L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 367L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 368L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 369L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 370L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 371L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 372L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 373L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 374L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 375L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 376L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 377L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 378L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 379L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 381L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 382L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 383L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 384L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 386L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 387L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 388L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 389L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 390L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 391L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 392L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 393L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 394L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 395L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 396L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 397L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 398L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 399L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 401L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 402L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 403L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 404L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 406L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 408L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 409L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 410L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 411L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 412L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 413L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 414L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 415L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 416L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 417L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 418L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 419L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 421L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 422L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 423L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 424L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 425L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 426L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 428L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 429L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 430L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 431L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 432L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 433L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 434L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 435L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 436L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 437L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 438L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 439L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 441L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 442L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 443L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 444L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 446L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 448L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 449L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 450L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 451L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 452L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 453L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 454L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 455L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 456L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 457L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 458L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 459L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 461L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 462L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 463L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 464L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 465L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 466L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 468L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 469L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 470L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 471L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 472L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 473L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 474L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 475L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 476L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 477L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 478L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 479L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 481L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 482L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 483L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 484L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 485L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 486L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 487L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 488L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 489L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 490L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 491L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 492L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 493L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 494L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 495L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 496L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 497L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 498L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 499L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 501L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 502L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 503L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 504L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 505L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 506L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 508L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 509L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 510L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 511L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 512L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 513L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 514L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 515L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 516L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 517L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 518L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 519L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 521L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 522L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 523L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 524L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 525L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 526L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 528L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 529L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 530L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 531L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 532L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 533L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 534L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 535L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 536L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 537L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 538L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 539L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 541L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 542L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 543L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 544L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 546L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 548L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 549L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 550L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 551L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 552L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 553L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 554L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 555L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 556L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 557L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 558L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 559L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 561L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 562L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 563L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 564L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 565L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 566L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 567L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 568L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 569L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 570L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 571L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 572L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 573L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 574L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 575L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 576L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 577L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 578L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 579L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 581L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 582L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 583L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 584L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 585L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 586L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 587L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 588L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 589L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 590L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 591L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 592L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 593L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 594L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 595L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 596L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 597L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 598L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 599L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 601L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 602L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 603L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 604L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 605L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 606L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 607L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 608L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 609L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 610L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 611L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 612L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 613L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 614L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 615L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 616L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 617L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 618L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 619L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 621L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 622L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 623L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 624L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 626L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 628L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 629L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 630L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 631L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 632L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 633L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 634L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 635L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 636L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 637L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 638L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 639L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 641L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 642L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 643L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 644L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 646L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 648L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 649L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 650L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 651L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 652L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 653L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 654L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 655L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 656L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 657L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 658L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 659L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 661L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 662L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 663L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 664L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 665L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 666L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 667L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 668L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 669L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 670L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 671L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 672L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 673L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 674L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 675L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 676L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 677L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 678L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 679L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 681L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 682L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 683L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 684L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 685L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 686L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 687L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 688L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 689L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 690L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 691L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 692L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 693L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 694L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 695L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 696L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 697L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 698L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 699L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 701L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 702L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 703L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 704L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 705L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 706L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 708L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 709L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 710L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 711L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 712L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 713L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 714L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 715L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 716L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 717L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 718L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 719L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 721L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 722L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 723L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 724L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 725L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 726L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 728L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 729L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 730L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 731L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 732L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 733L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 734L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 735L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 736L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 737L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 738L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 739L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 741L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 742L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 743L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 744L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 745L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 746L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 748L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 749L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 750L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 751L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 752L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 753L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 754L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 755L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 756L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 757L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 758L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 759L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 761L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 762L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 763L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 764L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 766L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 768L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 769L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 770L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 771L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 772L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 773L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 774L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 775L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 776L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 777L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 778L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 779L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 781L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 782L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 783L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 784L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 785L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 786L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 788L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 789L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 790L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 791L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 792L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 793L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 794L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 795L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 796L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 797L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 798L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 799L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 801L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 802L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 803L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 804L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 805L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 806L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 808L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 809L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 810L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 811L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 812L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 813L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 814L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 815L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 816L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 817L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 818L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 819L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 821L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 822L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 823L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 824L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 825L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 826L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 828L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 829L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 830L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 831L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 832L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 833L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 834L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 835L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 836L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 837L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 838L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 839L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 841L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 842L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 843L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 844L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 845L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 846L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 848L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 849L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 850L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 851L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 852L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 853L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 854L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 855L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 856L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 857L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 858L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 859L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 861L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 862L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 863L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 864L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 865L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 866L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 868L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 869L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 870L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 871L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 872L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 873L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 874L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 875L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 876L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 877L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 878L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 879L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 881L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 882L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 883L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 884L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 885L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 886L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 888L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 889L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 890L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 891L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 892L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 893L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 894L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 895L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 896L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 897L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 898L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 899L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 901L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 902L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 903L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 904L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 905L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 906L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 908L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 909L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 910L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 911L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 912L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 913L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 914L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 915L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 916L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 917L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 918L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 919L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 921L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 922L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 923L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 924L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 925L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 926L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 928L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 929L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 930L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 931L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 932L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 933L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 934L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 935L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 936L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 937L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 938L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 939L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 941L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 942L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 943L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 944L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 945L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 946L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 947L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 948L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 949L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 950L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 951L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 952L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 953L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 954L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 955L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 956L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 957L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 958L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 959L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 961L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 962L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 963L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 964L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 965L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 966L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 967L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 968L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 969L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 970L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 971L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 972L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 973L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 974L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 975L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 976L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 977L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 978L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 979L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1039L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1040L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1041L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1043L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1045L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1046L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1047L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1048L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1049L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1050L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1051L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1052L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1053L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1054L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1055L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1056L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1058L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1059L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1060L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1062L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1064L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1065L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1066L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1067L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1068L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1069L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1070L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1071L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1072L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1073L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1074L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1075L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1079L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1081L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1083L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1084L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1085L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1086L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1087L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1088L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1089L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1090L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1091L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1092L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1093L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1094L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 301L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 302L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 305L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 306L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 307L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 311L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 325L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 327L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 345L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 347L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 365L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 385L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 405L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 407L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 427L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 445L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 447L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 467L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 507L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 527L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 545L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 547L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 625L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 627L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 645L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 647L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 707L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 727L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 747L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 765L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 767L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 787L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 807L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 827L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 847L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 867L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 887L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 907L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 927L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1038L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1042L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1044L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1057L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1061L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1063L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1076L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1077L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1078L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1080L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1082L);

            migrationBuilder.RenameColumn(
                name: "SectionOperationId",
                table: "RoleSectionOperations",
                newName: "OperationId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleSectionOperations_SectionOperationId",
                table: "RoleSectionOperations",
                newName: "IX_RoleSectionOperations_OperationId");

            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "RoleSectionOperations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Appointment", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Appointment\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Appointment\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "BranchOffice", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"BranchOffice\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"BranchOffice\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "CashRegister", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegister\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegister\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "CashRegisterOpening", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpening\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpening\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "CashRegisterOpeningsAmount", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpeningsAmount\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpeningsAmount\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "CheckUpAttachment", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CheckUpAttachment\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CheckUpAttachment\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "CompanyPayment", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CompanyPayment\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CompanyPayment\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "CompanyState", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CompanyState\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CompanyState\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "CompositeProduct", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CompositeProduct\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CompositeProduct\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "CreditNote", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CreditNote\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CreditNote\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Currency", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Currency\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Currency\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "CustomerBalance", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerBalance\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerBalance\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Customer", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Customer\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Customer\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "CustomerPayment", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayment\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayment\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "CustomerReturn", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerReturn\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerReturn\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "CustomerReturnDetail", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerReturnDetail\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerReturnDetail\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Expense", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Expense\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Expense\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "ExpensePayment", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensePayment\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensePayment\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "ExpenseTax", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpenseTax\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpenseTax\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Insurance", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Insurance\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Insurance\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "InsurancePlan", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InsurancePlan\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InsurancePlan\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "InsuranceServiceCoverage", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InsuranceServiceCoverage\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InsuranceServiceCoverage\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Inventory", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Inventory\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Inventory\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "InventoryEntry", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryEntry\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryEntry\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Invoice", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoice\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoice\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "InvoiceTax", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InvoiceTax\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InvoiceTax\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Language", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Language\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Language\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Login", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Login\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Login\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Logout", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Logout\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Logout\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "MedicalSpeciality", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"MedicalSpeciality\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"MedicalSpeciality\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "MovementType", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"MovementType\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"MovementType\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "OpeningAmount", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"OpeningAmount\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"OpeningAmount\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Operation", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Operation\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Operation\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "PatientCheckup", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PatientCheckup\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PatientCheckup\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Payment", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Payment\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Payment\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "PaymentDetail", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentDetail\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentDetail\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "PaymentType", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentType\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentType\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "ProductComposite", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductComposite\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductComposite\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Product", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Product\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Product\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "ProductCost", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductCost\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductCost\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "ProductTax", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductTax\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductTax\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "ProductUnit", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductUnit\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductUnit\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "ReturnDetail", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ReturnDetail\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ReturnDetail\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Role", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Role\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Role\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "RoleSectionOperation", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"RoleSectionOperation\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"RoleSectionOperation\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Seller", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Seller\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Seller\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "SupplierBalance", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SupplierBalance\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SupplierBalance\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Supplier", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Supplier\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Supplier\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "SupplierReturn", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SupplierReturn\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SupplierReturn\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Tax", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Tax\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Tax\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "TrnControl", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"TrnControl\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"TrnControl\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Unit", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Unit\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Unit\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "UnitProductEquivalence", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UnitProductEquivalence\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UnitProductEquivalence\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "User", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"User\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"User\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "UserRole", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRole\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRole\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Warehouse", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Warehouse\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Warehouse\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "WarehouseMovement", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseMovement\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseMovement\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "WarehouseTransfer", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfer\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfer\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Zone", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Zone\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Zone\"}]}" });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Active", "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "TranslationData" },
                values: new object[] { 60L, true, "All", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BaseTenant", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"All\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"All\"}]}" });

            migrationBuilder.AddForeignKey(
                name: "FK_RoleSectionOperations_Operations_OperationId",
                table: "RoleSectionOperations",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleSectionOperations_Operations_OperationId",
                table: "RoleSectionOperations");

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DropColumn(
                name: "Section",
                table: "RoleSectionOperations");

            migrationBuilder.RenameColumn(
                name: "OperationId",
                table: "RoleSectionOperations",
                newName: "SectionOperationId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleSectionOperations_OperationId",
                table: "RoleSectionOperations",
                newName: "IX_RoleSectionOperations_SectionOperationId");

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "0-0-1", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Night" },
                    { "0-1-0", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Afternoon" },
                    { "0-1-1", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Afternoon - Night" },
                    { "1-0-0", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Morning" },
                    { "1-0-1", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Morning - Night" },
                    { "1-1-0", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Morning - Afternoon" },
                    { "1-1-1", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Morning - Afternoon - Night" },
                    { "accountNumber_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Account number" },
                    { "actions_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Actions" },
                    { "additionalInfo_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Additional linfo" },
                    { "addMedicine_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Add" },
                    { "address_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Address" },
                    { "addRole_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Add roles" },
                    { "addSector_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Add sector" },
                    { "administration_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Administration" },
                    { "age_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Age" },
                    { "all_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "All" },
                    { "AlreadyExist_error", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Already exist" },
                    { "alreadyNull_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Already nulled" },
                    { "amount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Amount" },
                    { "amountIsGreater_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Credit note amount is greater than invoice amount." },
                    { "appliedCreditNoteAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Applied CN amount" },
                    { "appointment_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Appointment" },
                    { "appointmentAlreadyProcessed_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Appointment already processed" },
                    { "appointmentExist_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Appointment already exist" },
                    { "AppointmentIsProcess_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Appointment is processed already" },
                    { "appointmentNotValid_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Appointment not valid" },
                    { "appointmentNulled_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Appointment is nulled" },
                    { "appointmentNumber_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Appointment number" },
                    { "appointments_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Appointments" },
                    { "appointmentType_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Appointment type" },
                    { "april_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "April" },
                    { "areadyClosed_error", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Already closed" },
                    { "areYouSure_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Are you sure?" },
                    { "assignedWarehouse_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Assigned Warehouse" },
                    { "attachments_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Attachments" },
                    { "attend_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Attend" },
                    { "attendedBy_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Attended by" },
                    { "aug_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Augoust" },
                    { "auth_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Auth" },
                    { "balance_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Balance" },
                    { "banktransfer_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Bank transfer" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "baseProducts_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Base products" },
                    { "beforeTaxAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Before taxes amount" },
                    { "beforeTaxesAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Before taxes amount" },
                    { "bill_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Bill Quote" },
                    { "billConfirm_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Are you sure to convert this quote?" },
                    { "billedBy_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Billed by" },
                    { "billing_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Billing" },
                    { "billingAmountLimit_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Billing amount limit" },
                    { "billingDate_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Billing date" },
                    { "billingStateB_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Billed" },
                    { "billingStateC_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Converted" },
                    { "billingStateD_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Delivered" },
                    { "billingStateE_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Expired" },
                    { "billingStateF_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "In Progress" },
                    { "billingStateG_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Generated" },
                    { "billingStateI_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Not enough inventory " },
                    { "billingStateJ_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Projected" },
                    { "billingStateM_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Nulled Lead" },
                    { "billingStateN_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Nulled" },
                    { "billingStateO_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Generated without inventory" },
                    { "billingStateP_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Paid" },
                    { "billingStateQ_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Quoted" },
                    { "billingStateR_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Full Paid" },
                    { "billingStateS_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Scheduled" },
                    { "birthDate_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Birth date" },
                    { "birthDay_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Birth day" },
                    { "bloodType_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Blood type" },
                    { "branchOffice_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Branch office" },
                    { "branchOffice_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Branch Offices" },
                    { "cancel_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Cancel" },
                    { "CannotDeleteExpense_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Cannot delete expense" },
                    { "cannotDeleteTax_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Cannot delete product tax. " },
                    { "cannotEraseUnit_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Cannot erase product unit." },
                    { "cannotRemoveBaseProduct_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Cannot remove base product." },
                    { "CannotUpdateExpense_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Cannot update  expense" },
                    { "cannotUpdatePayment_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Cannot update payment. " },
                    { "CantCloseWithZero_error", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Closure amount cannot be 0" },
                    { "cardId_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Card Id" },
                    { "cardIdAlreadyExist_error", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Card id already exists." },
                    { "cash_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Cash" },
                    { "cashRegister_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Cash register" },
                    { "cashRegister_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Cash Registers" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "cashRegisterManteinance_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Manteinance" },
                    { "cashRegisterOpeningHours_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Cash register opening hours" },
                    { "cashRegisterOpeningIsClosed_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Cash register already closed" },
                    { "cashROpenClose_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Opening/Closing" },
                    { "changePass_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Change Password" },
                    { "check_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Check" },
                    { "CheckbookNumber_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Checkbook number" },
                    { "checkupNumber_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Checkup number" },
                    { "closeCashRegister_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Close cash register" },
                    { "closing_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Closing" },
                    { "closureAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Closure amount" },
                    { "closureDate_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Closure date" },
                    { "code_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Code" },
                    { "comissionAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Comissions amount" },
                    { "comissionByProduct_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Product comissions" },
                    { "comissionRate_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Comission rate" },
                    { "commissions_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Commissions" },
                    { "companyDebt_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Company debts" },
                    { "CompanyOwedAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Company debt" },
                    { "consultation_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Consultation" },
                    { "consultation_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Consultation" },
                    { "consultations_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Consultations" },
                    { "consultationType_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Consultation type" },
                    { "contact1_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Contact 1" },
                    { "contact2_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Contact 2" },
                    { "contact3_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Contact 3" },
                    { "contacts_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Contacts" },
                    { "core_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Configurations" },
                    { "cost_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Cost" },
                    { "coverageAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Coverage amount" },
                    { "createLead_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Create lead" },
                    { "Credit_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Credit" },
                    { "creditAmountLimit_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Credit amount limit" },
                    { "creditCard_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Credit card" },
                    { "creditLimitReached_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Credit limit reached. Cannot continue." },
                    { "creditNote_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Credit Note" },
                    { "creditNoteAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Credit Note Amount" },
                    { "creditNoteApplied_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Credit note is already applied." },
                    { "creditNoteInfo_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Add Credit Note" },
                    { "creditNoteNotExist_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Credit note does not exist. " },
                    { "credits_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Credits" },
                    { "currencies_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Currencies" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "currency_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Currency" },
                    { "CurrencyCode_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Currency code" },
                    { "CurrencyId_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Currency ID" },
                    { "CurrencyName_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Currency name" },
                    { "CurrentBalance_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Current balance" },
                    { "customer_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Customer" },
                    { "customerDebt_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Customer debts" },
                    { "CustomerName_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Customer name" },
                    { "customerPayment_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Payments" },
                    { "customerReturns_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Customers returns" },
                    { "customers_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Customers" },
                    { "customersList_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Customers List" },
                    { "CustomersOwedAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Customer debt" },
                    { "customersReturns_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Customers Returns" },
                    { "dashboard_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Dashboard" },
                    { "date_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Date" },
                    { "day_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Day of week" },
                    { "daysAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Days amount" },
                    { "DaysCount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Days count" },
                    { "Debit_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Debit" },
                    { "debits_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Debits" },
                    { "debtsToPay_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Debts To Pay" },
                    { "dec_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Dicember" },
                    { "defWarehouseNotExit_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Defective warehouse does not exist. Please create one with 'DEF' as code first. " },
                    { "delete_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Delete" },
                    { "deleteConfirm_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Are you sure you want to delete?" },
                    { "deliverdBy_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Delivered by" },
                    { "deliverLead_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Mark lead as delivered" },
                    { "description_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Description" },
                    { "destinyBranchOffice_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Destiny branch office" },
                    { "destinyWarehouse_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Destiny warehouse" },
                    { "details_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Details" },
                    { "details_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Details" },
                    { "detailsRequired_error", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Details are required" },
                    { "diagnoses_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Diagnoses" },
                    { "differentCurrency_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Currencies are different. You can only apply the same currency. " },
                    { "discountAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Discount Amount" },
                    { "discountRate_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Discount rate" },
                    { "dispatchInventory_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Dispatch Inventory" },
                    { "doctor_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Doctor" },
                    { "doctorRequired_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Doctor required" },
                    { "documentDoesntExist_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Document does not exist" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "documentNumber_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Document number" },
                    { "edit_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Edit" },
                    { "editAppointment_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Edit Appointment" },
                    { "email_input", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Email" },
                    { "email_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Email" },
                    { "emptyAppointment_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Empty apointment" },
                    { "emptyInvoice_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Invoice doesn't have any details. Cannot be empty." },
                    { "emptyStomach_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Empty stomach" },
                    { "endDate_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "End date" },
                    { "equivalence_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Equivalence" },
                    { "error_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Error: Could not completed the current operation. " },
                    { "errorDictionary_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Error dictionary" },
                    { "especializedImages_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Especialized images" },
                    { "exchangeRate_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Exchange rate" },
                    { "ExchangeRateAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Exchange rate amount" },
                    { "existence_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Existence" },
                    { "exo_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Exnonerated" },
                    { "expensePayments_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Expenses payments" },
                    { "ExpenseReference_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Expense reference" },
                    { "expenses_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Expenses" },
                    { "expensesPayment_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Payments" },
                    { "expensesRegister_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Register expenses" },
                    { "export_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Export" },
                    { "feb_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Febrary" },
                    { "female_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Female" },
                    { "fieldsRequired_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Fields required" },
                    { "fixedComission_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Fixed comission" },
                    { "forgotPass_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Forgot Password?" },
                    { "friday_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Friday" },
                    { "gender_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Gender" },
                    { "GivenAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Given amount" },
                    { "history_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "History" },
                    { "hospital_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Hospital" },
                    { "hospitals_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Hospitals" },
                    { "id_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Id" },
                    { "incomeAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Income amount" },
                    { "incomeReceipts_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Income Receipts" },
                    { "insurance_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Insurance" },
                    { "insuranceApprovalCode_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Insurance approval code" },
                    { "insuranceCard_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Insurance card" },
                    { "insuranceCardId_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Insurance card ID" },
                    { "insuranceCoverage_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Insurance coverage" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "insuranceCoverageAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Insurance coverage amount" },
                    { "insuranceCoveragesReport_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Coverages report" },
                    { "insurancePlan_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Insurance plan" },
                    { "insurances_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Insurances" },
                    { "invalidConsultationAppointment_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Invalid consultation APPOINTMENT" },
                    { "invalidInvoice_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Invalid invoice." },
                    { "invalidInvoiceStateReturn_error", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Invalid invoice state." },
                    { "inventory_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Inventory" },
                    { "inventoryDoesntExist_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Inventory doesnt exist" },
                    { "inventoryIn_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Inventory Incomes" },
                    { "InvoiceCurrency_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Invoice currency" },
                    { "invoiceDoesNotExist_error", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Invoice number does not exists" },
                    { "invoiceDueDays_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Invoice due days" },
                    { "InvoiceId_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Invoice ID" },
                    { "invoiceInfo_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Basic Information" },
                    { "invoiceLeads_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Invoice Lead" },
                    { "invoiceNumber_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Invoice number" },
                    { "invoiceNumberRequired_error", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Invoice number is required" },
                    { "invoicePaid_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Invoice is already paid." },
                    { "invoices_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Invoices" },
                    { "isActive_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Active?" },
                    { "isCompositeProduct_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Composite product" },
                    { "isDefective_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Defective" },
                    { "isLocalCurrency_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Local currency" },
                    { "isPrimary_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Primary" },
                    { "isService_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Is service" },
                    { "jan_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "January" },
                    { "jul_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "July" },
                    { "jun_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Jun" },
                    { "laboratory_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Laboratory" },
                    { "labTests_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Lab tests" },
                    { "language_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Language" },
                    { "lastName_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Last name" },
                    { "leadDueDays_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Lead due days" },
                    { "leadNumber_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Lead number" },
                    { "login_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Login" },
                    { "logOut_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Log Out" },
                    { "logOut_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Log out" },
                    { "male_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Male" },
                    { "march_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "March" },
                    { "markAsDeliveredConfirm_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Are you sure to mark this lead as delivered?" },
                    { "maxClosureDate_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Max closure date" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "may_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "May" },
                    { "medicalConsultation_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Medical consultation" },
                    { "medicalSpecialities_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Medical specialities" },
                    { "medicalSpeciality_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Medical speciality" },
                    { "medicalSpecialty_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Medical speciality" },
                    { "medication_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Medication" },
                    { "medications_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Medications" },
                    { "medicine_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Medicine" },
                    { "medicineWarehouse_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Medicine warehouses" },
                    { "menu_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Lunch menu" },
                    { "mobile_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Mobile phone number" },
                    { "monday_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Monday" },
                    { "month_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Month" },
                    { "movements_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Movements" },
                    { "movementType_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Movement type" },
                    { "name_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Name" },
                    { "NameAndCode_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Name and code" },
                    { "nameRequired_error", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Name required" },
                    { "newItems_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "New Items" },
                    { "no_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "No" },
                    { "noCoverage_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "No coverage" },
                    { "notExistingClass_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Cannot process this product/Service. Class does not exist." },
                    { "notFound_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Not found" },
                    { "notValid_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Not valid" },
                    { "nov_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "November" },
                    { "nrc_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "NRC" },
                    { "null_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Null" },
                    { "NumberOfDays_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Days count" },
                    { "numericControl_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Numeric number" },
                    { "observations_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Observations" },
                    { "oct_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "October" },
                    { "ok_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "OK" },
                    { "ok_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Operation completed successfully." },
                    { "onlyOneConsultationPerAppointment_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Only one medical consultation per appointment." },
                    { "opening_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Opening" },
                    { "openingAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Opening amount" },
                    { "openingDate_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Opening date" },
                    { "operations_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Operations" },
                    { "originBranchOffice_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Origin branch office" },
                    { "originQuantity_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Origin quantity" },
                    { "originWarehouse_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Origin warehouse" },
                    { "outcomeAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Outcome amount" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "outOfStock_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Product is out of stock." },
                    { "OutstandingAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Outstanding amount" },
                    { "owedAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Owed amount" },
                    { "owedAmountOutdated_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Owed amount is outdated. please try update and try again." },
                    { "paidAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Paid amount" },
                    { "parentUnitDoesntExist_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Parent unit does not exist." },
                    { "password_input", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Password" },
                    { "password_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Password" },
                    { "patient_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Patient" },
                    { "patientAppointments_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Active patient's appointments" },
                    { "patientCheckups_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Patient checkups" },
                    { "patientPaymentAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Patient payment amount" },
                    { "patients_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Patients" },
                    { "pay_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Pay" },
                    { "paymentNotValid_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Payment is not valid." },
                    { "paymentsComission_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Payments comissions" },
                    { "paymentType_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Payment type" },
                    { "permissions_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Permissions" },
                    { "phone_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Phone number" },
                    { "phoneNumber_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Phone number" },
                    { "plans_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Plans" },
                    { "pleaseSelect_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Please select" },
                    { "position_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Position" },
                    { "positiveBalance_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Positive balance" },
                    { "prescriptionTypes_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Prescription types" },
                    { "price_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Price" },
                    { "Price2_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Price 2" },
                    { "price3_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Price 3" },
                    { "pricesList_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Prices List" },
                    { "primaryUnitRequired_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Primary unit is required. Please select one" },
                    { "print_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Print" },
                    { "print_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Print" },
                    { "product_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Product" },
                    { "productCost_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Product cost" },
                    { "productNeedsPrimaryUnit_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Product needs one primary unit." },
                    { "productNeedsTaxes_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Product need at least one tax" },
                    { "productNeedsUnits_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Product needs at least one unit." },
                    { "products_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Products" },
                    { "productsMovements_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Products Movements" },
                    { "profile_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Profile" },
                    { "quantity_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Quantity" },
                    { "quotes_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Quotes" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "rate_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Rate" },
                    { "receiptsReport_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Receipts report" },
                    { "receivedAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Received amount" },
                    { "receivedBy_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Received by" },
                    { "recordedRate_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Recorded rate" },
                    { "reference_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Reference" },
                    { "remember_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Remember me?" },
                    { "reports_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Reports" },
                    { "reportType_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Report type" },
                    { "required_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Required" },
                    { "resetPass_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Reset Password" },
                    { "resultState_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Result State" },
                    { "returnAlreadyApplied_error", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Return already applied" },
                    { "returnedAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Returned amount" },
                    { "reverse_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Reverse" },
                    { "role_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Roles" },
                    { "roles_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Roles" },
                    { "sales_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Sales" },
                    { "salesComission_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Sales comissions" },
                    { "salesReport_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Sales report" },
                    { "save_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Save" },
                    { "savedFormData_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "There is previous information saved for this form. Do you want to recover?" },
                    { "school_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "School" },
                    { "schools_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Schools" },
                    { "search_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Search" },
                    { "search_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Search" },
                    { "section_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Section" },
                    { "sector_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Sector" },
                    { "selectColumns_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Select columns" },
                    { "selectedDate_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Selected date" },
                    { "selectedlabTests_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Selected lab tests" },
                    { "seller_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Seller" },
                    { "SellerName_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Seller name" },
                    { "sellerRate_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Seller rate" },
                    { "sellers_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Sellers" },
                    { "sep_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "September" },
                    { "sequence_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Sequence" },
                    { "sequenceError_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Sequence Error." },
                    { "serie_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Serie" },
                    { "series_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Series" },
                    { "sessionTimeOut_error", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "La sesión ha expirado. Favor iniciar sesión nuevamente." },
                    { "specializedImages_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Specialized images" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "start_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Start" },
                    { "startDate_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Start date" },
                    { "state_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "State" },
                    { "subTotal_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Before taxes amount" },
                    { "success_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Operation successfully" },
                    { "supplier_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Supplier" },
                    { "supplierCosts_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Supplier costs" },
                    { "suppliers_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Suppliers" },
                    { "suppliersReturns_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Suppliers Returns" },
                    { "symptoms_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Symptoms" },
                    { "tax_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Tax" },
                    { "taxAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Tax amount" },
                    { "taxes_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Taxes" },
                    { "taxes_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Taxes" },
                    { "taxesAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Taxes amount" },
                    { "taxesReport_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Taxes Report" },
                    { "TaxId_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Tax ID" },
                    { "taxIsReq_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Tax is required" },
                    { "thisIsABaseProduct_error", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "This is a base product" },
                    { "thursday_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Thursday" },
                    { "time_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Time" },
                    { "totalAmount_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Total amount" },
                    { "totalBilled_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Total billed" },
                    { "totalCompanyDebt_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Total company debts" },
                    { "totalCustomersDebt_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Total customers debts" },
                    { "totalIncome_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Total income" },
                    { "totalInsuranceCoverage_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Total Coverage amount" },
                    { "totalOutcome_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Total outcome" },
                    { "totalOwed_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Total owed" },
                    { "totalPaid_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Total paid" },
                    { "trn_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "TRN" },
                    { "trnControl_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "TRN control" },
                    { "TRNControl_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "TRN Control" },
                    { "trnNotAvailable_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "TRN is not available." },
                    { "TRNType_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "TRN type" },
                    { "tusday_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Tusday" },
                    { "type_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Type" },
                    { "unit_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Unit" },
                    { "unitCost_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Unit costs" },
                    { "unitDoesntExist_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Unit doesnt exist" },
                    { "unitNotExist_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Unit does not exist." },
                    { "unitPrice_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Unit price" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "units_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Units" },
                    { "upload_btn", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Upload" },
                    { "user_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "User" },
                    { "user_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "User" },
                    { "userName_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Username" },
                    { "users_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Users" },
                    { "warehouse_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Warehouse" },
                    { "warehouse_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Warehouses" },
                    { "warehouseError_msg", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Warehouse does not exist." },
                    { "warehouseTransfers_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Warehouses Transfers" },
                    { "week_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Week of month" },
                    { "wendsday_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Wendsday" },
                    { "whenToTake_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "When to Take" },
                    { "yes_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Yes" },
                    { "zone_lbl", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Zone" },
                    { "zones_menu", "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Zones" },
                    { "0-0-1", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Noche" },
                    { "0-1-0", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Tarde" },
                    { "0-1-1", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Tarde - Noche" },
                    { "1-0-0", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Mañana" },
                    { "1-0-1", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Mañana - Noche" },
                    { "1-1-0", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Mañana - Tarde" },
                    { "1-1-1", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Mañana - Tarde - Noche" },
                    { "accountNumber_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Número de cuenta" },
                    { "accountsReceivable_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Cuentas por cobrar" },
                    { "accountState_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "estádo de cuentas" },
                    { "actions_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Acciones" },
                    { "add_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Agregar" },
                    { "additionalInfo_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Informacion adicional" },
                    { "addMedicine_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Agregar" },
                    { "address_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Dirección" },
                    { "addRole_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Agregar rol" },
                    { "addSector_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Agregar sector" },
                    { "administration_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Administración" },
                    { "age_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Edad" },
                    { "all_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Todos" },
                    { "AlreadyExist_error", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Ya existe un registro" },
                    { "alreadyNull_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Ya se encuentra anulado" },
                    { "amount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto" },
                    { "amountIsGreater_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto NC es mayor que el monto de la factura" },
                    { "appliedCreditNoteAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto NC aplicada" },
                    { "appointment_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Citas" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "appointmentAlreadyProcessed_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "La cita ya se encuentra procesada" },
                    { "appointmentExist_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Ya existe una cita para la fecha y hora seleccionada" },
                    { "AppointmentIsProcess_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "La cita ya se encuentra en proceso" },
                    { "appointmentNotValid_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Cita no válida" },
                    { "appointmentNulled_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "La cita está anulada" },
                    { "appointmentNumber_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "No. de cita" },
                    { "appointments_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Citas" },
                    { "appointmentType_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Tipo de cita" },
                    { "april_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Abril" },
                    { "areadyClosed_error", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Ya se encuentra cerrado. Operación no válida" },
                    { "areYouSure_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Está seguro?" },
                    { "assignedWarehouse_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Almacén asignado" },
                    { "attachments_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Adjuntos" },
                    { "attend_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Atender" },
                    { "attendedBy_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Atendido por" },
                    { "aug_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Agosto" },
                    { "auth_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Autorizaciones" },
                    { "balance_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Balance" },
                    { "banktransfer_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, null, null, null, null, "Transferencia bancaria" },
                    { "baseProducts_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Productos bases" },
                    { "beforeTaxAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto grabado" },
                    { "beforeTaxesAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto grabado" },
                    { "bill_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Facturar Cotización" },
                    { "billConfirm_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Está seguro de facturar la cotización?" },
                    { "billedBy_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Facturado por" },
                    { "billing_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Facturación" },
                    { "billingAmountLimit_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto límite de facturación" },
                    { "billingDate_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Fecha de facturación" },
                    { "billingStateB_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Facturado" },
                    { "billingStateC_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Convertido" },
                    { "billingStateD_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Entregado" },
                    { "billingStateE_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Expirado" },
                    { "billingStateF_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "En progreso" },
                    { "billingStateG_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Generado" },
                    { "billingStateI_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Inventario insuficiente" },
                    { "billingStateJ_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Proyectado" },
                    { "billingStateM_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Conduce anulado" },
                    { "billingStateN_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Anulado" },
                    { "billingStateO_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Generado sin inventario" },
                    { "billingStateP_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Pago aplicado" },
                    { "billingStateQ_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Cotizado" },
                    { "billingStateR_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Pago Completado" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "billingStateS_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Agendado" },
                    { "birthDate_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Fecha de nacimiento" },
                    { "birthDay_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Fecha de nacimiento" },
                    { "bloodType_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Tipo de sangre" },
                    { "branchOffice_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Sucursal" },
                    { "branchOffice_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Sucursales" },
                    { "cancel_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Cancelar" },
                    { "CannotDeleteExpense_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "No es posible eliminar el gasto" },
                    { "cannotDeleteTax_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "No se puede eliminar los impuestos del producto" },
                    { "cannotEraseUnit_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "No se puede eliminar las unidades del producto" },
                    { "cannotRemoveBaseProduct_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "No es posible eliminar el producto base" },
                    { "CannotUpdateExpense_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "No es posible actualizar el gasto" },
                    { "cannotUpdatePayment_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "No es posible actualizar el pago" },
                    { "CantCloseWithZero_error", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "No se puede realizar el cierre con valor 0" },
                    { "cardId_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Documento identidad" },
                    { "cardIdAlreadyExist_error", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Identificación ya existe." },
                    { "cash_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Efectivo" },
                    { "cashRegister_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Caja" },
                    { "cashRegister_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Cajas registradoras" },
                    { "cashRegisterManteinance_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Mantenimiento" },
                    { "cashRegisterOpeningHours_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Horas de apertura de caja" },
                    { "cashRegisterOpeningIsClosed_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "No se puede aperturar la caja. Ya se encuentra cerrada" },
                    { "cashROpenClose_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Apertura / Cierre" },
                    { "changePass_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Cambiar contraseña" },
                    { "check_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Cheque" },
                    { "CheckbookNumber_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Número de talonario" },
                    { "checkupNumber_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Secuencia de chequeo" },
                    { "closeCashRegister_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Cerrar caja" },
                    { "closing_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Cierre" },
                    { "closureAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto de cierre" },
                    { "closureDate_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Fecha de cierre" },
                    { "code_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Código" },
                    { "comissionAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto comisiones" },
                    { "comissionByProduct_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Comisiones por producto" },
                    { "comissionRate_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Porcentaje de comisión" },
                    { "commissions_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Comisiones" },
                    { "companyDebt_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto deuda de la compañia" },
                    { "CompanyOwedAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto adeudado compañia" },
                    { "consultation_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Consulta" },
                    { "consultation_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Consultas" },
                    { "consultations_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Consultas" },
                    { "consultationType_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Tipo de consulta" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "contact1_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Contacto 1" },
                    { "contact2_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Contacto 2" },
                    { "contact3_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Contacto 3" },
                    { "contacts_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Contactos" },
                    { "core_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Configuraciones" },
                    { "cost_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Costo" },
                    { "coverageAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto Cobertura" },
                    { "createLead_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Crear conduce" },
                    { "Credit_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Crédito" },
                    { "creditAmountLimit_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto límite de crédito" },
                    { "creditCard_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Tarjeta de crédito" },
                    { "creditLimitReached_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Límite de credito alcanzado. No se puede continuar" },
                    { "creditNote_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Nota de crédito" },
                    { "creditNoteAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Moto de Nota de crédito" },
                    { "creditNoteApplied_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "NC ya está aplicada" },
                    { "creditNoteInfo_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Aplicar Nota de Crédito" },
                    { "creditNoteNotExist_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "NC no existe" },
                    { "credits_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Créditos" },
                    { "currencies_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monedas" },
                    { "currency_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Moneda" },
                    { "CurrencyCode_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Moneda" },
                    { "CurrencyId_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "ID de moneda" },
                    { "CurrencyName_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Moneda" },
                    { "CurrentBalance_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Balance actual" },
                    { "customer_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Cliente" },
                    { "customerDebt_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto deuda de cliente" },
                    { "CustomerName_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Nombre de cliente" },
                    { "customerPayment_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Pagos" },
                    { "customerReturns_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Devolución de clientes" },
                    { "customers_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Clientes" },
                    { "customersList_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Listado de clientes" },
                    { "CustomersOwedAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto adeudado clientes" },
                    { "customersReturns_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Devoluciones de clientes" },
                    { "dashboard_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Tablero" },
                    { "date_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Fecha" },
                    { "day_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Día de la semana" },
                    { "daysAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Cantidad de días" },
                    { "DaysCount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Cantidad de días" },
                    { "Debit_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Débito" },
                    { "debits_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Débitos" },
                    { "debtsToPay_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Deudas a pagar" },
                    { "dec_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Diciember" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "defWarehouseNotExit_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Almacen de defectuosos no existe. Favor ingresar uno con el código 'DEF'" },
                    { "delete_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Borrar" },
                    { "deleteConfirm_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Está seguro que desea borrar?" },
                    { "deliverdBy_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Entregado por" },
                    { "deliverLead_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Marcar como entregado" },
                    { "description_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Descripción" },
                    { "destinyBranchOffice_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Sucursal destino" },
                    { "destinyWarehouse_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Almacén destino" },
                    { "details_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Detalles" },
                    { "details_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Detalles" },
                    { "detailsRequired_error", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Detalles son obligatorios" },
                    { "diagnoses_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Diagnostico" },
                    { "differentCurrency_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Las monedas son distintas. Solo puede aplicar pagos de la misma moneda" },
                    { "discountAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto descuento" },
                    { "discountRate_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Porcentaje descuento" },
                    { "dispatchInventory_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Despachar inventario" },
                    { "doctor_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Doctor" },
                    { "doctorRequired_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "El doctor es un campo obligatorio. Favor seleccionar uno" },
                    { "documentDoesntExist_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Documento no existe" },
                    { "documentNumber_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Número documento" },
                    { "edit_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Editar" },
                    { "editAppointment_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Editar Cita" },
                    { "email_input", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Email" },
                    { "email_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Email" },
                    { "emptyAppointment_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "La cita no puede estár vacía" },
                    { "emptyInvoice_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "La factura no tiene detalles" },
                    { "emptyStomach_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Estómago vacio" },
                    { "endDate_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Fecha final" },
                    { "equivalence_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Equivalencia" },
                    { "error_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Error: No se pudo completar la operación." },
                    { "errorDictionary_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Error de diccionario" },
                    { "especializedImages_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Imágenes especializadas" },
                    { "exchangeRate_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Tasa de cambio" },
                    { "ExchangeRateAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto de tasa" },
                    { "existence_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Existencia" },
                    { "exo_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Exonerado" },
                    { "expensePayments_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Pagos de gastos" },
                    { "ExpenseReference_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Referencia de gasto" },
                    { "expenses_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Gastos" },
                    { "expensesPayment_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Pagos" },
                    { "expensesRegister_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Registrar gastos" },
                    { "export_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Exportar" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "feb_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Febrero" },
                    { "female_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Femenino" },
                    { "fieldsRequired_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Campos obligatorios antes de continuar" },
                    { "fixedComission_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Comisión fija" },
                    { "forgotPass_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Olvidó contraseña?" },
                    { "friday_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Viernes" },
                    { "gender_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Género" },
                    { "GivenAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto aplicado" },
                    { "history_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Historial Médico" },
                    { "hospital_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Clínica" },
                    { "hospitals_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Clínicas" },
                    { "id_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Id" },
                    { "incomeAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto recibidos" },
                    { "incomeReceipts_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Recibos de ingreso" },
                    { "insurance_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Aseguradora" },
                    { "insuranceApprovalCode_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Código de aprobación aseguradora" },
                    { "insuranceCard_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Carnet de asegurado" },
                    { "insuranceCardId_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Carnet de asegurado" },
                    { "insuranceCoverage_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Coberturas aseguradoras" },
                    { "insuranceCoverageAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto de Cobertura" },
                    { "insuranceCoveragesReport_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Reporte de Coberturas" },
                    { "insurancePlan_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Plan" },
                    { "insurances_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Aseguradoras" },
                    { "invalidConsultationAppointment_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Cita no válida" },
                    { "invalidInvoice_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Factura inválida" },
                    { "invalidInvoicestáteReturn_error", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "estádo de factura no es válido" },
                    { "inventory_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Inventario" },
                    { "inventoryDoesntExist_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "El inventario no es válido" },
                    { "inventoryIn_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Entradas de inventario" },
                    { "InvoiceCurrency_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Moneda de factura" },
                    { "invoiceDoesNotExist_error", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Número de factura no exixste" },
                    { "invoiceDueDays_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Vencimiento de factura (días)" },
                    { "InvoiceId_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "ID factura" },
                    { "invoiceInfo_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Información Básica" },
                    { "invoiceLeads_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Conduces de factura" },
                    { "invoiceNumber_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Número de factura" },
                    { "invoiceNumberRequired_error", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Número de factura es requerido" },
                    { "invoicePaid_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "La factura ya se encuentra pagada." },
                    { "invoices_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Facturas" },
                    { "isActive_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Activo?" },
                    { "isCompositeProduct_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Producto compuesto" },
                    { "isDefective_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Defectuoso" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "isLocalCurrency_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Moneda local" },
                    { "isPrimary_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Principal" },
                    { "isService_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Es servicio" },
                    { "jan_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Enero" },
                    { "jul_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Julio" },
                    { "jun_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Junio" },
                    { "laboratory_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Laboratorio" },
                    { "labTests_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Pruebas de laboratorios" },
                    { "language_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Lenguage" },
                    { "lastName_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Apellidos" },
                    { "leadDueDays_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Dias de vencimiento" },
                    { "leadNumber_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Número de conduce" },
                    { "login_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Iniciar Sesión" },
                    { "logOut_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Salir" },
                    { "logOut_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Salir" },
                    { "male_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Masculino" },
                    { "march_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Marzo" },
                    { "markAsDeliveredConfirm_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Está seguro que desea marcar el conduce como entregado?" },
                    { "maxClosureDate_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Fecha máxima de cierre" },
                    { "may_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Mayo" },
                    { "medicalConsultation_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Consulta médica" },
                    { "medicalSpecialities_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Especialidades médicas" },
                    { "medicalSpeciality_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Especialidad médica" },
                    { "medicalSpecialty_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Especialidad médica" },
                    { "medication_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "medicamento" },
                    { "medications_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "medicación" },
                    { "medicine_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Medicina" },
                    { "medicineWarehouse_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Almacenes medicinas" },
                    { "menu_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Menú escolar" },
                    { "mobile_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Teléfono celular" },
                    { "monday_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Lunes" },
                    { "month_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Mes" },
                    { "movements_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Movimientos" },
                    { "movementType_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Tipo de movimiento" },
                    { "name_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Nombre" },
                    { "NameAndCode_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Nombre y código" },
                    { "nameRequired_error", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Nombre es requerido" },
                    { "newItems_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Agregar Articulos" },
                    { "no_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "No" },
                    { "noCoverage_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Sin cobertura" },
                    { "notExistingClass_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "No se puede procesar este producto/servicio. La clase no existe." },
                    { "notFound_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "No encontrado" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "notValid_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Operación no válida" },
                    { "nov_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Noviembre" },
                    { "nrc_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "NRC" },
                    { "null_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Anular" },
                    { "NumberOfDays_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Cantidad de días" },
                    { "numericControl_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Control numérico" },
                    { "observations_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Observaciones" },
                    { "oct_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Octubre" },
                    { "ok_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "OK" },
                    { "ok_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Operación completada con éxito." },
                    { "onlyOneConsultationPerAppointment_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Solo se permite una consulta médica por cita" },
                    { "opening_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Apertura" },
                    { "openingAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto de apertura" },
                    { "openingDate_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Fecha de apertura" },
                    { "operations_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Operaciones" },
                    { "originBranchOffice_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Sucursal origen" },
                    { "originQuantity_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Cantidad de origen" },
                    { "originWarehouse_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Almacén origen" },
                    { "outcomeAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto entregrados" },
                    { "outOfStock_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Producto agotado" },
                    { "OutstandingAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto pendiente" },
                    { "owedAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto adeudado" },
                    { "owedAmountOutdated_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto adeudado está desactualizado. Favor ingresar nuevamente." },
                    { "paidAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto pagado" },
                    { "parentUnitDoesntExist_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Unidad padre no existe." },
                    { "password_input", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Contraseña" },
                    { "password_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Contraseña" },
                    { "patient_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Paciente" },
                    { "patientAppointments_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Citas Activas del paciente" },
                    { "patientCheckups_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Chequeo de paciente" },
                    { "patientPaymentAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto a pagar paciente" },
                    { "patients_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Pacientes" },
                    { "pay_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Pagar" },
                    { "paymentNotValid_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "El pago no es válido." },
                    { "paymentsComission_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Comisiones por cobro" },
                    { "paymentType_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Tipo de pago" },
                    { "permissions_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Permisos" },
                    { "phone_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Teléfono" },
                    { "phoneNumber_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Teléfono" },
                    { "plans_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Planes" },
                    { "pleaseSelect_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Favor seleccionar" },
                    { "position_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Posición" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "positiveBalance_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Balance a favor" },
                    { "prescriptionTypes_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Tipos de prescripciones médicas" },
                    { "price_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Precio" },
                    { "Price2_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Precio 2" },
                    { "price3_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Precio 3" },
                    { "pricesList_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Listado de precios" },
                    { "primaryUnitRequired_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Es obligatorio una unidad principal. Favor elegir una." },
                    { "print_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Imprimir" },
                    { "print_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Imprimir" },
                    { "product_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Producto" },
                    { "productCost_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Costo de producto" },
                    { "productNeedsPrimaryUnit_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Es obligatorio una unidad principal. Favor elegir una." },
                    { "productNeedsTaxes_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "El producto necesita por lo menos un impuesto" },
                    { "productNeedsUnits_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Es obligatorio una unidad principal. Favor elegir una." },
                    { "products_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Producto" },
                    { "productsMovements_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Movimientos de productos" },
                    { "profile_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Perfil" },
                    { "quantity_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Cantidad" },
                    { "quotes_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Conduces" },
                    { "rate_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Porcentaje" },
                    { "receiptsReport_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Reporte recibos ingreso" },
                    { "receivedAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto recibido" },
                    { "receivedBy_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Recibido por" },
                    { "recordedRate_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Tasa registrada" },
                    { "reference_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Referencia" },
                    { "remember_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Recordarme?" },
                    { "reports_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Reportes" },
                    { "reportType_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Tipo de reporte" },
                    { "required_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Requerido" },
                    { "resetPass_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Reiniciar contraseña" },
                    { "resultState_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "estádo resultado" },
                    { "returnAlreadyApplied_error", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "La devolución ya se encuentra aplicada" },
                    { "returnedAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto devuelto" },
                    { "reverse_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Reversar" },
                    { "role_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Roles" },
                    { "roles_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Roles" },
                    { "sales_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Ventas" },
                    { "salesComission_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Comisiones por ventas" },
                    { "salesReport_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Reporte de ventas" },
                    { "save_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Guardar" },
                    { "savedFormData_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Existe información guardada en este formulario. Desea recuperarla?" },
                    { "school_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Escuela " }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "schools_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Escuelas" },
                    { "search_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Buscar" },
                    { "search_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Buscar" },
                    { "section_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Sección" },
                    { "sector_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Sector" },
                    { "selectColumns_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Seleccionar columnas" },
                    { "selectedDate_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Fecha seleccionada" },
                    { "selectedlabTests_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Pruebas de laboratorios seleccionadas" },
                    { "seller_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Vendedor" },
                    { "SellerName_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Nombre de vendedor" },
                    { "sellerRate_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Porcentaje de comisión" },
                    { "sellers_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Vendedores" },
                    { "sep_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "septiembre" },
                    { "sequence_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Sequencia" },
                    { "sequenceError_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Error de secuencias." },
                    { "serie_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Serie" },
                    { "series_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Serie" },
                    { "sessionTimeOut_error", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "La sesión ha expirado. Favor iniciar sesión nuevamente." },
                    { "specializedImages_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Imágenes especializadas" },
                    { "start_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Inicio" },
                    { "startDate_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Fecha inicio" },
                    { "state_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "estádo" },
                    { "subTotal_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto grabado" },
                    { "success_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "La operación fue un exito" },
                    { "supplier_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Suplidor" },
                    { "supplierCosts_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Costo por suplidor" },
                    { "suppliers_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Suplidores" },
                    { "suppliersReturns_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Devoluciones a suplidor" },
                    { "symptoms_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Sintomas" },
                    { "tax_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Impuesto" },
                    { "taxAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto impuesto" },
                    { "taxes_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Impuestos" },
                    { "taxes_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Impuestos" },
                    { "taxesAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto impuestos" },
                    { "taxesReport_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Reporte de impuestos" },
                    { "TaxId_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "ID impuesto" },
                    { "taxIsReq_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Impuesto es requerido." },
                    { "thisIsABaseProduct_error", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Este producto es base de otro." },
                    { "thursday_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Jueves" },
                    { "time_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Hora" },
                    { "totalAmount_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto total" },
                    { "totalBilled_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Total facturado" }
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "Key", "LanguageCode", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "Value" },
                values: new object[,]
                {
                    { "totalCompanyDebt_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto total deuda de la compañia" },
                    { "totalCustomersDebt_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto total deuda de clientes" },
                    { "totalIncome_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto total de entradas" },
                    { "totalInsuranceCoverage_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto total de Cobertura" },
                    { "totalOutcome_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Monto total de salidas" },
                    { "totalOwed_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Total adeudado" },
                    { "totalPaid_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Total pagado" },
                    { "trn_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "NCF" },
                    { "trnControl_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Control NCF" },
                    { "TRNControl_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Control NCF" },
                    { "trnNotAvailable_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "NCFs insuficientes" },
                    { "TRNType_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Tipo NCF" },
                    { "tusday_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Martes" },
                    { "type_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Tipo" },
                    { "unit_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Unidad" },
                    { "unitCost_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Costo por unidad" },
                    { "unitDoesntExist_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "La unidad no existe" },
                    { "unitNotExist_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "La unidad no existe" },
                    { "unitPrice_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Precio unitario" },
                    { "units_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Unidades" },
                    { "upload_btn", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Cargar" },
                    { "user_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Usuario" },
                    { "user_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Usuario" },
                    { "userName_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Nombre de usuario" },
                    { "users_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Usuarios" },
                    { "warehouse_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Almacén" },
                    { "warehouse_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Almacenes" },
                    { "warehouseError_msg", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Almacén no existe." },
                    { "warehouseTransfers_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Transferencias entre almacenes" },
                    { "week_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Semana" },
                    { "wendsday_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Miércoles" },
                    { "whenToTake_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Cuando tomar?" },
                    { "yes_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Si" },
                    { "zone_lbl", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Zona" },
                    { "zones_menu", "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, null, null, null, null, "Zonas" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "TranslationData" },
                values: new object[,]
                {
                    { 1L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Config - Sucursales\"}]}" },
                    { 2L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Config - Almacenes\"}]}" },
                    { 3L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Config - Monedas\"}]}" },
                    { 4L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Config - suplidores\"}]}" },
                    { 5L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Config - Impuestos\"}]}" },
                    { 6L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Config - Unidades\"}]}" },
                    { 7L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Config- Control NCF\"}]}" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "TenantId", "TranslationData" },
                values: new object[,]
                {
                    { 8L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Config - Zonas\"}]}" },
                    { 9L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Config - Vendedores\"}]}" },
                    { 10L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Config - Clientes\"}]}" },
                    { 11L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Config - Productos\"}]}" },
                    { 12L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Config - Escuelas\"}]}" },
                    { 13L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Config - Escuelas\"}]}" },
                    { 14L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Config - Menu escuelas\"}]}" },
                    { 15L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Cajas Reg - Mantenimiento\"}]}" },
                    { 16L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Cajas Reg - Apert/Cierre\"}]}" },
                    { 17L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Facturacion - Conduces admin\"}]}" },
                    { 18L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Facturacion - Facturas admin\"}]}" },
                    { 19L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Facturacion - Pagos admin\"}]}" },
                    { 20L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Gastos - Registros admin\"}]}" },
                    { 21L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Gastos - Pagos admin\"}]}" },
                    { 22L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Facturacion - Conduces\"}]}" },
                    { 23L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Facturacion - Facturas\"}]}" },
                    { 24L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Facturacion - pagos\"}]}" },
                    { 25L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Gastos - Registros\"}]}" },
                    { 26L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Gastos - Pagos\"}]}" },
                    { 27L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Movimientos - Entradas\"}]}" },
                    { 28L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Movimientos - Transferencias\"}]}" },
                    { 29L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Movimientos - Devoluciones suplidor\"}]}" },
                    { 30L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Ventas\"}],\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Ventas\"}]}" },
                    { 31L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Roles - Cuentas por cobrar\"}],\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Cuentas por cobrar\"}]}" },
                    { 32L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Recibos ingreso\"}],\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Recibos ingreso\"}]}" },
                    { 33L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Reporte - Comisiones\"}],\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Reporte - Comisiones\"}]}" },
                    { 34L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Inventario\"}],\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Inventario\"}]}" },
                    { 35L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Movimientos Productos\"}],\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Movimientos Productos\"}]}" },
                    { 36L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Cuentas por pagar\"}],\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Cuentas por pagar\"}]}" },
                    { 37L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Reporte - Listado precios\"}],\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Reporte - Listado precios\"}]}" },
                    { 38L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Listado clientes\"}],\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Listado clientes\"}]}" },
                    { 39L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Estado cuentas\"}],\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Estado cuentas\"}]}" },
                    { 40L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Estado resultado\"}],\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Estado resultado\"}]}" },
                    { 41L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "{\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Impuestos\"}],\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Reportes - Impuestos\"}]}" }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 1L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 1L, null },
                    { 2L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 1L, null },
                    { 3L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 1L, null },
                    { 4L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 1L, null },
                    { 5L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 1L, null },
                    { 6L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 1L, null },
                    { 7L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 1L, null },
                    { 8L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 1L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 9L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 1L, null },
                    { 10L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 1L, null },
                    { 11L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 1L, null },
                    { 12L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 1L, null },
                    { 13L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 1L, null },
                    { 14L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 1L, null },
                    { 15L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 1L, null },
                    { 16L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 1L, null },
                    { 17L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 1L, null },
                    { 18L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 1L, null },
                    { 19L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 1L, null },
                    { 21L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 2L, null },
                    { 22L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 2L, null },
                    { 23L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 2L, null },
                    { 24L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 2L, null },
                    { 25L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 2L, null },
                    { 26L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 2L, null },
                    { 27L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 2L, null },
                    { 28L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 2L, null },
                    { 29L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 2L, null },
                    { 30L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 2L, null },
                    { 31L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 2L, null },
                    { 32L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 2L, null },
                    { 33L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 2L, null },
                    { 34L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 2L, null },
                    { 35L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 2L, null },
                    { 36L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 2L, null },
                    { 37L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 2L, null },
                    { 38L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 2L, null },
                    { 39L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 2L, null },
                    { 41L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 3L, null },
                    { 42L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 3L, null },
                    { 43L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 3L, null },
                    { 44L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 3L, null },
                    { 45L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 3L, null },
                    { 46L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 3L, null },
                    { 47L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 3L, null },
                    { 48L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 3L, null },
                    { 49L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 3L, null },
                    { 50L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 3L, null },
                    { 51L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 3L, null },
                    { 52L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 3L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 53L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 3L, null },
                    { 54L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 3L, null },
                    { 55L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 3L, null },
                    { 56L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 3L, null },
                    { 57L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 3L, null },
                    { 58L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 3L, null },
                    { 59L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 3L, null },
                    { 61L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 4L, null },
                    { 62L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 4L, null },
                    { 63L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 4L, null },
                    { 64L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 4L, null },
                    { 65L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 4L, null },
                    { 66L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 4L, null },
                    { 67L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 4L, null },
                    { 68L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 4L, null },
                    { 69L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 4L, null },
                    { 70L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 4L, null },
                    { 71L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 4L, null },
                    { 72L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 4L, null },
                    { 73L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 4L, null },
                    { 74L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 4L, null },
                    { 75L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 4L, null },
                    { 76L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 4L, null },
                    { 77L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 4L, null },
                    { 78L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 4L, null },
                    { 79L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 4L, null },
                    { 81L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 5L, null },
                    { 82L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 5L, null },
                    { 83L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 5L, null },
                    { 84L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 5L, null },
                    { 85L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 5L, null },
                    { 86L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 5L, null },
                    { 87L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 5L, null },
                    { 88L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 5L, null },
                    { 89L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 5L, null },
                    { 90L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 5L, null },
                    { 91L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 5L, null },
                    { 92L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 5L, null },
                    { 93L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 5L, null },
                    { 94L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 5L, null },
                    { 95L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 5L, null },
                    { 96L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 5L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 97L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 5L, null },
                    { 98L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 5L, null },
                    { 99L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 5L, null },
                    { 101L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 6L, null },
                    { 102L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 6L, null },
                    { 103L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 6L, null },
                    { 104L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 6L, null },
                    { 105L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 6L, null },
                    { 106L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 6L, null },
                    { 107L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 6L, null },
                    { 108L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 6L, null },
                    { 109L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 6L, null },
                    { 110L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 6L, null },
                    { 111L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 6L, null },
                    { 112L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 6L, null },
                    { 113L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 6L, null },
                    { 114L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 6L, null },
                    { 115L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 6L, null },
                    { 116L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 6L, null },
                    { 117L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 6L, null },
                    { 118L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 6L, null },
                    { 119L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 6L, null },
                    { 121L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 7L, null },
                    { 122L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 7L, null },
                    { 123L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 7L, null },
                    { 124L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 7L, null },
                    { 125L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 7L, null },
                    { 126L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 7L, null },
                    { 127L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 7L, null },
                    { 128L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 7L, null },
                    { 129L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 7L, null },
                    { 130L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 7L, null },
                    { 131L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 7L, null },
                    { 132L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 7L, null },
                    { 133L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 7L, null },
                    { 134L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 7L, null },
                    { 135L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 7L, null },
                    { 136L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 7L, null },
                    { 137L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 7L, null },
                    { 138L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 7L, null },
                    { 139L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 7L, null },
                    { 141L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 8L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 142L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 8L, null },
                    { 143L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 8L, null },
                    { 144L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 8L, null },
                    { 145L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 8L, null },
                    { 146L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 8L, null },
                    { 147L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 8L, null },
                    { 148L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 8L, null },
                    { 149L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 8L, null },
                    { 150L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 8L, null },
                    { 151L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 8L, null },
                    { 152L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 8L, null },
                    { 153L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 8L, null },
                    { 154L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 8L, null },
                    { 155L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 8L, null },
                    { 156L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 8L, null },
                    { 157L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 8L, null },
                    { 158L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 8L, null },
                    { 159L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 8L, null },
                    { 161L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 9L, null },
                    { 162L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 9L, null },
                    { 163L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 9L, null },
                    { 164L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 9L, null },
                    { 165L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 9L, null },
                    { 166L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 9L, null },
                    { 167L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 9L, null },
                    { 168L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 9L, null },
                    { 169L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 9L, null },
                    { 170L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 9L, null },
                    { 171L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 9L, null },
                    { 172L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 9L, null },
                    { 173L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 9L, null },
                    { 174L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 9L, null },
                    { 175L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 9L, null },
                    { 176L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 9L, null },
                    { 177L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 9L, null },
                    { 178L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 9L, null },
                    { 179L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 9L, null },
                    { 181L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 10L, null },
                    { 182L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 10L, null },
                    { 183L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 10L, null },
                    { 184L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 10L, null },
                    { 185L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 10L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 186L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 10L, null },
                    { 187L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 10L, null },
                    { 188L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 10L, null },
                    { 189L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 10L, null },
                    { 190L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 10L, null },
                    { 191L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 10L, null },
                    { 192L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 10L, null },
                    { 193L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 10L, null },
                    { 194L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 10L, null },
                    { 195L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 10L, null },
                    { 196L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 10L, null },
                    { 197L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 10L, null },
                    { 198L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 10L, null },
                    { 199L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 10L, null },
                    { 201L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 11L, null },
                    { 202L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 11L, null },
                    { 203L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 11L, null },
                    { 204L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 11L, null },
                    { 205L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 11L, null },
                    { 206L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 11L, null },
                    { 207L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 11L, null },
                    { 208L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 11L, null },
                    { 209L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 11L, null },
                    { 210L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 11L, null },
                    { 211L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 11L, null },
                    { 212L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 11L, null },
                    { 213L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 11L, null },
                    { 214L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 11L, null },
                    { 215L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 11L, null },
                    { 216L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 11L, null },
                    { 217L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 11L, null },
                    { 218L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 11L, null },
                    { 219L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 11L, null },
                    { 221L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 12L, null },
                    { 222L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 12L, null },
                    { 223L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 12L, null },
                    { 224L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 12L, null },
                    { 225L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 12L, null },
                    { 226L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 12L, null },
                    { 227L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 12L, null },
                    { 228L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 12L, null },
                    { 229L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 12L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 230L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 12L, null },
                    { 231L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 12L, null },
                    { 232L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 12L, null },
                    { 233L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 12L, null },
                    { 234L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 12L, null },
                    { 235L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 12L, null },
                    { 236L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 12L, null },
                    { 237L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 12L, null },
                    { 238L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 12L, null },
                    { 239L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 12L, null },
                    { 241L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 13L, null },
                    { 242L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 13L, null },
                    { 243L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 13L, null },
                    { 244L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 13L, null },
                    { 245L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 13L, null },
                    { 246L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 13L, null },
                    { 247L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 13L, null },
                    { 248L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 13L, null },
                    { 249L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 13L, null },
                    { 250L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 13L, null },
                    { 251L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 13L, null },
                    { 252L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 13L, null },
                    { 253L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 13L, null },
                    { 254L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 13L, null },
                    { 255L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 13L, null },
                    { 256L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 13L, null },
                    { 257L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 13L, null },
                    { 258L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 13L, null },
                    { 259L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 13L, null },
                    { 261L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 14L, null },
                    { 262L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 14L, null },
                    { 263L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 14L, null },
                    { 264L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 14L, null },
                    { 265L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 14L, null },
                    { 266L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 14L, null },
                    { 267L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 14L, null },
                    { 268L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 14L, null },
                    { 269L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 14L, null },
                    { 270L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 14L, null },
                    { 271L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 14L, null },
                    { 272L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 14L, null },
                    { 273L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 14L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 274L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 14L, null },
                    { 275L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 14L, null },
                    { 276L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 14L, null },
                    { 277L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 14L, null },
                    { 278L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 14L, null },
                    { 279L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 14L, null },
                    { 281L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 15L, null },
                    { 282L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 15L, null },
                    { 283L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 15L, null },
                    { 284L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 15L, null },
                    { 285L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 15L, null },
                    { 286L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 15L, null },
                    { 287L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 15L, null },
                    { 288L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 15L, null },
                    { 289L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 15L, null },
                    { 290L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 15L, null },
                    { 291L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 15L, null },
                    { 292L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 15L, null },
                    { 293L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 15L, null },
                    { 294L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 15L, null },
                    { 295L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 15L, null },
                    { 296L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 15L, null },
                    { 297L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 15L, null },
                    { 298L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 15L, null },
                    { 299L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 15L, null },
                    { 301L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 16L, null },
                    { 302L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 16L, null },
                    { 303L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 16L, null },
                    { 304L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 16L, null },
                    { 305L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 16L, null },
                    { 306L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 16L, null },
                    { 307L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 16L, null },
                    { 308L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 16L, null },
                    { 309L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 16L, null },
                    { 310L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 16L, null },
                    { 311L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 16L, null },
                    { 312L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 16L, null },
                    { 313L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 16L, null },
                    { 314L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 16L, null },
                    { 315L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 16L, null },
                    { 316L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 16L, null },
                    { 317L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 16L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 318L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 16L, null },
                    { 319L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 16L, null },
                    { 321L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 17L, null },
                    { 322L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 17L, null },
                    { 323L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 17L, null },
                    { 324L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 17L, null },
                    { 325L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 17L, null },
                    { 326L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 17L, null },
                    { 327L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 17L, null },
                    { 328L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 17L, null },
                    { 329L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 17L, null },
                    { 330L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 17L, null },
                    { 331L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 17L, null },
                    { 332L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 17L, null },
                    { 333L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 17L, null },
                    { 334L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 17L, null },
                    { 335L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 17L, null },
                    { 336L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 17L, null },
                    { 337L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 17L, null },
                    { 338L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 17L, null },
                    { 339L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 17L, null },
                    { 341L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 18L, null },
                    { 342L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 18L, null },
                    { 343L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 18L, null },
                    { 344L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 18L, null },
                    { 345L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 18L, null },
                    { 346L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 18L, null },
                    { 347L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 18L, null },
                    { 348L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 18L, null },
                    { 349L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 18L, null },
                    { 350L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 18L, null },
                    { 351L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 18L, null },
                    { 352L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 18L, null },
                    { 353L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 18L, null },
                    { 354L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 18L, null },
                    { 355L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 18L, null },
                    { 356L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 18L, null },
                    { 357L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 18L, null },
                    { 358L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 18L, null },
                    { 359L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 18L, null },
                    { 361L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 19L, null },
                    { 362L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 19L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 363L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 19L, null },
                    { 364L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 19L, null },
                    { 365L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 19L, null },
                    { 366L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 19L, null },
                    { 367L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 19L, null },
                    { 368L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 19L, null },
                    { 369L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 19L, null },
                    { 370L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 19L, null },
                    { 371L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 19L, null },
                    { 372L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 19L, null },
                    { 373L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 19L, null },
                    { 374L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 19L, null },
                    { 375L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 19L, null },
                    { 376L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 19L, null },
                    { 377L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 19L, null },
                    { 378L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 19L, null },
                    { 379L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 19L, null },
                    { 381L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 20L, null },
                    { 382L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 20L, null },
                    { 383L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 20L, null },
                    { 384L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 20L, null },
                    { 385L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 20L, null },
                    { 386L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 20L, null },
                    { 387L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 20L, null },
                    { 388L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 20L, null },
                    { 389L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 20L, null },
                    { 390L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 20L, null },
                    { 391L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 20L, null },
                    { 392L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 20L, null },
                    { 393L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 20L, null },
                    { 394L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 20L, null },
                    { 395L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 20L, null },
                    { 396L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 20L, null },
                    { 397L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 20L, null },
                    { 398L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 20L, null },
                    { 399L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 20L, null },
                    { 401L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 21L, null },
                    { 402L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 21L, null },
                    { 403L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 21L, null },
                    { 404L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 21L, null },
                    { 405L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 21L, null },
                    { 406L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 21L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 407L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 21L, null },
                    { 408L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 21L, null },
                    { 409L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 21L, null },
                    { 410L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 21L, null },
                    { 411L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 21L, null },
                    { 412L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 21L, null },
                    { 413L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 21L, null },
                    { 414L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 21L, null },
                    { 415L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 21L, null },
                    { 416L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 21L, null },
                    { 417L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 21L, null },
                    { 418L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 21L, null },
                    { 419L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 21L, null },
                    { 421L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 22L, null },
                    { 422L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 22L, null },
                    { 423L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 22L, null },
                    { 424L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 22L, null },
                    { 425L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 22L, null },
                    { 426L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 22L, null },
                    { 427L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 22L, null },
                    { 428L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 22L, null },
                    { 429L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 22L, null },
                    { 430L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 22L, null },
                    { 431L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 22L, null },
                    { 432L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 22L, null },
                    { 433L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 22L, null },
                    { 434L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 22L, null },
                    { 435L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 22L, null },
                    { 436L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 22L, null },
                    { 437L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 22L, null },
                    { 438L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 22L, null },
                    { 439L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 22L, null },
                    { 441L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 23L, null },
                    { 442L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 23L, null },
                    { 443L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 23L, null },
                    { 444L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 23L, null },
                    { 445L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 23L, null },
                    { 446L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 23L, null },
                    { 447L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 23L, null },
                    { 448L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 23L, null },
                    { 449L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 23L, null },
                    { 450L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 23L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 451L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 23L, null },
                    { 452L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 23L, null },
                    { 453L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 23L, null },
                    { 454L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 23L, null },
                    { 455L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 23L, null },
                    { 456L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 23L, null },
                    { 457L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 23L, null },
                    { 458L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 23L, null },
                    { 459L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 23L, null },
                    { 461L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 24L, null },
                    { 462L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 24L, null },
                    { 463L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 24L, null },
                    { 464L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 24L, null },
                    { 465L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 24L, null },
                    { 466L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 24L, null },
                    { 467L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 24L, null },
                    { 468L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 24L, null },
                    { 469L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 24L, null },
                    { 470L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 24L, null },
                    { 471L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 24L, null },
                    { 472L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 24L, null },
                    { 473L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 24L, null },
                    { 474L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 24L, null },
                    { 475L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 24L, null },
                    { 476L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 24L, null },
                    { 477L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 24L, null },
                    { 478L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 24L, null },
                    { 479L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 24L, null },
                    { 481L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 25L, null },
                    { 482L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 25L, null },
                    { 483L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 25L, null },
                    { 484L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 25L, null },
                    { 485L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 25L, null },
                    { 486L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 25L, null },
                    { 487L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 25L, null },
                    { 488L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 25L, null },
                    { 489L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 25L, null },
                    { 490L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 25L, null },
                    { 491L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 25L, null },
                    { 492L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 25L, null },
                    { 493L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 25L, null },
                    { 494L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 25L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 495L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 25L, null },
                    { 496L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 25L, null },
                    { 497L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 25L, null },
                    { 498L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 25L, null },
                    { 499L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 25L, null },
                    { 501L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 26L, null },
                    { 502L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 26L, null },
                    { 503L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 26L, null },
                    { 504L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 26L, null },
                    { 505L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 26L, null },
                    { 506L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 26L, null },
                    { 507L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 26L, null },
                    { 508L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 26L, null },
                    { 509L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 26L, null },
                    { 510L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 26L, null },
                    { 511L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 26L, null },
                    { 512L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 26L, null },
                    { 513L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 26L, null },
                    { 514L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 26L, null },
                    { 515L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 26L, null },
                    { 516L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 26L, null },
                    { 517L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 26L, null },
                    { 518L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 26L, null },
                    { 519L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 26L, null },
                    { 521L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 27L, null },
                    { 522L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 27L, null },
                    { 523L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 27L, null },
                    { 524L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 27L, null },
                    { 525L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 27L, null },
                    { 526L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 27L, null },
                    { 527L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 27L, null },
                    { 528L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 27L, null },
                    { 529L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 27L, null },
                    { 530L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 27L, null },
                    { 531L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 27L, null },
                    { 532L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 27L, null },
                    { 533L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 27L, null },
                    { 534L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 27L, null },
                    { 535L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 27L, null },
                    { 536L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 27L, null },
                    { 537L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 27L, null },
                    { 538L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 27L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 539L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 27L, null },
                    { 541L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 28L, null },
                    { 542L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 28L, null },
                    { 543L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 28L, null },
                    { 544L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 28L, null },
                    { 545L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 28L, null },
                    { 546L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 28L, null },
                    { 547L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 28L, null },
                    { 548L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 28L, null },
                    { 549L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 28L, null },
                    { 550L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 28L, null },
                    { 551L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 28L, null },
                    { 552L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 28L, null },
                    { 553L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 28L, null },
                    { 554L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 28L, null },
                    { 555L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 28L, null },
                    { 556L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 28L, null },
                    { 557L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 28L, null },
                    { 558L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 28L, null },
                    { 559L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 28L, null },
                    { 561L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 29L, null },
                    { 562L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 29L, null },
                    { 563L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 29L, null },
                    { 564L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 29L, null },
                    { 565L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 29L, null },
                    { 566L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 29L, null },
                    { 567L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 29L, null },
                    { 568L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 29L, null },
                    { 569L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 29L, null },
                    { 570L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 29L, null },
                    { 571L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 29L, null },
                    { 572L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 29L, null },
                    { 573L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 29L, null },
                    { 574L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 29L, null },
                    { 575L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 29L, null },
                    { 576L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 29L, null },
                    { 577L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 29L, null },
                    { 578L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 29L, null },
                    { 579L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 29L, null },
                    { 581L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 30L, null },
                    { 582L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 30L, null },
                    { 583L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 30L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 584L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 30L, null },
                    { 585L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 30L, null },
                    { 586L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 30L, null },
                    { 587L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 30L, null },
                    { 588L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 30L, null },
                    { 589L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 30L, null },
                    { 590L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 30L, null },
                    { 591L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 30L, null },
                    { 592L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 30L, null },
                    { 593L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 30L, null },
                    { 594L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 30L, null },
                    { 595L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 30L, null },
                    { 596L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 30L, null },
                    { 597L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 30L, null },
                    { 598L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 30L, null },
                    { 599L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 30L, null },
                    { 601L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 31L, null },
                    { 602L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 31L, null },
                    { 603L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 31L, null },
                    { 604L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 31L, null },
                    { 605L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 31L, null },
                    { 606L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 31L, null },
                    { 607L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 31L, null },
                    { 608L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 31L, null },
                    { 609L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 31L, null },
                    { 610L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 31L, null },
                    { 611L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 31L, null },
                    { 612L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 31L, null },
                    { 613L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 31L, null },
                    { 614L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 31L, null },
                    { 615L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 31L, null },
                    { 616L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 31L, null },
                    { 617L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 31L, null },
                    { 618L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 31L, null },
                    { 619L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 31L, null },
                    { 621L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 32L, null },
                    { 622L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 32L, null },
                    { 623L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 32L, null },
                    { 624L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 32L, null },
                    { 625L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 32L, null },
                    { 626L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 32L, null },
                    { 627L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 32L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 628L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 32L, null },
                    { 629L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 32L, null },
                    { 630L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 32L, null },
                    { 631L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 32L, null },
                    { 632L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 32L, null },
                    { 633L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 32L, null },
                    { 634L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 32L, null },
                    { 635L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 32L, null },
                    { 636L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 32L, null },
                    { 637L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 32L, null },
                    { 638L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 32L, null },
                    { 639L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 32L, null },
                    { 641L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 33L, null },
                    { 642L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 33L, null },
                    { 643L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 33L, null },
                    { 644L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 33L, null },
                    { 645L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 33L, null },
                    { 646L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 33L, null },
                    { 647L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 33L, null },
                    { 648L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 33L, null },
                    { 649L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 33L, null },
                    { 650L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 33L, null },
                    { 651L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 33L, null },
                    { 652L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 33L, null },
                    { 653L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 33L, null },
                    { 654L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 33L, null },
                    { 655L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 33L, null },
                    { 656L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 33L, null },
                    { 657L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 33L, null },
                    { 658L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 33L, null },
                    { 659L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 33L, null },
                    { 661L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 34L, null },
                    { 662L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 34L, null },
                    { 663L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 34L, null },
                    { 664L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 34L, null },
                    { 665L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 34L, null },
                    { 666L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 34L, null },
                    { 667L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 34L, null },
                    { 668L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 34L, null },
                    { 669L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 34L, null },
                    { 670L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 34L, null },
                    { 671L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 34L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 672L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 34L, null },
                    { 673L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 34L, null },
                    { 674L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 34L, null },
                    { 675L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 34L, null },
                    { 676L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 34L, null },
                    { 677L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 34L, null },
                    { 678L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 34L, null },
                    { 679L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 34L, null },
                    { 681L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 35L, null },
                    { 682L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 35L, null },
                    { 683L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 35L, null },
                    { 684L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 35L, null },
                    { 685L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 35L, null },
                    { 686L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 35L, null },
                    { 687L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 35L, null },
                    { 688L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 35L, null },
                    { 689L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 35L, null },
                    { 690L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 35L, null },
                    { 691L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 35L, null },
                    { 692L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 35L, null },
                    { 693L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 35L, null },
                    { 694L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 35L, null },
                    { 695L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 35L, null },
                    { 696L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 35L, null },
                    { 697L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 35L, null },
                    { 698L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 35L, null },
                    { 699L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 35L, null },
                    { 701L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 36L, null },
                    { 702L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 36L, null },
                    { 703L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 36L, null },
                    { 704L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 36L, null },
                    { 705L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 36L, null },
                    { 706L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 36L, null },
                    { 707L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 36L, null },
                    { 708L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 36L, null },
                    { 709L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 36L, null },
                    { 710L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 36L, null },
                    { 711L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 36L, null },
                    { 712L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 36L, null },
                    { 713L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 36L, null },
                    { 714L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 36L, null },
                    { 715L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 36L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 716L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 36L, null },
                    { 717L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 36L, null },
                    { 718L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 36L, null },
                    { 719L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 36L, null },
                    { 721L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 37L, null },
                    { 722L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 37L, null },
                    { 723L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 37L, null },
                    { 724L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 37L, null },
                    { 725L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 37L, null },
                    { 726L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 37L, null },
                    { 727L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 37L, null },
                    { 728L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 37L, null },
                    { 729L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 37L, null },
                    { 730L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 37L, null },
                    { 731L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 37L, null },
                    { 732L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 37L, null },
                    { 733L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 37L, null },
                    { 734L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 37L, null },
                    { 735L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 37L, null },
                    { 736L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 37L, null },
                    { 737L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 37L, null },
                    { 738L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 37L, null },
                    { 739L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 37L, null },
                    { 741L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 38L, null },
                    { 742L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 38L, null },
                    { 743L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 38L, null },
                    { 744L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 38L, null },
                    { 745L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 38L, null },
                    { 746L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 38L, null },
                    { 747L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 38L, null },
                    { 748L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 38L, null },
                    { 749L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 38L, null },
                    { 750L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 38L, null },
                    { 751L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 38L, null },
                    { 752L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 38L, null },
                    { 753L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 38L, null },
                    { 754L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 38L, null },
                    { 755L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 38L, null },
                    { 756L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 38L, null },
                    { 757L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 38L, null },
                    { 758L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 38L, null },
                    { 759L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 38L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 761L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 39L, null },
                    { 762L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 39L, null },
                    { 763L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 39L, null },
                    { 764L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 39L, null },
                    { 765L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 39L, null },
                    { 766L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 39L, null },
                    { 767L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 39L, null },
                    { 768L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 39L, null },
                    { 769L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 39L, null },
                    { 770L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 39L, null },
                    { 771L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 39L, null },
                    { 772L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 39L, null },
                    { 773L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 39L, null },
                    { 774L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 39L, null },
                    { 775L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 39L, null },
                    { 776L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 39L, null },
                    { 777L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 39L, null },
                    { 778L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 39L, null },
                    { 779L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 39L, null },
                    { 781L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 40L, null },
                    { 782L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 40L, null },
                    { 783L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 40L, null },
                    { 784L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 40L, null },
                    { 785L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 40L, null },
                    { 786L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 40L, null },
                    { 787L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 40L, null },
                    { 788L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 40L, null },
                    { 789L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 40L, null },
                    { 790L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 40L, null },
                    { 791L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 40L, null },
                    { 792L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 40L, null },
                    { 793L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 40L, null },
                    { 794L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 40L, null },
                    { 795L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 40L, null },
                    { 796L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 40L, null },
                    { 797L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 40L, null },
                    { 798L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 40L, null },
                    { 799L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 40L, null },
                    { 801L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 41L, null },
                    { 802L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 41L, null },
                    { 803L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 41L, null },
                    { 804L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 41L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 805L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 41L, null },
                    { 806L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 41L, null },
                    { 807L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 41L, null },
                    { 808L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 41L, null },
                    { 809L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 41L, null },
                    { 810L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 41L, null },
                    { 811L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 41L, null },
                    { 812L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 41L, null },
                    { 813L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 41L, null },
                    { 814L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 41L, null },
                    { 815L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 41L, null },
                    { 816L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 41L, null },
                    { 817L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 41L, null },
                    { 818L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 41L, null },
                    { 819L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 41L, null },
                    { 821L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 42L, null },
                    { 822L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 42L, null },
                    { 823L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 42L, null },
                    { 824L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 42L, null },
                    { 825L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 42L, null },
                    { 826L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 42L, null },
                    { 827L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 42L, null },
                    { 828L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 42L, null },
                    { 829L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 42L, null },
                    { 830L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 42L, null },
                    { 831L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 42L, null },
                    { 832L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 42L, null },
                    { 833L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 42L, null },
                    { 834L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 42L, null },
                    { 835L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 42L, null },
                    { 836L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 42L, null },
                    { 837L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 42L, null },
                    { 838L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 42L, null },
                    { 839L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 42L, null },
                    { 841L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 43L, null },
                    { 842L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 43L, null },
                    { 843L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 43L, null },
                    { 844L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 43L, null },
                    { 845L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 43L, null },
                    { 846L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 43L, null },
                    { 847L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 43L, null },
                    { 848L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 43L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 849L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 43L, null },
                    { 850L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 43L, null },
                    { 851L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 43L, null },
                    { 852L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 43L, null },
                    { 853L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 43L, null },
                    { 854L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 43L, null },
                    { 855L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 43L, null },
                    { 856L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 43L, null },
                    { 857L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 43L, null },
                    { 858L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 43L, null },
                    { 859L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 43L, null },
                    { 861L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 44L, null },
                    { 862L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 44L, null },
                    { 863L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 44L, null },
                    { 864L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 44L, null },
                    { 865L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 44L, null },
                    { 866L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 44L, null },
                    { 867L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 44L, null },
                    { 868L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 44L, null },
                    { 869L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 44L, null },
                    { 870L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 44L, null },
                    { 871L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 44L, null },
                    { 872L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 44L, null },
                    { 873L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 44L, null },
                    { 874L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 44L, null },
                    { 875L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 44L, null },
                    { 876L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 44L, null },
                    { 877L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 44L, null },
                    { 878L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 44L, null },
                    { 879L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 44L, null },
                    { 881L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 45L, null },
                    { 882L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 45L, null },
                    { 883L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 45L, null },
                    { 884L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 45L, null },
                    { 885L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 45L, null },
                    { 886L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 45L, null },
                    { 887L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 45L, null },
                    { 888L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 45L, null },
                    { 889L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 45L, null },
                    { 890L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 45L, null },
                    { 891L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 45L, null },
                    { 892L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 45L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 893L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 45L, null },
                    { 894L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 45L, null },
                    { 895L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 45L, null },
                    { 896L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 45L, null },
                    { 897L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 45L, null },
                    { 898L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 45L, null },
                    { 899L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 45L, null },
                    { 901L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 46L, null },
                    { 902L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 46L, null },
                    { 903L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 46L, null },
                    { 904L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 46L, null },
                    { 905L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 46L, null },
                    { 906L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 46L, null },
                    { 907L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 46L, null },
                    { 908L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 46L, null },
                    { 909L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 46L, null },
                    { 910L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 46L, null },
                    { 911L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 46L, null },
                    { 912L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 46L, null },
                    { 913L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 46L, null },
                    { 914L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 46L, null },
                    { 915L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 46L, null },
                    { 916L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 46L, null },
                    { 917L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 46L, null },
                    { 918L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 46L, null },
                    { 919L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 46L, null },
                    { 921L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 47L, null },
                    { 922L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 47L, null },
                    { 923L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 47L, null },
                    { 924L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 47L, null },
                    { 925L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 47L, null },
                    { 926L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 47L, null },
                    { 927L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 47L, null },
                    { 928L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 47L, null },
                    { 929L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 47L, null },
                    { 930L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 47L, null },
                    { 931L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 47L, null },
                    { 932L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 47L, null },
                    { 933L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 47L, null },
                    { 934L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 47L, null },
                    { 935L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 47L, null },
                    { 936L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 47L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 937L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 47L, null },
                    { 938L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 47L, null },
                    { 939L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 47L, null },
                    { 941L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 48L, null },
                    { 942L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 48L, null },
                    { 943L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 48L, null },
                    { 944L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 48L, null },
                    { 945L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 48L, null },
                    { 946L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 48L, null },
                    { 947L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 48L, null },
                    { 948L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 48L, null },
                    { 949L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 48L, null },
                    { 950L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 48L, null },
                    { 951L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 48L, null },
                    { 952L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 48L, null },
                    { 953L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 48L, null },
                    { 954L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 48L, null },
                    { 955L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 48L, null },
                    { 956L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 48L, null },
                    { 957L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 48L, null },
                    { 958L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 48L, null },
                    { 959L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 48L, null },
                    { 961L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 49L, null },
                    { 962L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 49L, null },
                    { 963L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 49L, null },
                    { 964L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 49L, null },
                    { 965L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 49L, null },
                    { 966L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 49L, null },
                    { 967L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 49L, null },
                    { 968L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 49L, null },
                    { 969L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 49L, null },
                    { 970L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 49L, null },
                    { 971L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 49L, null },
                    { 972L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 49L, null },
                    { 973L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 49L, null },
                    { 974L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 49L, null },
                    { 975L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 49L, null },
                    { 976L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 49L, null },
                    { 977L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 49L, null },
                    { 978L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 49L, null },
                    { 979L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 49L, null },
                    { 1038L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 50L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 1039L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 50L, null },
                    { 1040L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 50L, null },
                    { 1041L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 50L, null },
                    { 1042L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 50L, null },
                    { 1043L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 50L, null },
                    { 1044L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 50L, null },
                    { 1045L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 50L, null },
                    { 1046L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 50L, null },
                    { 1047L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 50L, null },
                    { 1048L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 50L, null },
                    { 1049L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 50L, null },
                    { 1050L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 50L, null },
                    { 1051L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 50L, null },
                    { 1052L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 50L, null },
                    { 1053L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 50L, null },
                    { 1054L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 50L, null },
                    { 1055L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 50L, null },
                    { 1056L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 50L, null },
                    { 1057L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 51L, null },
                    { 1058L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 51L, null },
                    { 1059L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 51L, null },
                    { 1060L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 51L, null },
                    { 1061L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 51L, null },
                    { 1062L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 51L, null },
                    { 1063L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 51L, null },
                    { 1064L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 51L, null },
                    { 1065L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 51L, null },
                    { 1066L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 51L, null },
                    { 1067L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 51L, null },
                    { 1068L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 51L, null },
                    { 1069L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 51L, null },
                    { 1070L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 51L, null },
                    { 1071L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 51L, null },
                    { 1072L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 51L, null },
                    { 1073L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 51L, null },
                    { 1074L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 51L, null },
                    { 1075L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 51L, null },
                    { 1076L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 52L, null },
                    { 1077L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 52L, null },
                    { 1078L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 52L, null },
                    { 1079L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 52L, null },
                    { 1080L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 52L, null }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId", "TenantId" },
                values: new object[,]
                {
                    { 1081L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 52L, null },
                    { 1082L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 52L, null },
                    { 1083L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 52L, null },
                    { 1084L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 52L, null },
                    { 1085L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 52L, null },
                    { 1086L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 52L, null },
                    { 1087L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 12L, 52L, null },
                    { 1088L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 52L, null },
                    { 1089L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 52L, null },
                    { 1090L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 52L, null },
                    { 1091L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 52L, null },
                    { 1092L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 52L, null },
                    { 1093L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 52L, null },
                    { 1094L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 52L, null }
                });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "User,UserClaims,Role,RoleSection,Section,SectionOperation", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Permissions\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Permissions\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Customer,CustomerRate", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerRates\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerRates\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Product,ProductTax,MedicalSpeciality,Tax,ProductUnit,ProductCost,ProductComposite", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Products\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Products\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Customer,CustomerPayment", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomerPayments\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Currency", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Currencies\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Currencies\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Tax", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Taxes\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Taxes\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Invoice,InvoiceDetail,TRNControl,Unit,UnitProductEquivalence,Seller,BranchOffice,Warehouse,CreditNote,Currency,Customer,Inventory,PaymentType,Insurance,InsurancePlan", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Invoices\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Invoice,InvoiceDetail,Unit,UnitProductEquivalence,Seller,Currency,Customer,Insurance,InsurancePlan", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Quotes\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Customer,BranchOffice,Warehouse,TRNControl,Zone,Invoice,InvoicePlan,Insurance,InsurancePlan", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Customers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "BranchOffice,Warehouse", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Warehouses\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Warehouses\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "*", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"All\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"All\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Inventory,Product,BranchOffice,Warehouse,Supplier", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Inventories\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Inventories\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "TRNControl", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"TRNControl\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"TRNControl\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Supplier,Expense,Tax,ExpenseTax,Currency", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Expenses\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "BranchOffice,Warehouse", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"BranchOffices\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"BranchOffices\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Supplier,BranchOffice,User,Currency,Tax,ExpensesPayment", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ExpensesPayments\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Supplier", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Suppliers\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Suppliers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Unit", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Units\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Units\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "User,BranchOffice,Warehouse,CashRegister,MedicalSpeciality", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Users\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Users\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "PaymentType", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentTypes\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PaymentTypes\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "CashRegister,BranchOffice", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisters\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisters\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "CashRegister,User,CashRegisterOpening", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpenings\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpenings\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "CashRegister,User,CashRegisterOpening", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpeningsAmounts\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CashRegisterOpeningsAmounts\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Supplier,Product,Tax,User", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeMovements\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeMovements\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Invoice,Product,InvoiceDetail,Customer", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersReturns\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Supplier,Expense,Tax,Currency,SupplierReturn", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SuppliersReturns\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SuppliersReturns\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "BranchOffice,Warehouse,User,Product,Unit,WarehouseTransfer", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"WarehouseTransfers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Product,Unit,", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductUnits\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductUnits\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Role", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Roles\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Roles\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Section", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sections\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sections\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Operation", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Operations\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Operations\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Seller,Zone,BranchOffice", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Sellers\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Zone", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Zones\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Users,Role,UserRole", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"UserRoles\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DashBoard\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DashBoard\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Invoice", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SalesReport\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SalesReport\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Invoice", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountsReceivable\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountsReceivable\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "CustomerPayment,Invoice", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeReceipts\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"IncomeReceipts\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Invoice,CustomerPayment,Seller", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Commisions\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Commisions\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Product,Inventory,WarehouseMovement", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductMovements\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ProductMovements\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Expense", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"DebstToPay\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"DebstToPay\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Product", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PriceList\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PriceList\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Customer", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersList\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CustomersList\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Customer,Invoice,CustomerPayment", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountState\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"AccountState\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Invoice,Expense,CompanyState", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"ResultState\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"ResultState\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Tax,InvoiceTax", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"TaxesReport\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"TaxesReport\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "InventoryEntry", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InventoryIncomes\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "CompanyPayment", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"CompanyPayments\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"CompanyPayments\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Menu\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Menu\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "School,BranchOffice,Zone,Customer", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"School\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"School\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"SchoolMenu\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"SchoolMenu\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "InvoiceLead,Product,Customer,BranchOffice", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InvoiceLeads\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InvoiceLeads\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Insurance,InsurancePlan,Currency", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Insurance\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Insurance\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "InsurancePlan", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InsurancePlan\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InsurancePlan\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "InsuranceServiceCoverage,Insurance,InsurancePlan,Product,Currency", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InsuranceCoverage\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InsuranceCoverage\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "MedicalSpeciality,Appointment,User,ProductUnit,ProductTax,InsuranceServiceCoverage,BranchOffice,Customer,Product", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"Appointment\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"Appointment\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "PatientCheckup,CheckupAttachment,Appointment,MedicalSpeciality,Product,Customer", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"PatientCheckup\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"PatientCheckup\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "MedicalSpeciality", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"MedicalSpecialities\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"MedicalSpecialities\"}]}" });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "Controllers", "TranslationData" },
                values: new object[] { "Invoice,Insurance,Currency,BranchOffice", "{\"ES\":[{\"PropertyName\":\"Name\",\"Value\":\"InsurancesCoveragesReport\"}],\"EN\":[{\"PropertyName\":\"Name\",\"Value\":\"InsurancesCoveragesReport\"}]}" });

            migrationBuilder.InsertData(
                table: "RoleSectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "RoleId", "SectionOperationId", "TenantId" },
                values: new object[,]
                {
                    { 1L, false, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 281L, null },
                    { 2L, false, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 283L, null },
                    { 3L, false, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 283L, null },
                    { 4L, false, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 283L, null },
                    { 5L, false, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 285L, null },
                    { 6L, false, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 284L, null },
                    { 7L, false, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 282L, null },
                    { 8L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 287L, null },
                    { 9L, false, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1L, 292L, null },
                    { 10L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 187L, null },
                    { 11L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 3L, 87L, null },
                    { 12L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 4L, 327L, null },
                    { 13L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 5L, 107L, null },
                    { 14L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 6L, 347L, null },
                    { 15L, false, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 185L, null },
                    { 16L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 2L, 285L, null },
                    { 17L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 7L, 247L, null },
                    { 18L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 8L, 647L, null },
                    { 19L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 627L, null },
                    { 20L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 9L, 645L, null },
                    { 21L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 27L, null },
                    { 22L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 167L, null },
                    { 23L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 85L, null },
                    { 24L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 10L, 245L, null },
                    { 25L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 47L, null },
                    { 26L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 85L, null },
                    { 27L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 345L, null },
                    { 28L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 325L, null },
                    { 29L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 105L, null },
                    { 30L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 11L, 547L, null },
                    { 31L, false, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 1044L, null },
                    { 32L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 165L, null },
                    { 33L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 645L, null },
                    { 34L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 285L, null },
                    { 35L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 185L, null },
                    { 36L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 1063L, null },
                    { 37L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 45L, null },
                    { 38L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 41L, null },
                    { 39L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 345L, null },
                    { 40L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 14L, 545L, null },
                    { 41L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 407L, null },
                    { 42L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 15L, 285L, null }
                });

            migrationBuilder.InsertData(
                table: "RoleSectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "RoleId", "SectionOperationId", "TenantId" },
                values: new object[,]
                {
                    { 43L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 365L, null },
                    { 44L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 285L, null },
                    { 45L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 405L, null },
                    { 46L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 85L, null },
                    { 47L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 427L, null },
                    { 48L, false, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 445L, null },
                    { 49L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 16L, 447L, null },
                    { 50L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 285L, null },
                    { 51L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 185L, null },
                    { 52L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 1082L, null },
                    { 53L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 1061L, null },
                    { 54L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 45L, null },
                    { 55L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 345L, null },
                    { 56L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 545L, null },
                    { 57L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 105L, null },
                    { 58L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 225L, null },
                    { 59L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 1061L, null },
                    { 60L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 127L, null },
                    { 61L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 185L, null },
                    { 62L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 285L, null },
                    { 63L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 25L, null },
                    { 64L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 245L, null },
                    { 65L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 85L, null },
                    { 66L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 165L, null },
                    { 67L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 18L, 1080L, null },
                    { 68L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 67L, null },
                    { 69L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 125L, null },
                    { 70L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 285L, null },
                    { 71L, false, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 185L, null },
                    { 72L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 165L, null },
                    { 73L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 85L, null },
                    { 74L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 125L, null },
                    { 75L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 19L, 385L, null },
                    { 76L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 20L, 267L, null },
                    { 77L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 20L, 285L, null },
                    { 78L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 20L, 325L, null },
                    { 79L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 20L, 85L, null },
                    { 80L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 20L, 105L, null },
                    { 81L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 20L, 385L, null },
                    { 82L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 21L, 307L, null },
                    { 83L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 21L, 265L, null },
                    { 84L, false, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 21L, 285L, null }
                });

            migrationBuilder.InsertData(
                table: "RoleSectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "RoleId", "SectionOperationId", "TenantId" },
                values: new object[,]
                {
                    { 85L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 21L, 325L, null },
                    { 86L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 21L, 85L, null },
                    { 87L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 21L, 385L, null },
                    { 88L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 13L, 1044L, null },
                    { 91L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 22L, 1076L, null },
                    { 92L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 22L, 1077L, null },
                    { 93L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 22L, 1080L, null },
                    { 94L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 22L, 1061L, null },
                    { 95L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 22L, 185L, null },
                    { 96L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 22L, 285L, null },
                    { 97L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 22L, 1042L, null },
                    { 98L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 22L, 545L, null },
                    { 99L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 22L, 45L, null },
                    { 100L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 22L, 41L, null },
                    { 101L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 22L, 1038L, null },
                    { 102L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 22L, 1057L, null },
                    { 103L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 22L, 1078L, null },
                    { 104L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 1057L, null },
                    { 105L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 1038L, null },
                    { 106L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 41L, null },
                    { 107L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 45L, null },
                    { 108L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 17L, 1042L, null },
                    { 109L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 23L, 121L, null },
                    { 110L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 23L, 122L, null },
                    { 111L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 23L, 125L, null },
                    { 112L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 23L, 126L, null },
                    { 113L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 23L, 185L, null },
                    { 114L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 23L, 285L, null },
                    { 115L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 23L, 25L, null },
                    { 116L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 23L, 245L, null },
                    { 117L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 23L, 85L, null },
                    { 118L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 23L, 165L, null },
                    { 119L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 23L, 1080L, null },
                    { 120L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 24L, 61L, null },
                    { 121L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 24L, 62L, null },
                    { 122L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 24L, 65L, null },
                    { 123L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 24L, 66L, null },
                    { 124L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 24L, 125L, null },
                    { 125L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 24L, 185L, null },
                    { 126L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 24L, 285L, null },
                    { 127L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 24L, 165L, null },
                    { 128L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 24L, 85L, null }
                });

            migrationBuilder.InsertData(
                table: "RoleSectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "RoleId", "SectionOperationId", "TenantId" },
                values: new object[,]
                {
                    { 129L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 24L, 385L, null },
                    { 130L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 25L, 261L, null },
                    { 131L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 25L, 262L, null },
                    { 132L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 25L, 265L, null },
                    { 133L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 25L, 266L, null },
                    { 134L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 25L, 85L, null },
                    { 135L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 25L, 105L, null },
                    { 136L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 25L, 325L, null },
                    { 137L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 25L, 285L, null },
                    { 138L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 25L, 385L, null },
                    { 139L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 26L, 301L, null },
                    { 140L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 26L, 302L, null },
                    { 141L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 26L, 305L, null },
                    { 142L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 26L, 306L, null },
                    { 143L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 26L, 265L, null },
                    { 144L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 26L, 325L, null },
                    { 145L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 26L, 385L, null },
                    { 146L, false, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 26L, 311L, null },
                    { 147L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 26L, 271L, null },
                    { 148L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 21L, 271L, null },
                    { 149L, false, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 27L, 467L, null },
                    { 150L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 27L, 185L, null },
                    { 151L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 27L, 45L, null },
                    { 152L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 27L, 325L, null },
                    { 153L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 27L, 345L, null },
                    { 154L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 27L, 285L, null },
                    { 155L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 27L, 325L, null },
                    { 156L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 27L, 927L, null },
                    { 157L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 28L, 185L, null },
                    { 158L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 28L, 285L, null },
                    { 159L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 28L, 225L, null },
                    { 160L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 28L, 345L, null },
                    { 161L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 28L, 527L, null },
                    { 162L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 28L, 45L, null },
                    { 163L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 29L, 507L, null },
                    { 164L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 29L, 185L, null },
                    { 165L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 29L, 285L, null },
                    { 166L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 29L, 325L, null },
                    { 167L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 29L, 45L, null },
                    { 168L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 29L, 345L, null },
                    { 169L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 29L, 545L, null },
                    { 170L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 29L, 125L, null }
                });

            migrationBuilder.InsertData(
                table: "RoleSectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "RoleId", "SectionOperationId", "TenantId" },
                values: new object[,]
                {
                    { 171L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 30L, 707L, null },
                    { 172L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 30L, 285L, null },
                    { 173L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 30L, 165L, null },
                    { 174L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 31L, 727L, null },
                    { 175L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 31L, 285L, null },
                    { 176L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 31L, 165L, null },
                    { 177L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 32L, 747L, null },
                    { 178L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 32L, 285L, null },
                    { 179L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 32L, 165L, null },
                    { 180L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 32L, 85L, null },
                    { 181L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 32L, 385L, null },
                    { 182L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 33L, 85L, null },
                    { 183L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 33L, 625L, null },
                    { 184L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 33L, 165L, null },
                    { 185L, false, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 33L, 765L, null },
                    { 186L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 33L, 767L, null },
                    { 187L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 34L, 227L, null },
                    { 188L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 34L, 285L, null },
                    { 189L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 34L, 185L, null },
                    { 190L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 34L, 45L, null },
                    { 191L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 35L, 787L, null },
                    { 192L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 35L, 45L, null },
                    { 193L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 35L, 185L, null },
                    { 194L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 35L, 285L, null },
                    { 195L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 36L, 807L, null },
                    { 196L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 36L, 325L, null },
                    { 197L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 36L, 85L, null },
                    { 198L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 36L, 285L, null },
                    { 199L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 37L, 45L, null },
                    { 200L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 37L, 827L, null },
                    { 201L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 38L, 165L, null },
                    { 202L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 38L, 847L, null },
                    { 203L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 39L, 165L, null },
                    { 204L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 39L, 867L, null },
                    { 205L, false, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 39L, 89L, null },
                    { 206L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 39L, 169L, null },
                    { 207L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 40L, 887L, null },
                    { 208L, true, new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 41L, 907L, null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_RoleSectionOperations_SectionOperations_SectionOperationId",
                table: "RoleSectionOperations",
                column: "SectionOperationId",
                principalTable: "SectionOperations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
