import { Component, OnInit , Inject } from '@angular/core';
import { BaseComponent } from '../../../@core/common/baseComponent';
import {  AppRoles, ObjectTypes, QueryFilter } from '../../../@core/common/enums';
import { LanguageService } from '../../../@core/services/translateService';
import { ActivatedRoute, Router } from '@angular/router';
import { basename } from 'path';
import {IPaginationModel, IActionButtonModel } from '../../../@theme/components/pagination/pagination.component';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { NgbdModalConfirmAutofocus } from '../../../@theme/components/modal/modal.component';
import { ModalService } from '../../../@core/services/modal.service';
import { BaseService } from '../../../@core/services/baseService';
import { endpointUrl, endpointViewsUrl } from '../../../@core/common/constants';
import { HttpClient } from '@angular/common/http';
import { Customer } from '../../../@core/data/customer';
import { CustomerService } from '../../../@core/services/CustomerService';
import { AppConfig } from '../../../@core/services/app.config';

declare const $: any;
@Component({
    selector: "patientCheckup-list",
    templateUrl: "./patientCheckupIndex.component.html",
    styleUrls: ["../patientCheckupStyles.component.scss"]
})
export class patientCheckupIndexComponent extends BaseComponent implements OnInit {
    ngOnInit(): void {
        this.verifyUser();
    }
    _route:ActivatedRoute;
    modalRef:NgbModalRef=null;
    service:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/PatientCheckUp`);
    tableConfig:IPaginationModel[]=[]
    actions:IActionButtonModel[]=[];
    pageNumber:number=1;
    pageSize:number=10;
    appointmentId:number=0;
    patientId:number=0;
    maxCount:number=0;
    filters: QueryFilter[] = [
        {
            property: "Zone",
            value: "Name",
            type: ObjectTypes.ChildObject,
            isTranslated:false
        },
    ];

    orderBy: string = 'Id';
    orderDirection: string = 'desc';
    patient:Customer= {} as Customer;
    patientCheckups:any[]=[];


    constructor(@Inject('BASE_URL') private baseUrl: string,
        route: Router,
        private config: AppConfig,
        langService: LanguageService,
        private modals:NgbModal,
        router: ActivatedRoute,
        private customerService:CustomerService,
       modalService:ModalService,
       private  http: HttpClient,
    ) {
        super(route, langService, AppRoles.Patient_Checkup,modalService);
        this._route=router;
        let scope = this;
        this.patientId= parseInt( this._route.snapshot.paramMap.get('patientid'));
       this.appointmentId= parseInt( this._route.snapshot.paramMap.get('appointmentid'));
        this.getPatient(this.patientId);
        this.getPatientCheckups(this.patientId);

    }

  async getPatient(id:number){
    if(id>0){
        this.customerService.getById(id).subscribe(r=>{
            if(r.status<0)
            this.modalService.showError(r.message)
            else
            this.patient=r.data[0];
        })
    }
   }

  async getPatientCheckups(id:number){
    if(id>0){
        this.service.getByUrlParameters(["GetPatientHistory",id.toString()]).subscribe(r=>{
            if(r.status>=0){
                this.patientCheckups=r.data;
            }
            else
            this.modalService.showError(r.message);
        })
    }
   }

   async printCheckup(id:number){
    this.service.getById(id).subscribe(r=>{
        try{
            if(r.status>=0){
                const checkup=r.data[0];
                const selectedMedicines=checkup.checkupPrescriptions.filter(x=>x.type=="M");
                const selectedLabTests=checkup.checkupPrescriptions.filter(x=>x.type=="L");
                const selectedConsultations=checkup.checkupPrescriptions.filter(x=>x.type=="C");
                const selectedImages=checkup.checkupPrescriptions.filter(x=>x.type=="E");
                const user = JSON.parse(localStorage.getItem("currentUser"));

                if(selectedMedicines && selectedMedicines.length>0)
                window.open(`${this.baseUrl}views/CheckupMedicationsPrint?id=${checkup.id}&language=${user.languageId}`, "_blank");


               if(selectedLabTests && selectedLabTests.length>0)
               window.open(`${this.baseUrl}views/CheckupLabTestsPrint?id=${checkup.id}&language=${user.languageId}`, "_blank");


               if(selectedConsultations && selectedConsultations.length>0)
               window.open(`${this.baseUrl}views/CheckupConsultationsPrint?id=${checkup.id}&language=${user.languageId}`, "_blank");


               if(selectedImages && selectedImages.length>0)
               window.open(`${this.baseUrl}views/CheckupSpecializedImagesPrint?id=${checkup.id}&language=${user.languageId}`, "_blank");

            }
        }
        catch(ex){
console.log(ex);
        }

    });
   }


    addNew() {
        this.router.navigateByUrl(`pages/patientcheckup/add/${this.patientId}/${this.appointmentId}`);
    }

    editAppointment() {
        this.router.navigateByUrl(`pages/appointment/edit/${this.appointmentId}/1`);
    }
    getCheckupDetails(e:any) {
        this.router.navigateByUrl(`pages/patientcheckup/edit/${e.patientId}/${this.appointmentId}/${e.id}/0`);
    }
    editCheckup(e:any) {
        this.router.navigateByUrl(`pages/patientcheckup/edit/${e.patientId}/${e.appointmentId}/${e.id}/1`);
    }

    source:any={};
    onDeleteConfirm(event:any): void {
 var result =       this.modalService.confirmationModal({
            titleText:this.lang.getValueByKey('deleteConfirm_lbl'),
            bodyText:this.lang.getValueByKey('areYouSure_lbl'),
            cancelButtonText:this.lang.getValueByKey('cancel_btn'),
            okText:this.lang.getValueByKey('ok_btn'),
        });
  result.subscribe(r=>{
      if(r)
      this.delete(event.id);
  })

    }

    delete(id: number) {
        this.service.delete(id).subscribe(r => {
            if (r.status >= 0) {
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'))

            }
            else
             this.modalService.showError(r.message);
        },
            error => {
                this.modalService.showError();
            })
    }
}
