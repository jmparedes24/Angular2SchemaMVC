"use strict";
var router_1 = require('@angular/router');
var watch_model_list_component_1 = require('./watchmodel/watch-model-list.component');
// Route config let's you map routes to components
var routes = [
    // map '/allData' to the people list component
    {
        path: 'RolexLuxury',
        component: watch_model_list_component_1.WatchModelListComponent,
    },
    // map '/' to '/allData' as our default route
    {
        path: 'RolexLuxury/Watch/WatchModel',
        component: watch_model_list_component_1.WatchModelListComponent,
    },
];
exports.routing = router_1.RouterModule.forRoot(routes);
//# sourceMappingURL=app.routes.js.map