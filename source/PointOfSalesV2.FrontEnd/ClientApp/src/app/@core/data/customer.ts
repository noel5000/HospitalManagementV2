import { BaseModel } from './baseModel';
import { Currency } from './currencyModel';
import { TRNControl } from './trnControlModel';


export class Customer extends BaseModel {
    trnControlId:number;
    name:string;
    cardId :string;
    phoneNumber :string;
    address :string;
    code :string;
    currencyId :number;
    warehouseId:number;
    zoneId :number;
    comissionRate:number; 
    comissionByProduct :boolean;
    fixedComission :boolean;
    nameAndCode:string;
    currency: Currency; 
    invoiceDueDays:number;
    billingAmountLimit:number;
    creditAmountLimit:number;
    trnType:string;
    trnControl:TRNControl;
    insuranceId?:number;
    insurancePlanId?:number;
    insurance:any;
    insurancePlan:any;
    insuranceCardId:string;     
    bloodType:string;
    informante :string;
         ahf :string;
         apnp :string;
         antecedentesPerinatales :string;
         desarrolloPsicomotor :string;
         antecedentesPatologicos :string;
         padenciaActual :string;
         exploracionFisica :string;
         espirometria :string;
         paraclinicos :string;
         diagnosticos :string;
         planTerapeutico :string;
         estadoDeSalud :string;
}