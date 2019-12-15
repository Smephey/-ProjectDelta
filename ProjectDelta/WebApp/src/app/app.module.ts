import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';

import {AppComponent} from './app.component';
import {RouterModule} from '@angular/router';
import {APP_BASE_HREF, CommonModule} from '@angular/common';
import {AppRoutingModule} from './app-routing.module';
import {HomePageComponent} from './pages/home-page/home-page.component';
import {ApplicationsPageComponent} from './pages/applications-page/applications-page.component';
import {HttpClientModule} from '@angular/common/http';
import {ApplicationRepository} from './services/application.repository';
import {ApplicationService} from './services/application.service';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    ApplicationsPageComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    CommonModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [
    {provide: APP_BASE_HREF, useValue: '/'},
    ApplicationRepository,
    ApplicationService
  ],
  bootstrap: [AppComponent],
})
export class AppModule {
}
