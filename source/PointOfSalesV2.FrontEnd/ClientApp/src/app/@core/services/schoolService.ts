import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { School } from '../data/school';
import { AppConfig } from './app.config';

@Injectable({
    providedIn: "root"
})

export class SchoolService extends BaseService<School, number>{
    constructor(
        private config: AppConfig,
        http: HttpClient
    ) {
        super(http, `${config.config.endpointUrl}${endpointControllers.schools}`);
    }
}