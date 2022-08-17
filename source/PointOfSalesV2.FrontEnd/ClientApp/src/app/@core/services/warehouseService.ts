import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Warehouse } from '../data/warehouse';
import { AppConfig } from './app.config';

@Injectable({
    providedIn: "root"
})

export class WarehouseService extends BaseService<Warehouse, number>{
    constructor( private config: AppConfig,
        http: HttpClient
    ) {
        super(http, `${config.config.endpointUrl}${endpointControllers.warehoses}`);
    }
}