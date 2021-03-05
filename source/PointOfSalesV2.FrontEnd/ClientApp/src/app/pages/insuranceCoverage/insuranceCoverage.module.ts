import { NgModule } from '@angular/core';
import { insuranceCoverageIndexComponent } from './index/insuranceCoverageIndex.component';
import { insuranceCoverageFormComponent } from './form/insuranceCoverageForm.component';
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


const routes: Routes = [
    {
        path: "",
        component: insuranceCoverageIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: insuranceCoverageFormComponent
    },
    {
        path: "edit/:id",
        component: insuranceCoverageFormComponent
    },
];

@NgModule({

    declarations: [insuranceCoverageFormComponent, insuranceCoverageIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
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


export class insuranceCoverageModule {

}