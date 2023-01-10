import { HttpClient, HttpHeaders } from '@angular/common/http';
import { AfterViewInit, ChangeDetectorRef, Component, ElementRef, EventEmitter, Input, OnInit, Output, ViewChild, Inject } from '@angular/core';
import { fromEvent } from 'rxjs';
import { debounceTime, distinctUntilChanged, tap } from 'rxjs/operators';

@Component({
  selector: 'custom-auto-complete',
  template: `
  <div class="autoComplete">
    
 
  <input type="text"[(ngModel)]="filterString"
   class="form-control2" placeholder="...."
  (keyup.enter)="firstOrDefault()"
  (keyup.arrowup)="changeSelected(-1)"
  (keyup.arrowdown)="changeSelected(1)"
   [ngClass]="!selectedItem?'isInvalid':''"
    id="myInput"
    #textInputSearch
    >
 <ng-container *ngFor="let item of itemsToShow; let i = index;">
 <a  class="form-control2 selectOption" [ngClass]="i==selectedIndex?'selectedOption':''"  (click)="selectItem(item)">{{showData(item)}}</a> <br>
 </ng-container>
  

</div>
  `,
  styles: [`
  .autoComplete{
    max-width: 300px;
  }
  .isInvalid{
    border-color:red !important;
  }
  .selectOption{
    cursor: pointer;
  }
  .selectedOption{
    background-color: bisque !important;
    text-decoration: none !important;
  }
  
  #myInput{
   min-width: 100px;
   max-width: 300px; 
  }
  
  .form-control2 {
    display: inline-block;
    width: 100%;
    height: calc(1.5em + 0.75rem + 2px);
    padding: 0.375rem 0.75rem;
    font-size: 1rem;
    font-weight: 400;
    line-height: 1.5;
    color: #495057;
    background-color: #fff;
    background-clip: padding-box;
    border: 1px solid #ced4da;
    border-radius: 0.25rem;
    transition: border-color .15s ease-in-out,box-shadow .15s ease-in-out;
  }
  `
  ]
})
export class AutoCompleteComponent implements OnInit, AfterViewInit {

  @ViewChild('textInputSearch', { static: false }) textInputSearch: ElementRef<HTMLInputElement> = {} as ElementRef;
  _items: any[] = [];
  get items() {
    return this._items;
  }
  changeSelected(increment: number) {
    let newSelected = this.selectedIndex + increment;
    if (newSelected < 0)
      newSelected = this.itemsToShow.length - 1;
    if (newSelected >= this.itemsToShow.length)
      newSelected = 0;
    this.selectedIndex = newSelected;
  }
  selectedIndex: number = 0;
  @Input() set items(data: any[]) {
    this._items = data;
    if (this.filterString)
      this.itemsToShow = this._items.filter(x => x[this.propertyToShow].toString().toLowerCase().includes(this.filterString.toLowerCase()));
    this.changes.detectChanges();
  }

  async firstOrDefault() {
    let selected = this.itemsToShow.length >= 0 ? this.itemsToShow[this.selectedIndex] : null;
    if (!selected) {
      selected = new Object();
      selected[this.propertyToShow] = this.filterString;
      selected['id'] = Math.floor(Math.random() * -1000);
    }
    this.selectItem(selected);
  }

  itemsToShow: any[] = [];
  @Input() urlSearch: boolean = false;
  @Input() externalSearch: boolean = false;
  @Input() dataUrl: string = '';
  @Input() requestHeader: HttpHeaders = new HttpHeaders({
    "Content-Type": "application/json"
  });
  @Input() inputRequestParam: string = '';
  @Input() propertyToShow: string = '';
  showDrop: boolean = true;
  filterString: string = '';
  @Output() onFilter: EventEmitter<string> = new EventEmitter<string>();
  @Output() onSelectedItem: EventEmitter<any> = new EventEmitter<any>();
  @Output() selectedItem: any = null;

  constructor(@Inject('BASE_URL') private baseUrl: string, private _http: HttpClient,
    private changes: ChangeDetectorRef,
  ) { }

  ngAfterViewInit(): void {
    fromEvent(this.textInputSearch.nativeElement, 'keyup')
      .pipe(

        debounceTime(100),
        distinctUntilChanged(),
        tap((text) => {
          if (text['key'] != 'ArrowUp' && text['key'] != 'ArrowDown')
          this.searchItem();
        })
      )
      .subscribe();
  }

  ngOnInit(): void {

  }

  toggleDrop() {
    this.showDrop = !this.showDrop;
  }

  searchItem() {
    if (!this.filterString || this.filterString.length < 2)
      this.selectedItem = null;
    if (this.selectedItem)
      return;

    if (!this.propertyToShow) {
      alert('"propertyToShow" input needs an initial value');
      return;
    }
    if (this.externalSearch) {
      this.onFilter.emit(this.filterString);
    }
    if (this.filterString.length > 1) {


      if (!this.urlSearch) {
        this.itemsToShow = this._items.filter(x => x[this.propertyToShow].toString().toLowerCase().includes(this.filterString.toLowerCase()));
        this.changes.detectChanges();
      }
      else {
        const url = this.dataUrl.replace('{}', this.filterString);
        this._http.get<any>(url, {
          headers: this.requestHeader
        }).subscribe(r => {
          this.items = this.inputRequestParam ? r[this.inputRequestParam] : r;
          this.itemsToShow = this._items.filter(x => x[this.propertyToShow].toString().toLowerCase().includes(this.filterString.toLowerCase()));
          this.changes.detectChanges();
        })
      }



    }
    else {
      this.itemsToShow = [];
      this.selectedItem = null;
      this.changes.detectChanges();
    }

  }

  showData(item: any) {
    if (this.propertyToShow)
      return item[this.propertyToShow];
  }

  selectItem(item: any) {
    if (!this.propertyToShow) {
      alert('propertyToShow needs an initial value');
      this.changes.detectChanges();
      this.selectedItem = null;
      return;
    }
    if (item && item[this.propertyToShow]) {

      this.selectedItem = item;
      this.itemsToShow = [];
      this.changes.detectChanges();
      this.filterString = item[this.propertyToShow].toString();
      this.onSelectedItem.emit(item);
    }
    else
      this.selectedItem = null;
    this.changes.detectChanges();
  }


}
