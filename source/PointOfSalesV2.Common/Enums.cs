using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Common
{
    public class Enums
    {

        public enum Month
        {
            NotSet = 0,
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
        public enum BillingStates
        {
            Billed = 'B',
            Nulled = 'N',
            Paid = 'P',
            FullPaid = 'R',
            Quoted = 'Q',
            Converted = 'C',
            Generated = 'G',
            Projected = 'J',
            Delivered = 'D',
            Expired = 'E',
            NotEnoughInventory = 'I',
            NulledLead = 'M',
            GeneratedWithoutInventory = 'O',
            Scheduled = 'S',
            InProgress = 'F'
        }

        public enum AppointmentStates
        {
            Scheduled = 'S',
            InProgress = 'F',
            Billed = 'B',
            Nulled = 'N',
            FullPaid = 'R',
            Expired='E'
        }

        public enum AppointmentTypes 
        {
        Consultation='C',
        Laboratory='L',
        Medication='M',
        EspecializedImages='E'
        }

       

        public enum CashRegisterOpeningType
        {
            cash,
            check,
            creditCard
        }
        public enum CashRegisterOpeningStates
        {
            Open = 'O',
            Close = 'C',
            Nulled = 'N'
        }
        public enum SortDirections
        {
            DESC = 0,
            ASC = 1
        }

        public enum ExcelColumnsDef
        {
            TEXT = 1,
            DECIMAL = 2,
            INTEGER = 3,
            DATETIME = 4
        }

        public static Dictionary<string, ExcelColumnsDef> PropertyTypesToExcelEnum = new Dictionary<string, ExcelColumnsDef>()
        {
            {"datetime",ExcelColumnsDef.DATETIME },
            {"int",ExcelColumnsDef.INTEGER },
            {"byte",ExcelColumnsDef.INTEGER },
            {"long",ExcelColumnsDef.INTEGER },
            {"short",ExcelColumnsDef.INTEGER },
            {"string",ExcelColumnsDef.TEXT },
            {"decimal",ExcelColumnsDef.DECIMAL },
            {"float",ExcelColumnsDef.DECIMAL },
            {"char",ExcelColumnsDef.TEXT },
        };

        public static Dictionary<PaymentTypes,string > GetPaymentTypeSpanishName = new Dictionary<PaymentTypes, string>()
        {
            {PaymentTypes.CHECK,"Cheque" },
            {PaymentTypes.CASH,"Efectivo" },
            {PaymentTypes.CREDITCARD ,"Tarjeta de Crédito"},
            {PaymentTypes.BANKTRANSFER,"Transferencia Bancaria" },
        };

        public static Dictionary<PaymentTypes, string> GetPaymentTypeEnglishName = new Dictionary<PaymentTypes, string>()
        {
            {PaymentTypes.CHECK,"Check" },
            {PaymentTypes.CASH,"Cash" },
            {PaymentTypes.CREDITCARD,"Credit Card" },
            {PaymentTypes.BANKTRANSFER,"Bank Transfer" },
        };

        public enum ObjectType
        {
            STRING = 0,
            NUMBER = 2,
            DATE = 3,
            BOOL = 4
        }


        public enum SequenceTypes
        {

            Invoices = 1,
            Sellers = 2,
            Customers = 3,
            Quotes = 4,
            Expenses = 5,
            WarehouseTransfers = 6,
            InventoryIncomes = 7,
            CustomersReturns = 8,
            SupplierReturns = 9,
            CustomerPayments = 10,
            CompanyPayments = 11,
            Leads = 12,
            Schools = 13,
            ExpensePayments = 14,
            Products = 15,
            Menus = 16,
            Insurances = 17
        }



        public enum CompanyPaymentTypes
        {
            ExpensePayment = 0,
            CustomerPayment = 1
        }

        public enum SequenceTypeCode
        {
            FAC = 1,
            VEND = 2,
            CLI = 3,
            COT = 4,
            GST = 5,
            TRF = 6,
            ENT = 7,
            DEV = 8,
            DEVS = 9,
            R = 10,
            P = 11,
            CONDUCE = 12,
            ESC = 13,
            PG = 14,
            PRO = 15,
            MEN = 16,
            INS = 17
        }

        public enum Controllers
        {
            NotSpecified = 0,
            All=60,
            Appointment = 1,
            BranchOffice = 2,
            CashRegister = 3,
            CashRegisterOpening = 4,
            CashRegisterOpeningsAmount = 5,
            CheckUpAttachment= 6,
            CompanyPayment = 7,
            CompanyState = 8,
            CompositeProduct = 9,
            CreditNote=10,
            Currency=11,
            CustomerBalance=12,
            Customer=13,
            CustomerPayment=14,
            CustomerReturn=15,
            CustomerReturnDetail=16,
            Expense=17,
            ExpensePayment=18,
            ExpenseTax=19,
            Insurance=20,
            InsurancePlan=21,
            InsuranceServiceCoverage=22,
            Inventory=23,
            InventoryEntry=24,
            Invoice=25,
            InvoiceTax=26,
            Language=27,
            Login=28,
            Logout=29,
            MedicalSpeciality=30,
            MovementType=31,
            OpeningAmount=32,
            Operation=33,
            PatientCheckup=34,
            Payment=35,
            PaymentDetail=36,
            PaymentType=37,
            ProductComposite=38,
            Product=39,
            ProductCost=40,
            ProductTax=41,
            ProductUnit=42,
            ReturnDetail=43,
            Role=44,
            RoleSectionOperation=45,
            Seller=46,
            SupplierBalance=47,
            Supplier=48,
            SupplierReturn=49,
            Tax=50,
            TrnControl=51,
            Unit=52,
            UnitProductEquivalence=53,
            User=54,
            UserRole=55,
            Warehouse=56,
            WarehouseMovement=57,
            WarehouseTransfer=58,
            Zone=59
        }
        public enum MovementTypes
        {
            IN = 1,
            OUT = 2
        }

        public enum PaymentTypes
        {
            CASH = 1,
            CHECK = 2,
            CREDITCARD = 3,
            BANKTRANSFER = 4
        }
      
        public enum Gender
        {
            Male = 'M',
            Female = 'F'
        }

        public enum ServerDirectoryType
        {
            Folder = 0,
            FTP = 1
        }

        public enum Operations
        {
            READ = 1,
            ADD = 2,
            UPDATE = 3,
            DELETE = 4,
            READALL = 5,
            EXPORT = 6,
            ALL = 7,
            NONE = 8,
            ACCOUNTSTATEREPORT = 9,
            RECEIPTSREPORT = 10,
            DEBTSTOPAYREPORT = 11,
            MENU = 12,
            INVENTORYREPORT = 13,
            ACCOUNTRECEIVABLES = 14,
            SALESREPORT = 15,
            TAXREPORT = 16,
            GENERATEDICTIONARY = 17,
            COMISSIONSREPORT = 18,
            PRODUCTMOVEMENTS = 19,
            PATIENSHISTORY=20,
            ATTENDPATIENT=21

        }
    }
}
