

import { Component, OnInit , Inject } from '@angular/core';
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
import { AppConfig } from '../../../@core/services/app.config';


declare const $: any;
@Component({
    selector: "patienteditcheckup-form",
    templateUrl: "./patientCheckupEditForm.component.html",
    styleUrls: ["../patientCheckupStyles.component.scss"]
})
export class patientCheckupEditFormComponent extends BaseComponent implements OnInit {






    editing:number=1;
    attachmentsService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/CheckupAttachment`);
    attachments:any[]=[];
    public uploader: FileUploader;



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
    specilizedimages:Product[]=[];
    medicines:Product[]=[];



    service:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/PatientCheckUp`);
    appointmentService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/Appointment`);
    medicalSpecialityService:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/MedicalSpeciality`);
    zones:Zone[]=[];
    newProduct:boolean=false;

    constructor(@Inject('BASE_URL') private baseUrl: string,
        private config: AppConfig,
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
                appointmentId:[null],
                symptoms:['',[Validators.required, Validators.minLength(1),Validators.maxLength(500)]],
                diagnoses:['',[Validators.required, Validators.minLength(1),Validators.maxLength(500)]],
                doctorId: [0,[ Validators.required, Validators.min(1)]],
                patientId: [0,[ Validators.required, Validators.min(1)]],
                productId: [null],
                quantity:[1],
                whenToTake:[''],
                medicalSpecialityId:[null],
                emptyStomach:[false],
                additionalData:['',[Validators.maxLength(500)]],
                id: [0],
                hospitalId:[0],
                insuranceId:[null],
                insurancePlanId:[null],
                currencyId:[0],
                newProduct:[null,[Validators.maxLength(100)]],
                alergies: ['',[ Validators.maxLength(1000)]],
                bloodTransfusions: ['',[ Validators.maxLength(1000)]],
                familyIllnesses: ['',[ Validators.maxLength(1000)]],
                medications: ['',[ Validators.maxLength(1000)]],
                sc: [0],
                size: [0],
                surgeries: ['',[ Validators.maxLength(1000)]],
                weight:[0],
                plan: ['',[ Validators.maxLength(1000)]],
                medicalBackground: ['',[ Validators.maxLength(1000)]],
                consultationReason: ['',[ Validators.maxLength(1000)]],
                physicalExamHeadNeck: ['',[ Validators.maxLength(1000)]],
                physicalExam: ['',[ Validators.maxLength(1000)]],
                physicalExamChest: ['',[ Validators.maxLength(1000)]],
                physicalExamHeart: ['',[ Validators.maxLength(1000)]],
                physicalExamLungs: ['',[ Validators.maxLength(1000)]],
                physicalExamStomach: ['',[ Validators.maxLength(1000)]],
                physicalExamExtremities: ['',[ Validators.maxLength(1000)]],
                laboratoriesResults:[''],
                imagesResults:['']
            });


        this.uploader=new FileUploader({ url:  `${this.baseUrl}Files/SaveCheckupFile/${this.id}`,authToken:`Bearer ${this.getUser().tokenKey}`, authTokenHeader:'Authorization', itemAlias: 'file', headers:[{name:'Access-Control-Allow-Origin',value:''}] });
    }

    addProduct(type:string){
        this.newProduct=true;
        this.itemForm.patchValue({productId:null});
        if(!this.itemForm.contains('newProduct'))
        this.itemForm.addControl('newProduct',new FormControl(null,[ Validators.required, Validators.minLength(1), Validators.maxLength(100)]));
    }
    saveNewProduct(prescriptionType:string){

        const {medicalSpecialityId,currencyId} = this.itemForm.getRawValue();
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
                let index = -1;
                switch(prescriptionType){
                    case 'L':
                        index = this.products.findIndex(x=>x.name.toLocaleLowerCase().trim()==newProduct.name.toLowerCase().trim());
                        if(index<0){
                           this.products.push(newProduct);
                        }
                        else
                            newProduct.id=this.products[index].id
                            this.itemForm.patchValue({productId:newProduct.id});
                    break;
                    case 'M':
                        index = this.medicines.findIndex(x=>x.name.toLocaleLowerCase().trim()==newProduct.name.toLowerCase().trim());
                        if(index<0){
                           this.medicines.push(newProduct);
                        }
                        else
                            newProduct.id=this.medicines[index].id
                            this.itemForm.patchValue({productId:newProduct.id});
                    break;
                    case 'E':
                        index = this.specilizedimages.findIndex(x=>x.name.toLocaleLowerCase().trim()==newProduct.name.toLowerCase().trim());
                        if(index<0){
                           this.specilizedimages.push(newProduct);
                        }
                        else
                            newProduct.id=this.specilizedimages[index].id
                            this.itemForm.patchValue({productId:newProduct.id});
                    break;
                }

            }

        }
        else{
            let newConsultation ={
                id:Math.floor(Math.random() * -1000),
                type:prescriptionType,
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
        this.itemForm.patchValue({newProduct:''});
        this.products.sort((a, b) => (a.name > b.name) ? 1 : -1);
        this.medicines.sort((a, b) => (a.name > b.name) ? 1 : -1);
        this.specilizedimages.sort((a, b) => (a.name > b.name) ? 1 : -1);
        this.medicalSpecialities.sort((a, b) => (a.name > b.name) ? 1 : -1)
    }
    cancelNewProduct(){
        this.itemForm.patchValue({
            productId:null,
            medicalSpecialityId:null,
            newProduct:''

        });
       this.newProduct=false;
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
        this.medicines=[];
        this.specilizedimages=[];
        this.products=[];
        this.medicalSpecialities=[];
        this.verifyUser();
        this.getMedicalSpecialities();
        this.getProducts('M');
        this.getProducts('L');
        this.getProducts('E');
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
            this.medicalSpecialities.sort((a, b) => (a.name > b.name) ? 1 : -1)
        })
    }

    setLink(attachment:any){
        return `${this.baseUrl}Files/${attachment.fileAttachment.fileName}`
    }

    removeAttachment(id:number){
        this.attachmentsService.delete(id).subscribe(r=>{
            this.getAttachments(this.id);
        });
    }

    onChanges(){


    }
    async labTestSelection(index:number){
        this.products[index].selected=!this.products[index].selected;
        const labTest = this.products[index];
        const selectedIndex = this.selectedLabTests.findIndex(x=>x.productId==labTest.id);
        if(labTest.selected){
            const {medicalSpecialityId,quantity,additionalData,whenToTake,emptyStomach} = this.itemForm.getRawValue();
                let prescription={
                   productId:labTest.id,
                   medicalSpecialityId,
                   quantity,
                   additionalData,
                   whenToTake,
                   emptyStomach,
                    type:'L',
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
            switch(type){

                case 'M':
                    this.medicines=[{id:0, name:''} as Product];
                    this.medicines=this.products.concat( r['value']);
                    this.medicines.sort((a, b) => (a.name > b.name) ? 1 : -1);
                break;
                case 'L':
                    this.products=[{id:0, name:''} as Product];
                    this.products=this.products.concat( r['value']);
                    this.products.sort((a, b) => (a.name > b.name) ? 1 : -1);
                break;
                case 'E':
                    this.specilizedimages=[{id:0, name:''} as Product];
                    this.specilizedimages=this.products.concat( r['value']);
                    this.specilizedimages.sort((a, b) => (a.name > b.name) ? 1 : -1);
                break;
            }

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
                    plan: this.item.plan,
                    medicalBackground: this.item.medicalBackground,
                    consultationReason: this.item.consultationReason,
                    physicalExamHeadNeck: this.item.physicalExamHeadNeck,
                    physicalExam: this.item.physicalExam,
                    physicalExamChest: this.item.physicalExamChest,
                    physicalExamHeart: this.item.physicalExamHeart,
                    physicalExamLungs: this.item.physicalExamLungs,
                    physicalExamStomach: this.item.physicalExamStomach,
                    physicalExamExtremities: this.item.physicalExamExtremities,

                })
            }
        })
    }


    async getPatient(getData:number=0){
      this.patientService.getById(this.patientId).subscribe(r=>{
        if(r.status>=0)
        {
            this.patient=r.data[0];
            this.itemForm.patchValue({
                alergies: this.patient.alergies,
                bloodTransfusions: this.patient.bloodTransfusions,
                familyIllnesses: this.patient.familyIllnesses,
                medications: this.patient.medications,
                sc: this.patient.sc,
                size: this.patient.size,
                surgeries: this.patient.surgeries,
                weight:this.patient.weight
             })
        }
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

      setLabResult(index:number,value:string, isNewEntry:boolean=false){
        if(!this.itemForm.contains(`labResult_${index}`))
        this.itemForm.addControl(`labResult_${index}`,new FormControl(value));
    }

    setImageResult(index:number,value:string, isNewEntry:boolean=false){
        if(!this.itemForm.contains(`imageResult_${index}`))
        this.itemForm.addControl(`imageResult_${index}`,new FormControl(value));
    }

    removeLabResult(index:number){
        if(this.itemForm.contains(`labResult_${index}`))
        this.itemForm.removeControl(`labResult_${index}`)
    }

    removeImageResult(index:number){
        if(this.itemForm.contains(`imageResult${index}`))
        this.itemForm.removeControl(`imageResult${index}`)
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
                if(this.selectedLabTests && this.selectedLabTests.length>0){
                    for(let i=0; i<this.selectedLabTests .length;i++){
                        this.setLabResult(this.selectedLabTests[i].id,this.selectedLabTests[i].results);

                      }
                }

                if(this.selectedImages && this.selectedImages.length>0){
                    for(let i=0; i<this.selectedImages .length;i++){
                        this.setImageResult(this.selectedImages[i].id,this.selectedImages[i].results);

                      }
                }
                const {
                    appointmentId,
                    symptoms,
                    diagnoses,
                    doctorId,
                    patientId,
                    id,
                    insuranceId,
                    insurancePlanId,
                    plan,
                    medicalBackground,
                    consultationReason,
                    laboratoriesResults,
                    imagesResults,
                    physicalExamHeadNeck,
                    physicalExam,
                    physicalExamChest,
                    physicalExamHeart,
                    physicalExamLungs,
                    physicalExamStomach,
                    physicalExamExtremities
                }=this.item;
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
                    plan,
                    medicalBackground,
                    consultationReason,
                    laboratoriesResults,
                    imagesResults,
                    physicalExamHeadNeck,
                    physicalExam,
                    physicalExamChest,
                    physicalExamHeart,
                    physicalExamLungs,
                    physicalExamStomach,
                    physicalExamExtremities
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
           this.selectedLabTests.forEach(l=>{
            if(this.itemForm.contains(`labResult_${l.id}`)){
                l.results=this.itemForm.get(`labResult_${l.id}`).value;
            }
        });

        this.selectedImages.forEach(l=>{
         if(this.itemForm.contains(`imageResult_${l.id}`)){
             l.results=this.itemForm.get(`imageResult_${l.id}`).value;
         }
     });
           this.item.checkupPrescriptions=this.selectedLabTests.concat(this.selectedConsultations,this.selectedImages,this.selectedMedicines);

           this.patient.alergies=formValue.alergies;
           this.patient.bloodTransfusions=formValue.bloodTransfusions;
           this.patient.familyIllnesses=formValue.familyIllnesses;
           this.patient.medications=formValue.medications;
           this.patient.sc=formValue.sc;
           this.patient.size=formValue.size;
           this.patient.surgeries=formValue.surgeries;
           this.patient.weight=formValue.weight;
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
    async addPrescription(type:string){
        const {productId,medicalSpecialityId,quantity,additionalData,whenToTake,emptyStomach} = this.itemForm.getRawValue();
        var quantityByWhenToTake= whenToTake?whenToTake.toString().split('-').filter(x=>x=='1'):[];
        let prescription={
           productId,
           medicalSpecialityId,
           quantity,
           additionalData,
           whenToTake,
           medicinesAmount:(type=='M'?(quantityByWhenToTake.length * parseInt(quantity)):0),
           emptyStomach,
            type,
            product:this.findProduct(productId,type),
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
            this.itemForm.patchValue({
                productId: null,
                quantity:1,
                whenToTake:'',
                medicalSpecialityId:null,
                emptyStomach:false,
                additionalData:'',
                newProduct:''
            })
        }

        }

        findProduct(id:number,type:string):Product{
            let result= null;
            switch (type){
                case 'L':
                result = this.products.find(x=>x.id==id);
                break;
                case 'M':
                result = this.medicines.find(x=>x.id==id);
                break;
                case 'E':
                result = this.specilizedimages.find(x=>x.id==id);
                break;
                case 'C':
                result = this.medicalSpecialities.find(x=>x.id==id);
                break;
            }
            return result;
        }
      async  deleteSelectedLabTests(index:number){
        const i = this.products.findIndex(x=>x.id==this.selectedLabTests[index].productId);
        if(i>=0){
            this.products[i].selected=false;

        }
        const test= this.selectedLabTests[index];
        this.itemForm.removeControl(`labResult_${test.id}`);
        this.selectedLabTests.splice(index,1);

        }

        async  deleteSelectedConsultation(index:number){
            this.selectedConsultations.splice(index,1);
        }

        async  deleteSelectedImage(index:number){
            const test= this.selectedImages[index];
            this.itemForm.removeControl(`imageResult_${test.id}`);
            this.selectedImages.splice(index,1);
        }

        async  deleteSelectedMedicine(index:number){
            this.selectedMedicines.splice(index,1);
        }

        cancel(){
            this.clearBackupData();
        this.router.navigateByUrl(`pages/patientcheckup/${this.patientId}/${this.appointmentId}`);
        }

        uploadClick(){
            document.getElementById('imageUpload').click();
          }
          fileSelectedUpload(arg:any){
            console.log(arg);
          this.uploader.uploadAll();
          }



}
