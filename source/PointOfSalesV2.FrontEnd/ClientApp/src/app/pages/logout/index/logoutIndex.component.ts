import { Component, OnInit , Inject } from '@angular/core';
import { LanguageService } from '../../../@core/services/translateService';
import { Router } from '@angular/router';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { AppConfig } from '../../../@core/services/app.config';


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
    service:BaseService<any,number>;


    constructor(@Inject('BASE_URL') private baseUrl: string,
        private config: AppConfig,
        langService: LanguageService,
        private modals:NgbModal,
       private router: Router,
      private modalService:ModalService,
       private  http: HttpClient,
    ) {

      this.service= new BaseService<any,number>(this.http, `${this.baseUrl}api/Logout`);
    }

}
