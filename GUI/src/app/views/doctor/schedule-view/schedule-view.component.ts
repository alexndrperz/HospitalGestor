import { Component } from '@angular/core';
import { ApiConnectService } from 'src/app/services/api-connect.service';

@Component({
  selector: 'app-schedule-view',
  templateUrl: './schedule-view.component.html',
  styleUrls: ['./schedule-view.component.scss']
})
export class ScheduleViewComponent {
  daySelected:number = 1;

  constructor(private _apiConnect:ApiConnectService) {}

  scheduleView:any[] = [] 

  ngOnInit() {
    this.selectedDay()
  }
  selectedDay() {
    this._apiConnect.get(`/schedules/${this.daySelected}/${this._apiConnect.decodeToken().aditionalEnt}`)
    .subscribe({
      next:(res:any) => {
        this.scheduleView = res
        
      }
    })
  }
}
