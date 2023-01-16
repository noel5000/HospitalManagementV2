import { Component , Inject } from '@angular/core';
import { BaseComponent } from './../../@core/common/baseComponent';
import { Router } from '@angular/router';
import { AppRoles } from '../../@core/common/enums';
import { LanguageService } from './../../@core/services/translateService';
import { ModalService } from '../../@core/services/modal.service';
import { SecurityService } from '../../@core/services/securityService';
@Component({
  selector: 'ngx-dashboard',
  templateUrl: './dashboard.component.html',
})
export class DashboardComponent extends BaseComponent {
  constructor(@Inject('BASE_URL') private baseUrl: string,
  route: Router, 
  lang: LanguageService,
  private securityService: SecurityService,
   modaService:ModalService) {
    super(route, lang, AppRoles.DashBoard,modaService);
  }

  permits:any={
    Config_Patients:AppRoles.Config_Patients,
    Appointments:AppRoles.Appointments,
    Invoices:AppRoles.Invoices,
    Invoices_Payments:AppRoles.Invoices_Payments
  }

  async navigate(e: string) {
    switch (e) {
      case 'patients':
        this.router.navigateByUrl(`pages/customer`);
        break;
      case 'appointments':
        this.router.navigateByUrl(`pages/appointment`);
        break;
      case 'invoices':
        this.router.navigateByUrl(`pages/invoice`);
        break;
      case 'payments':
        this.router.navigateByUrl(`pages/invoicepayment`);
        break;
    }
    
  }
}
