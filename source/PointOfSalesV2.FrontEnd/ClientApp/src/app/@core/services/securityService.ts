import { Injectable , Inject } from '@angular/core';
import { AppRoles,  Operations } from '../common/enums';
import { AuthModel } from '../data/authModel';


@Injectable({
    providedIn: "root"
})
export class SecurityService {

   
  constructor() {
        
    }
    isUserValidInMenu(role: AppRoles): boolean {
        let result = false;
        const auth = JSON.parse(localStorage.getItem('currentUser'));
        if (auth && new Date(auth.expiration) > new Date()) {
            if (auth.user.permissions.length == 0)
                return true;
            if (auth.user.permissions.filter(x => x.roleId == role && (x.operationId == Operations.READ || x.operationId == Operations.ALL)).length > 0)
                return true;
        }
        return result;
    }

    validateMenuChildren(roles: AppRoles[]): boolean {
        let result = false;
        const auth = JSON.parse(localStorage.getItem('currentUser'));
        if (auth && new Date(auth.expiration) > new Date()) {
            if (auth.user.permissions.length == 0)
                return true;
                roles.forEach(s => {
                if (auth.user.permissions.filter(x => x.roleId == s && (x.operationId == Operations.READ || x.operationId == Operations.ALL)).length > 0)
                    result= true;
            })
        }
        return result;
    }

}
