

import { Component, OnInit , Inject } from '@angular/core';
import { LanguageService } from '../../../@core/services/translateService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import {  AppRoles } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { Item } from '../../../@core/data/itemModel';
import { AppConfig } from '../../../@core/services/app.config';


declare const $: any;
@Component({
    selector: "invoice-lead-print",
    templateUrl: "./appointmentPrint.component.html",
    styleUrls: ["../appointmentStyles.component.scss"]
})
export class appointmentPrintComponent extends BaseComponent implements OnInit {

    override item: any={leadDetails:[],customer:{},currency:{},invoiceNumber:''};
    menuId:number=0;
    schoolId:number=0;
    showColumns:any={};
    leadId:number=0;
    currentDate:string='';
    sequence:string='';
    _route:ActivatedRoute;
    appointmentsService:BaseService<any,number>;
    weeksOfMonth:Item[]=[
        {
            id:null,
            name:``
        },
        {
            id:0,
            name:`${this.lang.getValueByKey('week_lbl')} 1`
        },
         {
            id:1,
            name:`${this.lang.getValueByKey('week_lbl')} 2`
        },
        {
            id:2,
            name:`${this.lang.getValueByKey('week_lbl')} 3`
        },
        {
            id:3,
            name:`${this.lang.getValueByKey('week_lbl')} 4`
        },
        {
            id:4,
            name:`${this.lang.getValueByKey('week_lbl')} 5`
        },
    ];

    daysOfWeek:Item[]=[
        {
            id:null,
            name:``
        },
        {
            id:1,
            name:`${this.lang.getValueByKey('monday_lbl')}`
        },
         {
            id:2,
            name:`${this.lang.getValueByKey('tusday_lbl')}`
        },
        {
            id:3,
            name:`${this.lang.getValueByKey('wendsday_lbl')}`
        },
        {
            id:4,
            name:`${this.lang.getValueByKey('thursday_lbl')}`
        },
        {
            id:5,
            name:`${this.lang.getValueByKey('friday_lbl')}`
        },
    ];

    constructor(@Inject('BASE_URL') private baseUrl: string, private config: AppConfig,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
         modalService:ModalService,
      private  http: HttpClient
        ){
      super(route, langService, AppRoles.Appointments,modalService);
      this.appointmentsService= new BaseService<any,number>(this.http, `${this.baseUrl}api/appointment`);
      this._route = router;
    }
    ngOnInit(): void {

        this.verifyUser();

    }




    getCurrentLead(){
        this.appointmentsService.getByUrlParameters(['GetLeadForPrint',this.leadId.toString(),this.menuId.toString(),this.schoolId.toString(),this.sequence])
        .subscribe(r=>{

            if(r.status>=0){

               this.item=r.data[0];
            }
            else
            this.modalService.showError(r.message);
        })
    }


}
