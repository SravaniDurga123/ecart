import { Component, OnInit } from '@angular/core';
import { Project } from 'src/app/Models/project';

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.css']
})
export class ProjectComponent implements OnInit {
 list:Project[]=[];
 projectId:number;
 projectName:string;
 domain:string;
 startDate:Date;
 endDate:Date;
 item:Project;
 domainarray:string[]=[".net","java","devops"];
  constructor() { }

  ngOnInit() {
  }
 public Add(){
  this.item=new Project();
  this.item.projectId=this.projectId;
  this.item.projectName=this.projectName;
  this.item.domain=this.domain;
  this.item.startDate=this.startDate;
  this.item.endDate=this.endDate;
  this.list.push(this.item);
  console.log(this.item);
 }
}
