import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-event-demo',
  templateUrl: './event-demo.component.html',
  styleUrls: ['./event-demo.component.css']
})
export class EventDemoComponent implements OnInit {
name:string;
c:number;
d:number;
  constructor() { }

  ngOnInit() {
  }
 public setname(){
   this.name='vivek';
 }
 public Greet(val:string){
   this.name=val;
 }
 public Add(a:number,b:number){
  this.c=Number(a)+Number(b);
 }
 public Sub(a:number,b:number){
  this.d=a-b;
 }
}
