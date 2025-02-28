import { BaseModel } from './baseModel';
import { Currency } from './currencyModel';
import { TRNControl } from './trnControlModel';


export class Customer extends BaseModel {
    trnControlId:number = 0;
    name:string = '';
    cardId :string = '';
    phoneNumber :string = '';
    address :string = '';
    code :string = '';
    currencyId :number = 0;
    warehouseId:number = 0;
    zoneId :number = 0;
    comissionRate:number = 0;
    comissionByProduct :boolean = false;
    fixedComission :boolean = false;
    nameAndCode:string = '';
    currency: Currency = new Currency();
    invoiceDueDays:number = 0;
    billingAmountLimit:number = 0;
    creditAmountLimit:number = 0;
    trnType:string = '';
    trnControl:TRNControl = new TRNControl();
    insuranceId?:number = 0;
    insurancePlanId?:number = 0;
    insurance:any;
    insurancePlan:any;
    insuranceCardId:string = '';
    bloodType:string = '';

}
