import { NgModule } from '@angular/core';
import { LanguageService } from './../../@core/services/translateService';
import { SecurityService } from './../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';
import { TaxService } from '../../@core/services/TaxService';
import { CurrencyService } from '../../@core/services/CurrencyService';
import { UnitService } from '../../@core/services/UnitService';
import { SupplierService } from '../../@core/services/supplierService';
import { HttpClient } from '@angular/common/http';
import { BranchOfficeService } from '../../@core/services/branchOfficeService';
import { CustomerService } from '../../@core/services/CustomerService';
import { SchoolService } from '../../@core/services/SchoolService';
import { QuotesIndexComponent } from './index/quotesIndex.component';
import { QuotesFormComponent } from './form/quotesForm.component';


const routes: Routes = [
    {
        path: "",
        component: QuotesIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: QuotesFormComponent
    },
    {
        path: "edit/:id",
        component: QuotesFormComponent
    },
];

@NgModule({

    declarations: [QuotesFormComponent, QuotesIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        ModalService,
        CurrencyService,
        CustomerService,
        BranchOfficeService,
        SchoolService
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


export class quotesModule {

}