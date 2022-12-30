

import { Component, OnInit , Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators, Validator, FormControl } from '@angular/forms';
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
import { Customer } from '../../../@core/data/customer';
import { School } from '../../../@core/data/school';
import { CustomerService } from '../../../@core/services/customerService';
import { SchoolService } from '../../../@core/services/SchoolService';
import { Product } from '../../../@core/data/product';
import { ProductService } from '../../../@core/services/ProductService';
import { TRNControl } from '../../../@core/data/trnControlModel';
import { Seller } from '../../../@core/data/seller';
import { Warehouse } from '../../../@core/data/Warehouse';
import { TRNControlService } from '../../../@core/services/TRNControlService';
import { SellerService } from '../../../@core/services/SellerService';
import { WarehouseService } from '../../../@core/services/WarehouseService';
import { AppConfig } from '../../../@core/services/app.config';


declare const $: any;
@Component({
    selector: "invoice-form",
    templateUrl: "./invoiceForm.component.html",
    styleUrls: ["../invoiceStyles.component.scss"]
})
export class InvoiceFormComponent extends BaseComponent implements OnInit {

    hospitalId:number=0;
    warehouseId:number=0;
    currentDate:string='';
    productQuantity:number=0;
    showProductQuantity:boolean=false;
    _route:ActivatedRoute;
    localCurrency:Currency=null;
    products:Product[]=[];//
    patients:Customer[]=[];
    trnControls:TRNControl[]=[];
    sellers:Seller[]=[];
    productPrices:any[]=[];
    warehouses:Warehouse[]=[];
    productUnits:any[]=[];//
    productTaxes:any[]=[];//
    inventories=[];
    entries:any[]=[];
    defaultTaxAmountValidator:FormControl=new FormControl(0,[ Validators.required,Validators.min(0.0001)]);
    defaultUnitValidator:FormControl=new FormControl(null,[ Validators.required,Validators.min(1)]);
    currentProductCost:any={cost:0};
    currentProductPrice:any={sellingPrice:0,costPrice:0, equivalence:0};
    inventoryService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/Inventory`);
    creditNoteService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/CreditNote`);
    invoiceService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/Invoice`);
    menuService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/Menu`);
    currencyService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/Currency`);
    productUnitService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/ProductUnit`);
    productTaxService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/ProductTax`);
    medicalSpecialityService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/MedicalSpeciality`);
    appointmentService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/Appointment`);
    userService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/User`);
    insuranceService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/InsuranceServiceCoverage`);
    appointments:any[]=[];
    selectedAppointment:any=null;
    oldProductCost:number=0;
    oldProductPrice:number=0;
    selectedProductCurrency:Currency=null;
    isEditing:boolean=false;
    appointmentDetails:any[]=[];
    types:any[]=[

        {
            id:'L',
            name:this.lang.getValueByKey('laboratory_lbl')
        },
        {
            id:'E',
            name:this.lang.getValueByKey('especializedImages_lbl')
        },
        {
            id:'M',
            name:this.lang.getValueByKey('medicine_lbl')
        }
    ];
    medicalSpecialities:any[]=[];
    doctors:any[]=[];
    details:any[]=[];

    constructor(@Inject('BASE_URL') private baseUrl: string,
        private config: AppConfig,
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
        private productService:ProductService,
       modalService:ModalService,
      private  http: HttpClient,
      private patientService:CustomerService,
      private trnControlService:TRNControlService,
      private sellerService:SellerService,
      private warehouseService:WarehouseService
        ){

            super(route, langService, AppSections.Invoices,modalService);
            this.verifyUser();
            this.dataToBackup="entries,sellers,productUnits,productTaxes,inventories,warehouses,productPrices,currentProductCost,currentProductPrice,oldProductCost,oldProductPrice,selectedProductCurrency,isEditing";
            this._route=router;
            this.id=parseInt( this._route.snapshot.paramMap.get('id'))>0?parseInt( this._route.snapshot.paramMap.get('id')):0;
            this.isEditing=this.id && this.id>0;
            this.currentDate = new Date().toDateString();
            if( this.id && this.id>0){
                this.getCurrentInvoice(this.id);

            }
            else
            this.validateFormData();

           this.hospitalId=this.authModel.user.branchOfficeId;
           this.warehouseId=this.authModel.user.warehouseId;

        this.itemForm = this.formBuilder.group({
id: [0],
patientId:[{value:null, disabled:this.isEditing},[ Validators.required,Validators.min(1)]],
trnType:[{value:null, disabled:this.isEditing},[ Validators.required]],
nrc:[null],
productId:[null,[ Validators.required,Validators.min(1)]],
unitId:this.defaultUnitValidator,
branchOfficeId:[this.hospitalId],
warehouseId:[{value:null, disabled:this.isEditing}],
sellerId:[{value:null, disabled:this.isEditing}],
billingDate:[this.currentDate],
inventoryModified:[true],
discountRate:[{value:0, disabled:this.isEditing},[Validators.min(0),Validators.max(100)]],
discountAmount:[0],
currencyName:[''],
cashRegisterId:[0],
invoiceNumber:[''],
documentNumber:[''],
currencyId:[0],
active:[true],
exchangeRate:[0],
sellerRate:[0],
paidDate:[null],
receivedAmount:[0],
appliedCreditNote:[''],
cost:[0],
Month:[0],
appliedCreditNoteAmount:[{value:0, disabled:true}],
trn:[null],
trnControlId:[0],
details:[null],
state:[''],
quantity:[0,[ Validators.required,Validators.min(0.0001)]],
productCost:[0],
productPrice:[0],
selectedPrice:[0],
beforeTaxesAmount:[0],
paidAmount:[0],
returnedAmount:[0],
owedAmount:[0],
noTaxes:[false],
taxesAmount:[0],
totalAmount:[0],
free:[false],
medicalSpecialityId:[null],
type:[null],
appointmentId:[{value:null, disabled:this.isEditing}],
insuranceCoverageAmount:[0],
insuranceName:[""],
insurancePlanName:[""],
patientPaymentAmount:[0],
insuranceId:[null],
insurancePlanId:[null],
doctorId:[null]
        });
    }
    ngOnInit(): void {

     this.onChanges();
        this.verifyUser();
        this.getTrnControls();
        this.getWarehouses();
       this.getLocalCurrency();
       this.getEspecialities();
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


    setAdditionalBackupData(){
        for(let i=0; i<this.entries.length;i++){
            this.setDetailFormAmount(i,this.entries[i].quantity);
            this.setDetailFormDiscount(i,this.entries[i].discountRate);
            this.setDetailFormApprovalCode(i,this.entries[i].insuranceApprovalCode);
            this.setDetailFormNoCoverage(i,this.entries[i].noCoverage);
          }

          const {appointmentId} = this.itemForm.getRawValue();
          if(appointmentId)
          this.selectAppointment(appointmentId);
    }

    async getTrnControls(){

        this.trnControlService.getAll().subscribe(r=>{
            this.trnControls=[{id:0, name:''} as TRNControl];
            this.trnControls=this.trnControls.concat( r);
        });
    }

    async getWarehouses(){
        let filter = [

    ];

    const user = this.authModel.user;
    if(user.branchOfficeId)
    filter.push({
        property: 'BranchOfficeId',
        value: user.branchOfficeId.toString(),
        type: ObjectTypes.Number,
        isTranslated:false
    } as QueryFilter);


        this.warehouseService.getAllFiltered(filter).subscribe(r=>{
            this.warehouses=[{id:0, name:''} as Warehouse];
            this.warehouses= this.warehouses.concat((r['value'] as Warehouse[]).filter(x=>x.code!='DEF'));
        });
    }

    async getSellers(patientId:number){
        const patient = this.patients.find(x=>x.id==patientId);
        this.itemForm.patchValue({
            currencyId:patient.currencyId,
            currencyName:patient.currency.name,
            trnType:patient.trnType,
            nrc:patient.cardId,
            warehouseId:patient.warehouseId?patient.warehouseId:this.warehouseId
        })
        const filter = [{
            property: 'ZoneId',
            value:patient.zoneId? patient.zoneId.toString():0,
            type: ObjectTypes.Number,
            comparer:patient.zoneId?null:ODataComparers.NotEqual,
            isTranslated:false
        } as QueryFilter
    ]
        this.sellerService.getAllFiltered(filter).subscribe(r=>{
            this.sellers=[{id:0, name:''} as Seller];
            this.sellers= this.sellers.concat(r['value']);
        });
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
            this.productUnits=[{id:0, unitId:0,unit:{id:0, name:''},sellingPrice:0, costPrice:0, equivalence:0}];
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


    async GetDetailProductTaxes(index:number){
        let entry = this.entries[index];
        const filter = [{
            property: 'ProductId',
            value: entry.productId.toString(),
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
           const taxes=r['value'];
           entry.quantity = this.itemForm.getRawValue()[`unitQuantity_${index}`];
           entry.discountRate = this.itemForm.getRawValue()[`unitDiscountRate_${index}`];
           entry.beforeTaxesAmount= entry.quantity * entry.amount;
           entry.discountAmount = entry.beforeTaxesAmount /100 * entry.discountRate;
           entry.taxesAmount= taxes.length<=0?0:taxes.reduce(function(a,b){return a+(b.tax.rate*(entry.beforeTaxesAmount -entry.discountAmount))},0);
           entry.totalAmount = entry.beforeTaxesAmount + entry.taxesAmount- entry.discountAmount;
           this.entries[index]=entry;
        });
    }

    async getLocalCurrency(){
        const filter = [{
            property: 'IsLocalCurrency',
            value: 'true',
            type: ObjectTypes.Boolean,
            isTranslated:false
        } as QueryFilter
    ]
        this.currencyService.getAllFiltered(filter).subscribe(r=>{
          this.localCurrency=r['value'][0]
        });
    }

    async GetDetailDiscount(index:number){
        let entry = this.entries[index];
        entry.quantity = this.itemForm.getRawValue()[`unitQuantity_${index}`];
           entry.discountRate = this.itemForm.getRawValue()[`unitDiscountRate_${index}`];
           entry.discountAmount = entry.beforeTaxesAmount /100 * entry.discountRate;
           entry.beforeTaxesAmount= entry.quantity * entry.amount;
           entry.totalAmount = entry.beforeTaxesAmount + entry.taxesAmount - entry.discountAmount;
           this.entries[index]=entry;
    }

    CalculateProductTax():number{
        const {productPrice,discountRate}= this.itemForm.getRawValue();
        return this.productTaxes.length<=0?0:this.productTaxes.reduce(function(a,b){return a+(b.tax.rate*productPrice-(b.tax.rate*productPrice*discountRate/100))},0);
    }





    async GetProductCost(productId:number){
        const currentProduct = this.products.find(x=>x.id==productId);
        this.currentProductCost.cost=currentProduct.cost;
        const {unitId,productPrice} = this.itemForm.getRawValue();
        this.currentProductPrice.sellingPrice= unitId && unitId>0 && this.productUnits.length>0?currentProduct.price/this.productUnits.find(x=>x.unitId==unitId).equivalence: currentProduct.price;
        this.refreshAmounts();
    }



    async getProducts(medicalSpecialityId:number, type:string='C'){
        let filter = [
        {
            property: "Currency",
            value: "Id,Name,Code,ExchangeRate",
            type: ObjectTypes.ChildObject,
            isTranslated: false
        } as QueryFilter

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

    async getPatients(name:string){

        if(name){
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
                 value: "Id,Name, IsLocalCurrency",
                 type: ObjectTypes.ChildObject,
                 isTranslated: false
             } as QueryFilter
         ]
         if(name)
         filter.push( {
             property: "Name",
             value: name.toString(),
             type: ObjectTypes.String,
             isTranslated: false
         } as QueryFilter);

             this.patientService.getAllFiltered(filter).subscribe(r=>{
                 this.patients=[];
                 this.patients=this.patients.concat(r["value"]);

             });
        }
             else{
                 this.itemForm.patchValue({
                     customerId:null,
                     trnType:null,
                     currencyId:null,
                     trnControlId:null,
                    sellerId:null,
                    insuranceName:'',
                    insurancePlanName:'',
                    currencyName:'',
                    nrc:'',
                 });
                 this.refreshAmounts(false);
             }



     }

     async selectPatient(patient:any){
         if(patient){
           this.itemForm.patchValue({
            patientId:patient.id,
               trnType:patient.trnType,
               currencyId:patient.currencyId,
               currencyName:patient.currency.name,
               trnControlId:patient.trnControlId,
                insurancePlanName:patient.insurancePlan.name,
                insuranceName:patient.insurance.name,
                insuranceId:patient.insuranceId,
                insurancePlanId:patient.insurancePlanId,
                insuranceCoverageAmount:0
            })

         }
         else{
             this.itemForm.patchValue({
                customerId:null,
                trnType:null,
                currencyName:'',
                currencyId:null,
                trnControlId:null,
               sellerId:null,
               insuranceName:'',
               insurancePlanName:'',
               nrc:''

             });
             this.refreshAmounts(false);
         }


       }

    async getCreditNote(){
        const formVal= this.itemForm.getRawValue();
        const filter = [
        {
            property: "Sequence",
            value: formVal.appliedCreditNote,
            type: ObjectTypes.String,
            comparer:ODataComparers.equals,
            isTranslated: false
        } as QueryFilter,
        {
            property: "patientId",
            value: formVal.patientId,
            type: ObjectTypes.Number,
            comparer:ODataComparers.equals,
            isTranslated: false
        } as QueryFilter,
        {
            property: "Applied",
            value: "false",
            type: ObjectTypes.Boolean,
            comparer:ODataComparers.equals,
            isTranslated: false
        } as QueryFilter,

        {
            property: "CurrencyId",
            value: formVal.currencyId,
            type: ObjectTypes.Number,
            comparer:ODataComparers.equals,
            isTranslated: false
        } as QueryFilter
    ]
        this.creditNoteService.getAllFiltered(filter).subscribe(r=>{
            const result = r['value'][0];
            if(result)
            this.itemForm.patchValue({
                appliedCreditNoteAmount:result.amount
            });

        });
    }

    async getProductInventory(hospitalId:number,warehouseId:number=0,productId:number=0){

        let filter = [
            {
                property: "BranchOffice",
                value: "Name",
                type: ObjectTypes.ChildObject,
                isTranslated:false
            }  as QueryFilter,
            {
                property: "Warehouse",
                value: "Name,Code",
                type: ObjectTypes.ChildObject,
                isTranslated:true
            }  as QueryFilter,
            {
                property: "Unit",
                value: "Name",
                type: ObjectTypes.ChildObject,
                isTranslated:true
            }  as QueryFilter,
            {
                property: "Warehouse.Code",
                value: 'DEF',
                type: ObjectTypes.String,
                comparer:ODataComparers.NotEqual,
                isTranslated: false
            } as QueryFilter
        ];
    if(hospitalId)
    filter.push({
        property: "BranchOfficeId",
        value: hospitalId.toString(),
        type: ObjectTypes.Number,
        comparer:ODataComparers.equals,
        isTranslated: false
    } as QueryFilter);
    if(warehouseId)
    filter.push({
        property: "WarehouseId",
        value: warehouseId.toString(),
        type: ObjectTypes.Number,
        comparer:ODataComparers.equals,
        isTranslated: false
    } as QueryFilter);

    if(productId)
    filter.push({
        property: "ProductId",
        value: productId.toString(),
        type: ObjectTypes.Number,
        comparer:ODataComparers.equals,
        isTranslated: false
    } as QueryFilter)


        this.inventoryService.getAllFiltered(filter).subscribe(r=>{
            if(r['value'].length>0)
            this.inventories=r['value'];
            else
            this.modalService.showError('billingStateI_lbl');

        })
    }
    async getInventoryDescription():Promise<string>{
        let result ='';
        return result;
    }


    onChanges(): void {


           this.itemForm.get('quantity').valueChanges.subscribe(val => {
            if(val){
                this.refreshAmounts(true);
            }
            });

            this.itemForm.get('appliedCreditNote').valueChanges.subscribe(val => {
                if(val){
                    this.getCreditNote();
                }
                else
                this.itemForm.patchValue({appliedCreditNoteAmount:0});
                });

                this.itemForm.get('insuranceCoverageAmount').valueChanges.subscribe(val => {

                    this.refreshAmounts(true);

                });

            this.itemForm.get('discountRate').valueChanges.subscribe(val => {
                // if(val!=null && val<=100){
                //     for(let i=0; i<this.entries.length;i++){
                //         this.entries[i].discountRate=val;
                //         this.itemForm.get(`unitDiscountRate_${i}`).setValue(val);
                //         this.entries[i].discountAmount =this.entries[i].discountRate>1?( (val/100)* this.entries[i].beforeTaxesAmount):((val)* this.entries[i].beforeTaxesAmount);
                //         this.entries[i].totalAmount =  this.entries[i].beforeTaxesAmount +  this.entries[i].taxesAmount -  this.entries[i].discountAmount;
                //     }
                //    }
                });

                this.itemForm.get('branchOfficeId').valueChanges.subscribe(val => {

                    const {medicalSpecialityId} = this.itemForm.getRawValue();
                    if(val && val>0 && medicalSpecialityId && medicalSpecialityId>0 )
                    this.getDoctors(medicalSpecialityId,val);

                });

                this.itemForm.get('medicalSpecialityId').valueChanges.subscribe(val => {

                    const {branchOfficeId,type} = this.itemForm.getRawValue();
                    if(branchOfficeId && branchOfficeId>0 ){
                        this.getProducts(val,type?type:'C');
                        this.getDoctors(val,branchOfficeId);
                    }
                });

                this.itemForm.get('type').valueChanges.subscribe(val => {
                    this.products=[];
                    const {branchOfficeId,medicalSpecialityId} = this.itemForm.getRawValue();
                    this.itemForm.patchValue({productId:null,medicalSpecialityId:null,doctorId:null});


                        this.getProducts(medicalSpecialityId,val);




                });


            this.itemForm.get('unitId').valueChanges.subscribe(val => {


                if(val && val!="0"){
                    this.refreshAmounts();
                    const currentUnit = this.productUnits.find(x=>x.unitId==val);
                   const {productId,warehouseId,selectedPrice}= this.itemForm.getRawValue();
                   this.updateSelectedPrice(selectedPrice);


                }
                });

                this.itemForm.get('patientId').valueChanges.subscribe(val => {
                  //  this.resetForm(this.id>0?false:true);
                  this.appointments=[];
                    if(val && this.patients && this.patients.length>0){
                        this.getPatientAppointments();
                        const patient = this.patients.find(x=>x.id==val);
                        if(patient){
                            this.itemForm.patchValue({
                                trnControlId:   patient.trnControlId,
                                insuranceId:patient.insuranceId,
                                insurancePlanId:patient.insurancePlanId,
                                insuranceName:patient.insurance?patient.insurance.name:'',
                                insurancePlanName:patient.insurancePlan?patient.insurancePlan.name:'',
                                currencyId:patient.currencyId,
                                currencyName:patient.currency?patient.currency.name:'',
                                insuranceCoverageAmount:0,
                                nrc:patient.cardId,
                                appointmentId:null
                            });
                            this.removeEntries();

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

            this.itemForm.get('taxesAmount').valueChanges.subscribe(val => {

                    this.refreshAmounts(true);

                });

                this.itemForm.get('appointmentId').valueChanges.subscribe(val => {

                   if(val && val>0) {

                    this.selectAppointment(val);
                   }


                });
                this.itemForm.get('productCost').valueChanges.subscribe(val => {

                    if(val!=this.oldProductCost)
                    this.refreshAmounts(true);

                });

                this.itemForm.get('productPrice').valueChanges.subscribe(val => {

                    if(val!=this.oldProductPrice)
                    this.refreshAmounts(true);

                });

                this.itemForm.get('noTaxes').valueChanges.subscribe(val => {

                    if(val)
                   this.itemForm.setControl('taxesAmount',new FormControl(0))
                   else{
                    this.itemForm.setControl('taxesAmount',new FormControl(0));
                    this.refreshAmounts(true);
                   }

                });

                this.itemForm.get('selectedPrice').valueChanges.subscribe(val => {

                   if(val){
                     this.updateSelectedPrice(val);
                   }

                });

        this.itemForm.get('productId').valueChanges.subscribe(val => {
            if(val && val>0){
                const product= this.products.find(x=>x.id==val);
                this.inventories=[];
                this.productUnits=[];
                this.productPrices=[];
                this.selectedProductCurrency=null;
                this.itemForm.patchValue({
                    quantity:0,
                    insuranceCoverageAmount:0,
                    beforeTaxesAmount:product.price,
                    totalAmount:0,
                    taxesAmount:0,
                    productPrice:product.price,
                })
                this.productQuantity=0;
                this.showProductQuantity=false;
                this.selectedProductCurrency=product.currency;
                this.productPrices=[{ id:1,price:product.price, currency:product.currency.code},{id:2, price:product.price2, currency:product.currency.code},{id:3,price:product.price3, currency:product.currency.code}].filter(x=>x.price>0);

                const form = this.itemForm.getRawValue();
                this.getInsuranceCoverage(val,form.insuranceId,form.insurancePlanId);
                this.itemForm.patchValue({selectedPrice:this.productPrices[0].price});
               if( product.isService){
                this.itemForm.removeControl('unitId');
                this.itemForm.addControl('unitId', new FormControl(null))
               }
               else{
                this.itemForm.removeControl('unitId');
                this.itemForm.addControl('unitId',this.defaultUnitValidator)
                this.GetProductUnits(val);

                const user = this.getUser();

                    this.getProductInventory(user.branchOfficeId,form.warehouseId==null?0:form.warehouseId,val)

            }
                this.productTaxes=[];
                this.GetProductTaxes(val);
                this.itemForm.patchValue({unitId:null});

                this.GetProductCost(val);
            }
            else
            this.itemForm.patchValue({insuranceCoverageAmount:0})
        });

      }

      setMedicalSpecialityChanges(){
        this.itemForm.get('medicalSpecialityId').valueChanges.subscribe(val => {

            const {branchOfficeId,type} = this.itemForm.getRawValue();
            if(branchOfficeId && branchOfficeId>0 ){
                this.getProducts(val,type?type:'C');
                this.getDoctors(val,branchOfficeId);
            }
        });
      }

      removeEntries(){
          for(let i=0;i<this.entries.length;i++){

              if(this.itemForm.contains(`unitQuantity_${i}`))
              this.itemForm.removeControl(`unitQuantity_${i}`);

              if(this.itemForm.contains(`insuranceApprovalCode_${i}`))
              this.itemForm.removeControl(`insuranceApprovalCode_${i}`);

              if(this.itemForm.contains(`noCoverage_${i}`))
              this.itemForm.removeControl(`noCoverage_${i}`);


          }

          this.entries=[];
      }

      async getPatientAppointments(){
          const {patientId} = this.itemForm.getRawValue();
          if(patientId && patientId>0){
              const filter =[
                {
                    property: "PatientId",
                    value: patientId,
                    type: ObjectTypes.Number,
                    isTranslated: false,
                    comparer: ODataComparers.equals
                } as QueryFilter,
                {
                    property: "State",
                    value: "F,S",
                    type: ObjectTypes.String,
                    comparer:ODataComparers.in,
                    isTranslated:false
                } as QueryFilter,
              ]
              this.appointmentService.getAllFiltered(filter).subscribe(r=>{
                  this.appointments=[{id:0, dateFormatted:''}]
                  r['value'].forEach(a=>{
                    a['dateFormatted']=new Date(a.date).toLocaleString();
                    this.appointments.push(a);
                });


              })
          }
      }

      selectAppointment(id:number){
          const form = this.itemForm.getRawValue();
          this.appointmentService.getById(id).subscribe(r=>{
            this.selectedAppointment=r.data[0];
            this.itemForm.patchValue({branchOfficeId:this.selectedAppointment.hospitalId});
            if(!this.isEditing){
                let index =this.entries.findIndex(x=>x.appointmentId && x.appointmentId>0);
                while(index>=0){
                    this.entries.splice(index,1);
                    index =this.entries.findIndex(x=>x.appointmentId && x.appointmentId>0)
                }
                if(this.selectedAppointment.details && this.selectedAppointment.details.length>0){
                    this.selectedAppointment.details.forEach((d,i) => {
                        const detail ={
                        quantity:1,
                        doctorId:d.doctorId,
                        productId:d.productId,
                        medicalSpecialityId:d.medicalSpecialityId,
                        branchOfficeId: this.selectedAppointment.hospitalId,
                        insuranceApprovalCode:'',
                        type:d.type,
                        insuranceCoverageAmount:d.insuranceCoverageAmount,
                        beforeTaxesAmount:d.beforeTaxesAmount,
                        taxesAmount:d.taxesAmount,
                        totalAmount:d.totalAmount,
                        discountAmount:0,
                        creditNoteAmount:0,
                        date:d.date,
                        invoiceId:this.id,
                        patientPaymentAmount:d.totalAmount - d.insuranceCoverageAmount,
                        returnAmount:0,
                        noCoverage:false,
                        product:d.product,
                        doctor:d.doctor,
                        medicalSpeciality:d.medicalSpeciality,
                        currencyId:d.currencyId,
                        currency:d.currency,
                        cost:d.product?d.product.cost:0,
                        amount:d.beforeTaxesAmount,
                        free:false,
                        comments:'',
                        principalCurrencyAmount:d.totalAmount,
                        discountRate:0,
                        warehouseId:form.warehouseId,
                        appointmentId:d.appointmentId,
                        unitId:null,
                        unit:null,
                        saveRegister:true
                        };
                        const index = this.entries.findIndex(x=>x.productId==detail.productId
                             && x.doctorId==detail.doctorId && x.type==detail.type && x.medicalSpecialityId==detail.medicalSpecialityId);
                   if(!this.itemForm.contains(`insuranceApprovalCode_${i}`)){
                       this.itemForm.addControl(`insuranceApprovalCode_${i}`, new FormControl({value:detail.insuranceApprovalCode, disabled:(detail.noCoverage || this.isEditing)},(detail.noCoverage?[]:[Validators.required,Validators.minLength(1), Validators.maxLength(50)])) )
                   }

                   if(!this.itemForm.contains(`unitQuantity_${i}`)){
                    this.itemForm.addControl(`unitQuantity_${i}`, new FormControl({value:detail.quantity, disabled:this.isEditing},[Validators.required, Validators.min(0.0001)]) )
                }
                if(!this.itemForm.contains(`noCoverage_${i}`)){
                    this.itemForm.addControl(`noCoverage_${i}`, new FormControl({value:detail.noCoverage, disabled:this.isEditing},[]) )
                }

                    if(index >-1)
                    this.entries[index]=detail;
                    else{
                        this.entries.push(detail);
                    }

                    });
                    this.appointmentDetails=this.entries;
                    this.refreshAmounts();
                }
            }


          })
      }

      setCoverageValue(index:number){
          const name=`noCoverage_${index}`;
          const codeName=`insuranceApprovalCode_${index}`;
          const {insuranceId,insurancePlanId} = this.itemForm.getRawValue();
          const val =this.itemForm.get(name).value;
          const item = this.entries[index];
            // if(this.itemForm.contains(codeName))
            // this.itemForm.removeControl(codeName);

        this.itemForm.setControl(codeName, new FormControl({value:'', disabled:(val|| this.isEditing)},(val?[]:[Validators.required,Validators.minLength(1), Validators.maxLength(50)])));
         if(val)
             this.entries[index].insuranceCoverageAmount=0;
             else
             this.getInsuranceCoverageAmount(item.productId,index,insuranceId,insurancePlanId);

             this.entries[index].patientPaymentAmount= this.entries[index].totalAmount - this.entries[index].insuranceCoverageAmount;



      }

      getInsuranceCoverage(productId:number,insuranceId:number=0,insurancePlanId:number=0){
        const form = this.itemForm.getRawValue();
        if((productId) && (form.insuranceId || form.insurancePlanId) )
        this.insuranceService.getByUrlParameters(["GetInsuranceCoverage",productId.toString(),insuranceId?insuranceId.toString():'null',insurancePlanId?insurancePlanId.toString():'null'])
        .subscribe(r=>{
            try{
                if(r.status>=0){
                    const coverage=r.data[0];
                    this.itemForm.patchValue({insuranceCoverageAmount:coverage.coverageAmount});
                    this.refreshAmounts(false);
                }
                else
                this.modalService.showError('error_msg');
            }
            catch(ex){
                console.log(ex);
            }

        });
        else
        {
            this.itemForm.patchValue({insuranceCoverageAmount:0});
            this.refreshAmounts(false);
        }

    }

    getInsuranceCoverageAmount(productId:number,index:number,insuranceId:number=0,insurancePlanId:number=0){

        if((productId) && (insuranceId || insurancePlanId) )
        this.insuranceService.getByUrlParameters(["GetInsuranceCoverage",productId.toString(),insuranceId?insuranceId.toString():'null',insurancePlanId?insurancePlanId.toString():'null'])
        .subscribe(r=>{
            try{
                if(r.status>=0){
                    const coverage=r.data[0];
                    this.entries[index].insuranceCoverageAmount= coverage.coverageAmount;
                    this.entries[index].patientPaymentAmount= this.entries[index].totalAmount - this.entries[index].insuranceCoverageAmount;
                }
                else
                this.modalService.showError('error_msg');
            }
            catch(ex){
                console.log(ex);
            }
        });

    }

      updateSelectedPrice(val){
        const {productId,unitId}= this.itemForm.getRawValue();
        if(productId && productId>0){
            let price =val;
         if (unitId){
          const productUnit = this.productUnits.find(x=>x.unitId==unitId);
          price = val/productUnit.equivalence;
         }

         this.itemForm.patchValue({productPrice:price});

        }
      }
    resetForm(deleteEntries:boolean=false){

        this.itemForm.patchValue({
            trnType:null,
            nrc:null,
            productId:null,
            unitId:null,
            warehouseId:null,
            sellerId:null,
            discountRate:0,
            discountAmount:0,
            currencyName:'',
            currencyId:0,
            exchangeRate:0,
            appliedCreditNote:'',
            sellerRate:0,
            paidDate:null,
            receivedAmount:0,
            cost:0,
            appliedCreditNoteAmount:0,
            trn:null,
            trnControlId:null,
            details:null,
            quantity:0,
            productCost:0,
            productPrice:0,
            selectedPrice:0,
            beforeTaxesAmount:0,
            paidAmount:0,
            returnedAmount:0,
            owedAmount:0,
            noTaxes:false,
            taxesAmount:0,
            totalAmount:0,
            free:false
        });
        if(deleteEntries){
            this.removeEntries();
            this.appointmentDetails=[];
        }
    }
    get form() { return this.itemForm.controls; }

    get formValues(){
        let form = this.itemForm.getRawValue();
        form.beforeTaxesAmount= this.getTotalAmount(this.entries,'beforeTaxesAmount');
        form.taxesAmount= this.getTotalAmount(this.entries,'taxesAmount');
        form.discountAmount = this.getTotalAmount(this.entries,'discountAmount')
        form.totalAmount= this.getTotalAmount(this.entries,'totalAmount');
        form.patientPaymentAmount= this.getTotalAmount(this.entries,'patientPaymentAmount');
        form.insuranceCoverageAmount= this.getTotalAmount(this.entries,'insuranceCoverageAmount');
        form.owedAmount= form.totalAmount - form.paidAmount - form.appliedCreditNoteAmount;
        form.owedAmount = form.owedAmount <0?0:form.owedAmount;
        form.owedAmount= form.owedAmount<0?0:form.owedAmount;
        form.returnedAmount = form.paidAmount - form.totalAmount;
        form.returnedAmount = form.returnedAmount>0?form.returnedAmount:0;
        return form;
    }

    verifyTotalAmount(){
        const calculatedAmount= this.itemForm.get('totalAmountCalc')?this.itemForm.get('totalAmountCalc').value:0;
        const total= this.itemForm.get('totalAmount')?this.itemForm.get('totalAmount').value:0;

    }


    save(){
        if (!this.entries || this.entries.length==0 )
            return;
            this.updateEntriesValues();
        let form = this.itemForm.getRawValue() as any;
           form.warehouseId=form.warehouseId==0?null:form.warehouseId;
           form.invoiceDetails=this.entries;
           form.discountAmount=0;
           form.customerId=form.patientId;
           form.state=!form.state?(form.inventoryModified?BillingStates.Billed:BillingStates.Quoted):form.state;
            const subscription =window.location.href.split('/').findIndex(x=>x.toLowerCase()=='add')>=0? this.invoiceService.post(form,"",""):this.invoiceService.put(form,"","");
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/invoice');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    updateEntriesValues(){
        const form = this.itemForm.getRawValue();
        for(let i=0;i<this.entries.length;i++){
            this.entries[i].quantity = form[`unitQuantity_${i}`];
            this.entries[i].quantity = !this.entries[i].quantity?0:this.entries[i].quantity;
            this.entries[i].discountRate = !this.entries[i].discountRate?0:this.entries[i].discountRate;
            this.entries[i].discountAmount= this.entries[i].discountRate/100*this.entries[i].beforeTaxesAmount;
            this.entries[i].discountAmount = !this.entries[i].discountAmount?0:this.entries[i].discountAmount;
            this.entries[i].insuranceApprovalCode = form[`insuranceApprovalCode_${i}`];
            this.entries[i].noCoverage = this.entries[i].noCoverage?this.entries[i].noCoverage:((!form[`noCoverage_${i}`] ||!form[`noCoverage_${i}`].value?false:true));
            this.entries[i].patientPaymentAmount = this.entries[i].totalAmount -(this.entries[i].insuranceCoverageAmount?this.entries[i].insuranceCoverageAmount:0);
        }
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/invoice');
    }

    addEntry(){
       let entry = this.itemForm.getRawValue() as any;
        if(!entry.productId ||  !entry.quantity|| !entry.currencyId ||
             !entry.beforeTaxesAmount || entry.taxesAmount===undefined || !entry.totalAmount || !entry.type  )
        return;
        const patientCurrency =entry.patientId && entry.patientId>0? this.patients.find(x=>x.id==entry.patientId).currency:null;
        const rate =!patientCurrency?0:  patientCurrency.isLocalCurrency? (this.selectedProductCurrency?this.selectedProductCurrency.exchangeRate:1):
        (this.selectedProductCurrency.exchangeRate/patientCurrency.exchangeRate);
      entry.product= this.products.find(x=>x.id==entry.productId);
      entry.amount = entry.productPrice * rate;
      entry.productId=parseInt(entry.productId.toString());
      entry.unitId=entry.product.isService || !entry.unitId?null: parseInt(entry.unitId.toString());
      entry.unit=entry.unitId?this.productUnits.find(x=>x.unitId==entry.unitId).unit:{id:0, name:''};
      entry.id=0;
      entry.appointmentId=null;
      entry.noCoverage=true;
      entry.product.taxes=this.productTaxes;
      entry.taxesAmount= entry.product.taxes.length<=0?0:entry.product.taxes.reduce(function(a,b){return a+(b.tax.rate*(entry.beforeTaxesAmount -entry.discountAmount))},0);
      entry.product.productUnits = this.productUnits;
      entry.discountAmount = entry.discountRate>1?( entry.discountRate/100 * entry.beforeTaxesAmount):(entry.discountRate* entry.beforeTaxesAmount);
      const currentIndex =this.entries.length;
        let index = this.entries.findIndex(x=>x.productId==entry.productId && x.warehouseId==entry.warehouseId);

        if(index<0){
            this.setDetailFormAmount(currentIndex,entry.quantity,true);
            this.setDetailFormDiscount(currentIndex,entry.discountRate,true);
            this.setDetailFormApprovalCode(currentIndex,entry.insuranceApprovalCode,true,false);
            this.setDetailFormNoCoverage(currentIndex,entry.noCoverage,true);
            this.entries.push(entry);
        }
        else {
            this.entries.splice(index,1);
            this.entries.push(entry);
        }

        this.itemForm.patchValue({
            productId:null,
            quantity:0,
            beforeTaxesAmount:0,
            taxesAmount:0,
            totalAmount:0,
            unitId:null,
            noTaxes:false,
            free:false,
            productCost:0,
            productPrice:0

        });
      this.appointmentDetails=this.entries;
    }
    deleteEntry(index:number){
        const entry = this.entries[index];
        this.itemForm.removeControl(`unitQuantity_${index}`);
        this.itemForm.removeControl(`unitDiscountRate_${index}`);
        this.itemForm.removeControl(`insuranceApprovalCode_${index}`);
        this.entries.splice(index,1);
        this.appointmentDetails=this.entries;
    }


    getCurrentInvoice(invoiceId:number){
        this.invoiceService.getByUrlParameters(['GetForPrint',invoiceId.toString()])
        .subscribe(r=>{

            if(r.status>=0){
                for(let i=0; i<this.entries.length;i++){
                    if(this.itemForm.contains(`unitQuantity_${i}`))
                    this.itemForm.removeControl(`unitQuantity_${i}`);

                    if(this.itemForm.contains(`unitDiscountRate_${i}`))
                    this.itemForm.removeControl(`unitDiscountRate_${i}`);

                    if(this.itemForm.contains(`noCoverage_${i}`))
                    this.itemForm.removeControl(`noCoverage_${i}`);

                    if(this.itemForm.contains(`insuranceApprovalCode_${i}`))
                    this.itemForm.removeControl(`insuranceApprovalCode_${i}`);
                }
                if(r.data[0] && r.data[0].invoiceDetails && r.data[0].invoiceDetails.length>0){
                    for(let i=0; i<r.data[0].invoiceDetails.length;i++){
                        this.setDetailFormAmount(i,r.data[0].invoiceDetails[i].quantity);
                        this.setDetailFormDiscount(i,r.data[0].invoiceDetails[i].discountRate);
                        this.setDetailFormApprovalCode(i,r.data[0].invoiceDetails[i].insuranceApprovalCode);
                        this.setDetailFormNoCoverage(i,r.data[0].invoiceDetails[i].noCoverage);
                      }
                }
                this.entries=r.data[0] && r.data[0].
                invoiceDetails?r.data[0].invoiceDetails:[];

                this.item=r.data[0];
                this.itemForm.patchValue(this.item);
                this.appointmentDetails=this.entries;

            }
            else
            this.modalService.showError(r.message);

        this.validateFormData();

        })
    }



    setDetailFormAmount(index:number,quantity:number, isNewEntry:boolean=false){
        if(!this.itemForm.contains(`unitQuantity_${index}`))
        this.itemForm.addControl(`unitQuantity_${index}`,new FormControl({value:quantity, disabled:isNewEntry?false: this.isEditing},[ Validators.required,Validators.min(0.0001)]));
    }

     setDetailFormDiscount(index:number,discount:number, isNewEntry:boolean=false){
        if(!this.itemForm.contains(`unitDiscountRate_${index}`))
        this.itemForm.addControl(`unitDiscountRate_${index}`,new FormControl({value:discount, disabled:isNewEntry?false: this.isEditing},[Validators.max(100) ,Validators.min(0)]));
    }

    setDetailFormNoCoverage(index:number,noCoverage:boolean=false, isNewEntry:boolean=false){
        if(!this.itemForm.contains(`noCoverage_${index}`))
        this.itemForm.addControl(`noCoverage_${index}`,new FormControl({value:noCoverage},[]));
    }

    setDetailFormApprovalCode(index:number,code:string, isNewEntry:boolean=false, coverageNeeded:boolean=true){
        const noCoverage = this.itemForm.getRawValue()[`noCoverage_${index}`];
        if(coverageNeeded){
            if(!this.itemForm.contains(`insuranceApprovalCode_${index}`))
            this.itemForm.addControl(`insuranceApprovalCode_${index}`,
            new FormControl({value:!code?'':code, disabled:isNewEntry?false: ( (noCoverage && noCoverage.value) ||this.isEditing)},((noCoverage && noCoverage.value))?
            []: [Validators.required,Validators.maxLength(50) ,Validators.minLength(1)]));
        }

    }
    refreshAmounts(fromForm:boolean=false){

        let {productPrice,productCost,quantity,unitId,beforeTaxesAmount, totalAmount, taxesAmount,discountAmount, discountRate,patientId, productId, patientPaymentAmount,insuranceCoverageAmount} = this.itemForm.getRawValue() as any;
        if(productId && productId>0){
            const equivalence =unitId && unitId>0 && this.productUnits? this.productUnits.find(x=>x.unitId==unitId).equivalence:1;
            const patientCurrency =patientId && patientId>0 && this.patients.length>0? this.patients.find(x=>x.id==patientId).currency:null;
            const rate =!patientCurrency?0:  patientCurrency.isLocalCurrency? (this.selectedProductCurrency?this.selectedProductCurrency.exchangeRate:1):
            (this.selectedProductCurrency.exchangeRate/patientCurrency.exchangeRate);
            productPrice=productPrice*rate;
            productCost=(fromForm?productCost:this.currentProductCost.cost>0?(this.currentProductCost.cost/equivalence):productCost)*rate;
            beforeTaxesAmount= quantity * productPrice;
            discountAmount= beforeTaxesAmount* (discountRate>1?discountRate/100:discountRate);
            taxesAmount=(this.CalculateProductTax() * quantity)*rate;
            taxesAmount= (taxesAmount - (discountRate>1?taxesAmount*discountRate/100:taxesAmount*discountRate));
            totalAmount= beforeTaxesAmount + taxesAmount - discountAmount;
           patientPaymentAmount=totalAmount-insuranceCoverageAmount;
            this.oldProductCost=productCost;
            this.oldProductPrice=productPrice;
            this.itemForm.patchValue({
                productCost,
                beforeTaxesAmount,
                totalAmount,
                taxesAmount,
                discountAmount,
                patientPaymentAmount
            })
        }





    }
}
