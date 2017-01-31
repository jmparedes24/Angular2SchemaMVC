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
var http_1 = require('@angular/http');
var BehaviorSubject_1 = require('rxjs/BehaviorSubject');
require('rxjs/add/operator/map');
require('rxjs/add/operator/catch');
var api_service_1 = require('./api.service');
var watch_model_model_1 = require('../models/watch-model.model');
var WatchModelDataService = (function () {
    function WatchModelDataService(apiService, http) {
        this.apiService = apiService;
        this.http = http;
        this.currentWatchModelSubject = new BehaviorSubject_1.BehaviorSubject(new watch_model_model_1.WatchModelData());
        this.currentWatchModel = this.currentWatchModelSubject.asObservable().distinctUntilChanged();
    }
    WatchModelDataService.prototype.getAllModels = function () {
        return this.apiService.get('/WatchModel')
            .map(function (res) { return res; });
    };
    WatchModelDataService = __decorate([
        core_1.Injectable(), 
        __metadata('design:paramtypes', [api_service_1.ApiService, http_1.Http])
    ], WatchModelDataService);
    return WatchModelDataService;
}());
exports.WatchModelDataService = WatchModelDataService;
//# sourceMappingURL=watch-model.service.js.map