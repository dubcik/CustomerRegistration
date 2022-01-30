import { Injectable } from '@angular/core';
import { Customer } from './customer.model';
import { HttpClient } from "@angular/common/http"

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private http:HttpClient) { }

  formData:Customer = new Customer();
  list:Customer[];

  readonly baseURL="http://localhost:61236/api/Customer" 

  postCustomer(){
    return this.http.post(this.baseURL,this.formData);
  }

  putCustomer(){
    return this.http.put(this.baseURL +"/"+ this.formData.customerId,this.formData);//return this.http.put('${this.baseURL}/${this.formData.customerId}',this.formData);
  }

  deleteCustomer(id:number){
    return this.http.delete(this.baseURL +"/"+ id);
  }

  refreshList(){
    this.http.get(this.baseURL)
    .toPromise()
    .then(res => this.list = res as Customer[]);
  }

  
}
