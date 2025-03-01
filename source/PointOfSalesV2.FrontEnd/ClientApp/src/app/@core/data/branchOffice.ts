import { BaseModel } from './baseModel';


export class BranchOffice extends BaseModel {

    name: string;
    address: string;
    phoneNumber: string;
    nrc: string;
    email: string;
    warehouses: any[];
    users:any[];
    cashRegisters:any[];
}