import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DoctorsShownComponent } from './doctors-shown/doctors-shown.component';
import { DoctorDetailsComponent } from './doctor-details/doctor-details.component';
import { PersonalReservesComponent } from './personal-reserves/personal-reserves.component';
import { MenuClientComponent } from './menu-client/menu-client.component';
import { MenuComponent } from 'src/app/shared/menu/menu.component';
import { RouterModule } from '@angular/router';
import { ClientRouting } from './client.routing';
import { SharedModule } from 'src/app/shared/shared.module';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    DoctorsShownComponent,
    DoctorDetailsComponent,
    PersonalReservesComponent,
    MenuClientComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    FormsModule,
    RouterModule.forChild(ClientRouting)
  ]
})
export class ClientModule { }
