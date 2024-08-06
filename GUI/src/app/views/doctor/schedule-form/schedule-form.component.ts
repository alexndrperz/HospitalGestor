import { Component } from '@angular/core';
import { ApiConnectService } from 'src/app/services/api-connect.service';

@Component({
  selector: 'app-schedule-form',
  templateUrl: './schedule-form.component.html',
  styleUrls: ['./schedule-form.component.scss']
})
export class ScheduleFormComponent {

  calcBy:number = 0
daySelected:number = 1
  initHourInp:number = 0
  finalHourInp:number = 0
  peopleToAttend:number = 0
  schedSystemInfos:any[] = []
  dataSourceSched:any[] = []

  especialities:any[] = []

  dataUpdateDoctor:any = {
    fullname:"",
    especiality_id:0,
    telefono:"",
    email:""
  }


  constructor(private _apiConnect:ApiConnectService) {}

  ngOnInit() {
    this.getInputData()
    
  }

  getInputData() {
    this._apiConnect.get("/schedules")
    .subscribe({
      next:(res:any) => {
        
        this.schedSystemInfos = res
        
      }
    })

    this._apiConnect.get("/especialities")
    .subscribe({
      next:(res:any) => {
        console.log(res);
        this.especialities = res
        
      }
    })
  }

  updateDoctor() {
    console.log(this.dataUpdateDoctor);
    
    this._apiConnect.put(`/user-dep/doctors/${this._apiConnect.decodeToken().aditionalEnt}`, this.dataUpdateDoctor)
    .subscribe({
      next:(res:any) => {
        console.log(res);
        
        this._apiConnect.apiResSnackbar("Actualizado correctamente")
      }
    })
  }


  renderInfo() {
    const result:boolean = this.validateRender()

    if(result) {
      if(this.calcBy ==1) {
        for (let i = 0; i < this.peopleToAttend; i++) {
          const element = this.schedSystemInfos[i];
          
          const newObj:any = {
            id:element.id,
            initHour:element.initHour,
            finalHour:element.finalHour,
            doctor_id:this._apiConnect.decodeToken().doctor_id
          }
          this.dataSourceSched.push(newObj)
          
        }
      } else {
        for (let i = this.initHourInp-1; i < this.finalHourInp-1; i++) {
          const element = this.schedSystemInfos[i];
          
          const newObj:any = {
            id:element.id,
            initHour:element.initHour,
            finalHour:element.finalHour,
            doctor_id:this._apiConnect.decodeToken().doctor_id, 
            day_id: this.daySelected
          }
          this.dataSourceSched.push(newObj)
          
        }
      } 
    } 

  }

  deleteRenderedCol(id:number) {
    this.dataSourceSched = this.dataSourceSched.filter((as:any) => {
      return as.id != id
    })
  }

  validateRender() : boolean {
    if(this.calcBy == 2) {

      
      if(this.initHourInp >= this.finalHourInp) {
        this._apiConnect.apiResSnackbar("Hora de inicio no puede ser mayor a la final")
        return false;
      }
      if(this.initHourInp == 0 || this.finalHourInp == 0) {
        this._apiConnect.apiResSnackbar("Debe especificarse hora")
        return false;
      }
    }

    if(this.calcBy ==1) {
      if(this.peopleToAttend > 26) {
        this._apiConnect.apiResSnackbar("solo puede atender un maximo de 26 personas por dia");
        return false;
        
      }
    }
    return true
  }

  formatSendDataForAPI() {
    const data:any = this.dataSourceSched.map((res:any) => {return {sched_id:res.id, day_id:this.daySelected, doctor_id:this._apiConnect.decodeToken().aditionalEnt }})
    console.log(data);
    
    this._apiConnect.post("/schedules", data)
    .subscribe({
      next:(res:any) => {
        console.log(res);
        window.location.reload()
        
        this._apiConnect.apiResSnackbar(res.msg)
      }
    })
  }




}
