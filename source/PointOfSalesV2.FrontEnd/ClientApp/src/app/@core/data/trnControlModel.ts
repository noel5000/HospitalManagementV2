import { BaseModel } from './baseModel';


export class TRNControl extends BaseModel {

    name: string = '';
    series:string ='';
    type:string ='';
    sequence :number =0;
    numericControl :number =0;
    quantity :number =0;
}
