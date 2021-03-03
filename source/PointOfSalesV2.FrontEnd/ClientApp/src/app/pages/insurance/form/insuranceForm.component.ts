

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, ObjectTypes, ODataComparers, QueryFilter } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { BaseService } from '../../../@core/services/baseService';
import { TRNControl } from '../../../@core/data/trnControlModel';
import { TRNControlService } from '../../../@core/services/TRNControlService';
import { CurrencyService } from '../../../@core/services/CurrencyService';
import { Currency } from '../../../@core/data/currencyModel';
import { ZoneService } from '../../../@core/services/zoneService';
import { Zone } from '../../../@core/data/zoneModel';
import { endpointUrl } from '../../../@core/common/constants';
import { HttpClient } from '@angular/common/http';


declare const $: any;
@Component({
    selector: "insurance-form",
    templateUrl: "./insuranceForm.component.html",
    styleUrls: ["../insuranceStyles.component.scss"]
})
export class InsuranceFormComponent extends BaseComponent implements OnInit {

   
    insurancePlans:any[]=[];
    _route:ActivatedRoute;
    currencies:Currency[]=[];
    service:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Insurance`);
    insurancePlanService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}InsurancePlan`);

    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
        private  http: HttpClient,
        private zoneService:ZoneService,
        private trnService:TRNControlService,
        private currencyService:CurrencyService,
       modalService:ModalService
        ){
           
            super(route, langService, AppSections.Insurance,modalService);
            this._route=router;
        this.itemForm = this.formBuilder.group({
            name: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(50)]],
            phoneNumber: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(20)]],
            address: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(200)]],
            code: [''],
            accountNumber:[""],
            contact1:[""],
            contact2:[""],
            planName:[''],
            insurancePlanId:[0],
            contact3:[""],
            currencyId: [0,[Validators.required,Validators.min(1)]],
            id: [0]
        });
    }
    ngOnInit(): void {
     const urlId= parseInt( this._route.snapshot.paramMap.get('id'));
     if(!isNaN(urlId)){
        this.id=urlId;
        this.getItem(urlId);
        this.getPlans();
     }
     else
     this.validateFormData();
     
        this.verifyUser();
        this.getCurrencies();
    }

   async getItem(id:number){
    this.service.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
            this.itemForm.patchValue({
                id:this.item.id,
                name: this.item.name,
                phoneNumber: this.item.phoneNumber,
                address: this.item.address,
                code: this.item.code,
                currencyId: this.item.currencyId,
                accountNumber:this.item.accountNumber,
                contact1:this.item.contact1,
                contact2:this.item.contact2,
                contact3:this.item.contact3
            });

        }
        this.validateFormData();
    })
    }
addPlan(){
    const {planName,insurancePlanId} = this.itemForm.getRawValue();
    if(!planName)
    this.modalService.showError('nameRequired_error');
const toSave={
    name:planName,
    insuranceId:this.id,
    id:insurancePlanId,
    active:true
};
const subscription = insurancePlanId>0?this.insurancePlanService.put(toSave):this.insurancePlanService.post(toSave);
subscription.subscribe(r=>{
   if(r.status>=0){
    this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
    this.getPlans();
    this.itemForm.patchValue({planName:'',insurancePlanId:0})
   }
   else
   this.modalService.showError(r.message);
})

}
editPlan(id:number){
    const plan = this.insurancePlans.find(x=>x.id==id);
    this.itemForm.patchValue({planName:plan.name,insurancePlanId:plan.id});
}

onDeletePlanConfirm(event:number): void {
    var result =       this.modalService.confirmationModal({
               titleText:this.lang.getValueByKey('deleteConfirm_lbl'),
               bodyText:this.lang.getValueByKey('areYouSure_lbl'),
               cancelButtonText:this.lang.getValueByKey('cancel_btn'),
               okText:this.lang.getValueByKey('ok_btn'),
           });
     result.subscribe(r=>{
         if(r)
         this.deletePlan(event);
     })
      
       }
   
       deletePlan(id: number) {
           this.insurancePlanService.delete(id).subscribe(r => {
               if (r.status >= 0) {
                   this.modalService.showSuccess(this.lang.getValueByKey('success_msg'))
                   this.getPlans();
               }
               else
                this.modalService.showError(r.message);
           },
               error => {
                   this.modalService.showError();
               })
       }

getPlans(){
    if(this.id && this.id>0){
        this.insurancePlanService.getAllFiltered([
            {
                property: "InsuranceId",
                value: this.id.toString(),
                type: ObjectTypes.Number,
                comparer:ODataComparers.equals,
            } as QueryFilter
        ]).subscribe(r=>{
            this.insurancePlans = r['value'];
            
        },error=>{

        })
    }
}

    getCurrencies(){
        this.currencyService.getAll().subscribe(r=>{
            this.currencies=r;
            if(this.currencies.length==1)
            this.itemForm.patchValue({currencyId:this.currencies[0].id});
        });
    }

   
    get form() { return this.itemForm.controls; }
    save(){
        if (this.itemForm.invalid) {
            return;
        }
       const formValue = this.itemForm.value as any;
      
           if(!this.item)
           this.item = {};
           this.item=  this.updateModel<any>(formValue,this.item);;
           this.item.currencyId=parseInt(this.item.currencyId.toString());
            const subscription = this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/insurance');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/insurance');
    }
}