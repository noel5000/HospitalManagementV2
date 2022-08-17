import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Supplier } from '../data/Supplier';
import { AppConfig } from './app.config';

@Injectable({
    providedIn: "root"
})

export class SupplierService extends BaseService<Supplier, number>{
    constructor(
        private config: AppConfig,
        http: HttpClient
    ) {
        super(http, `${config.config.endpointUrl}${endpointControllers.suppliers}`);
    }
}