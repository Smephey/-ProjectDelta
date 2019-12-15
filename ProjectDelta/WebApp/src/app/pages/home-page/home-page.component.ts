import {Component, OnInit} from '@angular/core';
import {ApplicationService} from '../../services/application.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
})
export class HomePageComponent implements OnInit {

  public testData: Array<any>;
  private _applicationService: ApplicationService;

  constructor(applicationService: ApplicationService) {
    this._applicationService = applicationService;
  }


  ngOnInit(): void {
    this._applicationService.getTest()
      .subscribe((test) => {
        this.testData = test;
      });
  }

}
