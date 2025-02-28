import { BaseModel } from './baseModel';
import { Zone } from './zoneModel';


export class School extends BaseModel {


    name:string = '';
    assignedWarehouseId? :number = 0;
    currencyId :number = 0;
    customerId :number = 0;
    leadDueDays :number = 0;
    phoneNumber :string = '';
    address :string = '';
    code :string = '';
    zoneId? :number = 0;
    comissionRate:number = 0;
    comissionByProduct :boolean = false;
    fixedComission :boolean = false;
    nameAndCode:string = '';
    branchOfficeId?:number = 0;
    zone: Zone = new Zone();
    contacts:SchoolContact[] = [];
}

export class SchoolContact extends BaseModel {


    name:string = '';
    cardId :string = '';
    phoneNumber :string = '';
    address :string = '';
    position :string = '';
    schoolId:number = 0;
}
