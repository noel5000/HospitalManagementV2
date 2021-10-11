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
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { endpointUrl } from '../../../@core/common/constants';


declare const $: any;
@Component({
    selector: "logout-list",
    templateUrl: "./logoutIndex.component.html"
})
export class LogoutIndexComponent  implements OnInit {
    ngOnInit(): void {
     this.service.post({}).subscribe(r=>{
         if(r.status>=0){
           localStorage.removeItem('currentUser')
          this.router.navigateByUrl('auth/login');

         }

         else
         this.modalService.showError(r.message);
     })
    }
    service:BaseService<any,number>= new BaseService<any,number>(this.http, `${endpointUrl}Logout`);


    constructor(
        langService: LanguageService,
        private modals:NgbModal,
       private router: Router,
      private modalService:ModalService,
       private  http: HttpClient,
    ) {


    }

}
