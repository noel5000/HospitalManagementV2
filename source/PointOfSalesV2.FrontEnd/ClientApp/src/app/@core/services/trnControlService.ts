import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { TRNControl } from '../data/trnControlModel';
import { AppConfig } from './app.config';

@Injectable({
    providedIn: "root"
})

export class TRNControlService extends BaseService<TRNControl, number>{
    constructor(
        private config: AppConfig,
        http: HttpClient
    ) {
        super(http, `${config.config.endpointUrl}${endpointControllers.trncontrol}`);
    }
}