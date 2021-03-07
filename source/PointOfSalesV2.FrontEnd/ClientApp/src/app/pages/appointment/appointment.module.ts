import { NgModule } from '@angular/core';
import { LanguageService } from './../../@core/services/translateService';
import { SecurityService } from './../../@core/services/securityService';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { BranchOfficeService } from './../../@core/services/branchOfficeService';
import { NbCardModule, NbTreeGridModule, NbIconModule, NbInputModule } from '@nebular/theme';
import { ThemeModule } from '../../@theme/theme.module';
import { NgbPaginationModule, NgbAlertModule, NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../@core/services/modal.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CalendarModule, DateAdapter } from 'angular-calendar';
import { adapterFactory } from 'angular-calendar/date-adapters/date-fns';
import { NgbModalModule } from '@ng-bootstrap/ng-bootstrap';
import { appointmentIndexComponent } from './index/appointmentIndex.component';
import { FlatpickrModule } from 'angularx-flatpickr';
import { MatMenuModule, MatButtonModule, MatButtonToggleModule } from '@angular/material';
import { WarehouseService } from '../../@core/services/WarehouseService';
import { appointmentFormComponent } from './form/appointmentForm.component';
import { SchoolService } from '../../@core/services/SchoolService';
import { appointmentPrintComponent } from './print/appointmentPrint.component';


const routes: Routes = [
    {
        path: "",
        component: appointmentIndexComponent,
        pathMatch: "full"
    },

    {
        path: "add/:menuid/:leadid/:schoolid/:branchofficeid/:warehouseid/:date",
        component: appointmentFormComponent
    },
    {
        path: "edit/:menuid/:leadid/:schoolid/:branchofficeid/:warehouseid/:date",
        component: appointmentFormComponent
    },
    {
        path: "print/:leadid/:menuid/:schoolid/:date/:sequence",
        component: appointmentPrintComponent
    },
];

@NgModule({

    declarations: [appointmentFormComponent, appointmentIndexComponent,appointmentPrintComponent],
    bootstrap: [],
    providers: [
        LanguageService,
        SecurityService,
        BranchOfficeService,
        WarehouseService,
        ModalService,
        SchoolService
    ],
    imports: [
        NbCardModule,
        MatMenuModule,
        MatButtonModule,
        MatButtonToggleModule,
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
        NgbModalModule,
        FlatpickrModule.forRoot(),
        CalendarModule.forRoot({
          provide: DateAdapter,
          useFactory: adapterFactory
        })
    ],
})


export class appointmentsModule {

}