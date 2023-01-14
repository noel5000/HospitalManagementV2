import { Component, OnInit , Inject } from '@angular/core';
import { BaseComponent } from '../../../@core/common/baseComponent';
import {  AppRoles, ObjectTypes, Operations, QueryFilter } from '../../../@core/common/enums';
import { LanguageService } from '../../../@core/services/translateService';
import { Router } from '@angular/router';
import { TRNControlService } from '../../../@core/services/TRNControlService';
import { basename } from 'path';
import {IPaginationModel, IActionButtonModel } from '../../../@theme/components/pagination/pagination.component';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { NgbdModalConfirmAutofocus } from '../../../@theme/components/modal/modal.component';
import { ModalService } from '../../../@core/services/modal.service';
import { TRNControl } from '../../../@core/data/trnControlModel';
import { AppConfig } from '../../../@core/services/app.config';


declare const $: any;
@Component({
    selector: "trn-control-list",
    templateUrl: "./trnControlIndex.component.html",
    styleUrls: ["../trnControlStyles.component.scss"]
})
export class TRNControlIndexComponent extends BaseComponent implements OnInit {
    ngOnInit(): void {
        this.verifyUser();
        this.getPagedData(1);
    }
    modalRef:NgbModalRef=null;
    tableConfig:IPaginationModel[]=[]
    actions:IActionButtonModel[]=[];
    pageNumber:number=1;
    pageSize:number=10;
    maxCount:number=0;
    filters: QueryFilter[] = [];
    orderBy: string = 'Id';
    orderDirection: string = 'desc';
    TRNControls:TRNControl[]=[];


    constructor(@Inject('BASE_URL') private baseUrl: string,
        private config: AppConfig,
        route: Router,
        langService: LanguageService,
        private service: TRNControlService,
        private modals:NgbModal,
       modalService:ModalService
    ) {
        super(route, langService, AppRoles.Config_TrnControl,modalService);
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
    id:'name',
    type:'text',
    isTranslated:true,
    name:this.lang.getValueByKey('name_lbl'),
    sorting:'desc',
    toSort:false,
    objectType:ObjectTypes.String,
    filterIsActive:true
  },
  {
    visible:true,
    id:'series',
    type:'text',
    isTranslated:false,
    name:scope.lang.getValueByKey('series_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.String,
    filterIsActive:true
  },
  {
    visible:true,
    id:'type',
    type:'text',
    isTranslated:false,
    name:scope.lang.getValueByKey('type_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.String,
    filterIsActive:true
  },
  {
    visible:true,
    id:'sequence',
    type:'number',
    isTranslated:false,
    name:scope.lang.getValueByKey('sequence_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.Number,
    filterIsActive:true
  },
  {
    visible:true,
    id:'numericControl',
    type:'number',
    isTranslated:false,
    name:scope.lang.getValueByKey('numericControl_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.Number,
    filterIsActive:true
  },
  {
    visible:true,
    id:'quantity',
    type:'number',
    isTranslated:false,
    name:scope.lang.getValueByKey('quantity_lbl'),
    sorting:'desc',
    toSort:true,
    objectType:ObjectTypes.Number,
    filterIsActive:true
  },
        ];
this.actions=[
    {
        title:scope.lang.getValueByKey('edit_btn'),
        class:'btn btn-primary mx-1 my-1',
        icon:'',
        id:'edit',
        visible:()=>{
            return this.isUserValidOperation(Operations.UPDATE);
        }
    },
    {
        title:scope.lang.getValueByKey('delete_btn'),
        class:'btn btn-danger mx-1 my-1',
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
            this.TRNControls=r['value'];
          
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
        this.router.navigateByUrl(`pages/trncontrol/add`);
    }
    edit(e:TRNControl) {
        this.router.navigateByUrl(`pages/trncontrol/edit/${e.id}`);
    }
    source:any={};
    onDeleteConfirm(event:TRNControl): void {
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