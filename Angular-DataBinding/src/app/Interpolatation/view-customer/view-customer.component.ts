import { Component, OnInit } from '@angular/core';
import { Customer } from 'src/app/Models/customer';

@Component({
  selector: 'app-view-customer',
  templateUrl: './view-customer.component.html',
  styleUrls: ['./view-customer.component.css']
})
export class ViewCustomerComponent implements OnInit {
 obj:Customer;
  constructor() {
    this.obj={name:'sravani',mail:'sravani@gmail.com',mobile:'34534535',city:'afef',address:'dafdf'}
   }

  ngOnInit() {
  }

}
