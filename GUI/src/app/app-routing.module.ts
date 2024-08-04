import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path: "", pathMatch:"full", redirectTo:"auth"},
  {
    path: "auth", 
    loadChildren:() =>  import("./views/auth/auth.module").then(m => m.AuthModule)
   }, 
   {
    path:"admin",
    loadChildren:() => import("./views/administrator/administrator.module").then(m => m.AdministratorModule)
   }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
