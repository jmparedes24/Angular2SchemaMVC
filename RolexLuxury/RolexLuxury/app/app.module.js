"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require('@angular/core');
var platform_browser_1 = require('@angular/platform-browser');
var router_1 = require('@angular/router');
var app_component_1 = require('./app.component');
//import { ArticleModule } from './article/article.module';
//import { AuthModule } from './auth/auth.module';
//import { EditorModule } from './editor/editor.module';
var home_module_1 = require('./home/home.module');
//import { ProfileModule } from './profile/profile.module';
//import { SettingsModule } from './settings/settings.module';
var api_service_1 = require('./shared/services/api.service');
//ArticlesService,
//AuthGuard,
//CommentsService,
//FooterComponent,
var header_component_1 = require('./shared/layout/header.component');
//JwtService,
//ProfilesService,
var shared_module_1 = require('./shared/shared.module');
//TagsService,
var watch_model_service_1 = require('./shared/services/watch-model.service');
var rootRouting = router_1.RouterModule.forRoot([], { useHash: true });
var AppModule = (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            declarations: [
                app_component_1.AppComponent,
                //FooterComponent,
                header_component_1.HeaderComponent
            ],
            imports: [
                platform_browser_1.BrowserModule,
                //ArticleModule,
                //AuthModule,
                //EditorModule,
                home_module_1.HomeModule,
                //ProfileModule,
                rootRouting,
                shared_module_1.SharedModule,
            ],
            providers: [
                api_service_1.ApiService,
                //ArticlesService,
                //AuthGuard,
                //CommentsService,
                //JwtService,
                //ProfilesService,
                //TagsService,
                watch_model_service_1.WatchModelDataService
            ],
            bootstrap: [app_component_1.AppComponent]
        }), 
        __metadata('design:paramtypes', [])
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map