import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, ObjectTypes, Operations, QueryFilter } from '../../../@core/common/enums';
import { LanguageService } from '../../../@core/services/translateService';
import { Router } from '@angular/router';
import { basename } from 'path';
import {IPaginationModel, IActionButtonModel } from '../../../@theme/components/pagination/pagination.component';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { NgbdModalConfirmAutofocus } from '../../../@theme/components/modal/modal.component';
import { ModalService } from '../../../@core/services/modal.service';
import { HttpClient } from '@angular/common/http';
import { endpointUrl } from '../../../@core/common/constants';
import { BaseService } from '../../../@core/services/baseService';
import { AppConfig } from '../../../@core/services/app.config';


declare const $: any;
@Component({
    selector: "insuranceCoverage-list",
    templateUrl: "./insuranceCoverageIndex.component.html",
})
export class insuranceCoverageIndexComponent extends BaseComponent implements OnInit {
    ngOnInit(): void {
        this.verifyUser();
        this.getPagedData(1);
    }
    modalRef:NgbModalRef=null;
    tableConfig:IPaginationModel[]=[]
    actions:IActionButtonModel[]=[];    
    service:BaseService<any,number>= new BaseService<any,number>(this.http, `${this.config.config.endpointUrl}InsuranceServiceCoverage`);
    pageNumber:number=1;
    pageSize:number=10;
    maxCount:number=0;
    filters: QueryFilter[] = [
        {
            property: "Insurance",
            value: "Name",
            type: ObjectTypes.ChildObject,
            isTranslated:false
        },
        {
            property: "InsurancePlan",
            value: "Name",
            type: ObjectTypes.ChildObject,
            isTranslated:false
        },
        
        {
            property: "Currency",
            value: "Name",
            type: ObjectTypes.ChildObject,
            isTranslated:false
        },
        
        {
            property: "Product",
            value: "Name",
            type: ObjectTypes.ChildObject,
            isTranslated:false
        }
        ];
    orderBy: string = 'Id';
    orderDirection: string = 'desc';
    insuranceCoverages:any[]=[];


    constructor(
        private config: AppConfig,
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
        private http:HttpClient,
       modalService:ModalService
    ) {
        super(route, langService, AppSections.Users,modalService);
        this.section=AppSections.Users;
        let scope = this;
       
        this.tableConfig=[
{
  visible:true,
  id:'id',
  type:'number',
  isTranslated:false,
  name:scope.lang.getValueByKey('id_lbl'),
  sorting:'desc',
  toSort:true,
  objectType:ObjectTypes.Number,
  filterIsActive:true
},
{
    visible:true,
    id:'insuranceId',
    fieldToShow:'insurance.name',
    objectTypeToShow:ObjectTypes.String,
    type:'text',
    isTranslated:false,
    name:scope.lang.getValueByKey('insurance_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.String,
    filterIsActive:true
 },
 {
    visible:true,
    id:'insurancePlanId',
    fieldToShow:'insurancePlan.name',
    type:'text',
    isTranslated:false,
    name:scope.lang.getValueByKey('insurancePlan_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.String,
    filterIsActive:true
 },
 {
    visible:true,
    id:'productId',
    fieldToShow:'product.name',
    type:'text',
    isTranslated:true,
    name:scope.lang.getValueByKey('consultation_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.String,
    filterIsActive:true
 },
 {
    visible:true,
    id:'currencyId',
    fieldToShow:'currency.name',
    type:'text',
    isTranslated:true,
    name:scope.lang.getValueByKey('currency_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.String,
    filterIsActive:true
 },
 {
    visible:true,
    id:'coverageAmount',
    type:'number',
    isTranslated:false,
    name:scope.lang.getValueByKey('coverageAmount_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.String,
    filterIsActive:true
 },
        ];
this.actions=[
    {
        title:scope.lang.getValueByKey('edit_btn'),
        class:'btn btn-primary',
        icon:'',
        id:'edit',
        visible:()=>{
            return this.isUserValidOperation(Operations.UPDATE);
        }
    },
    {
        title:scope.lang.getValueByKey('delete_btn'),
        class:'btn btn-danger',
        icon:'',
        id:'delete',
        visible:()=>{
            return this.isUserValidOperation(Operations.DELETE);
        }
    }
];
       
    }

    rowAction(e){
        if(e && e.action && e.item){
            switch(e.action.id){
                case 'edit':
                    this.edit(e.item);
                    break;
                case 'delete':
                    this.onDeleteConfirm(e.item);
                    break;
            }
        }
    }

    getData() {
        this.service.getFiltered(this.pageNumber, this.pageSize, this.filters, this.orderBy, this.orderDirection).subscribe(r => {

            this.maxCount = r['@odata.count']?r['@odata.count']:0;
            this.insuranceCoverages=r['value'];
          
        },
            error => {
                 this.modalService.showError(`${this.lang.getValueByKey(error.message)}`);
            }
        )
    }
addFilter(e){
const config = e.config as IPaginationModel;
if(e.value)
this.filterData(e.value,config.fieldToShow?config.fieldToShow: config.id,config.objectTypeToShow?config.objectTypeToShow: config.objectType,config.isTranslated);
else{
   const index=  this.filters.findIndex(x=>x.property==(config.fieldToShow?config.fieldToShow:config.id));
  if(index>-1){
      this.filters.splice(index,1);
    this.getPagedData(1);
  }
}


}
    getPagedData(page:number) {
        this.pageNumber = page?page:1;
        this.orderBy=this.tableConfig.find(x=>x.toSort).id;
        this.orderDirection=this.tableConfig.find(x=>x.toSort).sorting;
        this.getData();
    }

    onSort(e){
        let temp = e as IPaginationModel;
       let config = {
           sorting:temp.sorting,
           toSort:true,
           visible:temp.visible,
            id:temp.id,
  type:temp.type,
  isTranslated:temp.isTranslated,
  name:temp.name,
  objectType:temp.objectType,
  filterIsActive:temp.filterIsActive
       };
       config.sorting=config.sorting=='desc'?'asc':'desc';
       config.toSort=true;
       this.tableConfig.forEach(c=>c.toSort=false);
       const index = this.tableConfig.findIndex(x=>x.id==config.id);
       if(index!== -1)
       this.tableConfig[index]=config;

       this.getPagedData(1);
    }
 

    filterData(currentValue: string, propertyName: string, propertyType: ObjectTypes, isTranslated:boolean=false) {
        const scope = this;
        let currentFilter = {
            property: propertyName,
            value: currentValue,
            type: propertyType,
            isTranslated:isTranslated
        } as QueryFilter;
        const index = this.filters.findIndex(x => x.property == currentFilter.property);
        if (index >= 0) {
            this.filters.splice(index, 1);
            this.filters.push(currentFilter);
        }
        else {
            this.filters.push(currentFilter);
        }
                scope.getData();  
       
      
           
      
        


    }

    addNew() {
        this.router.navigateByUrl(`pages/insuranceCoverage/add`);
    }
    edit(e:any) {
        this.router.navigateByUrl(`pages/insuranceCoverage/edit/${e.id}`);
    }
    source:any={};
    onDeleteConfirm(event:any): void {
 var result =       this.modalService.confirmationModal({
            titleText:this.lang.getValueByKey('deleteConfirm_lbl'),
            bodyText:this.lang.getValueByKey('areYouSure_lbl'),
            cancelButtonText:this.lang.getValueByKey('cancel_btn'),
            okText:this.lang.getValueByKey('ok_btn'),
        });
  result.subscribe(r=>{
      if(r)
      this.delete(event.id);
  })
   
    }

    delete(id: number) {
        this.service.delete(id).subscribe(r => {
            if (r.status >= 0) {
                this.modalService.showSuccess(this.lang.getValueByKey('success_msg'))
                this.getData();
            }
            else
             this.modalService.showError(r.message);
        },
            error => {
                this.modalService.showError();
            })
    }
}