import { Component, OnInit } from '@angular/core';

import { WatchModelData } from '../models';
import { WatchModelDataService } from '../services';

@Component({
    selector: 'layout-header',
    templateUrl: './header.component.html'
})
export class HeaderComponent implements OnInit {
    constructor(
        private watchService: WatchModelDataService
    ) { }

    currentUser: WatchModelData;

    ngOnInit() {
        this.watchService.currentWatchModel.subscribe(
            (watchData) => {
                this.currentUser = watchData;
            }
        )
    }
}
