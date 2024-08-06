import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ApiConnectService } from 'src/app/services/api-connect.service';

@Component({
  selector: 'app-doctor-details',
  templateUrl: './doctor-details.component.html',
  styleUrls: ['./doctor-details.component.scss']
})
export class DoctorDetailsComponent {
  daySelected:number = 1;

  constructor(private _apiConnect:ApiConnectService,private _actRouter:ActivatedRoute) {}

  scheduleView:any[] = [] 
  doc_id:any = 0

  ngOnInit() {
    this.doc_id = this._actRouter.snapshot.paramMap.get("id");
    this.selectedDay(1)
  }
  selectedDay(evt:any) {
    this.daySelected
    this._apiConnect.get(`/schedules/${evt}/${this.doc_id}`)
    .subscribe({
      next:(res:any) => {
        console.log(res);
        
        this.scheduleView = res
        
      }
    })
  }
}



