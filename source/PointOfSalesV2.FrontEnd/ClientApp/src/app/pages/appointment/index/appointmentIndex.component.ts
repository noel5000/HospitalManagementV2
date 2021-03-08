import { 
    Component, 
    OnInit, 
    ChangeDetectionStrategy,
    ViewChild,
    TemplateRef,
    NgZone,
    ChangeDetectorRef, } from '@angular/core';
    import {
        startOfDay,
        endOfDay,
        subDays,
        addDays,
        endOfMonth,
        isSameDay,
        isSameMonth,
        addHours,
      } from 'date-fns';
import { BaseComponent } from '../../../@core/common/baseComponent';
import { AppSections, ObjectTypes, QueryFilter, BillingStatesColors, BillingStates, ODataComparers } from '../../../@core/common/enums';
import { LanguageService } from '../../../@core/services/translateService';
import { ActivatedRoute, Router } from '@angular/router';
import { BranchOfficeService } from '../../../@core/services/branchOfficeService';
import { BranchOffice } from '../../../@core/data/branchOffice';
import { basename } from 'path';
import {IPaginationModel, IActionButtonModel } from '../../../@theme/components/pagination/pagination.component';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { NgbdModalConfirmAutofocus } from '../../../@theme/components/modal/modal.component';
import { ModalService } from '../../../@core/services/modal.service';

import { Subject } from 'rxjs';
import {
  CalendarEvent,
  CalendarEventAction,
  CalendarEventTimesChangedEvent,
  CalendarView,
  CalendarMonthViewBeforeRenderEvent,
  CalendarWeekViewBeforeRenderEvent,
  CalendarDayViewBeforeRenderEvent,
} from 'angular-calendar';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { endpointUrl, endpointViewsUrl } from '../../../@core/common/constants';
import { Warehouse } from '../../../@core/data/Warehouse';
import { WarehouseService } from '../../../@core/services/WarehouseService';
import { FormBuilder, Validators } from '@angular/forms';
import { medicalSpecialityModule } from '../../medicalSpeciality/medicalSpeciality.module';


declare const $: any;



@Component({
    selector: "appointments-list",
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: "./appointmentIndex.component.html",
    styleUrls: ["../appointmentStyles.component.scss"],
   
})
export class appointmentIndexComponent extends BaseComponent implements OnInit {
    
    @ViewChild('modalContent', { static: true }) modalContent: TemplateRef<any>;
    service: BaseService<any,number> = new BaseService<any,number>(this.http,`${endpointUrl}Appointment`);
    hospitalService: BaseService<any,number> = new BaseService<any,number>(this.http,`${endpointUrl}branchoffice`);
    medicalSpecialitiesService: BaseService<any,number> = new BaseService<any,number>(this.http,`${endpointUrl}medicalSpeciality`);
    doctorService: BaseService<any,number> = new BaseService<any,number>(this.http,`${endpointUrl}user`);
    patientsService: BaseService<any,number> = new BaseService<any,number>(this.http,`${endpointUrl}Customer`);
    visible:boolean=true;
    hospitals:any[]=[];
    medicalSpecialities:any[]=[];
    doctors:any[]=[];
    patients:any[]=[];
    selectedDate:Date=null;
    selectedAppointments:any[]=[];
    appointments:any[]=[];
    view: CalendarView = CalendarView.Month;

    CalendarView = CalendarView;

  
    viewDate: Date = new Date();
  
    modalData: {
      action: string;
      event: CalendarEvent;
    };

 
      refresh: Subject<any> = new Subject();

      events: CalendarEvent[] = [];
    
      activeDayIsOpen: boolean = false;
      constructor(
        private zone:NgZone,
        private changes:ChangeDetectorRef,
        private formBuilder: FormBuilder,
        router: ActivatedRoute,
        route: Router,
        langService: LanguageService,
        private modals:NgbModal,
         modalService:ModalService,
      private  http: HttpClient
        ){
      super(route, langService, AppSections.Users,modalService);  
      this.itemForm = this.formBuilder.group({
        branchOfficeId: [0],
        doctorId: ["null"],
        medicalSpecialityId:[0],
        patientId:[0]        
    });     
    }
    async getHospitals(){
      this.hospitalService.getAll().subscribe(r=>{
 
        this.hospitals=r;
        if(this.hospitals.length==1)
       this.itemForm.patchValue({
        branchOfficeId:this.hospitals[0].id
       });
       this.changes.detectChanges();
      })
    }
    async getPatients(){
      this.patientsService.getAll().subscribe(r=>{
      
        this.patients=r;
        if(this.patients.length==1)
        this.itemForm.patchValue({
          patientId:this.patients[0].id
         });
         this.changes.detectChanges();
      })
    }

    
    async getDoctors(specialityId:number, hospitalId:number){
      let filter :QueryFilter[]=[];

      if(specialityId && specialityId>0)
      filter.push(
        {
          property: "MedicalSpecialityId",
          value: specialityId.toString(),
          type: ObjectTypes.Number,
          isTranslated: false
      } as QueryFilter
      );

      if(hospitalId && hospitalId>0)
      filter.push(
        {
          property: "BranchOfficeId",
          value: hospitalId.toString(),
          type: ObjectTypes.Number,
          isTranslated: false
      } as QueryFilter
      )
      this.doctorService.getAllFiltered(filter).subscribe(r=>{
    
        this.doctors=r['value'];
        if(this.doctors.length==1)
        this.itemForm.patchValue({
          doctorId:this.doctors[0].userId
         });
         this.changes.detectChanges();
      })
    }

     getSelectedDateFormatted(){
      if(!this.selectedDate)
      return "";
      return `${this.selectedDate.getFullYear()}-${this.selectedDate.getMonth()+1}-${this.selectedDate.getDate()}`;
    }

    async getSpecialtities(){
      this.medicalSpecialitiesService.getAll().subscribe(r=>{
      
        this.medicalSpecialities=r;
        if(this.medicalSpecialities.length==1)
        this.itemForm.patchValue({
          medicalSpecialityId:this.medicalSpecialities[0].id
         });
         this.changes.detectChanges();
      })
    }

    actions: CalendarEventAction[] = [
        {
          label: '<i class="fa fa-fw fa-pencil"></i>',
          a11yLabel: 'Edit',
          onClick: ({ event }: { event: CalendarEvent }): void => {
            this.handleEvent('Edited', event);
          },
        },
        {
          label: '<i class="fa fa-fw fa-times"></i>',
          a11yLabel: 'Delete',
          onClick: ({ event }: { event: CalendarEvent }): void => {
            this.events = this.events.filter((iEvent) => iEvent !== event);
            this.handleEvent('Deleted', event);
          },
        },
      ];
      save(){}

    ngOnInit(): void {
        this.verifyUser();
        this.getHospitals();
        this.getPatients();
        this.getMonthAppointments();
        this.getSpecialtities();
        this.OnChanges();
    }
  
    async OnChanges(){
      this.itemForm.get('branchOfficeId').valueChanges.subscribe(val => {
        
        if(val && val>0){
          const {medicalSpecialityId}=this.itemForm.getRawValue();
          this.getDoctors(medicalSpecialityId,val);
          this.changes.detectChanges();
        }
        
        
          });
      this.itemForm.get('medicalSpecialityId').valueChanges.subscribe(val => {
        if(val && val>0){
          const {branchOfficeId}=this.itemForm.getRawValue();
          this.getDoctors(val,branchOfficeId);
          this.changes.detectChanges();
        }
          });
      this.itemForm.get('doctorId').valueChanges.subscribe(val => {
        this.changes.detectChanges();
          });
      this.itemForm.get('patientId').valueChanges.subscribe(val => {
        this.changes.detectChanges();
          });
  }
  


getStatusDescription(state:string):string{
  return this.lang.getValueByKey(`billingState${state}_lbl`);
}



removeAppointment(appointment:any){
  var result =       this.modalService.confirmationModal({
    titleText:this.lang.getValueByKey('deleteConfirm_lbl'),
    bodyText:this.lang.getValueByKey('areYouSure_lbl'),
    cancelButtonText:this.lang.getValueByKey('cancel_btn'),
    okText:this.lang.getValueByKey('ok_btn'),
});
result.subscribe(r=>{
if(r)
this.service.delete(appointment.id).subscribe(r=>{
  if(r.status>=0)
    this.modalService.showSuccess(this.lang.getValueByKey(r.message));
  else
  this.modalService.showError(this.lang.getValueByKey(r.message));
  
  this.getDayAppointments(this.viewDate);
});
});
 
}
printAppointment(appointment:any){
  const user = JSON.parse(localStorage.getItem("currentUser"));
  this.router.navigate(['/externalRedirect', { externalUrl: `${endpointViewsUrl}views/appointmentPrint?id=${appointment.id}&language=${user.languageId}` }], {
    skipLocationChange: true,
});
}

print(e: any) {
  const user = JSON.parse(localStorage.getItem("currentUser"));
  this.router.navigate(['/externalRedirect', { externalUrl: `${endpointViewsUrl}views/appointmentPrint?id=${e.id}&language=${user.languageId}` }], {
    skipLocationChange: true,
});
  }
  async getDayAppointments(date:Date){
    const form = this.itemForm.getRawValue();
    const dateFormatted=`${date.getFullYear()}-${date.getMonth()+1}-${date.getDate()}`;
    this.service.getByUrlParameters(['GetAppointmentsByDay',dateFormatted,form.branchOfficeId.toString(),
    form.doctorId.toString(),form.medicalSpecialityId.toString(), form.patientId.toString()]).subscribe(r=>{
     this.selectedAppointments=r.data;
     this.changes.detectChanges();
    });
  }


   async getMonthAppointments(){
    const form = this.itemForm.getRawValue();
    const dateFormatted=`${this.viewDate.getFullYear()}-${this.viewDate.getMonth()+1}-${this.viewDate.getDate()}`;
     this.service.getByUrlParameters(['GetAppointmentsByMonth',dateFormatted,form.branchOfficeId.toString(),
     form.doctorId.toString(),form.medicalSpecialityId.toString(), form.patientId.toString()]).subscribe(r=>{
      this.appointments=r.data;
      this.events=[];
      this.appointments.forEach(d=>{
        this.events.push({
          start:new Date(d.date),
          end: new Date(d.date),
          title: `${d.doctorName} ${d.patientName}`,
          color:BillingStatesColors[d.state],
          actions: this.actions,
          allDay: true,
        } as CalendarEvent)
      });
      this.refresh.next();
      this.changes.detectChanges();
     });
   }
    beforeMonthViewRender(renderEvent: CalendarMonthViewBeforeRenderEvent): void {
        renderEvent.body.forEach((day) => {
          const dayOfMonth = day.date.getDate();
          // if (dayOfMonth > 5 && dayOfMonth < 10 && day.inMonth) {
          //   day.cssClass = 'bg-pink';
          // }
        });
      }
    
  dayClicked({ date, events }: { date: Date; events: CalendarEvent[] }): void {
    this.selectedDate=date;
 this.getDayAppointments(date);
  }

  eventTimesChanged({
    event,
    newStart,
    newEnd,
  }: CalendarEventTimesChangedEvent): void {
    this.events = this.events.map((iEvent) => {
      if (iEvent === event) {
        return {
          ...event,
          start: newStart,
          end: newEnd,
        };
      }
      return iEvent;
    });
    this.handleEvent('Dropped or resized', event);
  }

  handleEvent(action: string, event: CalendarEvent): void {
    this.modalData = { event, action };
    this.modals.open(this.modalContent, { size: 'lg' });
  }

  addEvent(): void {
    this.events = [
      ...this.events,
      {
        title: 'New event',
        start: startOfDay(new Date()),
        end: endOfDay(new Date()),
        draggable: true,
        resizable: {
          beforeStart: true,
          afterEnd: true,
        },
      },
    ];
  }



  deleteEvent(eventToDelete: CalendarEvent) {
    this.events = this.events.filter((event) => event !== eventToDelete);
  }

  setView(view: CalendarView) {
    this.view = view;
  }

  closeOpenMonthViewDay() {
    this.activeDayIsOpen = false;
    this.getMonthAppointments();
  }

  addNew() {
    const form = this.itemForm.getRawValue();
    const dateFormatted=`${this.selectedDate.getFullYear()}-${this.selectedDate.getMonth()+1}-${this.selectedDate.getDate()} ${this.selectedDate.getHours()}:${this.selectedDate.getMinutes()}:${this.selectedDate.getSeconds()}`;
    this.router.navigateByUrl(`pages/appointment/add/${form.branchOfficeId}/${dateFormatted}/${form.medicalSpecialityId}/${form.doctorId}/${form.patientId}`);
}

editAppointment(appointment:any) {
  this.router.navigateByUrl(`pages/appointment/edit/${appointment.id}`);
}

}