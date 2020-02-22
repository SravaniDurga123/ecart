import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/Models/student';
import { dashCaseToCamelCase } from '@angular/compiler/src/util';

@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent implements OnInit {
 obj:Student=new Student();

  constructor() {
     this.obj.sid=1;
     this.obj.sname='sravani';
     this.obj.dob=new Date(2009,12,31);
     this.obj.age=3;
     this.obj.std='2';
     
    //  this.obj={sid:1,sname:'sravani',dob:new Date(2009,12,31),age:3,std:'2'}
   }

  ngOnInit() {
  }

}
