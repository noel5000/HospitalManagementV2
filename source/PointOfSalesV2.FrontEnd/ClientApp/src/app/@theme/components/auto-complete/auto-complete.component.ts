import { HttpClient, HttpHeaders } from '@angular/common/http';
import { AfterViewInit, ChangeDetectorRef, Component, ElementRef, EventEmitter, Input, OnInit, Output, ViewChild } from '@angular/core';
import {  fromEvent } from 'rxjs';
import { debounceTime, distinctUntilChanged, tap } from 'rxjs/operators';

@Component({
  selector: 'custom-auto-complete',
  template: `
  <div class="autoComplete">
    
 
  <input type="text"[(ngModel)]="filterString"
   class="form-control2" placeholder="...."
   [ngClass]="!selectedItem?'isInvalid':''"
    id="myInput"
    #textInputSearch
    >
 <ng-container *ngFor="let item of itemsToShow">
 <a  class="form-control2 selectOption"  (click)="selectItem(item)">{{showData(item)}}</a> <br>
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
  .selectOption:hover{
    background-color: bisque;
    text-decoration: none;
  }
  
  #myInput{
   min-width: 100px;
   max-width: 300px; 
  }
  
  .form-control2 {
    display: block;
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

  @ViewChild('textInputSearch',{static:false}) textInputSearch: ElementRef<HTMLInputElement> = {} as ElementRef;
  _items:any[]=[];
  get items(){
   return this._items;
  }
  @Input() set items(data:any[]){
this._items=data;
if(this.filterString)
this.itemsToShow= this._items.filter(x=>x[this.propertyToShow].toString().toLowerCase().includes(this.filterString.toLowerCase()));
this.changes.detectChanges();
  }


  itemsToShow:any[]=[];
  @Input() urlSearch:boolean=false;
  @Input() externalSearch:boolean=false;
  @Input() dataUrl:string='';
  @Input() requestHeader:HttpHeaders=  new HttpHeaders({
    "Content-Type":"application/json"
});
  @Input() inputRequestParam:string='';
  @Input() propertyToShow:string='';
  showDrop:boolean=true;
 filterString:string='';
 @Output() onFilter:EventEmitter<string>= new EventEmitter<string>();
 @Output() onSelectedItem: EventEmitter<any> = new EventEmitter<any>();
 @Output() selectedItem: any=null;
 
 constructor(private _http:HttpClient,
  private changes:ChangeDetectorRef,
  ) { }

  ngAfterViewInit(): void {
       fromEvent(this.textInputSearch.nativeElement,'keyup')
    .pipe(
       
        debounceTime(100),
        distinctUntilChanged(),
        tap((text) => {
         this.searchItem();
        })
    )
    .subscribe();
  }

  ngOnInit(): void {
  }

  toggleDrop(){
    this.showDrop=!this.showDrop;
  }

  searchItem(){
    if(!this.propertyToShow){
      alert('"propertyToShow" input needs an initial value');
      return;
    }
    if(this.externalSearch){
      this.onFilter.emit(this.filterString);
    }
    if(this.filterString.length>1){
     
    
        if(!this.urlSearch){
          this.itemsToShow= this._items.filter(x=>x[this.propertyToShow].toString().toLowerCase().includes(this.filterString.toLowerCase()));
          this.changes.detectChanges();
        }
        else
        {
          const url=this.dataUrl.replace('{}',this.filterString);
          this._http.get<any>(url,{
            headers:this.requestHeader
          }).subscribe(r=>{
            this.items=this.inputRequestParam?r[this.inputRequestParam]: r;
            this.itemsToShow=this._items.filter(x=>x[this.propertyToShow].toString().toLowerCase().includes(this.filterString.toLowerCase()));
            this.changes.detectChanges();
          })
        }
      
     
     
    }
    else{
      this.itemsToShow=[];
      this.selectedItem=null;
      this.changes.detectChanges();
    }
   
  }

  showData(item:any){
    if(this.propertyToShow)
    return item[this.propertyToShow];
      }

      selectItem(item:any){
        if(!this.propertyToShow){
          alert('propertyToShow needs an initial value');
          this.selectedItem=null;
          return;
        }
        if(item && item[this.propertyToShow]){
          this.onSelectedItem.emit(item);
          this.selectedItem=item;
          this.itemsToShow=[];
          this.changes.detectChanges();
          this.filterString=item[this.propertyToShow].toString();
        }
        else
        this.selectedItem=null;
        
      }


}
