import { AppSections } from './enums';

//export const endpointUrl = 'https://localhost:44386/api/';
export const endpointUrl = document.getElementsByTagName('base')[0].href;

//export const endpointViewsUrl = 'https://localhost:44386/';
 export const endpointViewsUrl = 'https://localhost:44386/';

export const endpointControllers = {
    login: 'login',
    products: 'product',
    logout: 'logout',
    languages: 'language',
    branchOffices: 'branchoffice',
    units: 'unit',
    taxes: 'tax',
    currencies: 'currency',
    zones: 'zone',
    trncontrol: 'trncontrol',
    warehoses: 'warehouse',
    sellers:'seller',
    suppliers:'supplier',
    customers:'customer',
    productTaxes:'producttax',
    users:'user',
    cashRegister:'cashregister',
    expenses:'expense',
    expensePayment:'expensespayment',
    schools:'school'
}

export const menuChildren = {
    core: [
        AppSections.BranchOffices,
        AppSections.Warehouses,
        AppSections.Currencies,
        AppSections.Suppliers,
        AppSections.Taxes,
        AppSections.Units,
        AppSections.TRNControl,
        AppSections.Zones,
        AppSections.Sellers,
        AppSections.Customers,
        AppSections.Products,
    ],
    cashRegister: [
        AppSections.CashRegisters,
        AppSections.CashRegisterOpenings
    ],
    billing: [
        AppSections.Quotes,
        AppSections.Invoices,
        AppSections.CustomerPayments
    ],
    expenses: [
        AppSections.Expenses,
        AppSections.ExpensesPayments
    ],
    reports: [
        AppSections.SalesReport,
        AppSections.AccountsReceivable,
        AppSections.IncomeReceipts,
        AppSections.Commisions,
        AppSections.Inventories,
        AppSections.ProductMovements,
        AppSections.DebstToPay,
        AppSections.PriceList,
        AppSections.CustomersList,
        AppSections.AccountState,
        AppSections.ResultState,
        AppSections.TaxesReport
    ],
    movements: [
        AppSections.InventoryIncomes,
        AppSections.WarehouseTransfers,
        AppSections.CustomersReturns,
        AppSections.SuppliersReturns
    ],
    auth: [
        AppSections.Users,
        AppSections.Roles
    ]
}
