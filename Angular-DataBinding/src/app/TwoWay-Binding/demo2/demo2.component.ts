import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/Models/employee';

@Component({
  selector: 'app-demo2',
  templateUrl: './demo2.component.html',
  styleUrls: ['./demo2.component.css']
})
export class Demo2Component implements OnInit {
 obj:Employee;
 s:string;
  constructor() {
    this.obj=new Employee();

   }

  ngOnInit() {
  }
 public display(){
    this.s=this.obj.empid+" \n"+this.obj.empname+" \n"+this.obj.joindate+"\n "+this.obj.designation+"\n "+this.obj.salary;
 }
}
