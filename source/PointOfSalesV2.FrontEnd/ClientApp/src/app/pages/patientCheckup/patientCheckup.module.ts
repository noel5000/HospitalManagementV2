import { NgModule , Inject } from '@angular/core';
import { LanguageService } from './../../@core/services/translateService';
import { SecurityService } from './../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule, NbAccordionItemComponent, NbAccordionModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';
import { ZoneService } from '../../@core/services/zoneService';
import { patientCheckupIndexComponent } from './index/patientCheckupIndex.component';
import { patientCheckupFormComponent } from './form/patientCheckupForm.component';
import { ProductService } from '../../@core/services/ProductService';
import { CustomerService } from '../../@core/services/CustomerService';
import { UserService } from '../../@core/mock/users.service';
import { patientCheckupEditFormComponent } from './edit/patientCheckupEditForm.component';
import { FileUploadModule } from 'ng2-file-upload';


const routes: Routes = [
   
    {
        path: ":patientid/:appointmentid",
        component: patientCheckupIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add/:patientid/:appointmentid",
        component: patientCheckupFormComponent
    }, {
        path: "edit/:patientid/:appointmentid/:checkupid/:editing",
        component: patientCheckupEditFormComponent
    },
];

@NgModule({

    declarations: [patientCheckupFormComponent, patientCheckupIndexComponent,patientCheckupEditFormComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        ModalService,
        ProductService,
        CustomerService,
        UserService
    ],
    imports: [
        NbCardModule,
        NbAccordionModule,
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
        FormsModule,
        FileUploadModule,
    ],
})


export class PatientCheckupModule {

}