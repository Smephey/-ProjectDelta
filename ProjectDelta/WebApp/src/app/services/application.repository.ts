import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {BACKEND_ADDRESS} from '../api-reference';

@Injectable()
export class ApplicationRepository {
    private _httpClient: HttpClient;

    constructor(httpClient: HttpClient) {
        this._httpClient = httpClient;
    }

    getTest(): Observable<any> {
        return this._httpClient.get(`${BACKEND_ADDRESS}/api/applications`);
    }
}
