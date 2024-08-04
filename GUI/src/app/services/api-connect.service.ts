import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class ApiConnectService {

  constructor(private _http:HttpClient, private _router:Router) { }

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
    return this._http.get(this.host + path)
  }

  closeSesion() {
    sessionStorage.removeItem("user")
    this._router.navigate([""])

  }
}
