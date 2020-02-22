import { Component, OnInit } from '@angular/core';
import { Login } from 'src/app/Model/login';

@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent implements OnInit {
 obj:Login;
 
 res:string;
  constructor() { 
    this.obj=new Login();
  }

  ngOnInit() {
  }
 public  submit(){
   
   if(this.obj.uname=="admin" && this.obj.pwd=="12345")
     {
        this.res="Login success";
     }
     else{
       this.res=" Login fail";
     }
 }
}
