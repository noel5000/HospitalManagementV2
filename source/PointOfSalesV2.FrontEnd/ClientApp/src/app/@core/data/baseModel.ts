

export class BaseModel {
    createdByName: string = '';
    modifiedByName: string = '';
    createdDate: Date = new Date();
    modifiedDate: Date = new Date();
    createdBy:string = '';
    modifiedBy:string = '';
    id: number = 0;
    active: boolean = false;
    actions: string='';
}
