import { BaseService } from './baseService';
import { endpointUrl, endpointControllers } from '../common/constants';
import { HttpClient } from '@angular/common/http';
import { Injectable , Inject } from '@angular/core';
import { TRNControl } from '../data/trnControlModel';
import { AppConfig } from './app.config';

@Injectable({
    providedIn: "root"
})

export class TRNControlService extends BaseService<TRNControl, number>{
  constructor(
    @Inject('BASE_URL') private baseUrl2: string,
        private config: AppConfig,
        http: HttpClient
    ) {
    super(http, `${baseUrl2}api/${endpointControllers.trncontrol}`);
    }
}
