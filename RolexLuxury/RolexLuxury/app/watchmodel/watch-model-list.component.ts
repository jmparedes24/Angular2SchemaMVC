import { Component, OnInit } from '@angular/core';
import { WatchModelData } from './watchmodeldata';
import { WatchModelDataService } from './watch-model-data.service';

@Component({
    selector: 'watch-model-list',
    templateUrl: 'app/watchmodel/watch-model-dropdown-list.html',    
})

export class WatchModelListComponent implements OnInit {
    allData: WatchModelData[] = [];
    errorMessage: string = '';
    isLoading: boolean = true;
    private baseUrl: string = 'http://localhost/RolexLuxury';

    constructor(private dataService: WatchModelDataService) { }   

    ngOnInit() {        
        this.dataService
            .getAll()
            .subscribe(
         /* happy path */ d => this.allData = d,
         /* error path */ e => this.errorMessage = e,
         /* onComplete */() => this.isLoading = false);
    }
}
