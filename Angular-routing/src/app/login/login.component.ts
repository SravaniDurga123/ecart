import { Component, OnInit } from '@angular/core';
import { Router} from  "@angular/router";
import { tick } from '@angular/core/testing';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
 uname:string;
 pwd:string;
 errmsg:string;
  constructor(private route:Router) { }

  ngOnInit() {
  }
  public validate(){
     if(this.uname=="rohan" && this.pwd=="1234")
     {
       sessionStorage.setItem("uname",this.uname);
        this.route.navigateByUrl('user'); //user is the name of the route 
     }
     else if(this.uname==null  && this.pwd==null)
     {
       this.errmsg="please fill your details"
     }
     else 
       {
         this.errmsg="invalid login  details";
       }
  }
}
