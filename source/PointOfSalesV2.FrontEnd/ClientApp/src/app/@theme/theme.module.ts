import { ModuleWithProviders, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import {
  FooterComponent,
  HeaderComponent,
  LayoutDirectionSwitcherComponent,
  SearchInputComponent,
  SwitcherComponent,
} from './components';

import {
  CapitalizePipe,
  PluralPipe,
  RoundPipe,
  TimingPipe,
  NumberWithCommasPipe,
} from './pipes';
import {
  OneColumnLayoutComponent,
  ThreeColumnsLayoutComponent,
  TwoColumnsLayoutComponent,
} from './layouts';
import { DEFAULT_THEME } from './styles/theme.default';
import { COSMIC_THEME } from './styles/theme.cosmic';
import { CORPORATE_THEME } from './styles/theme.corporate';
import { DARK_THEME } from './styles/theme.dark';
import { TranslateService, TranslateModule } from '@ngx-translate/core';
import { LanguageService } from '../@core/services/translateService';
import { PaginationCompoment, NgbdSortableHeader } from './components/pagination/pagination.component';
import { NgbPaginationModule, NgbDropdownModule, NgbModalModule } from '@ng-bootstrap/ng-bootstrap';
import { NgbdModalConfirmAutofocus } from './components/modal/modal.component';
import { FormsModule } from '@angular/forms';


const COMPONENTS = [
  SwitcherComponent,
  HeaderComponent,
  PaginationCompoment,
  NgbdModalConfirmAutofocus,
  FooterComponent,
  SearchInputComponent,
  OneColumnLayoutComponent,
  ThreeColumnsLayoutComponent,
  TwoColumnsLayoutComponent,
];
const PIPES = [
  CapitalizePipe,
  PluralPipe,
  RoundPipe,
  TimingPipe,
  NumberWithCommasPipe,
];

@NgModule({
  imports: [CommonModule,TranslateModule,NgbPaginationModule, NgbDropdownModule, NgbModalModule, FormsModule],
  exports: [CommonModule],
  declarations: [NgbdSortableHeader],
  providers: [LanguageService]
})
export class ThemeModule {
  static forRoot(): ModuleWithProviders<ThemeModule> {
    return <ModuleWithProviders<ThemeModule>>{
      ngModule: ThemeModule,
      providers: [
      ],
    };
  }
}
