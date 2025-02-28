

import { Component, OnInit , Inject } from '@angular/core';
import { FormBuilder, Validators, FormControl } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import {   AppRoles } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { CustomerService } from '../../../@core/services/customerService';
import { ProductService } from '../../../@core/services/productService';
import { TRNControlService } from '../../../@core/services/trnControlService';
import { SellerService } from '../../../@core/services/sellerService';
import { WarehouseService } from '../../../@core/services/warehouseService';
import { AppConfig } from '../../../@core/services/app.config';


declare const $: any;
@Component({
  standalone:false,
    selector: "customerreturn-form",
    templateUrl: "./customerReturnForm.component.html",
    styleUrls: ["../customerReturnStyles.component.scss"]
})
export class CustomerReturnFormComponent extends BaseComponent implements OnInit {

    invoice: any={};

    details:any[]=[];
    defaultTaxAmountValidator:FormControl=new FormControl(0,[ Validators.required,Validators.min(0.0001)]);
    defaultUnitValidator:FormControl=new FormControl(null,[ Validators.required,Validators.min(1)]);


    invoiceService:BaseService<any,number>;
    service:BaseService<any,number>;

    isEditing:boolean=false;


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
      private customerService:CustomerService,
      private trnControlService:TRNControlService,
      private sellerService:SellerService,
      private warehouseService:WarehouseService
        ){

            super(route, langService, AppRoles.Movements_CustomersReturns,modalService);
            this.invoiceService= new BaseService<any,number>(this.http, `${this.baseUrl}api/Invoice`);
            this.service= new BaseService<any,number>(this.http, `${this.baseUrl}api/CustomerReturn`);
            this.verifyUser();
            this.dataToBackup="invoice,details";
            this.isEditing=(this.id && this.id>0?true:false);

        this.itemForm = this.formBuilder.group({
            invoiceNumber: [null,[Validators.required]],
            customerName:[''],
            selectedAmount:[0],
            totalAmount:[0,[Validators.required,Validators.min(1)]],
            currencyName:[''],
            billingDate:['']
        });
    }

    searchInvoice(){
        const {invoiceNumber}= this.itemForm.getRawValue();
        this.invoiceService.getByUrlParameters(["GetByInvoiceNumber",invoiceNumber.toString()]).subscribe(r=>{
            if(r && r.status>=0 && r.data.length>0){
                this.invoice=r.data[0];
                for(let i=0; i<this.details.length;i++){
                    if(this.itemForm.contains(`returnQuantity_${i}`))
                    this.itemForm.removeControl(`returnQuantity_${i}`);

                    if(this.itemForm.contains(`defectiveDetail_${i}`))
                    this.itemForm.removeControl(`defectiveDetail_${i}`);

                }
                this.details= this.invoice &&  this.invoice.
                invoiceDetails? this.invoice.invoiceDetails:[];

                if( this.invoice &&  this.invoice.invoiceDetails &&  this.invoice.invoiceDetails.length>0){
                    for(let i=0; i< this.invoice.invoiceDetails.length;i++){
                        this.setDetailFormDefective(i, false);
                        this.setDetailFormAmount(i, 0,this.invoice.invoiceDetails[i].quantity);
                      }
                }


                this.itemForm.patchValue({
                    customerName:`${this.invoice.patient.name} - ${this.invoice.patient.code}`,
                    currencyName:this.invoice.currency.code,
                    billingDate:this.invoice.billingDate.split('T')[0],
                    totalAmount:this.invoice.patientPaymentAmount
                });


            }
            else{
                this.invoice=null;
                this.modalService.showError(r.message);
            }
        },e=>{
            this.modalService.showError('error_msg');
        });
    }
    ngOnInit(): void {

     this.onChanges();
        this.verifyUser();
        this.validateFormData();
    }






    override onChanges(): void {



      }

    resetForm(deletedetails:boolean=false){

        this.itemForm.patchValue({

        });

    }
    get form() { return this.itemForm.controls as any; }

    get formValues(){
        let form = this.itemForm.getRawValue();

      let result=0;
      for(let i=0;i<this.details.length;i++){
          const selectedQuantity = this.itemForm.getRawValue()[`returnQuantity_${i}`] as number;
          if(selectedQuantity && selectedQuantity>0){
              const {totalAmount,quantity} = this.details[i];
              result+=selectedQuantity* (totalAmount/quantity);
          }
      }
      form.totalAmount=result;

        return form;
    }

    verifyTotalAmount(){
        const calculatedAmount= this.itemForm.get('totalAmountCalc')?this.itemForm.get('totalAmountCalc')?.value:0;
        const total= this.itemForm.get('totalAmount')?this.itemForm.get('totalAmount')?.value:0;

    }


    save(){
        if (!this.details || this.details.length==0 || this.itemForm.invalid && !this.invoice)
            return;
            this.updatedetailsValues();
        let form = this.itemForm.getRawValue() as any;
          let toSave ={
              invoiceNumber:this.invoice.invoiceNumber,
              customerId:this.invoice.customerId,
              branchOfficeId:this.invoice.branchOfficeId,
              invoiceId:this.invoice.id,
              beforeTaxesAmount:this.formValues.totalAmount,
              taxesAmount:0,
              totalAmount:this.formValues.totalAmount,
              currencyId:this.invoice.currencyId,
              returnDetails:this.setReturnDetails()
          };

            const subscription =this.service.post(toSave,"","");
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/customerreturn');
               }
               else
               this.modalService.showError(r.message);
           })
    }
    setReturnDetails():any[]{
        let details=[];
        for(let i=0;i<this.details.length;i++){
            const selectedQuantity= this.itemForm.getRawValue()[`returnQuantity_${i}`] as number;
            if(selectedQuantity && selectedQuantity>0){
                let selectedDetail=this.details[i];
                selectedDetail.quantity=selectedQuantity;
                selectedDetail.invoiceNumber=this.invoice.invoiceNumber;
                selectedDetail.taxesAmount=0;
                selectedDetail.id=0;
                selectedDetail.totalAmount= this.details[i].totalAmount;
                selectedDetail.beforeTaxesAmount=selectedQuantity* this.details[i].totalAmount/this.details[i].quantity;

                selectedDetail.customerId=this.invoice.customerId;
                selectedDetail.defective = this.itemForm.getRawValue()[`defectiveDetail_${i}`] as boolean;
                selectedDetail.defective = selectedDetail.defective==null?false:selectedDetail.defective;
                details.push(selectedDetail);
            }
        }
        return details;
    }

    updatedetailsValues(){
        const form = this.itemForm.getRawValue();
        for(let i=0;i<this.details.length;i++){
          this.details[i]['returnQuantity'] = form[`returnQuantity_${i}`]? form[`returnQuantity_${i}`].value:0;
          this.details[i]['discountAmount']= this.details[i].discountRate/100*this.details[i].beforeTaxesAmount;
        }
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/customerreturn');
    }


    setDetailFormAmount(index:number,quantity:number, maxNumber:number){
        if(!this.itemForm.contains(`returnQuantity_${index}`))
        this.itemForm.addControl(`returnQuantity_${index}`,new FormControl({value:quantity, disabled:(this.isEditing || (this.details[index].type=='C' && !this.details[index].noCoverage))},[ Validators.required,Validators.min(0.0001),Validators.max(maxNumber)]));
    }

     setDetailFormDefective(index:number,selected:boolean, isNewEntry:boolean=false){
        if(!this.itemForm.contains(`defectiveDetail_${index}`))
        this.itemForm.addControl(`defectiveDetail_${index}`,new FormControl({value:selected , disabled:(this.isEditing || (this.details[index].type=='C' && !this.details[index].noCoverage))}));
    }
    refreshAmounts(fromForm:boolean=false){



    }
}
