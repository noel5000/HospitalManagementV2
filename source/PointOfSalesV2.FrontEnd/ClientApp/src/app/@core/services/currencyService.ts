import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Currency } from '../data/currencyModel';
import { AppConfig } from './app.config';

@Injectable({
    providedIn: "root"
})

export class CurrencyService extends BaseService<Currency, number>{
    constructor(
        private config: AppConfig,
        http: HttpClient
    ) {
        super(http, `${config.config.endpointUrl}${endpointControllers.currencies}`);
    }
}