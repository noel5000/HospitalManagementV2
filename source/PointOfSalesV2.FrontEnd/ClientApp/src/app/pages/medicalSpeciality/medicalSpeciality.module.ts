import { NgModule , Inject } from '@angular/core';
import { medicalSpecialityIndexComponent } from './index/medicalSpecialityIndex.component';
import { medicalSpecialityFormComponent } from './form/medicalSpecialityForm.component';
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
        component: medicalSpecialityIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add",
        component: medicalSpecialityFormComponent
    },
    {
        path: "edit/:id",
        component: medicalSpecialityFormComponent
    },
];

@NgModule({

    declarations: [medicalSpecialityFormComponent, medicalSpecialityIndexComponent],
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


export class medicalSpecialityModule {

}