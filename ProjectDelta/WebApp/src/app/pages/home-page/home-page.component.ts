import {Component, OnInit} from '@angular/core';
import {ApplicationService} from '../../services/application.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent implements OnInit {

  constructor(private applicationService: ApplicationService) {
  }


  ngOnInit(): void {
    this.applicationService.getTest()
      .subscribe((test) => {
        console.log(test);
      });
  }

}
