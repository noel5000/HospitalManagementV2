import { BaseService } from './baseService';
import { BranchOffice } from '../data/branchOffice';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable , Inject } from '@angular/core';
import { AppConfig } from './app.config';

@Injectable({
    providedIn: "root"
})

export class BranchOfficeService extends BaseService<BranchOffice, number>{
    constructor(
      private config: AppConfig,
      @Inject('BASE_URL') private baseUrl2: string,
        http: HttpClient
    ) {
      super(http, `${baseUrl2}api/${endpointControllers.branchOffices}`);
    }
}
