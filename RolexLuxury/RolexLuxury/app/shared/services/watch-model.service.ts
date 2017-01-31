import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from 'rxjs/Rx';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { ReplaySubject } from 'rxjs/ReplaySubject';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

import { ApiService } from './api.service';
import { WatchModelData } from '../models/watch-model.model';

@Injectable()
export class WatchModelDataService {
    private currentWatchModelSubject = new BehaviorSubject<WatchModelData>(new WatchModelData());
    public currentWatchModel = this.currentWatchModelSubject.asObservable().distinctUntilChanged();

    constructor(
        private apiService: ApiService,
        private http: Http
    ) { }

    getAllModels(): Observable<WatchModelData[]> {
        return this.apiService.get('/WatchModel')
            .map(res => res);     
    }

}