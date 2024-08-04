import { Component } from '@angular/core';
import { ApiConnectService } from 'src/app/services/api-connect.service';

@Component({
  selector: 'app-especialities-crud',
  templateUrl: './especialities-crud.component.html',
  styleUrls: ['./especialities-crud.component.scss']
})
export class EspecialitiesCrudComponent {
  formData:EspecialityCreate = {
    name: ''
  }

  selectedId:number = 0;
  constructor(private _apiConnect:ApiConnectService) {}
  ngOnInit() {
    this.getAllEspecialities();
  }
  

  especailities:EspecialityRetrieve[] = []
  getAllEspecialities() {
    this._apiConnect.get("/especialities")
    .subscribe({
      next:(res:any) => {
        console.log(res);
        this.especailities = res;

      }
    })
  }


  createEspecial()  {
    this._apiConnect.post("/especialities", this.formData) 
    .subscribe({
      next:(res:any) => {
        this.getAllEspecialities()
        console.log(res);
        
      }
    })
  }

  updateEspeciality() {
    
    this._apiConnect.put(`/especialities/${this.selectedId}`, this.formData) 
    .subscribe({
      next:(res:any) => {
        this.getAllEspecialities()
        console.log(res);
      }
    })
  }

  popUpOpened(idSelected:number = 0) {
    this.selectedId = idSelected
    this.formData = {
      name:""
    }
  }


  deshabilitateEspeciality(especiality_id:number) {
    this._apiConnect.delete(`/especialities/${especiality_id}`) 
    .subscribe({
      next:(res:any) => {
        console.log(res);
        this.getAllEspecialities()
      }
    })
  }
}


export interface EspecialityCreate {
  name:string
}

export interface EspecialityRetrieve {
  id:number,
  name:string
}
