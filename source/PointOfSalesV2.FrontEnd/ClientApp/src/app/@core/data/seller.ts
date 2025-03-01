import { BaseModel } from './baseModel';
import { Zone } from './zoneModel';


export class Seller extends BaseModel {


    name:string ='';
    cardId :string ='';
    phoneNumber :string ='';
    address :string ='';
    code :string ='';
    zoneId :number =0;
    comissionRate:number =0;
    comissionByProduct :boolean = false;
    fixedComission :boolean = false;
    nameAndCode:string ='';
    zone: Zone | null = null;
}
