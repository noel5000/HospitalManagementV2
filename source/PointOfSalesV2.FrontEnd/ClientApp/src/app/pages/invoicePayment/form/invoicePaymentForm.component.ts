

import { Component, OnInit, Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { LanguageService } from '../../../@core/services/translateService';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, QueryFilter, ObjectTypes, ODataComparers } from '../../../@core/common/enums';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from '../../../@core/services/modal.service';
import { Currency } from '../../../@core/data/currencyModel';
import { Unit } from '../../../@core/data/unitModel';
import { Supplier } from '../../../@core/data/Supplier';
import { Tax } from '../../../@core/data/taxModel';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { CurrencyService } from '../../../@core/services/CurrencyService';
import { UnitService } from '../../../@core/services/UnitService';
import { SupplierService } from '../../../@core/services/supplierService';
import { TaxService } from '../../../@core/services/TaxService';
import { endpointUrl } from '../../../@core/common/constants';
import { BranchOfficeService } from '../../../@core/services/branchOfficeService';
import { BranchOffice } from '../../../@core/data/branchOffice';
import { CustomerService } from '../../../@core/services/CustomerService';
import { Customer } from '../../../@core/data/customer';
import { AppConfig } from '../../../@core/services/app.config';


declare const $: any;
@Component({
  selector: "invoice-payment-form",
  templateUrl: "./invoicePaymentForm.component.html",
  styleUrls: ["../invoicePaymentStyles.component.scss"]
})
export class InvoicePaymentFormComponent extends BaseComponent implements OnInit {

  canPay: boolean = false;
  invoiceId: number = 0;
  paymentTypes: any[] = [];
  invoices: any[] = [];
  _route: ActivatedRoute;
  currencies: Currency[] = [];
  customers: Customer[] = [];
  patient: Customer = null;
  branchOffices: BranchOffice[] = [];
  paymentWithReference: boolean = false;
  paymentTypeService: BaseService<any, number> = new BaseService<any, number>(this.http, `${this.baseUrl}api/paymentType`);
  service: BaseService<any, number> = new BaseService<any, number>(this.http, `${this.baseUrl}api/Invoice`);
  paymentService: BaseService<any, number> = new BaseService<any, number>(this.http, `${this.baseUrl}api/CustomerPayment`);



  constructor(@Inject('BASE_URL') private baseUrl: string,
    private config: AppConfig,
    private formBuilder: FormBuilder,
    router: ActivatedRoute,
    route: Router,
    langService: LanguageService,
    private modals: NgbModal,
    private currencyService: CurrencyService,
    private customerService: CustomerService,
    modalService: ModalService,
    private brancOfficeService: BranchOfficeService,
    private http: HttpClient
  ) {

    super(route, langService, AppSections.CustomerPayments, modalService);
    this._route = router;
    this.dataToBackup = "invoices,canPay,paymentWithReference";
    this.itemForm = this.formBuilder.group({
      id: [0],
      branchOfficeId: [null, [Validators.required, Validators.min(1)]],
      paymentDestinationId: [null, [Validators.required, Validators.min(1)]],
      currencyId: [null, [Validators.required, Validators.min(1)]],
      details: [''],
      patientName:[''],
      reference: [''],
      destinationType: [0],
      paymentTypeId: [null, [Validators.required, Validators.min(1)]],
      givenAmount: [null],
      invoiceId: [null],
      returnedAmount: [0],
      positiveBalance: [0],
      paidAmount: [0]
    });
  }
  ngOnInit(): void {

    this.onChanges();
    this.verifyUser();
    this.getBranchOffices();
    this.getCurrencies();
    this.getPaymentTypes();
    this.validateFormData();
    const urlId = parseInt(this._route.snapshot.paramMap.get('invoiceId'));
    if (!isNaN(urlId)) {
      this.invoiceId = urlId;
      this.getInvoice(urlId);
    }
  }


  async selectPatient(patient: any) {
    if (patient) {
      this.patient = patient;
      this.itemForm.patchValue({
        paymentDestinationId: patient.id,
        patientName: patient.name
      })

    }
    else {
      this.patient = null;
      this.itemForm.patchValue({
        customerId: null,
        trnType: null,
        patientName: '',
        currencyName: '',
        currencyId: null,

      });
    }
  }

  async getPatients(name: string) {

    if (name) {
      const filter = [
        {
          property: "InsurancePlan",
          value: "Id,Name",
          type: ObjectTypes.ChildObject,
          isTranslated: false
        } as QueryFilter,
        {
          property: "Insurance",
          value: "Id,Name",
          type: ObjectTypes.ChildObject,
          isTranslated: false
        } as QueryFilter,
        {
          property: "Currency",
          value: "Id,Name, IsLocalCurrency",
          type: ObjectTypes.ChildObject,
          isTranslated: false
        } as QueryFilter
      ]
      if (name)
        filter.push({
          property: "Name",
          value: name.toString(),
          type: ObjectTypes.String,
          isTranslated: false
        } as QueryFilter);

      this.customerService.getAllFiltered(filter).subscribe(r => {
        this.customers = [];
        this.customers = this.customers.concat(r["value"]);

      });
    }
    else {
      this.patient = null;
      this.itemForm.patchValue({
        customerId: null,
        trnType: null,
        currencyId: null,
        trnControlId: null,
        sellerId: null,
        insuranceName: '',
        insurancePlanName: '',
        currencyName: '',
        nrc: '',
      });
    }
  }

  async getinvoices() {
    if (this.invoiceId <= 0) {
      this.invoices = !this.invoices ? [] : this.invoices;
      const filter = {
        branchOfficeId: this.itemForm.get('branchOfficeId').value ? this.itemForm.get('branchOfficeId').value : 0,
        currencyId: this.itemForm.get('currencyId').value ? this.itemForm.get('currencyId').value : 0,
        customerId: this.itemForm.get('paymentDestinationId').value ? this.itemForm.get('paymentDestinationId').value : 0,
        invoiceId: this.itemForm.get('invoiceId').value ? this.itemForm.get('invoiceId').value : 0
      }

      this.service.getByUrlParameters(['GetInvoicesToPay', filter.branchOfficeId, filter.customerId, filter.currencyId]).subscribe(r => {

        if (r.data) {
          this.invoices = r.data;
        }
      });
    }    
  }


  async getCurrencies() {
    this.currencyService.getAll().subscribe(r => {
      this.currencies = r;
      if (this.currencies.length == 1)
        this.itemForm.patchValue({ currencyId: this.currencies[0].id });
    });
  }

  async getInvoice(id: number) {
    this.service.getByUrlParameters(['GetForPrint', id.toString()]).subscribe(r => {
      const invoice = r.data[0];
      if (invoice && invoice.id)
        this.itemForm.patchValue({
          paymentDestinationId: invoice.customerId,
          currencyId: invoice.currencyId,
          branchOfficeId: invoice.branchOfficeId,
          invoiceId: invoice.id,
          patientName: invoice.patient ? invoice.patient.name:'',
          givenAmount: (invoice.owedAmount)
        });
      this.invoices = [invoice];
      this.itemForm.controls['currencyId'].disable();
    });
  }

  async getBranchOffices() {
    this.brancOfficeService.getAll().subscribe(r => {
      this.branchOffices = r;
      if (this.branchOffices.length == 1)
        this.itemForm.patchValue({ branchOfficeId: this.branchOffices[0].id });
    });
  }



  async getPaymentTypes() {
    this.paymentTypeService.getAll().subscribe(r => { this.paymentTypes = r });
  }


  onChanges(): void {



    this.itemForm.get('paymentTypeId').valueChanges.subscribe(val => {
      this.itemForm.removeControl('reference');
      if (val && val > 0) {
        const paymentType = this.paymentTypes.find(x => x.id == val);
        this.paymentWithReference = paymentType && paymentType.code != 1;

        if (this.paymentWithReference) {
          this.itemForm.addControl(`reference`, new FormControl(null, [Validators.required]))
        }
        else
          this.itemForm.addControl(`reference`, new FormControl(''))

      }
    });

    this.itemForm.get('currencyId').valueChanges.subscribe(val => {
      const { currencyId } = this.itemForm.getRawValue();
      if (currencyId && currencyId > 0)
        this.getinvoices();
    });

    this.itemForm.get('branchOfficeId').valueChanges.subscribe(val => {
      const { branchOfficeId } = this.itemForm.getRawValue();
      if (branchOfficeId && branchOfficeId > 0)
        this.getinvoices();
    });
    this.itemForm.get('paymentDestinationId').valueChanges.subscribe(val => {
      if (val && val > 0)
        this.getinvoices();
    });
    this.itemForm.get('givenAmount').valueChanges.subscribe(val => {
      this.canPay = val && val > 0;      
        const paidAmount = this.itemForm.get('paidAmount') ? this.itemForm.get('paidAmount').value : 0;
        this.itemForm.patchValue({
          positiveBalance: paidAmount ? val - paidAmount : val
        })
      
    });

  }
  get form() { return this.itemForm.controls; }

  save() {
    if (this.itemForm.invalid) {
      return;
    }
    const formValue = this.itemForm.getRawValue();


    const toPost = {
      payment: {
        branchOfficeId: formValue.branchOfficeId,
        currencyId: formValue.currencyId,
        paymentTypeId: formValue.paymentTypeId,
        customerId: formValue.paymentDestinationId,
        reference: formValue.reference,
        details: formValue.details,
        positiveBalance: formValue.positiveBalance,
        givenAmount: formValue.givenAmount,
      },
      invoices: this.invoices.filter(x => x.currentPaidAmount > 0),
      userId: this.authModel.user.userId
    };
    const subscription = this.paymentService.post(toPost, null, 'PayInvoices');
    subscription.subscribe(r => {
      if (r.status >= 0) {
        this.clearBackupData();
        this.modalService.showSuccess(this.lang.getValueByKey('success_msg'));
        this.router.navigateByUrl('pages/invoicepayment');
      }
      else
        this.modalService.showError(r.message);
    })
  }

  cancel() {
    this.clearBackupData();
    this.router.navigateByUrl('pages/invoicepayment');
  }

  payInvoice(invoice: any) {
    const index = this.invoices.findIndex(x => x.id == invoice.id);
    if (!this.invoices[index].selected) {
      this.invoices[index].selected = true;
      const givenAmount = this.itemForm.get('givenAmount').value;
      const paidAmount = this.itemForm.get('paidAmount').value;
      if ((givenAmount - paidAmount) > 0)
        this.invoices[index].currentPaidAmount =
          (givenAmount - paidAmount) > this.invoices[index].owedAmount ? this.invoices[index].owedAmount : (givenAmount - paidAmount);
      else
        this.invoices[index].selected = false;
    }
    else {
      this.invoices[index].selected = false;
    }
    this.refreshTotalAmount(index, this.invoices[index].selected);

  }

  refreshTotalAmount(index: number, hasValue: boolean) {
    this.invoices[index].currentPaidAmount = hasValue ? this.invoices[index].currentPaidAmount : 0;
    const paidSumm = this.invoices.reduce(function (a, b) { return a + b.currentPaidAmount }, 0);
    const givenAmount = this.itemForm.get('givenAmount') ? this.itemForm.get('givenAmount').value ? this.itemForm.get('givenAmount').value : 0 : 0;
    this.itemForm.patchValue({
      paidAmount: paidSumm,
      positiveBalance: givenAmount - paidSumm
    });

  }
}
