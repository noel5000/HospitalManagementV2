import { AppRoles,  Operations } from './enums';
import { Router } from '@angular/router';
import { AuthModel } from '../data/authModel';
import { LanguageService } from './../services/translateService';
import { OnInit , Inject } from '@angular/core';
import { User } from '../data/users';
import { FormGroup } from '@angular/forms';
import { ModalService } from '../services/modal.service';

export class BaseComponent  {
   
    constructor(route: Router, langService: LanguageService, role:AppRoles, modaService:ModalService) {
       
        this.lang = langService;
        this.router = route;
        this.role=role;
        this.modalService=modaService;
        this.backupData();
    }
 
    modalService:ModalService;
    itemForm: FormGroup;
    item: any;
    id:number=0;
    enableBackup:boolean=false;
    dataToBackup="";
    getLanguageValue(value){
        return this.lang.getValueByKey(value);
  }


    backupData(){
        // let scope=this;
        // const controllerUrl =window.location.href;
        // if(controllerUrl.includes("/add") || controllerUrl.includes("/edit"))
        // setInterval(function(){
        //     if(scope.itemForm!=null){
        //         let toSave={
        //             form:scope.itemForm.getRawValue(),
        //         }
        //         if(scope.dataToBackup && scope.dataToBackup.split(",").length>0){
                  
        //             scope.dataToBackup.split(',').forEach(data=>{
        //                 toSave[data]=scope[data];
        //             });
        //         }
        //         localStorage.setItem(`${scope.getUser().userId} - ${scope.role.toString()}`,JSON.stringify(toSave));
        //     }
         
        // },90000);
        // else
        this.clearBackupData();
  }
   dynamicSort(property) {
  var sortOrder = 1;
  if (property[0] === "-") {
    sortOrder = -1;
    property = property.substr(1);
  }
  return function (a, b) {
    /* next line works with strings and numbers, 
     * and you may want to customize it to your needs
     */
    var result = (a[property] < b[property]) ? -1 : (a[property] > b[property]) ? 1 : 0;
    return result * sortOrder;
  }
}

    verifyUser(){
        this.authModel = JSON.parse(localStorage.getItem('currentUser'));
        if (this.authModel && new Date(this.authModel.expiration) > new Date()) {
            this.getUserAuthorizations();
        }
        else
            this.returnToLogin();

    }
    validateFormData(){
        const stringForm= this.getUser().userId?  localStorage.getItem(`${this.getUser().userId} - ${this.role.toString()}`):null;
    if(stringForm && JSON.parse(stringForm)!=null){
        const savedForm = JSON.parse(stringForm);
      var result =       this.modalService.confirmationModal({
            titleText:this.lang.getValueByKey('savedFormData_lbl'),
            bodyText:this.lang.getValueByKey('areYouSure_lbl'),
            cancelButtonText:this.lang.getValueByKey('cancel_btn'),
            okText:this.lang.getValueByKey('ok_btn'),
        });
  result.subscribe(r=>{
      if(r){
        if(savedForm.form && this.itemForm!=null){
            if(this.dataToBackup && this.dataToBackup.split(',').length>0){
                this.dataToBackup.split(',').forEach(val=>{
                    this[val]=savedForm[val];
                });
            }
            this.setAdditionalBackupData();
            this.itemForm.patchValue(savedForm.form);
            this.onChanges();
            if(this.getUser() && this.getUser().userId)
            localStorage.removeItem(`${this.getUser().userId} - ${this.role.toString()}`);
         
            }
      }
      else
      this.clearBackupData();
     
    
  })
       
    }
    }
   setAdditionalBackupData(){

     }

     onChanges(): void{

     }
    clearBackupData(){
        if(this.getUser() && this.getUser().userId)
        localStorage.removeItem(`${this.getUser().userId} - ${this.role.toString()}`);
    }

    getUser():User{
        const user=    (JSON.parse(localStorage.getItem('currentUser')) as AuthModel);
        return user?user.user:{} as User;
    }

    getTotalAmount(items:any[],selector:string):number{
        let total=0;
        
          
                items.forEach(i=>{
                total+=i[selector];
            })
            
        
        return total;
    }

    updateModel<T>(model:any,toUpdate:T):T{
        for(var prop in model){
            toUpdate[prop]=model[prop];
        }

        return toUpdate;
    }
    role:AppRoles=null;
    authModel: AuthModel = null;
    permits: any = {};

    router: Router;
    lang: LanguageService;
    getUserAuthorizations() {
        const url = window.location.href;
        const sectionOperations = this.authModel.user.permissions.filter(x => x.roleId === this.role);
        this.permits.read = sectionOperations.length==0 || sectionOperations.findIndex(x => x.operationId === Operations.READ ||
            x.operationId === Operations.READALL) >= 0;
        this.permits.add = sectionOperations.length==0 || sectionOperations.findIndex(x => x.operationId === Operations.ADD) >= 0;
        this.permits.update = sectionOperations.length==0 || sectionOperations.findIndex(x => x.operationId === Operations.UPDATE) >= 0;
        this.permits.delete = sectionOperations.length==0 || sectionOperations.findIndex(x => x.operationId === Operations.DELETE) >= 0;
        this.permits.readPaged =sectionOperations.length==0 || sectionOperations.findIndex(x => x.operationId === Operations.READALL) >= 0;

        if (sectionOperations.findIndex(x => x.operationId === Operations.ALL) >= 0 || sectionOperations.length == 0) {
            this.permits = { read: true, update: true, delete: true, add: true, readPaged: true };
        }
        if (!this.permits.read || ((url.indexOf('add')>=0 || url.indexOf('edit')>=0) &&!this.permits.add && !this.permits.update && !this.permits.delete)) {
            this.returnToLogin();
        }
        const currentUrl = this.router.url.split('/');
        if ((currentUrl.indexOf('add') >= 0 && !this.permits.add) || (currentUrl.indexOf('edit') >= 0 && !this.permits.update))
            this.returnToLogin();
    }

    isUserValidOperation(operation:Operations):boolean{
       try{
           this.verifyUser();
           
           return this.authModel.user.permissions.length==0 || this.authModel.user.permissions.findIndex(x=>x.roleId==this.role && x.operationId==operation)>=0
           || this.authModel.user.permissions.findIndex(x=>x.roleId==this.role && x.operationId==Operations.ALL)>=0;
       }
       catch{
           return false;
       }
    }


    returnToLogin() {
        var auth = JSON.parse(localStorage.getItem(`currentUser`)) as AuthModel;
        if(!auth)
        {
            auth=new AuthModel();
            auth.languageId='EN';
        }
        localStorage.setItem(`language-${auth.languageId}`, null);
        localStorage.setItem('currentUser', null);
        this.lang.setLanguageInHeaders('EN');
        this.lang.setCurrentLanguage('EN');
        this.authModel = null;
        this.router.navigateByUrl('auth/login');
    }
}
