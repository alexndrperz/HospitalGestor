import { Component } from '@angular/core';
import { UserCreate } from '../models/Users.model';
import { ApiConnectService } from 'src/app/services/api-connect.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent {

  constructor(private _apiConnect:ApiConnectService, private _router:Router) {

  }

  dataForRegister:UserCreate = {
    username: '',
    password: '',
    role_id: 0,
    confirmPassword: ''
  }


  sendDataForRegister() {
    this._apiConnect.post("/auth/register", this.dataForRegister)
    .subscribe({
      next:(res:any) => {
        console.log(res);
        this._router.navigate(["/auth/login"])
      }
    })
  }

}
