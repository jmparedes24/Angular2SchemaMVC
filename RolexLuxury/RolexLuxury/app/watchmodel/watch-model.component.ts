import { Component } from '@angular/core';
import { WatchModelDataService } from './watch-model-data.service'; 
import 'rxjs/add/operator/map';

@Component({
    selector: 'watch-models',
    template: `
    <router-outlet>
    `,
    providers: [WatchModelDataService]
})
export class WatchModelComponent {
    title: string = 'Get All Data!';
}
