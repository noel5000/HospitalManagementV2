

export enum BillingStates {
  Billed = 'B',
  Nulled = 'N',
  Paid = 'P',
  FullPaid = 'R',
  Quoted = 'Q',
  Converted = 'C',
  Generated='G',
  Projected='J',
  Delivered='D',
  Expired='E',
  NotEnoughInventory='I',
  NulledLead = 'M',
  GeneratedWithoutInventory = 'O',
}

export enum CashRegisterOpeningStates
{
   Open='O',
   Close='C',
   Nulled='N'
}

export const BillingStatesColors={
    B :{
        primary: '#4d4dff',
        secondary: '#4d4dff',
      },
    N :{
        primary: '#FF0000',
        secondary: '#FF0000',
      },
    P :{
        primary: '#00ff00',
        secondary: '#00ff00',
      },
    Q :{
        primary: '#ff99ff',
        secondary: '#ff99ff',
      },
    C :{
        primary: '#999966',
        secondary: '#999966',
      },
    G:{
        primary: '#ff9933',
        secondary: '#ff9933',
      },
    J:{
        primary: '#804d00',
        secondary: '#804d00',
      },
    D:{
        primary: '#666699',
        secondary: '#666699',
      },
    E:{
        primary: '#737373',
        secondary: '#737373',
      },
    I:{
        primary: '#cccccc',
        secondary: '#cccccc',
      },
    M:{
        primary: '#9400D3',
        secondary: '#9400D3',
      },
    O:{
          primary: '#98FB98',
          secondary: '#98FB98',
      },
      F:{
        primary: '#98FB98',
        secondary: '#98FB98',
    },
    S:{
      primary: '#80bfff',
      secondary: '#80bfff',
  },
  R:{
    primary: '#339966',
    secondary: '#339966',
},
}

export enum ExcelColumnsDef {
    TEXT = 1,
    DECIMAL = 2,
    INTEGER = 3,
    DATETIME = 4
}

export const ODataOperations = {
    select: '$select',
    filter: '$filter=',
    count: '$count',
    skip: '$skip=',
    order: '$orderby=',
    search: '$search',
    top: '$top=',
    expand: '$expand='
}

export class QueryFilter {
    property: string;
    value: string;
    type: ObjectTypes;
    comparer?:ODataComparers;
    isTranslated:boolean=false;
}

export enum ODataComparers  {
    equals= 'eq',
    lesOrEqual='le',
    NotEqual='ne',
    greaterThan= 'gt',
    greaterThanOrEqual= 'ge',
    lessThan= 'lt',
    not='not',
    endWiths= 'endswith',
    in= 'in'

}
export enum ObjectTypes {
    String = 0,
    Number = 1,
    Date = 2,
    Boolean = 3,
    ChildObject=4
}

export const ODataOperators = {
    and: ' and ',
    or: ' or ',
    expand:'expand'
}



export enum AppRoles{
  DashBoard=0,
  Authorization_roles=77,
  Authorization_users=76,
  CashRegister_Manteinance=68,
  CashRegister_OpenClose=69,
  Patient_Checkup=64,
  Appointments=63,
  Config_warehouse=50,
  Config_Insurance=56,
  Config_Products=58,
  Config_TrnControl=55,
  Medical_Specialities=57,
  Config_Hospitals=49,
  Config_Taxes=53,
  Config_Currencies=51,
  Config_Patients=59,
  Config_Suppliers=52,
  Config_Units=54,
  Config_Sellers=60,
  Config_Zones=61,
  Patients_Consultation = 62,
  Quotes=66,
  Invoices=65,
  Expenses_Payments=71,
  Expenses_Registers=70,
  Movements_SupplierReturns=75,
  Movements_CustomersReturns=74,
  Movements_InventoryEntry=72,
  Movements_WarehousesTransfers=73,
  Invoices_Payments=67,
  Reports_InsuranceCoverage=90,
  Reports_Commissions=81,
  Reports_AccountsReceivables=79,
  Reports_DebtsToPay=84,
  Reports_AccountState=87,
  Reports_ResultState=88,
  Reports_Taxes=89,
  Reports_Inventory=82,
  Reports_Prices=85,
  Reports_Pacients=86,
  Reports_ProductMovements=83,
  Reports_ReceiptsReport=80,
  Reports_Sales=78
}

export enum MovementTypes {
    IN = 1,
    OUT = 2
}

export enum PaymentTypes {
    CASH = 1,
    CHECK = 2,
    CREDITCARD = 3,
    BANKTRANSFER = 4
}

export enum Gender {
    Male = 'M',
    Female = 'F'
}

export enum Operations {
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
