import { Component, OnDestroy, OnInit , Inject } from '@angular/core';

import { User, UserData } from '../../../@core/data/users';
import { map, takeUntil, filter } from 'rxjs/operators';
import { Subject } from 'rxjs';
import { Router } from '@angular/router';
import { TranslateService } from '@ngx-translate/core';
import { LanguageService } from '../../../@core/services/translateService';
import { BaseService } from '../../../@core/services/baseService';
import { HttpClient } from '@angular/common/http';
import { endpointControllers, endpointUrl } from '../../../@core/common/constants';
import { AuthModel } from '../../../@core/data/authModel';
import { AppConfig } from '../../../@core/services/app.config';

@Component({
  selector: 'ngx-header',
  styleUrls: ['./header.component.scss'],
  templateUrl: './header.component.html',
})
export class HeaderComponent implements OnInit, OnDestroy {
  languages: any[] = [];
  currentLanguage: string = 'EN';
  languageService: BaseService<any, string>;
  private destroy$: Subject<void> = new Subject<void>();
  userPictureOnly: boolean = false;
  user: any;

  changeLanguage(languageCode: string) {

    //this.currentLanguage = languageCode;
    let currentUser = JSON.parse(localStorage.getItem('currentUser') ?? '') as AuthModel;
    if (currentUser && new Date(currentUser.expiration!) > new Date()) {
      this.lang.setLanguageInHeaders(this.currentLanguage);
      this.lang.setCurrentLanguage(this.currentLanguage, true);
      // window.location.reload();
    }
  }

  themes = [
    {
      value: 'default',
      name: 'Light',
    },
    {
      value: 'dark',
      name: 'Dark',
    },
    {
      value: 'cosmic',
      name: 'Cosmic',
    },
    {
      value: 'corporate',
      name: 'Corporate',
    },
  ];

  currentTheme = '';

  userMenu : any[] = [];

  constructor(@Inject('BASE_URL') private baseUrl: string,
  private config: AppConfig,
    private userService: UserData,
    private route: Router,
    http: HttpClient,
    private lang: LanguageService,) {
    this.languageService = new BaseService(http, `${this.baseUrl}api/${endpointControllers.languages}`);

      this.userMenu = [
        {
          title: this.lang.getValueByKey('profile_btn'),
          target: 'profileBtn'
        },
        {
          title: this.lang.getValueByKey('logOut_btn'),
          target: 'logoutBtn'
        }];
    this.languageService.get().subscribe(r => {
      if (r.status >= 0) {
        this.languages = r.data;
        const currentUser = JSON.parse(localStorage.getItem('currentUser') ?? '') as AuthModel;
        if (!currentUser || !(new Date(currentUser.expiration!) > new Date())) {
          localStorage.removeItem('currentUser');
          this.route.navigateByUrl('auth/login');
        }
        this.currentLanguage = this.languages.find(x => x.code == currentUser.user!.languageCode).code;

      }

    });
  }

  ngOnInit() {
    const data =JSON.parse(localStorage.getItem('currentUser') ?? '')as AuthModel;
    if(!data){
      localStorage.removeItem('currentUser');
          this.route.navigateByUrl('auth/login');
    }

  this.user = data?data.user:new User();
  }

  ngOnDestroy() {
    this.destroy$.next();
    this.destroy$.complete();
  }

  logout() {
    var auth = JSON.parse(localStorage.getItem(`currentUser`) ?? '') as AuthModel;
    if(auth){
      localStorage.setItem(`language-${auth.languageId}`, '');
    }
    localStorage.removeItem('currentUser');
    this.lang.setLanguageInHeaders('ES');
    this.lang.setCurrentLanguage('ES');
    this.route.navigateByUrl('auth/login');
  }

  changeTheme(themeName: string) {
  }

  toggleSidebar(): boolean {

    return false;
  }

  navigateHome() {
    return false;
  }
}
