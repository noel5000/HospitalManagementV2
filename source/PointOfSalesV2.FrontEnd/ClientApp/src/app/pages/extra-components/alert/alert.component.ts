import { Component, Input , Inject } from '@angular/core';
import { LanguageService } from '../../../@core/services/translateService';

@Component({
  selector: 'ngx-alert',
  templateUrl: 'alert.component.html',
})
export class AlertComponent {

    constructor(@Inject('BASE_URL') private baseUrl: string,private lang:LanguageService){

    }
   @Input() title:string;
   @Input() message:string;
}