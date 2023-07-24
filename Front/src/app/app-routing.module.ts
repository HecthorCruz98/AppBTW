
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListCustomerComponent } from './pages/list-customer/list-customer.component';
import { AddCustomerComponent } from './pages/add-customer/add-customer.component';
import { UpCustomerComponent } from './pages/up-customer/up-customer.component';


const routes: Routes = [
  { path: 'ListCustomer', component: ListCustomerComponent, },
  { path: 'AddCustomer', component: AddCustomerComponent, },
  { path: 'UpCustomer', component: UpCustomerComponent, }

];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { } 