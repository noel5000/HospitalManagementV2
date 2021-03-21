import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, ObjectTypes, QueryFilter } from '../../../@core/common/enums';
import { LanguageService } from '../../../@core/services/translateService';
import { ActivatedRoute, Router } from '@angular/router';
import { basename } from 'path';
import {IPaginationModel, IActionButtonModel } from '../../../@theme/components/pagination/pagination.component';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { NgbdModalConfirmAutofocus } from '../../../@theme/components/modal/modal.component';
import { ModalService } from '../../../@core/services/modal.service';
import { BaseService } from '../../../@core/services/baseService';
import { endpointUrl } from '../../../@core/common/constants';
import { HttpClient } from '@angular/common/http';
import { Customer } from '../../../@core/data/customer';
import { CustomerService } from '../../../@core/services/CustomerService';

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
    service:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}PatientCheckUp`);
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


    constructor(
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
        router: ActivatedRoute,
        private customerService:CustomerService,
       modalService:ModalService,
       private  http: HttpClient,
    ) {
        super(route, langService, AppSections.PatientCheckup,modalService);
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
   

    addNew() {
        this.router.navigateByUrl(`pages/patientcheckup/add/${this.patientId}/${this.appointmentId}`);
    }
    getCheckupDetails(e:any) {
        this.router.navigateByUrl(`pages/patientcheckup/edit/${e.patientId}/${e.appointmentId}/${e.id}`);
    }
    editCheckup(e:any) {
        this.router.navigateByUrl(`pages/patientcheckup/edit/${e.patientId}/${e.appointmentId}/${e.id}`);
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