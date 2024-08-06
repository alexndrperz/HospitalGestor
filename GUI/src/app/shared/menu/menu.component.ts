import { Component } from '@angular/core';
import { ApiConnectService } from 'src/app/services/api-connect.service';

@Component({
  selector: 'menu-system',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss']
})
export class MenuComponent {

  constructor(private _apiConnect:ApiConnectService) {}

  closeSession() {
    this._apiConnect.closeSesion()
  }

}
