import { BaseModel } from './baseModel';
import { BranchOffice } from './branchOffice';
import { Currency } from './currencyModel';
import { User } from './users';
import { CashRegister } from './cashRegister';


export class CashRegisterOpening extends BaseModel {
      userId :string = '';
      currencyId :number=0;
      cashRegisterId :number=0;
      branchOfficeId :number=0;
      openingDate :Date | null = null;
      maxClosureDate :Date | null = null;
      closureDate :Date | null = null;
      totalPaymentsAmount :number=0;
      openingClosureDifference :number=0;
      userName :string='';
      details:OpeningType[]=[];
      state :string = '';
      totalOpeningAmount :number=0;
      totalClosureAmount :number=0;
      cashRegister :CashRegister | null = null;
      isClosing:boolean=false;
      user: User | null = null;
      currency :Currency | null = null;
      branchOffice: BranchOffice | null = null;
}
export class OpeningType extends BaseModel{
      type:string = '';
      cashRegisterOpeningId:number=0;
      details:string='';
      isClosing:boolean = false;
      totalAmount:number=0;

  }
