import { Injectable } from '@angular/core';
import { Http, Response, Headers} from '@angular/http';
import { Observable } from 'rxjs/Rx';
import { WatchModelData } from './watchmodeldata';  // Model
import { APP_BASE_HREF } from '@angular/common';
import 'rxjs/add/operator/map';

@Injectable()
export class WatchModelDataService {
    private baseUrl: string = 'http://localhost/RolexLuxury';

    constructor(private http: Http) {
    }

    private extractData(res: Response) {
        if (res.status < 200 || res.status >= 300) {
            throw new Error('Bad response status: ' + res.status);
        }
        let body = res.json();
        return body || {};
    }

    getAll(): Observable<WatchModelData[]> {        
        return this.http.get(`${this.baseUrl}/Watch/WatchModel/GetWatches`, { headers: this.getHeaders() })
            .map((res) => this.extractData(res))
            .catch((err) => this.handleError(err));
    }

    private getHeaders() {
        let headers = new Headers();
        headers.append('Accept', 'application/json');
        return headers;
    }

    private handleError(error: any) {
        // log error
        let errorMsg = error.message || 'There was a problem with REST service call';
        console.error(errorMsg);

        // throw an application level error
        return Observable.throw(errorMsg);
    }
}
