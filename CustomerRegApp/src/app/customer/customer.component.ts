import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Customer } from '../shared/customer.model';
import { CustomerService } from '../shared/customer.service';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styles: [
  ]
})
export class CustomerComponent implements OnInit {

  constructor(public service: CustomerService,
    private toastr:ToastrService) { }

  ngOnInit(): void {
    this.service.refreshList();
  }

  populareForm(selectedRecord:Customer) {
    this.service.formData = Object.assign({}, selectedRecord);
  }

  onDelete(id:number){
    if(confirm('Are you sure to delete this record?'))
    {
        this.service.deleteCustomer(id)
        .subscribe(
           res=>{
              this.service.refreshList();
              this.toastr.error("Deleted successfuly",'Customer Detail');
                },
           err=>{console.log(err)}
        )
    }

  }

  

}
