

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, ObjectTypes, ODataComparers, QueryFilter } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { ZoneService } from '../../../@core/services/zoneService';
import { Zone } from '../../../@core/data/zoneModel';
import { BaseService } from '../../../@core/services/baseService';
import { endpointUrl } from '../../../@core/common/constants';
import { HttpClient } from '@angular/common/http';
import { CustomerService } from '../../../@core/services/CustomerService';
import { UserService } from '../../../@core/mock/users.service';
import { ProductService } from '../../../@core/services/ProductService';
import { nullSafeIsEquivalent } from '@angular/compiler/src/output/output_ast';
import { Product } from '../../../@core/data/product';


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
    selectedMedicines:any[]=[];
    selectedImages:any[]=[];
    selectedConsultations:any[]=[];
    selectedLabTests:any[]=[];
    medicalSpecialities:any[]=[];
    whentoTakeSelections:any[]=[
        '1-0-0',
        '0-1-0',
        '0-0-1',
        '1-1-0',
        '1-0-1',
        '0-1-1',
        '1-1-1',
        
    ];
    products:Product[]=[];
    prescriptionType:string='';
    prescriptionTypes:any[]=[
        {
            id:'M',
            name:this.lang.getValueByKey('medicine_lbl')
        },
        {
            id:'C',
            name:this.lang.getValueByKey('consultation_lbl')
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


    service:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}PatientCheckUp`);
    appointmentService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Appointment`);
    medicalSpecialityService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}MedicalSpeciality`);
    zones:Zone[]=[];
    newProduct:boolean=false;
    constructor(
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private zoneService:ZoneService,
        private modals:NgbModal,
        private patientService:CustomerService,
        private doctorService:UserService,
        private productService:ProductService,
        private  http: HttpClient,
       modalService:ModalService
        ){
           
            super(route, langService, AppSections.PatientCheckup,modalService);
            this._route=router;
        this.itemForm = this.formBuilder.group({
            doctorName: [''],
            patientName:[''],
            appointmentId:[null,Validators.required],
            symptoms:['',Validators.required, Validators.minLength(1),Validators.maxLength(500)],
            diagnoses:['',Validators.required, Validators.minLength(1),Validators.maxLength(500)],
            prescriptionType: ['',[ Validators.required]],
            doctorId: [0,[ Validators.required, Validators.min(1)]],
            patientId: [0,[ Validators.required, Validators.min(1)]],
            productId: [null],
            quantity:[1],
            whenToTake:[''],
            medicalSpecialityId:[null],
            emptyStomach:[false],
            additionalData:['',Validators.maxLength(500)],
            id: [0],
            hospitalId:[0],
            insuranceId:[null],
            insurancePlanId:[null],
            currencyId:[0],
            
            exploracionFisica:[''],
            peso:[''],
            talla:[''],
            temperatura:[''],
            fc:[''],
            fr:[''],
            sat:[''],
        
        });
    }
    addProduct(){
        this.newProduct=true;
        this.itemForm.patchValue({productId:null});
        if(!this.itemForm.contains('newProduct'))
        this.itemForm.addControl('newProduct',new FormControl(null,[ Validators.required, Validators.minLength(1), Validators.maxLength(100)]));
    }
    saveNewProduct(){
        let newProduct={
            id:Math.floor(Math.random() * -1000),
            name:this.itemForm.getRawValue().newProduct,
            type:'M'
        } as Product;
        while(newProduct.id==0){
            newProduct.id=Math.floor(Math.random() * -1000);
        }
        if(newProduct.name && newProduct.name.length>1 && newProduct.name.length<100){
            const index = this.products.findIndex(x=>x.name.toLocaleLowerCase().trim()==newProduct.name.toLowerCase().trim());
            if(index<=0)
            this.products.push(newProduct);
            else
            newProduct.id=this.products[index].id;
            this.itemForm.patchValue({productId:newProduct.id});
            this.newProduct=false;
            if(this.itemForm.contains('newProduct'))
            this.itemForm.removeControl('newProduct');
        }

    }
    cancelNewProduct(){
        this.itemForm.patchValue({
            productId:null,
            newProduct:''
        });
        this.newProduct=false;
        if(this.itemForm.contains('newProduct'))
        this.itemForm.removeControl('newProduct');
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

     if(this.appointmentId && this.appointmentId>0)
        this.getAppointment(this.appointmentId);
        else
        this.modalService.showError('appointmentNotValid_msg');
        this.verifyUser();
        this.getMedicalSpecialities();
        this.onChanges();
    }
    async getMedicalSpecialities(){
        this.medicalSpecialityService.getAll().subscribe(r=>{
            this.medicalSpecialities=r;
        })
    }

    onChanges(){
        this.itemForm.get('prescriptionType').valueChanges.subscribe(val => {
               this.prescriptionType=val;
               this.itemForm.patchValue({
                medicalSpecialityId:null,
                productId:null,
                additionalData:'',
                quantity:1,
                emptyStomach:false,
                whenToTake:'',
               });

               if(val)
               this.getProducts(val);
        });
       
    }
    async labTestSelection(index:number){
        this.products[index].selected=!this.products[index].selected;
        const labTest = this.products[index];
        const selectedIndex = this.selectedLabTests.findIndex(x=>x.productId==labTest.id);
        if(labTest.selected){
            const {medicalSpecialityId,quantity,additionalData,whenToTake,emptyStomach,prescriptionType} = this.itemForm.getRawValue();
                let prescription={
                   productId:labTest.id,
                   medicalSpecialityId,
                   quantity,
                   additionalData,
                   whenToTake,
                   emptyStomach,
                    type:prescriptionType,
                    product:labTest,
                    medicalSpeciality:this.medicalSpecialities.find(x=>x.id==medicalSpecialityId)
                };
            if(selectedIndex<0){
                
                this.selectedLabTests.push(
                    prescription
                );
            }
           
            else
            this.selectedLabTests[selectedIndex]=prescription;
        }
        else{
            if(selectedIndex>=0)
            this.selectedLabTests.splice(selectedIndex,1);
        }
    }
    async getProducts(type:string){
        const filter = [
        {
            property: "Currency",
            value: "Id,Name,Code,ExchangeRate",
            type: ObjectTypes.ChildObject,
            isTranslated: false
        } as QueryFilter,
        {
            property: "Type",
            value: type,
            type: ObjectTypes.String,
            isTranslated: false,
            comparer: ODataComparers.equals
        } as QueryFilter
    ]
        this.productService.getAllFiltered(filter).subscribe(r=>{
            this.products=[{id:0, name:''} as Product];
            this.products=this.products.concat( r['value']);
            
        });
    }
    async getAppointment(id:number){
        this.appointmentService.getById(id).subscribe(r=>{
            this.appointment=r.data[0];
            if(!this.appointment)
            this.modalService.showError('appointmentNotValid_msg');
            else{
                const consultationDetail= this.appointment.details.find(x=>x.type=='C');
                if(!consultationDetail)
                this.modalService.showError('invalidConsultationAppointment_msg');
                else{
                    this.appointment.doctorName=consultationDetail.doctor.fullName;
                    this.appointment.doctorId=consultationDetail.doctorId;
                    
                }
                this.itemForm.patchValue({
                    appointmentId:this.appointment.id,
                    doctorId:this.appointment.doctorId,
                    hospitalId:this.appointment.hospitalId,
                    patientId:this.appointment.patientId,
                    insuranceId:this.appointment.insuranceId,
                    insurancePlanId:this.appointment.insurancePlanId,
                    doctorName:this.appointment.doctorName,
                    patientName:this.appointment.patientName,
                    currencyId:this.appointment.currencyId,
    
                })
            }
           
        })
    }

   async getItem(id:number){
    this.service.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
           
            this.itemForm.patchValue({
                doctorName: this.item.doctor.fullName,
                appointmentId:this.item.appointmentId,
                patientName:this.item.patientName,
                symptoms:this.item.symptoms,
                diagnoses:this.item.diagnoses,
                prescriptionType: '',
                doctorId: this.item.doctorId,
                patientId: this.item.patientId,
                productId:null,
                quantity:0,
                whenToTake:'',
                medicalSpecialityId:null,
                emptyStomach:false,
                additionalData:'',
                id: this.item.id,
                hospitalId:this.item.hospitalId,
                insuranceId:this.item.insuranceId,
                insurancePlanId:this.item.insurancePlanId,
                currencyId:this.item.currencyId,
                exploracionFisica:this.item.exploracionFisica,
                peso:this.item.peso,
                talla:this.item.talla,
                temperatura:this.item.temperatura,
                fc:this.item.fc,
                fr:this.item.fr,
                sat:this.item.sat,
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
       const formValue = this.itemForm.getRawValue();
      
           if(!this.item)
           this.item = {};
           this.item=  this.updateModel<any>(formValue,this.item);
           this.item.checkupPrescriptions=this.selectedLabTests.concat(this.selectedConsultations,this.selectedImages,this.selectedMedicines);
            const subscription = this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl(`pages/patientcheckup/${this.patientId}/${this.appointmentId}`);
               }
               else
               this.modalService.showError(r.message);
           })
    }
   async addPrescription(){
    const {productId,medicalSpecialityId,quantity,additionalData,whenToTake,emptyStomach,prescriptionType} = this.itemForm.getRawValue();
    let prescription={
       productId,
       medicalSpecialityId,
       quantity,
       additionalData,
       whenToTake,
       emptyStomach,
        type:prescriptionType,
        product:this.products.find(x=>x.id==productId),
        medicalSpeciality:this.medicalSpecialities.find(x=>x.id==medicalSpecialityId)
    };
    if(prescription.quantity && prescription.quantity>0){
        let index =0;
        switch(prescription.type){
            case "E":
                if(prescription.productId && prescription.productId>0){
                    index = this.selectedImages.findIndex(x=>x.productId==prescription.productId);
                    if(index>=0)
                    this.selectedImages[index]=prescription
                    else
                    this.selectedImages.push(prescription);
                }
             
            break;
            case "L":
                if(prescription.productId && prescription.productId>0){
                index = this.selectedLabTests.findIndex(x=>x.productId==prescription.productId);
                if(index>=0)
                this.selectedLabTests[index]=prescription
                else
                this.selectedLabTests.push(prescription);
            }
            break;
            case "M":
                if(prescription.productId){
                index = this.selectedMedicines.findIndex(x=>x.productId==prescription.productId);
                if(index>=0)
                this.selectedMedicines[index]=prescription
                else
                this.selectedMedicines.push(prescription);
                }
            break;
            case "C":
                if(prescription.medicalSpecialityId && prescription.medicalSpecialityId>0){
                index = this.selectedConsultations.findIndex(x=>x.productId==prescription.productId);
                if(index>=0)
                this.selectedConsultations[index]=prescription
                else
                this.selectedConsultations.push(prescription);
                }
            break;
        }
    }
    }
  async  deleteSelectedLabTests(index:number){
        this.selectedLabTests.splice(index,1);
    }

    async  deleteSelectedConsultation(index:number){
        this.selectedConsultations.splice(index,1);
    }

    async  deleteSelectedImage(index:number){
        this.selectedImages.splice(index,1);
    }

    async  deleteSelectedMedicine(index:number){
        this.selectedMedicines.splice(index,1);
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl(`pages/patientcheckup/${this.patientId}/${this.appointmentId}`);
    }
}