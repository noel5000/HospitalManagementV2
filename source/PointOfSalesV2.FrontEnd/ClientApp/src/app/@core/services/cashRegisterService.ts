import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Warehouse } from '../data/warehouse';
import { CashRegister } from '../data/cashRegister';
import { AppConfig } from './app.config';

@Injectable({
    providedIn: "root"
})

export class CashRegisterService extends BaseService<CashRegister, number>{
    constructor(
        private config: AppConfig,
        http: HttpClient
    ) {
        super(http, `${config.config.endpointUrl}${endpointControllers.cashRegister}`);
    }
}