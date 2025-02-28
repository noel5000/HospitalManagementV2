import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ConfigModel } from '../data/configModel';

@Injectable()
export class AppConfig {

    public config: ConfigModel | null = null;

    constructor(@Inject('BASE_URL') private baseUrl: string,private http: HttpClient) {

    }

    /**
     * Use to get the data found in the second file (config file)
     */
    public getConfig(key: any) {
        return (this.config as any)[key];
    }



    /**
     * This method:
     *   a) Loads "env.json" to get the current working environment (e.g.: 'production', 'development')
     *   b) Loads "config.[env].json" to get all env's variables (e.g.: 'config.development.json')
     */
     public async load() {

        let  request = await this.http.get<any>('assets/config/config.json').toPromise();

              this.config = request;


      }
}
