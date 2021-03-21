

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
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
    selector: "patienteditcheckup-form",
    templateUrl: "./patientCheckupEditForm.component.html",
    styleUrls: ["../patientCheckupStyles.component.scss"]
})
export class patientCheckupEditFormComponent extends BaseComponent implements OnInit {
 
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
            name:this.lang.getValueByKey('Consultation_lbl')
        },
        {
            id:'L',
            name:this.lang.getValueByKey('laboratory_lbl')
        },
        {
            id:'E',
            name:this.lang.getValueByKey('especializedImage_lbl')
        }
    ];


    service:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}PatientCheckUp`);
    appointmentService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Appointment`);
    medicalSpecialityService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}MedicalSpeciality`);
    zones:Zone[]=[];
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
            symptoms:['',[Validators.required, Validators.minLength(1),Validators.maxLength(500)]],
            diagnoses:['',[Validators.required, Validators.minLength(1),Validators.maxLength(500)]],
            prescriptionType: [''],
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
        });
        const urlId= parseInt( this._route.snapshot.paramMap.get('checkupid'));
        if(!isNaN(urlId)){
           this.id=urlId;
           this.getItem(urlId);
        }
        else
        this.validateFormData();
    }
    ngOnInit(): void {
    

    
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
    async getProducts(type:string){
        const filter = [
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
            else
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
        })
    }

   async getItem(id:number){
    this.service.getById(id).subscribe(r=>{
        try{
            if(r.status>=0){
                this.item=r.data[0];
                this.selectedMedicines=this.item.checkupPrescriptions.filter(x=>x.type=="M");
                this.selectedLabTests=this.item.checkupPrescriptions.filter(x=>x.type=="L");
                this.selectedConsultations=this.item.checkupPrescriptions.filter(x=>x.type=="C");
                this.selectedImages=this.item.checkupPrescriptions.filter(x=>x.type=="E");
                this.appointmentId=this.item.appointmentId;
                this.patientId=this.item.patientId;
                if(this.appointmentId && this.appointmentId>0)
                this.getAppointment(this.appointmentId);
                else
                this.modalService.showError('appointmentNotValid_msg');
                 this.itemForm.patchValue({
                     doctorName: this.item.doctor.fullName,
                     appointmentId:this.item.appointmentId,
                     patientName:this.item.patient.name,
                     symptoms:this.item.symptoms,
                    diagnoses:this.item.diagnoses,
                     prescriptionType: '',
                     doctorId: this.item.doctorId,
                     patientId: this.item.patientId,
                     productId:null,
                     quantity:1,
                     whenToTake:'',
                     medicalSpecialityId:null,
                     emptyStomach:false,
                     additionalData:'',
                     id: this.item.id,
                     hospitalId:this.item.doctor.branchOfficeId,
                     insuranceId:this.item.insuranceId?this.item.insuranceId:null,
                     insurancePlanId:this.item.insurancePlanId?this.item.insurancePlanId:null,
                     currencyId:this.item.patient.currencyId,
                });

                
            }
            this.validateFormData();
        }
        catch(ex){
console.log(ex);
        }

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
                if(prescription.productId && prescription.productId>0){
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