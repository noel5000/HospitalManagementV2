import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable , Inject } from '@angular/core';
import { User } from '../data/users';
import { AppConfig } from './app.config';

@Injectable({
    providedIn: "root"
})

export class UserService extends BaseService<User, string>{
  constructor(private config: AppConfig,
    @Inject('BASE_URL') private baseUrl2: string,
        http: HttpClient
    ) {
    super(http, `${baseUrl2}api/${endpointControllers.users}`);
    }
}
