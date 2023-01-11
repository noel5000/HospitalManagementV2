

import { Component, OnInit , Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { CustomerService } from '../../../@core/services/CustomerService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, ObjectTypes, ODataComparers, QueryFilter } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { Customer } from '../../../@core/data/customer';
import { BaseService } from '../../../@core/services/baseService';
import { TRNControl } from '../../../@core/data/trnControlModel';
import { TRNControlService } from '../../../@core/services/TRNControlService';
import { CurrencyService } from '../../../@core/services/CurrencyService';
import { Currency } from '../../../@core/data/currencyModel';
import { ZoneService } from '../../../@core/services/zoneService';
import { Zone } from '../../../@core/data/zoneModel';
import { HttpClient } from '@angular/common/http';
import { endpointUrl } from '../../../@core/common/constants';
import { AppConfig } from '../../../@core/services/app.config';


declare const $: any;
@Component({
    selector: "customer-form",
    templateUrl: "./customerForm.component.html",
    styleUrls: ["../customerStyles.component.scss"]
})
export class CustomerFormComponent extends BaseComponent implements OnInit {

    insurances:any[]=[];
    insurancePlans:any[]=[];
    _route:ActivatedRoute;
    trnControls:TRNControl[]=[];
    currencies:Currency[]=[];
    bloodTypes:string[]=["A+","A-","B+","B-","O+","O-","AB+","AB-"];
    insuranceService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/Insurance`);
    insurancePlanService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/InsurancePlan`);

    constructor(@Inject('BASE_URL') private baseUrl: string,
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        private config: AppConfig,
        route: Router,
        langService: LanguageService,
        private service: CustomerService,
        private modals:NgbModal,
        private zoneService:ZoneService,
        private  http: HttpClient,
        private trnService:TRNControlService,
        private currencyService:CurrencyService,
       modalService:ModalService
        ){

            super(route, langService, AppSections.Customers,modalService);
            this._route=router;
        this.itemForm = this.formBuilder.group({
            name: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(50)]],
            phoneNumber: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(20)]],
            cardId: ['',[Validators.maxLength(20)]],
            address: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(200)]],
            bloodType: ['',[Validators.maxLength(4)]],
            code: [''],
            birthDate:['', [Validators.required]],
            insuranceCardId:[''],
            insuranceId:[null],
            currencyId: [0,[Validators.required,Validators.min(1)]],
            trnControlId: [0,[Validators.required,Validators.min(1)]],
            insurancePlanId:[null],
            invoiceDueDays: [0],
            billingAmountLimit: [0],
            creditAmountLimit: [0],
            id: [0],
            alergies: ['',[ Validators.maxLength(1000)]],
            bloodTransfusions: ['',[ Validators.maxLength(1000)]],
            familyIllnesses: ['',[ Validators.maxLength(1000)]],
            medications: ['',[ Validators.maxLength(1000)]],
            sc: [0],
            size: [0],
            surgeries: ['',[ Validators.maxLength(1000)]],
            weight:[0]
        });
    }
    ngOnInit(): void {
        this.onChanges();
        this.getInsurances();
     const urlId= parseInt( this._route.snapshot.paramMap.get('id'));
     if(!isNaN(urlId)){
        this.id=urlId;
        this.getItem(urlId);
     }
     else
     this.validateFormData();

        this.verifyUser();
        this.getTrnControls();
        this.getCurrencies();
    }
    onChanges(){
        this.itemForm.get('insuranceId').valueChanges.subscribe(val => {
            this.insurancePlans=[];
            this.itemForm.patchValue({insurancePlanId:null});
                this.getPlans(val);
        });

    }
   async getItem(id:number){
    this.service.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
            const dateObj = this.item.birthDate?new Date(this.item.birthDate):new Date();
            const dateObjString= `${dateObj.getFullYear()}-${(dateObj.getMonth()+1).toString().length<2?('0'+ (dateObj.getMonth()+1).toString()):(dateObj.getMonth()+1).toString()}-${(dateObj.getDate()).toString().length<2?('0'+ (dateObj.getDate()).toString()):(dateObj.getDate()).toString()}`
            this.itemForm.patchValue({
                id:this.item.id,
                name: this.item.name,
                phoneNumber: this.item.phoneNumber,
                cardId: this.item.cardId,
                address: this.item.address,
                birthDate:dateObjString,
                code: this.item.code,
                currencyId: this.item.currencyId,
                trnControlId: this.item.trnControlId,
                bloodType:this.item.bloodType,
                insuranceId:this.item.insuranceId,
                insurancePlanId:this.item.insurancePlanId,
                insuranceCardId:this.item.insuranceCardId,
                alergies: this.item.alergies,
                bloodTransfusions: this.item.bloodTransfusions,
                familyIllnesses: this.item.familyIllnesses,
                medications: this.item.medications,
                sc: this.item.sc,
                size: this.item.size,
                surgeries: this.item.surgeries,
                weight:this.item.weight
            });

        }
        this.validateFormData();
    })
    }
    getTrnControls(){
        this.trnService.getAll().subscribe(r=>{this.trnControls=r.sort(this.dynamicSort('name'))});
    }

    getCurrencies(){
        this.currencyService.getAll().subscribe(r=>{
            this.currencies=r.sort(this.dynamicSort('name'));
            if(this.currencies.length==1)
            this.itemForm.patchValue({currencyId:this.currencies[0].id});
        });
    }

    getPlans(id:number){
        if(id && id>0){
            this.insurancePlanService.getAllFiltered([
                {
                    property: "InsuranceId",
                    value: id.toString(),
                    type: ObjectTypes.Number,
                    comparer:ODataComparers.equals,
                } as QueryFilter
            ]).subscribe(r=>{
                this.insurancePlans = r['value'];

            },error=>{

            })
        }
    }

    getInsurances(){

            this.insuranceService.getAll().subscribe(r=>{
                this.insurances = [{name:'', id:null}]
               this.insurances=this.insurances.concat(r.sort(this.dynamicSort('name')));

            },error=>{

            })

    }


    get form() { return this.itemForm.controls; }
    save(){
        if (this.itemForm.invalid) {
            return;
        }
       const formValue = this.itemForm.value as Customer;

           if(!this.item)
           this.item = formValue;
           this.item=  this.updateModel<Customer>(formValue,this.item);
          this.item.active=true;
          this.item.insuranceId=formValue.insuranceId?parseInt(formValue.insuranceId.toString()):null;
          this.item.insurancePlanId=formValue.insurancePlanId?parseInt(formValue.insurancePlanId.toString()):null;
           this.item.trnType= this.trnControls.find(x=>x.id==this.item.trnControlId).type;
           this.item.currencyId=parseInt(this.item.currencyId.toString());
           this.item.trnControlId=parseInt(this.item.trnControlId.toString());
            const subscription = this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/customer');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/customer');
    }
}
