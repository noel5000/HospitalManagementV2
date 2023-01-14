import { AppRoles } from './enums';

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
    core:[
        AppRoles.Patients_Consultation,
        AppRoles.Appointments
    ],
    billing: [
        AppRoles.Quotes,
        AppRoles.Invoices,
        AppRoles.Invoices_Payments
    ],
    reports: [
        AppRoles.Reports_Sales,
        AppRoles.Reports_AccountsReceivables,
        AppRoles.Reports_AccountState,
        AppRoles.Reports_Commissions,
        AppRoles.Reports_DebtsToPay,
        AppRoles.Reports_InsuranceCoverage,
        AppRoles.Reports_Inventory,
        AppRoles.Reports_Pacients,
        AppRoles.Reports_ProductMovements,
        AppRoles.Reports_Prices,
        AppRoles.Reports_ReceiptsReport,
        AppRoles.Reports_ResultState,
        AppRoles.Reports_Taxes
    ],
    management:
    {
        config: [
            AppRoles.Config_Hospitals,
            AppRoles.Config_warehouse,
            AppRoles.Config_Currencies,
            AppRoles.Config_Suppliers,
            AppRoles.Config_Taxes,
            AppRoles.Config_Units,
            AppRoles.Config_TrnControl,
            AppRoles.Config_Zones,
            AppRoles.Config_Sellers,
            AppRoles.Config_Patients,
            AppRoles.Config_Products,
            AppRoles.Config_Insurance,
            AppRoles.Medical_Specialities
        ],
        cashRegister: [
            AppRoles.CashRegister_Manteinance,
            AppRoles.CashRegister_OpenClose
        ],
        expenses: [
            AppRoles.Expenses_Registers,
            AppRoles.Expenses_Payments
        ],
        movements: [
            AppRoles.Movements_CustomersReturns,
            AppRoles.Movements_InventoryEntry,
            AppRoles.Movements_SupplierReturns,
            AppRoles.Movements_WarehousesTransfers
        ],
        auth: [
            AppRoles.Authorization_users,
            AppRoles.Authorization_roles
        ]
    },
    
}
