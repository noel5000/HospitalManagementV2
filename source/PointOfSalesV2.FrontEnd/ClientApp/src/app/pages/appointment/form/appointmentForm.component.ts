

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, QueryFilter, ObjectTypes, ODataComparers, BillingStates } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { Currency } from '../../../@core/data/currencyModel';
import { Unit } from '../../../@core/data/unitModel';
import { Supplier } from '../../../@core/data/Supplier';
import { Tax } from '../../../@core/data/taxModel';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { CurrencyService } from '../../../@core/services/CurrencyService';
import { UnitService } from '../../../@core/services/UnitService';
import { SupplierService } from '../../../@core/services/supplierService';
import { TaxService } from '../../../@core/services/TaxService';
import { endpointUrl } from '../../../@core/common/constants';
import { BranchOfficeService } from '../../../@core/services/branchOfficeService';
import { BranchOffice } from '../../../@core/data/branchOffice';
import { Warehouse } from '../../../@core/data/Warehouse';
import { Product } from '../../../@core/data/product';
import { WarehouseService } from '../../../@core/services/WarehouseService';
import { ProductService } from '../../../@core/services/ProductService';
import { Item } from '../../../@core/data/itemModel';
import { SchoolService } from '../../../@core/services/SchoolService';
import { School } from '../../../@core/data/school';
import { CustomerService } from '../../../@core/services/CustomerService';
import { Customer } from '../../../@core/data/customer';


declare const $: any;
@Component({
    selector: "invoice-lead-form",
    templateUrl: "./appointmentForm.component.html",
    styleUrls: ["../appointmentStyles.component.scss"]
})
export class appointmentFormComponent extends BaseComponent implements OnInit {
    itemForm: FormGroup;
    item: any;
    medicalSpecialities:any[]=[];
    doctorId:number=0;
    patientId:number=0;
    customers:Customer[]=[];
    branchOfficeId:number=0;
    warehouseId:number=0;
    currentDate:string='';
    _route:ActivatedRoute;
    products:Product[]=[];//
    productUnits:any[]=[];//
    productTaxes:any[]=[];//
    doctors:any[]=[];
    patients:any[]=[];
    defaultTaxAmountValidator:FormControl=new FormControl(0,[ Validators.required,Validators.min(0.0001)]);
    defaultUnitValidator:FormControl=new FormControl(null,[ Validators.required,Validators.min(1)]);
    currentProductCost:any={cost:0};
    currentProductPrice:any={sellingPrice:0,costPrice:0};
    medicalSpecialityService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}MedicalSpeciality`);
    appointmentService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Appointment`);
    userService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}User`);
    productUnitService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}ProductUnit`);
    productTaxService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}ProductTax`);
    insuranceCoverageService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}InsuranceServiceCoverage`);
   

    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        private customerService:CustomerService,
        langService: LanguageService,
        private modals:NgbModal,
        private schoolService:SchoolService,
        private productService:ProductService,
         modalService:ModalService,
      private  http: HttpClient
        ){
           
            super(route, langService, AppSections.Users,modalService);
            this._route=router;
          
            this.doctorId =parseInt( this._route.snapshot.paramMap.get('doctorid'))>0?parseInt( this._route.snapshot.paramMap.get('doctorid')):0;
            this.patientId =parseInt( this._route.snapshot.paramMap.get('patientid'))>0?parseInt( this._route.snapshot.paramMap.get('patientid')):0;
            this.currentDate = this._route.snapshot.paramMap.get('date');
         
        this.itemForm = this.formBuilder.group({
id: [0],
date:[this.currentDate,[Validators.required]],
medicalSpecialityId:[null,[ Validators.required,Validators.min(0), Validators.max(4)]],
doctorId:[this.doctorId,[ Validators.required,Validators.min(1), Validators.max(5)]],
patientId:[this.patientId,[ Validators.required,Validators.min(1), Validators.max(5)]],
productId:[null,[ Validators.required,Validators.min(1)]],
beforeTaxesAmount:[0],
taxesAmount:[0],
totalAmount:[0],
insuranceCoverageAmount:[0],
patientPaymentAmount:[0],
currencyId:[0],
currencyCode:[''],
sequence:[''],
        });
    }
    ngOnInit(): void {
   
     this.onChanges();
        this.verifyUser();
        this.getProducts();
       
    }


    async GetProductUnits(id:number){
        const filter = [{
            property: 'ProductId',
            value: id.toString(),
            type: ObjectTypes.Number,
            isTranslated:false
        } as QueryFilter,
        {
            property: "Unit",
            value: "Id,Name",
            type: ObjectTypes.ChildObject,
            isTranslated: false
        } as QueryFilter
    ]
        this.productUnitService.getAllFiltered(filter).subscribe(r=>{
            this.productUnits=[{id:0, unitId:0,unit:{id:0, name:''},sellingPrice:0, costPrice:0}];
            this.productUnits=this.productUnits.concat( r['value']);
        });
    }

    async GetProductTaxes(id:number){
        const filter = [{
            property: 'ProductId',
            value: id.toString(),
            type: ObjectTypes.Number,
            isTranslated:false
        } as QueryFilter,
        {
            property: "Tax",
            value: "Id,Name,Rate",
            type: ObjectTypes.ChildObject,
            isTranslated: false
        } as QueryFilter
    ]
        this.productTaxService.getAllFiltered(filter).subscribe(r=>{
            this.productTaxes=r['value'];
        });
    }

    CalculateProductTax():number{
        const {productPrice}= this.itemForm.getRawValue();
        return this.productTaxes.length<=0?0:this.productTaxes.reduce(function(a,b){return a+(b.tax.rate*productPrice)},0);
    }

    

    async GetProductCost(productId:number){
        const currentProduct = this.products.find(x=>x.id==productId);
        this.currentProductCost.cost=currentProduct.cost;
        const {unitId} = this.itemForm.getRawValue();
        this.currentProductPrice.sellingPrice= unitId && unitId>0 && this.productUnits.length>0?this.productUnits.find(x=>x.unitId==unitId).sellingPrice: currentProduct.price;
        this.refreshAmounts();
    }

  

    async getProducts(){
        const filter = [
        {
            property: "Currency",
            value: "Id,Name,Code,ExchangeRate",
            type: ObjectTypes.ChildObject,
            isTranslated: false
        } as QueryFilter,
        {
            property: "IsService",
            value: "1",
            type: ObjectTypes.Boolean,
            isTranslated: false,
            comparer: ODataComparers.equals
        } as QueryFilter
    ]
        this.productService.getAllFiltered(filter).subscribe(r=>{
            this.products=[{id:0, name:''} as Product];
            this.products=this.products.concat( r['value']);
        });
    }

  
    onChanges(): void {
      

         
            this.itemForm.get('taxAmount').valueChanges.subscribe(val => {
               
                    this.refreshAmounts(true);
                
                });
             

              

         
        this.itemForm.get('productId').valueChanges.subscribe(val => {
            if(val && val>0){
                const product= this.products.find(x=>x.id==val);
                this.itemForm.patchValue({currencyCode:product.currency.code})
            
                this.productTaxes=[];
                this.GetProductTaxes(val);
                this.GetProductCost(val);
            }
        });
      
      }
    
    get form() { return this.itemForm.controls; }

    verifyTotalAmount(){
        const calculatedAmount= this.itemForm.get('totalAmountCalc')?this.itemForm.get('totalAmountCalc').value:0;
        const total= this.itemForm.get('totalAmount')?this.itemForm.get('totalAmount').value:0;
      
    }
    save(){
       
        let form = this.itemForm.getRawValue() as any;
           form.warehouseId=form.warehouseId==0?null:form.warehouseId;
         
           form.state=!form.state?(form.inventoryModified?BillingStates.Generated:BillingStates.GeneratedWithoutInventory):form.state;
            const subscription =window.location.href.split('/').findIndex(x=>x.toLowerCase()=='add')>=0? this.appointmentService.post(form,"",""):this.appointmentService.put(form,"","");
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.router.navigateByUrl('pages/appointment');
               }
               else
               this.modalService.showError(r.message);
           })
    }

  

    cancel(){
    this.router.navigateByUrl('pages/appointment');
    }

  

  

    setDetailFormAmount(index:number,quantity:number){
        if(!this.itemForm.contains(`unitQuantity_${index}`))
        this.itemForm.addControl(`unitQuantity_${index}`,new FormControl(quantity,[ Validators.required,Validators.min(0.0001)]));
    }
    refreshAmounts(fromForm:boolean=false){
    
        let {productPrice,productCost,quantity,unitId,beforeTaxesAmount, totalAmount, taxesAmount} = this.itemForm.getRawValue() as any;

       const equivalence =unitId && unitId>0? this.productUnits.find(x=>x.unitId==unitId).equivalence:1;
            productCost=fromForm?productCost:this.currentProductCost.cost>0?(this.currentProductCost.cost/equivalence):productCost;
            productPrice=fromForm?productPrice:this.currentProductPrice.sellingPrice>0?(this.currentProductPrice.sellingPrice/equivalence):productPrice;
            beforeTaxesAmount= quantity * productCost;
            taxesAmount=this.CalculateProductTax() * quantity;
            totalAmount= beforeTaxesAmount + taxesAmount;
            this.itemForm.patchValue({
                productCost,
                beforeTaxesAmount,
                totalAmount,
                productPrice,
                taxesAmount
            })
        
            
      
      
    }
}