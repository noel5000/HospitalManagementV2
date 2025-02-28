

import { Component, OnInit , Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import {  QueryFilter, ObjectTypes, ODataComparers, AppRoles } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { Role } from '../../../@core/data/roleModel';
import { AppConfig } from '../../../@core/services/app.config';


declare const $: any;
@Component({
  standalone:false,
    selector: "role-form",
    templateUrl: "./roleForm.component.html",
    styleUrls: ["../roleStyles.component.scss"]
})
export class RoleFormComponent extends BaseComponent implements OnInit {

    isServiceFlag:boolean=false;
    isCompositeFlag:boolean=false;

    _route:ActivatedRoute;
    roleSectionOperations:any[]=[];
    sections:any[]=[];
    operations:any[]=[];
    sectionOperations:any[]=[];
    roleService:BaseService<any,number>;
    sectionOperationService:BaseService<any,number>;
    operationsService:BaseService<any,number>;
    sectionService:BaseService<any,number>;
    roleSectionOperationService:BaseService<any,number>;


    constructor(@Inject('BASE_URL') private baseUrl: string,
        private config: AppConfig,
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
       modalService:ModalService,
      private  http: HttpClient
        ){

            super(route, langService, AppRoles.Authorization_roles,modalService);
            this.roleService= new BaseService<any,number>(this.http, `${this.baseUrl}api/Role`);
            this.sectionOperationService= new BaseService<any,number>(this.http,`${this.baseUrl}api/SectionOperation`);
            this.operationsService= new BaseService<any,number>(this.http,`${this.baseUrl}api/operation`);
            this.sectionService= new BaseService<any,number>(this.http,`${this.baseUrl}api/Section`);
            this.roleSectionOperationService= new BaseService<any,number>(this.http,`${this.baseUrl}api/RoleSectionOperation`);
            this._route=router;
        this.itemForm = this.formBuilder.group({
            id: [0],
            sectionId: [''],
            name: ['',[Validators.required,Validators.minLength(1)]],
            operationId:[0]
        });
    }
    ngOnInit(): void {
     const urlId= parseInt( this._route.snapshot.paramMap.get('id') ?? "");
     if(!isNaN(urlId)){
        this.id=urlId;
        this.getItem(urlId);
     }
     else
     this.validateFormData();

     this.onChanges();
        this.verifyUser();
        this.getAllSections();
        this.getAllOperations();

    }
async getAllSections(){
    this.sectionService.getAll().subscribe(r=>{this.sections=r.sort(this.dynamicSort('name'))});
}
async getAllOperations(){
  this.operationsService.getAll().subscribe(r=>{this.operations=r.sort(this.dynamicSort('name'))});
}

async getRoleSectionOperations(id:number){
    this.roleSectionOperationService.getAllFiltered(
        [
            {
                property: 'RoleId',
                value: id.toString(),
                type: ObjectTypes.Number,
                isTranslated:false
            } as QueryFilter,
            {
                property: "Operation",
                value: "Id,Name",
                type: ObjectTypes.ChildObject,
                isTranslated: false
            } as QueryFilter,
        ]
    ).subscribe(r=>{
        this.roleSectionOperations=r['value'];
    });
}


   async getItem(id:number, refreshForm=true){
    this.roleService.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
            this.itemForm.patchValue({
                id:this.item.id,
                name:this.item.name,
            });
            this.getRoleSectionOperations(this.item.id);
        }

        this.validateFormData();
    })
    }
    override onChanges(): void {

      }
    get form() { return this.itemForm.controls as any; }
    save(){
        if (this.itemForm.invalid) {
            return;
        }
       const formValue = this.itemForm.value as Role;

           if(!this.item)
           this.item = new Role();
           this.item=  this.updateModel<Role>(formValue,this.item);
            const subscription = this.id>0?this.roleService.put(this.item):this.roleService.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.router.navigateByUrl(`pages/role/edit/${r.id}`);
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
    this.router.navigateByUrl(`pages/role`);
    }


    deleteSectionOperation(operation:any){
       this.roleSectionOperationService.delete(operation.id).subscribe(r=>{this.getItem(this.id)});
    }

    saveSectionOperation(){
        const formVal = this.itemForm.value;
        const toSave ={
            id:0,
            roleId:formVal.id,
            section:formVal.sectionId,
            operationId:formVal.operationId,
            active:true
        };

        this.roleSectionOperationService.post(toSave).subscribe(r=>{

            if(r.status>=0)
            this.modalService.showSuccess('success_msg')
            else
            this.modalService.showError(r.message);

            this.getItem(this.id);
        });
    }
}
