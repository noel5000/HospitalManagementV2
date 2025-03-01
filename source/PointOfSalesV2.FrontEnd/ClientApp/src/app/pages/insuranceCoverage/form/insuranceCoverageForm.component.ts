

import { Component, OnInit , Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import {  AppRoles, ObjectTypes, ODataComparers, QueryFilter } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { HttpClient } from '@angular/common/http';
import { BaseService } from '../../../@core/services/baseService';
import { endpointUrl } from '../../../@core/common/constants';
import { AppConfig } from '../../../@core/services/app.config';


declare const $: any;
@Component({
    selector: "insuranceCoverage-form",
    templateUrl: "./insuranceCoverageForm.component.html",
})
export class insuranceCoverageFormComponent extends BaseComponent implements OnInit {

    _route:ActivatedRoute;
    service:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/InsuranceServiceCoverage`);
    insuranceService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/Insurance`);
    insurancePlanService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/InsurancePlan`);
    productService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/Product`);
    currencyService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/Currency`);
    insurances:any=[];
    insurancePlans:any=[];
    products:any[]=[];
    currencies:any[]=[];
    productPrices:number[]=[];


    constructor(@Inject('BASE_URL') private baseUrl: string,
        private config: AppConfig,
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private http:HttpClient,
        private modals:NgbModal,
       modalService:ModalService
        ){

            super(route, langService, AppRoles.Config_Insurance,modalService);
            this._route=router;
        this.itemForm = this.formBuilder.group({
            insuranceId: [null],
            id: [0],
            consultationPrice:[0],
            insurancePlanId:[null],
            coverageAmount:[0,[Validators.required,Validators.min(1)]],
            currencyId:[0,[Validators.required,Validators.min(1)]],
            productId:[0,[Validators.required,Validators.min(1)]],

        });
    }
    ngOnInit(): void {
     const urlId= parseInt( this._route.snapshot.paramMap.get('id'));
     if(!isNaN(urlId)){
        this.id=urlId;
        this.getItem(urlId);
     }
     else
     this.validateFormData();

        this.verifyUser();
        this.getInsurances();
        this.getCurrencies();
        this.getProducts();
        this.OnChanges();
    }

    setProductPrices(productId:number,currencyId:number){
        if(productId && !isNaN(productId) && currencyId && !isNaN(currencyId)){
        const product = this.products.find(x=>x.id==productId);
                    const principalCurrency = this.currencies.find(x=>x.isLocalCurrency);
                    const currency= this.currencies.find(x=>x.id==currencyId);
                    const rate =(principalCurrency && currency)? principalCurrency.exchangeRate/currency.exchangeRate:1;
                    if(product){
                        this.productPrices=[product.price * rate,product.price2 * rate,product.price3 * rate];
                        this.productPrices=this.productPrices.filter(x=>x && x>0);
                        if(this.productPrices.length==1)
                        this.itemForm.patchValue({consultationPrice:this.productPrices[0]})
                    }
                }
    }

    async OnChanges(){
        this.itemForm.get('productId').valueChanges.subscribe(val => {
            this.productPrices=[];
            const {currencyId}= this.itemForm.getRawValue();
            if(val){
                this.setProductPrices(val,currencyId);
            }
            });

            this.itemForm.get('currencyId').valueChanges.subscribe(val => {
                if(val){
                    const {productId}=this.itemForm.getRawValue();
                    this.setProductPrices(productId,val);
                }
                });

                this.itemForm.get('insuranceId').valueChanges.subscribe(val => {
                    if(val){
                        this.insurancePlans=[];
                        this.getInsurancePlans(val);
                        const {productId}=this.itemForm.getRawValue();
                        this.setProductPrices(productId,val);
                    }
                    });
    }

    async getProducts(){
        const filter=[
            {
                property: "IsService",
                value: "true",
                type: ObjectTypes.Boolean,
                comparer:ODataComparers.equals,
                isTranslated:false
            }as QueryFilter,

        ];

        this.productService.getAllFiltered(filter).subscribe(r=>{
            this.products=[{id:null,name:""}];
            this.products=this.products.concat(r["value"]);
            if(r["value"].length==1&& (!this.item || !this.item.productId))
            this.itemForm.patchValue({productId:r["value"][0].id});
            else
            this.itemForm.patchValue({
                productId: this.item?this.item.productId:null
            })
        })
    }


    async getInsurances(){

        this.insuranceService.getAll().subscribe(r=>{
            this.insurances=[{id:null,name:""}];
            this.insurances=this.insurances.concat(r.sort(this.dynamicSort('name')));
            if(r.length==1&& (!this.item || !this.item.insuranceId))
            this.itemForm.patchValue({insuranceId:r[0].id});

            else
            this.itemForm.patchValue({
                insuranceId: this.item?this.item.insuranceId:null
            })
        })
    }
    async getCurrencies(){

        this.currencyService.getAll().subscribe(r=>{
            this.currencies=[{id:null,name:""}];
            this.currencies=this.currencies.concat(r.sort(this.dynamicSort('name')));
            if(r.length==1 && (!this.item || !this.item.currencyId))
            this.itemForm.patchValue({currencyId:r[0].id});
            else
            this.itemForm.patchValue({
               currencyId: this.item?this.item.currencyId:null
            })

        })
    }
    async getInsurancePlans(id:number){
        const filter=[
            {
                property: "InsuranceId",
                value: id.toString(),
                type: ObjectTypes.Number,
                comparer:ODataComparers.equals,
                isTranslated:false
            }as QueryFilter,

        ];

        this.insurancePlanService.getAllFiltered(filter).subscribe(r=>{
            this.insurancePlans=[{id:null,name:""}];
            this.insurancePlans=this.insurancePlans.concat(r["value"].sort(this.dynamicSort('name')));
            if(r["value"].length==1&& (!this.item || !this.item.insurancePlanId))
            this.itemForm.patchValue({insurancePlanId:r["value"][0].id});

            else
            this.itemForm.patchValue({
                insurancePlanId: this.item.insurancePlanId
            })
        })
    }

   async getItem(id:number){
    this.service.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
            this.itemForm.patchValue({
                insuranceId: this.item.insuranceId,
                id: this.item.id,
                currencyId:this.item.currencyId,
                insurancePlanId:this.item.insurancePlanId,
                coverageAmount:this.item.coverageAmount,
                productId:this.item.productId,
                consultationPrice:this.item.consultationPrice

            });

        }
        this.validateFormData();
    })
    }
    get form() { return this.itemForm.controls; }
    save(){
        if (this.itemForm.invalid) {
            return;
        }
      this.item = this.itemForm.value ;

           if(!this.item)
           this.item = {active:true};

        this.item.insuranceId=this.item.insuranceId?parseInt(this.item.insuranceId):null;
        this.item.insurancePlanId=this.item.insurancePlanId?parseInt(this.item.insurancePlanId):null;
        this.item.currencyId=this.item.currencyId?parseInt(this.item.currencyId):null;
        this.item.active=true;
            const subscription = this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/insuranceCoverage');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/insuranceCoverage');
    }
}
