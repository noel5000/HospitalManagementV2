import { Component , Inject } from '@angular/core';

import { MENU_ITEMS } from './pages-menu';
import { NbMenuItem } from '@nebular/theme';
import { LanguageService } from './../@core/services/translateService';
import { SecurityService } from '../@core/services/securityService';
import { menuChildren } from '../@core/common/constants';
import { User } from './../@core/data/users';
import { AppRoles } from '../@core/common/enums';

@Component({
  selector: 'ngx-pages',
  styleUrls: ['pages.component.scss'],
  template: `
    <ngx-one-column-layout>
      <nb-menu [items]="menu" class="dontPrint"></nb-menu>
      <router-outlet></router-outlet>
    </ngx-one-column-layout>
  `,
})
export class PagesComponent {
  constructor(@Inject('BASE_URL') private baseUrl: string,private lang: LanguageService, private securityService: SecurityService) {
    this.menu=[];
    this.menu=[
      {
        title: this.lang.getValueByKey('start_menu'),
        icon: 'home-outline',
        link: '/pages/dashboard',
        home: true,
        hidden: false
      },
      {
        title: this.lang.getValueByKey('user_menu'),
        icon: 'person-outline',
        hidden: false,
        children: [
          
          {
            title: this.lang.getValueByKey('logOut_btn'),
            link: '/pages/logout',
            hidden: false
          },
        ],
      },
      {
        title: this.lang.getValueByKey('consultation_menu'),
        icon: 'book-open-outline',
        children:[

          {
            title: this.lang.getValueByKey('patients_menu'),
            link: 'customer',
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Config_Patients)
          },
          {
            title: this.lang.getValueByKey('appointment_menu'),
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Appointments),
            link:'appointment'
          },
        ]
      },

      {
        title: this.lang.getValueByKey('billing_menu'),
        icon: 'shopping-cart-outline',
        hidden: !this.securityService.validateMenuChildren(menuChildren.billing),
        children: [
          {
            title: this.lang.getValueByKey('quotes_menu'),
            link: 'quotes',
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Quotes)
          },
          {
            title: this.lang.getValueByKey('invoices_menu'),
            link: 'invoice',
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Invoices)
          },
          {
            title: this.lang.getValueByKey('customerPayment_menu'),
            link: 'invoicepayment',
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Invoices_Payments)
          }
        ],
      },
      {
        title: this.lang.getValueByKey('reports_menu'),
        icon: 'file-text-outline',
        hidden: !this.securityService.validateMenuChildren(menuChildren.reports),
        children: [
          {
            title: this.lang.getValueByKey('sales_menu'),
            link: 'salesreport',
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Reports_Sales)
          },
          {
            title: this.lang.getValueByKey('accountsReceivable_menu'),
            link: 'accountreceivables',
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Reports_AccountsReceivables)
          },
          {
            title: this.lang.getValueByKey('incomeReceipts_menu'),
            link: 'receiptsreport',
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Reports_ReceiptsReport)
          },
          {
            title: this.lang.getValueByKey('commissions_menu'),
            link: 'comissionsreport',
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Reports_Commissions)
          },
          {
            title: this.lang.getValueByKey('inventory_menu'),
            link: 'inventoryreport',
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Reports_Inventory)
          },
          {
            title: this.lang.getValueByKey('productsMovements_menu'),
            link: 'warehousemovements',
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Reports_ProductMovements)
          },
          {
            title: this.lang.getValueByKey('debtsToPay_menu'),
            link: 'expensesreport',
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Reports_DebtsToPay)
          },
          {
            title: this.lang.getValueByKey('pricesList_menu'),
            link: 'pricelist',
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Reports_Prices)
          },
          {
            title: this.lang.getValueByKey('customersList_menu'),
            link: 'customerlist',
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Reports_Pacients)
          },
          {
            title: this.lang.getValueByKey('accountState_menu'),
            link: 'accountstate',
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Reports_AccountState)
          },
          {
            title: this.lang.getValueByKey('resultState_menu'),
            link: 'companystate',
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Reports_ResultState)
          },
          {
            title: this.lang.getValueByKey('taxesReport_menu'),
            link: 'taxesreport',
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Reports_Taxes)
          },
          {
            title: this.lang.getValueByKey('insuranceCoveragesReport_menu'),
            link: 'insurancecoveragereport',
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Reports_InsuranceCoverage)
          }
        ],
      },
      {
        title: this.lang.getValueByKey('administration_menu'),
        icon: 'archive-outline',
        children:[
          {
            title: this.lang.getValueByKey('core_menu'),
            icon: 'settings-2-outline',
            hidden: !this.securityService.validateMenuChildren(menuChildren.management.config),
            children: [
              {
                title: this.lang.getValueByKey('hospitals_menu'),
                link: 'branchoffice',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Config_Hospitals)
              },
              {
                title: this.lang.getValueByKey('medicineWarehouse_menu'),
                link: 'warehouse',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Config_warehouse)
              },
              {
                title: this.lang.getValueByKey('currencies_menu'),
                link: 'currency',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Config_Currencies)
              },
              {
                title: this.lang.getValueByKey('suppliers_menu'),
                link: 'supplier',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Config_Suppliers)
              },
              {
                title: this.lang.getValueByKey('taxes_menu'),
                link: 'tax',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Config_Taxes)
              },
              {
                title: this.lang.getValueByKey('units_menu'),
                link: 'unit',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Config_Units)
              },
              {
                title: this.lang.getValueByKey('TRNControl_menu'),
                link: 'trncontrol',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Config_TrnControl)
              },
              {
                title: this.lang.getValueByKey('insurances_menu'),
                link: 'insurance',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Config_Insurance)
              },
              {
                title: this.lang.getValueByKey('medicalSpecialities_menu'),
                link: 'medicalSpeciality',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Medical_Specialities)
              },
              {
                title: this.lang.getValueByKey('consultation_menu'),
                link: 'product',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Config_Products)
              },  
              {
                title: this.lang.getValueByKey('medicine_lbl'),
                link: 'medicine',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Config_Products)
              },  
              {
                title: this.lang.getValueByKey('medicalTests_menu'),
                link: 'medical-test',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Config_Products)
              },  
              {
                title: this.lang.getValueByKey('insuranceCoverage_menu'),
                link: 'insuranceCoverage',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Config_Insurance)
              },
              {
                title: this.lang.getValueByKey('patients_menu'),
                link: 'customer',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Config_Patients)
              },

              {
                title: this.lang.getValueByKey('sellers_menu'),
                link: 'seller',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Config_Sellers)
              },

              {
                title: this.lang.getValueByKey('zones_menu'),
                link: 'zone',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Config_Zones)
              },
            ],
          },
          {
            title: this.lang.getValueByKey('appointment_menu'),
            icon: 'calendar-outline',
            hidden: !this.securityService.isUserValidInMenu(AppRoles.Appointments),
            link:'appointment'
          },
          {
            title: this.lang.getValueByKey('cashRegister_menu'),
            icon: 'printer-outline',
            hidden: !this.securityService.validateMenuChildren(menuChildren.management.cashRegister),
            children: [
              {
                title: this.lang.getValueByKey('cashRegisterManteinance_menu'),
                link: 'cashregister',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.CashRegister_Manteinance)
              },
              {
                title: this.lang.getValueByKey('cashROpenClose_menu'),
                link: 'cashregisteropening',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.CashRegister_OpenClose)
              }
            ],
          },
          {
            title: this.lang.getValueByKey('expenses_menu'),
            icon: 'shopping-bag-outline',
            hidden: !this.securityService.validateMenuChildren(menuChildren.management.expenses),
            children: [
              {
                title: this.lang.getValueByKey('expensesRegister_menu'),
                link: 'expense',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Expenses_Registers)
              },
              {
                title: this.lang.getValueByKey('expensesPayment_menu'),
                link: 'expensepayment',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Expenses_Payments)
              }
            ],
          },
         
          {
            title: this.lang.getValueByKey('movements_menu'),
            icon: 'car-outline',
            hidden: !this.securityService.validateMenuChildren(menuChildren.management.movements),
            children: [
              {
                title: this.lang.getValueByKey('inventoryIn_menu'),
                link: 'inventoryentry',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Movements_InventoryEntry)
              },
              {
                title: this.lang.getValueByKey('warehouseTransfers_menu'),
                link: 'warehousetransfer',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Movements_WarehousesTransfers)
              },
              {
                title: this.lang.getValueByKey('customersReturns_menu'),
                link: 'customerreturn',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Movements_CustomersReturns)
              },
              {
                title: this.lang.getValueByKey('suppliersReturns_menu'),
                link: 'supplierreturn',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Movements_SupplierReturns)
              }
            ],
          },
          {
            title: this.lang.getValueByKey('auth_menu'),
            icon: 'lock-outline',
            hidden: !this.securityService.validateMenuChildren(menuChildren.management.auth),
            children: [
              {
                title: this.lang.getValueByKey('users_menu'),
                link: 'user',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Authorization_users)
              },
              {
                title: this.lang.getValueByKey('roles_menu'),
                link: 'role',
                hidden: !this.securityService.isUserValidInMenu(AppRoles.Authorization_roles)
              }
            ],
          }
        ],
      },
    ];

   }




  menu: NbMenuItem[] = [];
}
