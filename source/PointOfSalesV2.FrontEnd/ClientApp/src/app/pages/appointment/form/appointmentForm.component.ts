

import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
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
    doctorId:number=null;
    hospitals:BranchOffice[]=[];
    patientId:number=0;
    customers:Customer[]=[];
    branchOfficeId:number=0;
    warehouseId:number=0;
    currentDate:string='';
    _route:ActivatedRoute;
    types:any[]=[
        {
            id:'C',
            name:this.lang.getValueByKey('medicalConsultation_lbl')
        },
        {
            id:'L',
            name:this.lang.getValueByKey('laboratory_lbl')
        },
        {
            id:'E',
            name:this.lang.getValueByKey('especializedImages_lbl')
        }
    ];
    products:Product[]=[];//
    productUnits:any[]=[];//
    productTaxes:any[]=[];//
    doctors:any[]=[];
    patients:any[]=[];
    defaulttaxesAmountValidator:FormControl=new FormControl(0,[ Validators.required,Validators.min(0.0001)]);
    defaultUnitValidator:FormControl=new FormControl(null,[ Validators.required,Validators.min(1)]);
    currentProductCost:any={cost:0};
    currentProductPrice:any={sellingPrice:0,costPrice:0};
    medicalSpecialityService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}MedicalSpeciality`);
    appointmentService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Appointment`);
    userService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}User`);
    productUnitService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}ProductUnit`);
    productTaxService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}ProductTax`);
    insuranceService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}InsuranceServiceCoverage`);
   

    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        private changes:ChangeDetectorRef,
        route: Router,
        private branchOfficeService:BranchOfficeService,
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
          
            this.doctorId =parseInt( this._route.snapshot.paramMap.get('doctorid'))>0?parseInt( this._route.snapshot.paramMap.get('doctorid')):null;
            this.patientId =parseInt( this._route.snapshot.paramMap.get('patientid'))>0?parseInt( this._route.snapshot.paramMap.get('patientid')):0;
            const dateFromUrl=new Date(this._route.snapshot.paramMap.get('date'));
            let month= (dateFromUrl.getMonth()+1).toString();
            month=month.length>1?month:`0${month}`;
            let day= (dateFromUrl.getDate()).toString();
            day=day.length>1?day:`0${day}`;
            this.currentDate = `${dateFromUrl.getFullYear()}-${month}-${day}T00:00:00`;
         
        this.itemForm = this.formBuilder.group({
id: [0],
date:[this.currentDate,[Validators.required]],
medicalSpecialityId:[null,[ Validators.required,Validators.min(1)]],
doctorId:[this.doctorId],
patientId:[this.patientId,[ Validators.required,Validators.min(1)]],
productId:[null,[ Validators.required,Validators.min(1)]],
insuranceId:[null],
insurancePlanId:[null],
beforeTaxesAmount:[0],
taxesAmount:[0],
productCost:[0],
productPrice:[0],
totalAmount:[0],
insuranceCoverageAmount:[0],
insuranceName:[""],
insurancePlanName:[""],
patientPaymentAmount:[0],
currencyId:[null,[Validators.required, Validators.min(1)]],
hospitalId:[null,[Validators.required, Validators.min(1)]],
currencyName:[''],
type:[null,[Validators.required]],
sequence:[''],
        });
    }
    ngOnInit(): void {
   
     this.onChanges();
        this.verifyUser();
        this.getEspecialities();
        this.getPatients();
        this.getHospitals();
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
         const taxesAmount=   this.CalculateProductTax();
         this.itemForm.patchValue({taxesAmount});
         this.refreshAmounts(false);
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

    async getProducts(medicalSpecialityId:number, type:string='C'){
        let filter = [
        {
            property: "Currency",
            value: "Id,Name,Code,ExchangeRate",
            type: ObjectTypes.ChildObject,
            isTranslated: false
        } as QueryFilter,
        {
            property: "IsService",
            value: "true",
            type: ObjectTypes.Boolean,
            isTranslated: false,
            comparer: ODataComparers.equals
        } as QueryFilter,
        
    ]
    if(medicalSpecialityId && medicalSpecialityId>0)
    filter.push({
        property: "MedicalSpecialityId",
        value: medicalSpecialityId.toString(),
        type: ObjectTypes.Number,
        isTranslated: false,
        comparer: ODataComparers.equals
    } as QueryFilter);
    if(type)
    filter.push(
    
        {
            property: "Type",
            value: type,
            type: ObjectTypes.String,
            isTranslated: false,
            comparer: ODataComparers.equals
        } as QueryFilter)
        this.productService.getAllFiltered(filter).subscribe(r=>{
            this.products=[{id:0, name:''} as Product];
            this.products=this.products.concat( r['value']);
        });
    }

    async getDoctors(specialityId:number, hospitalId:number){
        let filter :QueryFilter[]=[];
  
        if(specialityId && specialityId>0)
        filter.push(
          {
            property: "MedicalSpecialityId",
            value: specialityId.toString(),
            type: ObjectTypes.Number,
            isTranslated: false
        } as QueryFilter
        );
  
        if(hospitalId && hospitalId>0)
        filter.push(
          {
            property: "BranchOfficeId",
            value: hospitalId.toString(),
            type: ObjectTypes.Number,
            isTranslated: false
        } as QueryFilter
        )
        this.userService.getAllFiltered(filter).subscribe(r=>{
      
          this.doctors=r['value'];
          if(this.doctors.length==1)
          this.itemForm.patchValue({
            doctorId:this.doctors[0].userId
           });
        })
      }
    async getEspecialities(){
        this.medicalSpecialityService.getAll().subscribe(r=>{
            this.medicalSpecialities=[{id:null, name:""}];
            this.medicalSpecialities=this.medicalSpecialities.concat(r);
            if(r.length==1)
            this.itemForm.patchValue({medicalSpecialityId:r[0].id});
        });
    }

    async getHospitals(){
        this.branchOfficeService.getAll().subscribe(r=>{
            this.hospitals=[{id:null, name:""} as BranchOffice];
            this.hospitals=this.hospitals.concat(r);
            if(r.length==1)
            this.itemForm.patchValue({hospitalId:r[0].id});
        });
    }

    async getPatients(){

        const filter = [
            {
                property: "InsurancePlan",
                value: "Id,Name",
                type: ObjectTypes.ChildObject,
                isTranslated: false
            } as QueryFilter,
            {
                property: "Insurance",
                value: "Id,Name",
                type: ObjectTypes.ChildObject,
                isTranslated: false
            } as QueryFilter,
            {
                property: "Currency",
                value: "Id,Name",
                type: ObjectTypes.ChildObject,
                isTranslated: false
            } as QueryFilter,
          
        ]
            this.customerService.getAllFiltered(filter).subscribe(r=>{
                this.customers=[{id:null, name:""} as Customer];
                this.customers=this.customers.concat(r["value"]);
                if(r["value"].length==1){
                    this.itemForm.patchValue({
                        patientId:r["value"][0].id,
                        insuranceId:r["value"][0].insuranceId,
                        insurancePlanId:r["value"][0].insurancePlanId,
                        insuranceName:r["value"][0].insurance?r["value"][0].insurance.name:'',
                        insurancePlanName:r["value"][0].insurancePlan?r["value"][0].insurancePlan.name:'',
                        currencyName:r["value"][0].currency?r["value"][0].currency.name:'',
                        currencyId:r["value"][0].currencyId,
                        insuranceCoverageAmount:0
                    });
                }
            });


        this.customerService.getAll().subscribe(r=>{
            this.customers=[{id:null, name:""} as Customer];
            this.customers=this.customers.concat(r);
            if(r.length==1){
                this.itemForm.patchValue({
                    patientId:r[0].id,
                    insuranceId:r[0].insuranceId,
                    insurancePlanId:r[0].insurancePlanId,
                    currencyId:r[0].currencyId
                });
            }
        });
    }

    onChanges(): void {
      

         
        this.itemForm.get('taxesAmount').valueChanges.subscribe(val => {
               
            this.refreshAmounts(true);
        
        });
    this.itemForm.get('beforeTaxesAmount').valueChanges.subscribe(val => {
       
            this.refreshAmounts(true);
        
        });
    this.itemForm.get('insuranceCoverageAmount').valueChanges.subscribe(val => {
       
            this.refreshAmounts(true);
        
        });

                this.itemForm.get('hospitalId').valueChanges.subscribe(val => {
               
                    const {medicalSpecialityId} = this.itemForm.getRawValue();
                    if(val && val>0 && medicalSpecialityId && medicalSpecialityId>0 )
                    this.getDoctors(medicalSpecialityId,val);
                
                });

                this.itemForm.get('medicalSpecialityId').valueChanges.subscribe(val => {
               
                    const {hospitalId,type} = this.itemForm.getRawValue();
                    if(hospitalId && hospitalId>0 ){
                        this.getProducts(val,type?type:'C');
                        this.getDoctors(val,hospitalId);
                    }
                    
        
                
                });

                this.itemForm.get('type').valueChanges.subscribe(val => {
               
                    const {hospitalId,medicalSpecialityId} = this.itemForm.getRawValue();
                    if( hospitalId && hospitalId>0 ){
                        this.getProducts(medicalSpecialityId,val);
                    }
                    
        
                
                });

                this.itemForm.get('patientId').valueChanges.subscribe(val => {
               
                   if(val && val>0){
                    const patient = this.customers.find(x=>x.id==val);
                    if(patient){
                        this.itemForm.patchValue({
                            insuranceId:patient.insuranceId,
                            insurancePlanId:patient.insurancePlanId,
                            insuranceName:patient.insurance?patient.insurance.name:'',
                            insurancePlanName:patient.insurancePlan?patient.insurancePlan.name:'',
                            currencyId:patient.currencyId,
                            currencyName:patient.currency?patient.currency.name:'',
                            insuranceCoverageAmount:0
                        });
                    }

                    const form = this.itemForm.getRawValue();
                    this.getInsuranceCoverage(form.productId,form.insuranceId,form.insurancePlanId);
                   }
                   else{
                    this.itemForm.patchValue({
                        insuranceId:null,
                        insurancePlanId:null,
                        insuranceName:'',
                        insurancePlanName:'',
                        currencyId:null,
                        currencyName:'',
                        insuranceCoverageAmount:0
                    });
                   }
                
                });
             

              

         
        this.itemForm.get('productId').valueChanges.subscribe(val => {
            if(val && val>0){
                const product= this.products.find(x=>x.id==val);
                this.itemForm.patchValue({
                    insuranceCoverageAmount:0,
                    beforeTaxesAmount:product.price,
                    totalAmount:0,
                    taxesAmount:0,
                    productPrice:product.price,
                })
            
                this.productTaxes=[];
                this.GetProductTaxes(val);
                const form = this.itemForm.getRawValue();
                this.getInsuranceCoverage(val,form.insuranceId,form.insurancePlanId);
               
            }
            else
            this.itemForm.patchValue({insuranceCoverageAmount:0})
        });
      
      }
    
    get form() { return this.itemForm.controls; }

    getInsuranceCoverage(productId:number,insuranceId:number=null,insurancePlanId:number=null){
        const form = this.itemForm.getRawValue();
        if(form.insuranceId || form.InsurancePlanId)
        this.insuranceService.getByUrlParameters(["GetInsuranceCoverage",productId.toString(),insuranceId?insuranceId.toString():'null',insurancePlanId?insurancePlanId.toString():'null'])
        .subscribe(r=>{
            if(r.status>=0){
                const coverage=r.data[0];
                this.itemForm.patchValue({insuranceCoverageAmount:coverage.coverageAmount});
                this.refreshAmounts(false);
            }
            else
            this.modalService.showError('error_msg');
        });
        else
        {
            this.itemForm.patchValue({insuranceCoverageAmount:0});
            this.refreshAmounts(false);
        }

    }

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
    
        let {productPrice,productCost,patientPaymentAmount,quantity,insuranceCoverageAmount,unitId,beforeTaxesAmount, totalAmount, taxesAmount} = this.itemForm.getRawValue() as any;
        quantity=!quantity?1:quantity;
       const equivalence =unitId && unitId>0? this.productUnits.find(x=>x.unitId==unitId).equivalence:1;
            productCost=fromForm?productCost:this.currentProductCost.cost>0?(this.currentProductCost.cost/equivalence):productCost;
            productPrice=fromForm?productPrice:this.currentProductPrice.sellingPrice>0?(this.currentProductPrice.sellingPrice/equivalence):productPrice;            
            taxesAmount=this.CalculateProductTax() * quantity;
            totalAmount= beforeTaxesAmount + taxesAmount;
            patientPaymentAmount= totalAmount - insuranceCoverageAmount;
            this.itemForm.patchValue({
                productCost,
                beforeTaxesAmount,
                totalAmount,
                productPrice,
                taxesAmount,
                patientPaymentAmount
            })
        
            
      
      
    }
}