

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

export enum AppSections {
    Permissions = 1,
    CustomerRates = 2,
    Products = 3,
    CustomerPayments = 4,
    Currencies = 5,
    Taxes = 6,
    Invoices = 7,
    Quotes = 8,
    Customers = 9,
    Warehouses = 10,
    All = 11,
    Inventories = 12,
    TRNControl = 13,
    Expenses = 14,
    BranchOffices = 15,
    ExpensesPayments = 16,
    Suppliers = 17,
    Units = 18,
    Users = 19,
    PaymentTypes = 20,
    CashRegisters = 21,
    CashRegisterOpenings = 22,
    CashRegisterOpeningsAmounts = 23,
    IncomeMovements = 24,
    CustomersReturns = 25,
    SuppliersReturns = 26,
    WarehouseTransfers = 27,
    ProductUnits = 28,
    Roles = 29,
    Sections = 30,
    Operations = 31,
    Sellers = 32,
    Zones = 33,
    UserRoles = 34,
    DashBoard = 35,
    SalesReport = 36,
    AccountsReceivable = 37,
    IncomeReceipts = 38,
    Commisions = 39,
    ProductMovements = 40,
    DebstToPay = 41,
    PriceList = 42,
    CustomersList = 43,
    AccountState = 44,
    ResultState = 45,
    TaxesReport = 46,
    InventoryIncomes = 47,
    CompanyPayments=48,
    Menu=49,
    Insurance=53,
    InsurancePlan=54

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
    READPAGED = 6,
    ALL = 7
}
