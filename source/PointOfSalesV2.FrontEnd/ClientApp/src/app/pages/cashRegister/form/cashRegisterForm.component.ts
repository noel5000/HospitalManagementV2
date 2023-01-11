

import { Component, OnInit , Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CashRegister } from '../../../@core/data/CashRegister';
import { LanguageService } from '../../../@core/services/translateService';
import { CashRegisterService } from '../../../@core/services/CashRegisterService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { BranchOffice } from '../../../@core/data/branchOffice';
import { BranchOfficeService } from '../../../@core/services/branchOfficeService';


declare const $: any;
@Component({
    selector: "cashregister-form",
    templateUrl: "./cashRegisterForm.component.html",
    styleUrls: ["../cashRegisterStyles.component.scss"]
})
export class CashRegisterFormComponent extends BaseComponent implements OnInit {
    _route:ActivatedRoute;
    branchOffices:BranchOffice[]=[];

    constructor(@Inject('BASE_URL') private baseUrl: string,
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private service: CashRegisterService,
        private modals:NgbModal,
        private branchOfficeService: BranchOfficeService,
       modalService:ModalService
        ){
           
            super(route, langService, AppSections.CashRegisters,modalService);
            this._route=router;
        this.itemForm = this.formBuilder.group({
            name: ['',[ Validators.required,Validators.minLength(3), Validators.maxLength(100)]],
            code: ['',[ Validators.required,Validators.minLength(1), Validators.maxLength(3)]],
            branchOfficeId: [0,[ Validators.required,Validators.min(1)]],
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
        this.getBranchOffices();
    }

   async getItem(id:number){
    this.service.getById(id).subscribe(r=>{
        if(r.status>=0){
            this.item=r.data[0];
            this.itemForm.patchValue({
                id:this.item.id,
                name:this.item.name,
                code:this.item.code,
                branchOfficeId:this.item.branchOfficeId
            });
        }
        this.validateFormData();
    })
    }
    setBranchOffice(branchOffice: BranchOffice){
        this.itemForm.patchValue({branchOfficeId:branchOffice.id});
    }
    async getBranchOffices (){
        this.branchOfficeService.getAll().subscribe(r=>{
            this.branchOffices=r;
        })
    }
    get form() { return this.itemForm.controls; }
    save(){
        if (this.itemForm.invalid) {
            return;
        }
       const formValue = this.itemForm.value as CashRegister;
      
           if(!this.item)
           this.item = new CashRegister();

           this.item = this.updateModel<CashRegister>(formValue,this.item);
           this.item.branchOfficeId= parseInt(this.item.branchOfficeId.toString());
            const subscription = this.id>0?this.service.put(this.item):this.service.post(this.item);
            subscription.subscribe(r=>{
               if(r.status>=0){
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
                this.clearBackupData();
                this.router.navigateByUrl('pages/cashregister');
               }
               else
               this.modalService.showError(r.message);
           })
    }

    cancel(){
        this.clearBackupData();
    this.router.navigateByUrl('pages/cashregister');
    }
}