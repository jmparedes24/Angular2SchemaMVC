import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

//import { ArticleListConfig, TagsService, UserService } from '../shared';

@Component({
    selector: 'home-page',
    templateUrl: './home.component.html',
    //styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
    constructor(
        private router: Router       
    ) { }

    ngOnInit() {
        
    }

    //setListTo(type: string = '', filters: Object = {}) {
    //    // If feed is requested but user is not authenticated, redirect to login
    //    if (type === 'feed' && !this.isAuthenticated) {
    //        this.router.navigateByUrl('/login');
    //        return;
    //    }

    //    // Otherwise, set the list object
    //    this.listConfig = { type: type, filters: filters };
    //}
}
