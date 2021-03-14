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
import { ZoneService } from '../../@core/services/zoneService';
import { patientCheckupIndexComponent } from './index/patientCheckupIndex.component';
import { patientCheckupFormComponent } from './form/patientCheckupForm.component';


const routes: Routes = [
    {
        path: ":patientid/:appointmentid",
        component: patientCheckupIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add/:patientid/:appointmentid",
        component: patientCheckupFormComponent
    },
    {
        path: "edit/:id",
        component: patientCheckupFormComponent
    },
];

@NgModule({

    declarations: [patientCheckupFormComponent, patientCheckupIndexComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        ModalService,
        ZoneService
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


export class PatientCheckupModule {

}