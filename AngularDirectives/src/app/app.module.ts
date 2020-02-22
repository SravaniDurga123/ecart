import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Demo1Component } from './NG-IF/demo1/demo1.component';
import { Demo2Component } from './NG-FOR/demo2/demo2.component';
import { Demo3Component } from './NG-FOR/demo3/demo3.component';
import { ProjectComponent } from './NG-FOR/project/project.component';
import { Demo4Component } from './NG-SWITCH/demo4/demo4.component';


@NgModule({
  declarations: [
    AppComponent,
    Demo1Component,
    Demo2Component,
    Demo3Component,
    ProjectComponent,
    Demo4Component,
 
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [Demo3Component]
})
export class AppModule { }
