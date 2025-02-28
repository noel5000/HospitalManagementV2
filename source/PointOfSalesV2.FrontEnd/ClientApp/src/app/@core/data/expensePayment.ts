import { BaseModel } from './baseModel';
import { Currency } from './currencyModel';
import { BranchOffice } from './branchOffice';
import { Supplier } from './Supplier';
import { Expense } from './expenseModel';


export class ExpensePayment extends BaseModel {

  details :string = '';
 exchangeRateAmount:number = 0;
 exchangeRate:number = 0;
  date :Date = new Date();
  state:string = '';
  branchOffice :BranchOffice = new BranchOffice();
  branchOfficeId :number = 0;
  taxes:any[] = [];
  currency :Currency = new Currency();
  currencyId :number = 0;
  outstandingAmount :number = 0;
  currentPaidAmount:number = 0;
  givenAmount :number = 0;
  returnedAmount :number = 0;
  beforeTaxesAmount :number = 0;
  taxesAmount :number = 0;
  paidAmount :number = 0;
  totalAmount :number = 0;
  expenseCurrencyId :number = 0;
  expenseCurrency:Currency = new Currency();
  expenseId:number = 0;
  expenseReference:string = '';
  supplier :Supplier = new Supplier();
  paymentType:any;
  supplierId :number = 0;
  paymentTypeId :number = 0;
  numberOfDays:number = 0;
  sequence:string = '';
  expense:Expense = new Expense();
  currentOutstandingAmount:number = 0;
}
