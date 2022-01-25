import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Unit } from '../data/unitModel';
import { AppConfig } from './app.config';

@Injectable({
    providedIn: "root"
})

export class UnitService extends BaseService<Unit, number>{
    constructor(
        private config: AppConfig,
        http: HttpClient
    ) {
        super(http, `${config.config.endpointUrl}${endpointControllers.units}`);
    }
}