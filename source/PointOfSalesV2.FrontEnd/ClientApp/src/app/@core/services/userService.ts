import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../data/users';
import { AppConfig } from './app.config';

@Injectable({
    providedIn: "root"
})

export class UserService extends BaseService<User, string>{
    constructor( private config: AppConfig,
        http: HttpClient
    ) {
        super(http, `${config.config.endpointUrl}${endpointControllers.users}`);
    }
}