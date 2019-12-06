import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApplicationRepository {

  constructor(private httpClient: HttpClient) {
  }

  getTest(): Observable<any> {
        return this.httpClient.get('http://localhost:/53132/api/applications');
  }
}
