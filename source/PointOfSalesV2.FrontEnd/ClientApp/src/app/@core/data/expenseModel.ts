import { BaseModel } from './baseModel';
import { Currency } from './currencyModel';
import { BranchOffice } from './branchOffice';
import { Supplier } from './Supplier';


export class Expense extends BaseModel {

  details :string = '';
 exchangeRateAmount:number = 0;
  date :Date = new Date();
  state:string = '';
  branchOffice :BranchOffice = new BranchOffice();
  branchOfficeId :number = 0;
  taxes:any[] = [];
  currency :Currency = new Currency();
  currencyId :number = 0;
  owedAmount :number = 0;
  givenAmount :number = 0;
  returnedAmount :number = 0;
  beforeTaxesAmount :number = 0;
  taxesAmount :number = 0;
  paidAmount :number = 0;
  totalAmount :number = 0;
  trn :string = '';
  sequence:string = '';
  currentPaidAmount:number = 0;
  expenseReference:string = '';
  supplier :Supplier = new Supplier();
  paymentType:any;
  supplierId :number = 0;
  paymentTypeId? :number = 0;
  numberOfDays:number = 0;
}
