import { Component, OnInit, Inject } from '@angular/core';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppRoles,  ObjectTypes, QueryFilter } from '../../../@core/common/enums';
import { LanguageService } from '../../../@core/services/translateService';
import { Router } from '@angular/router';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { Product } from '../../../@core/data/product';
import { ProductService } from '../../../@core/services/ProductService';
import { WarehouseService } from '../../../@core/services/WarehouseService';
import { BranchOfficeService } from '../../../@core/services/branchOfficeService';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { endpointUrl } from '../../../@core/common/constants';
import { BranchOffice } from '../../../@core/data/branchOffice';
import { FormBuilder, FormGroup, Validators, RequiredValidator } from '@angular/forms';
import { Customer } from '../../../@core/data/customer';
import { CustomerService } from '../../../@core/services/CustomerService';
import { Currency } from '../../../@core/data/currencyModel';
import { SupplierService } from '../../../@core/services/supplierService';
import { CurrencyService } from '../../../@core/services/CurrencyService';
import { Supplier } from '../../../@core/data/Supplier';
import { AppConfig } from '../../../@core/services/app.config';


declare const $: any;
@Component({
  selector: "account-state",
  templateUrl: "./accountStateIndex.component.html",
  styleUrls: ["../accountStateStyles.component.scss"]
})
export class AccountStateIndexComponent extends BaseComponent implements OnInit {
  selectedCustomer: Customer = null;
  ngOnInit(): void {
    this.verifyUser();
    this.onChanges();
  }
  modalRef: NgbModalRef = null;
  service: BaseService<any, number> = new BaseService<any, number>(this.http, `${this.baseUrl}api/Customer`);
  states: any[] = [];
  result: any = {};
  customers: Customer[] = [];


  constructor(@Inject('BASE_URL') private baseUrl: string, private config: AppConfig,
    route: Router,
    private formBuilder: FormBuilder,
    langService: LanguageService,
    private modals: NgbModal,
    private http: HttpClient,
    modalService: ModalService,
    private customersService: CustomerService,
  ) {
    super(route, langService, AppRoles.Reports_AccountState, modalService);
    this.itemForm = this.formBuilder.group({
      customerId: [0, [Validators.required, Validators.min(1)]],
    });
  }

  selectPatient(customer: any) {
    this.selectedCustomer = customer;
    this.itemForm.patchValue({
      customerId: customer ? customer.id : 0,
      currencyId: customer ? customer.currency.id : 0
    });
    this.customers = [];
  }
  async getPatientsByName(name: string) {
    if (name) {
      const filter = [
        {
          property: "Currency",
          value: "Id,Name,Code,ExchangeRate",
          type: ObjectTypes.ChildObject,
          isTranslated: false
        } as QueryFilter,
        {
          property: "Name",
          value: name,
          type: ObjectTypes.String,
          isTranslated: false
        } as QueryFilter
      ]
      this.customersService.getAllFiltered(filter).subscribe(r => {
        this.customers = [];
        this.customers = this.customers.concat(r['value'].sort(this.dynamicSort('name')));
      });
    }
    else {
      this.itemForm.patchValue({
        customerId: 0
      });


    }

  }


  onChanges() {
    this.itemForm.get('customerId').valueChanges.subscribe(val => {
      this.getData();
    });

  }
  getData() {
    const filter = this.itemForm.getRawValue();
    if (filter.customerId && filter.customerId > 0)
      this.service.getByUrlParameters(['AccountState', filter.customerId.toString()]).subscribe(r => {
        this.result = r['data'] ? r['data'] : { data: [] };
        this.states = this.result ? this.result.data : [];
      },
        error => {
          this.modalService.showError(`${this.lang.getValueByKey(error.message)}`);
        }
      )
  }








  getDataToExport() {
    const filter = this.itemForm.getRawValue();
    this.service.exportToExcel(filter, `AccountStateExport/${filter.customerId}`).subscribe(r => {

      this.service.downLoadFile(r, "application/ms-excel", `${this.lang.getValueByKey('accountState_menu')}`);

    },
      error => {
        this.modalService.showError(`${this.lang.getValueByKey(error.message)}`);
      }
    )
  }
  get form() { return this.itemForm.controls; }


  print() {
    window.print();
  }

  exportToCSV() {
    this.getDataToExport();
  }

}
