import { NgModule , Inject } from '@angular/core';
import { LanguageService } from './../../@core/services/translateService';
import { SecurityService } from './../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { CustomerService } from './../../@core/services/CustomerService';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';
import { CurrencyService } from '../../@core/services/CurrencyService';
import { TRNControlService } from '../../@core/services/TRNControlService';
import { InsuranceIndexComponent } from './index/insuranceIndex.component';
import { InsuranceFormComponent } from './form/insuranceForm.component';


const routes: Routes = [
    {
        path: "",
        component: InsuranceIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: InsuranceFormComponent
    },
    {
        path: "edit/:id",
        component: InsuranceFormComponent
    },
];

@NgModule({

    declarations: [InsuranceFormComponent, InsuranceIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        TRNControlService,
        CurrencyService,
        ModalService
    ],
    imports: [
        NbCardModule,
        NgbDropdownModule,
        NgbAlertModule,
        NbIconModule,
        NbInputModule,
        ThemeModule,
        CommonModule,
        RouterModule.forChild(routes),
        ReactiveFormsModule,
        FormsModule,
        TranslateModule,
    ],
})


export class InsuranceModule {

}