import { Routes, RouterModule } from '@angular/router';
import { WatchModelListComponent } from './watchmodel/watch-model-list.component';

// Route config let's you map routes to components
const routes: Routes = [
    // map '/allData' to the people list component
    {
        path: 'RolexLuxury',
        component: WatchModelListComponent,
    },
    // map '/' to '/allData' as our default route
    {
        path: 'RolexLuxury/Watch/WatchModel',
        component: WatchModelListComponent,
    },
];

export const routing = RouterModule.forRoot(routes);
