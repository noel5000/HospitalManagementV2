

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
import { endpointUrl, endpointViewsUrl } from '../../../@core/common/constants';
import { HttpClient } from '@angular/common/http';
import { CustomerService } from '../../../@core/services/CustomerService';
import { UserService } from '../../../@core/mock/users.service';
import { ProductService } from '../../../@core/services/ProductService';
import { nullSafeIsEquivalent } from '@angular/compiler/src/output/output_ast';
import { Product } from '../../../@core/data/product';
import { FileUploader } from 'ng2-file-upload';
import { appointmentIndexComponent } from '../../appointment/index/appointmentIndex.component';


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
        {key:'1-0-0',value:`${this.lang.getValueByKey('1-0-0')}`, multiplier:1},
        {key:'0-1-0',value:`${this.lang.getValueByKey('0-1-0')}`, multiplier:1},
        {key:'0-0-1',value:`${this.lang.getValueByKey('0-0-1')}`, multiplier:1},
        {key:'1-1-0',value:`${this.lang.getValueByKey('1-1-0')}`, multiplier:2},
        {key:'1-0-1',value:`${this.lang.getValueByKey('1-0-1')}`, multiplier:2},
        {key:'0-1-1',value:`${this.lang.getValueByKey('0-1-1')}`, multiplier:2},
        {key:'1-1-1',value:`${this.lang.getValueByKey('1-1-1')}`, multiplier:3},

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
    editing:number=1;
    attachmentsService:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}CheckupAttachment`);
    attachments:any[]=[];
    public uploader: FileUploader;
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
            const urlId= parseInt( this._route.snapshot.paramMap.get('checkupid'));
            const appointmentId= parseInt( this._route.snapshot.paramMap.get('appointmentid'));
            const patientId= parseInt( this._route.snapshot.paramMap.get('patientid'));
            const editing= parseInt( this._route.snapshot.paramMap.get('editing'));
            if(!isNaN(appointmentId))
            this.appointmentId=appointmentId;
            if(!isNaN(patientId))
            this.patientId=patientId;

            if(!isNaN(editing))
            this.editing=editing;

            if(!isNaN(urlId)){
               this.id=urlId;
               this.getItem(urlId);
            }
            else
            this.validateFormData();


            this.itemForm = this.formBuilder.group({
                doctorName: [''],
                patientName:[''],
                appointmentId:[ this.appointmentId==0?null:this.appointmentId],
                symptoms:['',[Validators.required, Validators.minLength(1),Validators.maxLength(500)]],
                diagnoses:['',[Validators.required, Validators.minLength(1),Validators.maxLength(500)]],
                prescriptionType: ['',[ Validators.required]],
                doctorId: [0,[ Validators.required, Validators.min(1)]],
                patientId: [0,[ Validators.required, Validators.min(1)]],
                productId: [null],
                quantity:[1],
                whenToTake:[''],
                medicalSpecialityId:[null],
                emptyStomach:[false],
                additionalData:['',[Validators.maxLength(500)]],
                id: [this.id],
                hospitalId:[0],
                insuranceId:[null],
                insurancePlanId:[null],
                currencyId:[0],
            });


        this.uploader=new FileUploader({ url:  `${endpointViewsUrl}Files/SaveCheckupFile/${this.id}`,authToken:`Bearer ${this.getUser().tokenKey}`, authTokenHeader:'Authorization', itemAlias: 'file', headers:[{name:'Access-Control-Allow-Origin',value:''}] });
    }

    addProduct(){
        this.newProduct=true;
        this.itemForm.patchValue({productId:null});
        if(!this.itemForm.contains('newProduct'))
        this.itemForm.addControl('newProduct',new FormControl(null,[ Validators.required, Validators.minLength(1), Validators.maxLength(100)]));
    }
    saveNewProduct(){

        const {medicalSpecialityId,prescriptionType,currencyId} = this.itemForm.getRawValue();
        if(prescriptionType!="C"){
            let newProduct={
                id:Math.floor(Math.random() * -1000),
                name:this.itemForm.getRawValue().newProduct,
                type:prescriptionType,
                currencyId,
                medicalSpecialityId,
                isService:prescriptionType=='M'?false:true
            } as Product;
            while(newProduct.id==0){
                newProduct.id=Math.floor(Math.random() * -1000);
            }
            if(newProduct.name && newProduct.name.length>1 && newProduct.name.length<100){
                const index = this.products.findIndex(x=>x.name.toLocaleLowerCase().trim()==newProduct.name.toLowerCase().trim());
                if(index<0){
                   this.products.push(newProduct);
                }
                else
                    newProduct.id=this.products[index].id
                    this.itemForm.patchValue({productId:newProduct.id});
            }

        }
        else{
            let newConsultation ={
                id:Math.floor(Math.random() * -1000),
            name:this.itemForm.getRawValue().newProduct
            }
            while(newConsultation.id==0){
                newConsultation.id=Math.floor(Math.random() * -1000);
            }
            if(newConsultation.name && newConsultation.name.length>1 && newConsultation.name.length<100){
                const index = this.medicalSpecialities.findIndex(x=>x.name.toLocaleLowerCase().trim()==newConsultation.name.toLowerCase().trim());
                if(index<0){
                   this.medicalSpecialities.push(newConsultation);
                }
                else
                newConsultation.id=this.medicalSpecialities[index].id;

                    this.itemForm.patchValue({medicalSpecialityId:newConsultation.id});
            }
        }

        this.newProduct=false;
        if(this.itemForm.contains('newProduct'))
        this.itemForm.removeControl('newProduct');
        this.products.sort((a, b) => (a.name > b.name) ? 1 : -1);
        this.medicalSpecialities.sort((a, b) => (a.name > b.name) ? 1 : -1);
    }
    cancelNewProduct(){
        this.itemForm.patchValue({
            productId:null,
            medicalSpecialityId:null,
            newProduct:''
        });
        this.newProduct=false;
        if(this.itemForm.contains('newProduct'))
        this.itemForm.removeControl('newProduct');
    }

    async getAttachments(id:number){
this.attachmentsService.getAllFiltered([
    {
    property:"PatientChekupId",
    value: id.toString(),
    type: ObjectTypes.Number,
    comparer:ODataComparers.equals,
    } as QueryFilter,
    {
        property:"FileAttachment",
        value:"Id,FileName",
        type: ObjectTypes.ChildObject,
        } as QueryFilter
]).subscribe(r=>{
    this.attachments= r['value'];
})
    }
    ngOnInit(): void {
        this.verifyUser();
        this.getMedicalSpecialities();
        this.onChanges();
        if(this.appointmentId && this.appointmentId>0)
        this.getAppointment(this.appointmentId);
        else {
          this.getPatient(1);
        }
        this.getAttachments(this.id);
        this.uploader.onAfterAddingFile = (file) => { file.withCredentials = false; };
    this.uploader.onCompleteItem = (item: any, response: any, status: any, headers: any) => {
         console.log('FileUpload:uploaded successfully:', item, status, response);
         this.modalService.showSuccess('ok_msg');
         this.getAttachments(this.id);
    };

    this.uploader.onAfterAddingFile = (file) => { file.withCredentials = false; };
    this.uploader.onErrorItem=(arg)=>{this.service.hideSpinner();};
    this.uploader.onBeforeUploadItem=(arg)=>{this.service.showSpinner();};
    this.uploader.onCompleteItem = (item: any, response: any, status: any, headers: any) => {
      this.service.hideSpinner();
         console.log('FileUpload:uploaded successfully:', item, status, response);
         this.uploader.clearQueue();
         this.uploader
         this.modalService.showSuccess(this.lang.getValueByKey('ok_msg'));
         this.getAttachments(this.id);
      
    };
    }
    async getMedicalSpecialities(){
        this.medicalSpecialityService.getAll().subscribe(r=>{
            this.medicalSpecialities=r;
            this.medicalSpecialities.sort((a, b) => (a.name > b.name) ? 1 : -1);
        })
    }

    setLink(attachment:any){
        return `${endpointViewsUrl}Files/${attachment.fileAttachment.fileName}`
    }

    removeAttachment(id:number){
        this.attachmentsService.delete(id).subscribe(r=>{
            this.getAttachments(this.id);
        });
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
            this.products.sort((a, b) => (a.name > b.name) ? 1 : -1);
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

    async getPatient(getData:number=0){
      this.patientService.getById(this.patientId).subscribe(r=>{
        if(r.status>=0)
        this.patient=r.data[0];
        else
        this.modalService.showError(r.message);

        if(getData>0)
        this.getDataWithoutApointment();
      })
      }

      async getDataWithoutApointment(){
        const user = this.getUser();
        this.itemForm.patchValue({
          patientId:this.patientId,
          doctorId: user.userId,
          hospitalId:user.branchOfficeId,
          appointmentId:null,
          insuranceId:this.patient.insuranceId,
          insurancePlanId:this.patient.insurancePlanId,
          doctorName:user.fullName,
          patientName:this.patient.name,
          currencyId:this.patient.currencyId,
        });

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
                this.patientId=this.item.patientId;
                const {appointmentId,symptoms,diagnoses,doctorId,patientId,id,insuranceId,insurancePlanId}=this.item;
                this.itemForm.patchValue({
                    doctorName: this.item.doctor.fullName,
                    appointmentId,
                    patientName:this.item.patient.name,
                    symptoms,
                    diagnoses,
                    prescriptionType: '',
                    doctorId,
                    patientId,
                    productId:null,
                    quantity:1,
                    whenToTake:'',
                    medicalSpecialityId:null,
                    emptyStomach:false,
                    additionalData:'',
                    id,
                    hospitalId:this.item.doctor.branchOfficeId,
                    insuranceId,
                    insurancePlanId,
                    currencyId:this.item.patient.currencyId,
               });

            }
            this.validateFormData();
        }
        catch(ex){
console.log(ex);
        }

    });
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
           this.item.id=this.id;
           this.item.checkupPrescriptions=this.selectedLabTests.concat(this.selectedConsultations,this.selectedImages,this.selectedMedicines);
           this.item.patient=this.patient;
           this.item.doctor=this.doctor?this.doctor:this.getUser();
           this.item.doctor.name=this.item.doctor.name?this.item.doctor.name:'Name';
           this.item.doctor.lastName=this.item.doctor.lastName?this.item.doctor.lastName:'lastName';
           this.item.doctor.password=this.item.doctor.password?this.item.doctor.password:'password';
           this.item.doctor.userName=this.item.doctor.userName?this.item.doctor.userName:'userName';
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
           medicinesAmount:quantity * this.whentoTakeSelections.find(x=>x.key==whenToTake).multiplier,
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
                    if(prescription.productId ){
                        index = this.selectedImages.findIndex(x=>x.productId==prescription.productId);
                        if(index>=0)
                        this.selectedImages[index]=prescription
                        else
                        this.selectedImages.push(prescription);
                    }

                break;
                case "L":
                    if(prescription.productId){
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
                    if(prescription.medicalSpecialityId){
                    index = this.selectedConsultations.findIndex(x=>x.medicalSpecialityId==prescription.medicalSpecialityId);
                    if(index>=0)
                    this.selectedConsultations[index]=prescription
                    else
                    this.selectedConsultations.push(prescription);
                    }
                break;
            }
            this.products.sort((a, b) => (a.name > b.name) ? 1 : -1)
            this.medicalSpecialities.sort((a, b) => (a.name > b.name) ? 1 : -1)
        }
        }
      async  deleteSelectedLabTests(index:number){
        const i = this.products.findIndex(x=>x.id==this.selectedLabTests[index].productId);
        if(i>=0){
            this.products[i].selected=false;
        }
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

        uploadClick(){
            document.getElementById('imageUpload').click();
          }
          fileSelectedUpload(arg:any){
            console.log(arg);
          this.uploader.uploadAll();
          }


    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl(`pages/patientcheckup/${this.patientId}/${this.appointmentId}`);
    }
}
