import { BaseModel } from './baseModel';
import { BranchOffice } from './branchOffice';
import { Currency } from './currencyModel';
import { User } from './users';
import { CashRegister } from './cashRegister';


export class CashRegisterOpening extends BaseModel {
      userId :string = '';
      currencyId :number = 0;
      cashRegisterId :number = 0;
      branchOfficeId :number = 0;
      openingDate :Date = new Date();
      maxClosureDate :Date = new Date();
      closureDate :Date = new Date();
      totalPaymentsAmount :number = 0;
      openingClosureDifference :number = 0;
      userName :string = '';
      details:OpeningType[] = [];
      state :string = '';
      totalOpeningAmount :number = 0;
      totalClosureAmount :number = 0;
      cashRegister :CashRegister = new CashRegister();
      isClosing:boolean=false;
      user: User = new User();
      currency :Currency = new Currency();
      branchOffice: BranchOffice = new BranchOffice();
}
export class OpeningType extends BaseModel{
      type:string = '';
      cashRegisterOpeningId:number = 0;
      details:string = '';
      isClosing:boolean = false;
      totalAmount:number=0;

  }
