import {Injectable} from '@angular/core';
import {ApplicationRepository} from './application.repository';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApplicationService {

  constructor(private applicationRepository: ApplicationRepository) {
  }

  public getTest(): Observable<any> {
    return this.applicationRepository.getTest();
  }

}
