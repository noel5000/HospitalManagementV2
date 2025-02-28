import { Component, OnInit , Inject } from '@angular/core';
import { BaseComponent } from '../../../@core/common/baseComponent';
import {  AppRoles } from '../../../@core/common/enums';
import { LanguageService } from '../../../@core/services/translateService';
import { Router } from '@angular/router';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { FormBuilder} from '@angular/forms';
import { AppConfig } from '../../../@core/services/app.config';


declare const $: any;
@Component({
  standalone:false,
    selector: "company-state",
    templateUrl: "./companyStateIndex.component.html",
    styleUrls: ["../companyStateStyles.component.scss"]
})
export class CompanyStateIndexComponent extends BaseComponent implements OnInit {
    ngOnInit(): void {
        this.verifyUser();
        this.onChanges();
    }
    modalRef:NgbModalRef | null =null;
  service: BaseService<any,number>;
    result:any[]=[];


    constructor(@Inject('BASE_URL') private baseUrl: string,
        private config: AppConfig,
        route: Router,
        private formBuilder: FormBuilder,
        langService: LanguageService,
        private modals:NgbModal,
        private http:HttpClient,
       modalService:ModalService,
    ) {
        super(route, langService, AppRoles.Reports_ResultState,modalService);
        this.service = new BaseService<any,number>(this.http,`${this.baseUrl}api/CompanyState`);
        this.itemForm = this.formBuilder.group({
       startDate:[''],
       endDate:['']
        });
    }


override onChanges(){

    this.itemForm.get('startDate')!.valueChanges.subscribe(val => {
        this.getData();
    });
    this.itemForm.get('endDate')!.valueChanges.subscribe(val => {
        this.getData();
    });
}
    getData() {
        const filter = this.itemForm.getRawValue();
        this.service.getGenericByUrlParameters(['GetState',filter.startDate? filter.startDate.toString():'0',filter.endDate?filter.endDate.toString():'0',]).subscribe(r => {
            this.result=r['data'];
        },
            error => {
                 this.modalService.showError(`${this.lang.getValueByKey(error.message)}`);
            }
        )
    }






    getDataToExport() {
        const filter = this.itemForm.getRawValue();
        this.service.exportToExcel(filter,`ExportState/${filter.startDate? filter.startDate.toString():'0'}/${filter.endDate?filter.endDate.toString():'0'}`).subscribe(r => {

          this.service.downLoadFile(r,"application/ms-excel",`${this.lang.getValueByKey('resultState_menu')}`);

        },
            error => {
                 this.modalService.showError(`${this.lang.getValueByKey(error.message)}`);
            }
        )
    }



 print(){
    window.print();
}

exportToCSV(){
   this.getDataToExport();
}

}
