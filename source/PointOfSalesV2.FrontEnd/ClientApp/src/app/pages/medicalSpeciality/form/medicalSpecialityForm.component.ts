

import { Component, OnInit , Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppRoles } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { HttpClient } from '@angular/common/http';
import { BaseService } from '../../../@core/services/baseService';
import { endpointUrl } from '../../../@core/common/constants';
import { AppConfig } from '../../../@core/services/app.config';


declare const $: any;
@Component({
    selector: "medicalSpeciality-form",
    templateUrl: "./medicalSpecialityForm.component.html",
})
export class medicalSpecialityFormComponent extends BaseComponent implements OnInit {

    _route:ActivatedRoute;
    service:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.baseUrl}api/MedicalSpeciality`);
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
           
            super(route, langService, AppRoles.Medical_Specialities,modalService);
            this._route=router;
        this.itemForm = this.formBuilder.group({
            name: ['',[ Validators.required,Validators.minLength(1), Validators.maxLength(50)]],
            id: [0]
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
    }

   async getItem(id:number){
    this.service.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
            this.itemForm.patchValue({
                id:this.item.id,
                name:this.item.name
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
       const formValue = this.itemForm.value ;
      
           if(!this.item)
           this.item = {active:true};

        this.item = this.updateModel<any>(formValue,this.item);
        this.item.active=true;
            const subscription = this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/medicalSpeciality');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/medicalSpeciality');
    }
}