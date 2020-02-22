import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo2',
  templateUrl: './demo2.component.html',
  styleUrls: ['./demo2.component.css']
})
export class Demo2Component implements OnInit {
 no:number[]=[1,2,3,4,5];
 name:string[]=['sravani','maragani']
  constructor() {
    this.name.push('hloo')
   }

  ngOnInit() {
  }

}
