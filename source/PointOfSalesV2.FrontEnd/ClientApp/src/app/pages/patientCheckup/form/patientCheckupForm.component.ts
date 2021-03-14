

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { ZoneService } from '../../../@core/services/zoneService';
import { Zone } from '../../../@core/data/zoneModel';
import { BaseService } from '../../../@core/services/baseService';
import { endpointUrl } from '../../../@core/common/constants';
import { HttpClient } from '@angular/common/http';


declare const $: any;
@Component({
    selector: "patientCheckup-form",
    templateUrl: "./patientCheckupForm.component.html",
    styleUrls: ["../patientCheckupStyles.component.scss"]
})
export class patientCheckupFormComponent extends BaseComponent implements OnInit {
 
    _route:ActivatedRoute;
    appointmentId:number=0;
    patientId:number=0;
    patient:any={};
    doctor:any={};
    appointment:any={};
    
    service:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}PatientCheckUp`);
    zones:Zone[]=[];
    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private zoneService:ZoneService,
        private modals:NgbModal,
        private  http: HttpClient,
       modalService:ModalService
        ){
           
            super(route, langService, AppSections.PatientCheckup,modalService);
            this._route=router;
        this.itemForm = this.formBuilder.group({
            name: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(50)]],
            phoneNumber: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(20)]],
            cardId: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(20)]],
            address: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(200)]],
            code: [''],
            zoneId: [0,[ Validators.required]],
            comissionRate: [0],
            comissionByProduct: [false],
            fixedComission: [false],
            id: [0]
        });
    }
    ngOnInit(): void {
     const urlId= parseInt( this._route.snapshot.paramMap.get('id'));
      this.patientId= parseInt( this._route.snapshot.paramMap.get('patientid'));
     this.appointmentId= parseInt( this._route.snapshot.paramMap.get('appointmentid'));
     if(!isNaN(urlId)){
        this.id=urlId;
        this.getItem(urlId);
     }
     else
     this.validateFormData();
     
        this.verifyUser();
        this.getZones();
    }

   async getItem(id:number){
    this.service.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
            this.itemForm.patchValue({
                name: this.item.name,
            phoneNumber: this.item.phoneNumber,
            cardId: this.item.cardId,
            address: this.item.address,
            code: this.item.code,
            zoneId: this.item.zoneId,
            comissionRate:this.item.comissionRate,
            comissionByProduct: this.item.comissionByProduct,
            fixedComission: this.item.fixedComission,
            id: this.item.id
            });

        }
        this.validateFormData();
    })
    }

    async getZones(){
        this.zoneService.getAll().subscribe(r=>{this.zones=r})
    }
    get form() { return this.itemForm.controls; }
    save(){
        if (this.itemForm.invalid) {
            return;
        }
       const formValue = this.itemForm.getRawValue();
      
           if(!this.item)
           this.item = {};
           this.item=  this.updateModel<any>(formValue,this.item);
           this.item.zoneId=parseInt(this.item.zoneId.toString());
            const subscription = this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/patientCheckup');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/patientCheckup');
    }
}