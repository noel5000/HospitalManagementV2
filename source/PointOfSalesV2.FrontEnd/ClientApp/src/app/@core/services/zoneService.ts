import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Zone } from '../data/zoneModel';
import { AppConfig } from './app.config';

@Injectable({
    providedIn: "root"
})

export class ZoneService extends BaseService<Zone, number>{
    constructor( private config: AppConfig,
        http: HttpClient
    ) {
        super(http, `${config.config.endpointUrl}${endpointControllers.zones}`);
    }
}