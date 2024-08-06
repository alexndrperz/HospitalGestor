import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { jwtDecode } from 'jwt-decode';

@Injectable({
  providedIn: 'root'
})
export class ApiConnectService {

  constructor(private _http:HttpClient, private _router:Router, private _snackBar:MatSnackBar) { }

  host = "https://localhost:7199/api"

  get(path:string) {
    return this._http.get(this.host + path)
  }

  post(path:string, data:any) {
    return this._http.post(this.host + path, data)
  }

  put(path:string, data:any) {
    return this._http.put(this.host + path, data)
  }
  delete(path:string) {
    return this._http.delete(this.host + path)
  }

  apiResSnackbar(msg:string) {
    this._snackBar.open(msg, "Ok",  {
      duration:2000
    })
  }

decodeToken() {
  console.log(sessionStorage.getItem("user"));
  
  return JSON.parse(sessionStorage.getItem("user") ?? "{}")
}

  closeSesion() {
    sessionStorage.removeItem("user")
    this._router.navigate([""])

  }
}
