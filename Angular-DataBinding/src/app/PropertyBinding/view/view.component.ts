import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/Models/student';

@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent implements OnInit {
 item:Student;

  constructor() { 
    this.item=new Student();
    this.item.sid=1;
    this.item.age=3;
    this.item.dob=new  Date(2009,12,31);
    this.item.sname='sravani';
    this.item.std='3';
  }

  ngOnInit() {
  }

}
