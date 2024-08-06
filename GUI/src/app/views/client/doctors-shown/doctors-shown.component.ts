import { Component } from '@angular/core';
import { ApiConnectService } from 'src/app/services/api-connect.service';

@Component({
  selector: 'app-doctors-shown',
  templateUrl: './doctors-shown.component.html',
  styleUrls: ['./doctors-shown.component.scss']
})
export class DoctorsShownComponent {
  ngOnInit() {
    this.getInfoGeneral()
  }

  doctors:any[] = []

  constructor(private _apiConnect:ApiConnectService) {}

  getInfoGeneral() {
    this._apiConnect.get(`/user-dep/doctors`)
    .subscribe({
      next:(res:any) => {
        console.log(res);
        this.doctors = res
        
      }
    })
  }


}

