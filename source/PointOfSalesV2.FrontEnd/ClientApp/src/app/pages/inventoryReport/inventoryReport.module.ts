import { NgModule , Inject } from '@angular/core';
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
import { InventoryReportIndexComponent } from './index/inventoryReportIndex.component';
import { ProductService } from '../../@core/services/ProductService';
import { BranchOfficeService } from '../../@core/services/branchOfficeService';
import { WarehouseService } from '../../@core/services/WarehouseService';


const routes: Routes = [
    {
        path: "",
        component: InventoryReportIndexComponent,
        pathMatch: "full"
    },
];

@NgModule({

    declarations: [InventoryReportIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        ProductService,
        ModalService,
        BranchOfficeService,
        WarehouseService
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


export class InventoryReportModule {

}