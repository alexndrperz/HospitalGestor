import { Component } from '@angular/core';
import { UserAuth } from '../models/Users.model';
import { ApiConnectService } from 'src/app/services/api-connect.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {
  formData:UserAuth = {
    username: '',
    password: ''
  } 

  ngOnInit() {
  }

  constructor(
    private _apiConnect: ApiConnectService,
    private _router:Router
  ) {}

  authUser() {
    this._apiConnect.post("/auth/login", this.formData)
    .subscribe((res:any) => {
      sessionStorage.setItem("user",JSON.stringify(res))
      const role_id = res.role_id
      switch (role_id) {
        case 1:this._router.navigate(["admin"]);break;
        case 2:this._router.navigate(["doctor"]);break;
        case 3:this._router.navigate(["client"]);break;
      
        default:
          break;
      }
      console.log("Role no especificado");
      
    })
  } 
  

}


