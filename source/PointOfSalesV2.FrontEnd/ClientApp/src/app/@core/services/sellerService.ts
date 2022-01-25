import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Seller } from '../data/seller';
import { AppConfig } from './app.config';

@Injectable({
    providedIn: "root"
})

export class SellerService extends BaseService<Seller, number>{
    constructor(
        private config: AppConfig,
        http: HttpClient
    ) {
        super(http, `${config.config.endpointUrl}${endpointControllers.sellers}`);
    }
}