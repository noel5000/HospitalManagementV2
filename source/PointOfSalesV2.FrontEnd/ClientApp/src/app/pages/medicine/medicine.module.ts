import { NgModule , Inject } from '@angular/core';
import { LanguageService } from '../../@core/services/translateService';
import { SecurityService } from '../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { ProductService } from '../../@core/services/ProductService';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';
import { TaxService } from '../../@core/services/TaxService';
import { CurrencyService } from '../../@core/services/CurrencyService';
import { UnitService } from '../../@core/services/UnitService';
import {MedicineIndexComponent} from './index/medicineIndex.component'
import {MedicineFormComponent} from './form/medicineForm.component'
import { SupplierService } from '../../@core/services/supplierService';
import { HttpClient } from '@angular/common/http';


const routes: Routes = [
    {
        path: "",
        component: MedicineIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: MedicineFormComponent
    },
    {
        path: "edit/:id",
        component: MedicineFormComponent
    },
];

@NgModule({

    declarations: [MedicineFormComponent, MedicineIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        ProductService,
        ModalService,
        CurrencyService,
        TaxService,
        UnitService,
        SupplierService
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


export class MedicineModule {

}