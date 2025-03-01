import { BaseModel } from './baseModel';
import { Currency } from './currencyModel';
import { Tax } from './taxModel';
import { Unit } from './unitModel';


export class Product extends BaseModel {

    description:string ='';
    price:number =0;
    price2:number =0;
    price3:number =0;
    code:string ='';
    isService:boolean = false;
    isCompositeProduct:boolean = false;
    cost:number =0;
    sellerRate:number =0;
    currencyId:number =0;
    existence:number =0;
    name:string ='';
    details:string ='';
    currency :Currency | null = null
    medicalSpecialityId:number=0;
    taxes:any[]=[];
    type:string ='';
    medicalSpeciality:any;
    selected:boolean=false;
    productUnits:any[]=[];
    baseCompositeProducts:any[]=[];
    suppliersCosts:any[]=[];
}
export class ProductTax extends BaseModel {

    productId:number =0;
    taxId:number =0;
    tax:Tax | null = null;
}

export class UnitProductEquivalence extends BaseModel {

         unitId:number =0;
         productId:number =0;
         equivalence:number =0;
         isPrimary :boolean = false;
         order :number =0;
         costPrice :number =0;
         sellingPrice :number =0;
         unit:Unit | null = null;
}

export class CompositeProduct extends BaseModel {

        ProductId :number =0;
        currencyId:number =0;
        BaseProductId:number =0;
        BaseProductUnitId :number =0;
        Quantity :number =0;
        TotalCost :number =0;
        TotalPrice :number =0;
        BaseProduct:Product | null = null;
        Product:Product | null = null;
        UnitProductEquivalence: UnitProductEquivalence | null = null;
        Currency: Currency | null = null;
}
