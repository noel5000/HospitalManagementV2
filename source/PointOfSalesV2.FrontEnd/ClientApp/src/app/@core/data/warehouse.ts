import { BaseModel } from './baseModel';
import { BranchOffice } from './branchOffice';


export class Warehouse extends BaseModel {

     branchOfficeId :number = 0;
     code:string = '';
     name :string = '';
     inventory :any[] = [];
     branchOffice :BranchOffice | null = null;

}
