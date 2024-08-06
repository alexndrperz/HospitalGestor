import { Component } from '@angular/core';
import { ApiConnectService } from 'src/app/services/api-connect.service';

@Component({
  selector: 'menu-doctor',
  templateUrl: './menu-doctor.component.html',
  styleUrls: ['./menu-doctor.component.scss']
})
export class MenuDoctorComponent {

  canViewForm:boolean =true;
  constructor(private _apiConnect:ApiConnectService) {}
ngOnInit() {
  if(this._apiConnect.decodeToken().dataReady) {
    this.canViewForm = false
  }
}

}
