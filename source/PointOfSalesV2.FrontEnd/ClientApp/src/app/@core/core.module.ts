import { ModuleWithProviders, NgModule, Optional, SkipSelf , Inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { of as observableOf } from 'rxjs';

import { throwIfAlreadyLoaded } from './module-import-guard';
import { AnalyticsService } from './utils';
const socialLinks = [
  {
    url: 'https://github.com/akveo/nebular',
    target: '_blank',
    icon: 'github',
  },
  {
    url: 'https://www.facebook.com/akveo/',
    target: '_blank',
    icon: 'facebook',
  },
  {
    url: 'https://twitter.com/akveo_inc',
    target: '_blank',
    icon: 'twitter',
  },
];




export const NB_CORE_PROVIDERS = [

  AnalyticsService,
];

@NgModule({
  imports: [

    CommonModule,
  ],
  exports: [

  ],
  declarations: [],
})
export class CoreModule {
  constructor(@Inject('BASE_URL') private baseUrl: string,@Optional() @SkipSelf() parentModule: CoreModule) {
    throwIfAlreadyLoaded(parentModule, 'CoreModule');
  }

  static forRoot(): ModuleWithProviders<CoreModule> {
    return <ModuleWithProviders<CoreModule>>{
      ngModule: CoreModule,
      providers: [
        ...NB_CORE_PROVIDERS,
      ],
    };
  }
}
