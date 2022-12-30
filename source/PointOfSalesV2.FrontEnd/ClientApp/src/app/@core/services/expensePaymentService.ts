import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable , Inject } from '@angular/core';
import { Expense } from '../data/expenseModel';
import { Observable } from 'rxjs';
import { BaseResultModel } from '../data/baseResultModel';
import { ExpensePayment } from '../data/expensePayment';
import { AppConfig } from './app.config';

export interface ISupplierPayment{
    payment:any;
    expenses:any[];
}

@Injectable({
    providedIn: "root"
})
export class ExpensePaymentService extends BaseService<ExpensePayment, number>{
    constructor(
      private config: AppConfig,
      @Inject('BASE_URL') private baseUrl2: string,
        http: HttpClient
    ) {
      super(http, `${baseUrl2}api/${endpointControllers.expensePayment}`);
    }

    PayExpenses(payment:ISupplierPayment,lang:string=''):Observable<any>{
        this.setHttpOptions();
        this.setLanguageInHeaders(lang);
        return this._httpClient.post<BaseResultModel<any>>(
            `${this.baseUrl}api/AddPayments`,
            payment,
            !lang ? this.httpOptions : this.tempHttpOptions
        );
    }
}
