import {RouterModule, Routes} from '@angular/router';
import {NgModule} from '@angular/core';
import {HomePageComponent} from './pages/home-page/home-page.component';

const appRoutes: Routes = [
  {path: 'home', component: HomePageComponent},
  {path: '**', component: HomePageComponent}
];

@NgModule({
  imports: [
    RouterModule.forRoot(
      appRoutes
    )
  ],
  exports: [
    RouterModule
  ]
})

export class AppRoutingModule {
}
