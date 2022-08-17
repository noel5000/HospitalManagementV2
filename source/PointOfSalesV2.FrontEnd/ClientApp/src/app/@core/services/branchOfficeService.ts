import { BaseService } from './baseService';
import { BranchOffice } from '../data/branchOffice';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AppConfig } from './app.config';

@Injectable({
    providedIn: "root"
})

export class BranchOfficeService extends BaseService<BranchOffice, number>{
    constructor(
        private config: AppConfig,
        http: HttpClient
    ) {
        super(http, `${config.config.endpointUrl}${endpointControllers.branchOffices}`);
    }
}