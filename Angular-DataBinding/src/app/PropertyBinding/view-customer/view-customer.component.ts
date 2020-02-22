import { Component, OnInit } from '@angular/core';
import { Customer } from 'src/app/Models/customer';

@Component({
  selector: 'app-view-customer',
  templateUrl: './view-customer.component.html',
  styleUrls: ['./view-customer.component.css']
})
export class ViewCustomerComponent implements OnInit {

  item:Customer;
 url:string="http://www.google.com";
  constructor() { 
    this.item=new Customer();
    this.item.name='sravani';
    this.item.mail='sravani@gmail.com';
   
    this.item.city='fdsf';
    this.item.address='dsadf';
  }

  ngOnInit() {
  }

}
