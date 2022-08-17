import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Customer } from '../data/customer';
import { AppConfig } from './app.config';

@Injectable({
    providedIn: "root"
})

export class CustomerService extends BaseService<Customer, number>{
    constructor(
        private config: AppConfig,
        http: HttpClient
    ) {
        super(http, `${config.config.endpointUrl}${endpointControllers.customers}`);
    }
}