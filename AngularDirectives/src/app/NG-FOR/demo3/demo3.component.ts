import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/Models/student';

@Component({
  selector: 'app-demo3',
  templateUrl: './demo3.component.html',
  styleUrls: ['./demo3.component.css']
})
export class Demo3Component implements OnInit {
  list:Student[]=[];
 stid:number;
 stname:string;
 age:number;
 std:string;
 item:Student;
 stds:string[]=["I","II","III"];
 val:boolean=false;
  constructor() { 
    //  this.list=[
    //    {stid:1,stname:'sravani',age:4,std:'fifth'},
    //    {stid:2,stname:'siva',age:4,std:'fifth'},
    //   {stid:3,stname:'sahd',age:4,std:'fifth'},
    //  ]
  }

  ngOnInit() {
  }
public Add(){
  this.item=new Student();
  this.item.stid=this.stid;
  this.item.age=this.age;
  this.item.stname=this.stname;
  this.item.std=this.std;
  this.list.push(this.item);
}
public setval(){
  this.val=!this.val;
}
}
