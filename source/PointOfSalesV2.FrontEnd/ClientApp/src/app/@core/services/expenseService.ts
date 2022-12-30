import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable , Inject } from '@angular/core';
import { Expense } from '../data/expenseModel';
import { BaseResultModel } from '../data/baseResultModel';
import { Observable } from 'rxjs';
import { AppConfig } from './app.config';

@Injectable({
    providedIn: "root"
})

export class ExpenseService extends BaseService<Expense, number>{
  constructor(
    @Inject('BASE_URL') private baseUrl2: string,
        private config: AppConfig,
        http: HttpClient
    ) {
    super(http, `${baseUrl2}api/${endpointControllers.expenses}`);
    }


    getExpensesToPay(searchModel: any, languageId: string = ""): Observable<Expense[]> {
        this.setHttpOptions();
        this.setLanguageInHeaders(languageId);
        return this._httpClient.post<Expense[]>(
            this.baseUrl+'/GetOwedExpenses',
            searchModel,
            !languageId ? this.httpOptions : this.tempHttpOptions
        );
    }
}
