

import { Component, OnInit , Inject } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import {  AppRoles } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { AppConfig } from '../../../@core/services/app.config';


declare const $: any;
@Component({
    selector: "invoice-payment-print",
    templateUrl: "./invoicePaymentPrint.component.html",
    styleUrls: ["../invoicePaymentStyles.component.scss"]
})
export class InvoicePaymentPrintComponent extends BaseComponent implements OnInit {

    override item: any={customer:{},currency:{},invoiceNumber:'',sequence:''};

    showColumns:any={};
    sequence:string='';
    paidInvoices:any[]=[];
    _route:ActivatedRoute;
    service:BaseService<any,number>;


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

            super(route, langService, AppRoles.Invoices_Payments,modalService);
            this.service = new BaseService<any,number>(this.http, `${this.baseUrl}api/CustomerPayment`);
            this._route=router;
            this.sequence= this._route.snapshot.paramMap.get('sequence') ?? '';
            this.getCurrent();



    }
    ngOnInit(): void {

        this.verifyUser();

    }




    getCurrent(){
        this.service.getByUrlParameters(['GetForPrint',this.sequence])
        .subscribe(r=>{

            if(r.status>=0){

               this.item=r.data[0];
               this.paidInvoices=this.item.paidInvoices;
            }
            else
            this.modalService.showError(r.message);
        })
    }


}
