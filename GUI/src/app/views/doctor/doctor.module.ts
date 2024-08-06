import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ScheduleFormComponent } from './schedule-form/schedule-form.component';
import { ScheduleViewComponent } from './schedule-view/schedule-view.component';
import { ReservesViewComponent } from './reserves-view/reserves-view.component';
import { MenuDoctorComponent } from './components/menu-doctor/menu-doctor.component';
import { MenuComponent } from 'src/app/shared/menu/menu.component';
import { RouterModule } from '@angular/router';
import { DoctorRoutes } from './doctor.routing';
import { FormsModule } from '@angular/forms';
import { SharedModule } from 'src/app/shared/shared.module';



@NgModule({
  declarations: [
    ScheduleFormComponent,
    ScheduleViewComponent,
    ReservesViewComponent,
    MenuDoctorComponent,

  ],
  imports: [
    CommonModule,
  FormsModule,
  SharedModule,
  
    RouterModule.forChild(DoctorRoutes)
  ]
})
export class DoctorModule { }
