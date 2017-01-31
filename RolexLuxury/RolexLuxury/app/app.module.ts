import { ModuleWithProviders, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
//import { ArticleModule } from './article/article.module';
//import { AuthModule } from './auth/auth.module';
//import { EditorModule } from './editor/editor.module';
import { HomeModule } from './home/home.module';
//import { ProfileModule } from './profile/profile.module';
//import { SettingsModule } from './settings/settings.module';
import { ApiService } from './shared/services/api.service';
    //ArticlesService,
    //AuthGuard,
    //CommentsService,
    //FooterComponent,
import { HeaderComponent } from './shared/layout/header.component';
    //JwtService,
    //ProfilesService,
import { SharedModule } from './shared/shared.module';
    //TagsService,
import { WatchModelDataService} from './shared/services/watch-model.service';

const rootRouting: ModuleWithProviders = RouterModule.forRoot([], { useHash: true });

@NgModule({
    declarations: [
        AppComponent,
        //FooterComponent,
        HeaderComponent
    ],
    imports: [
        BrowserModule,
        //ArticleModule,
        //AuthModule,
        //EditorModule,
        HomeModule,
        //ProfileModule,
        rootRouting,
        SharedModule,
        //SettingsModule
    ],
    providers: [
        ApiService,
        //ArticlesService,
        //AuthGuard,
        //CommentsService,
        //JwtService,
        //ProfilesService,
        //TagsService,
        WatchModelDataService
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }