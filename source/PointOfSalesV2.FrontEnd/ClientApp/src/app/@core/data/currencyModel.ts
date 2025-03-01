import { BaseModel } from './baseModel';


export class Currency extends BaseModel {

    name: string = '';
    code: string = '';
    isLocalCurrency: boolean = false;
    exchangeRate: number = 0;
    updatedRate: boolean = false;
}
