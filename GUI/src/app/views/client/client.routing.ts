import { Route } from "@angular/router";
import { DoctorsShownComponent } from "./doctors-shown/doctors-shown.component";
import { PersonalReservesComponent } from "./personal-reserves/personal-reserves.component";
import { DoctorDetailsComponent } from "./doctor-details/doctor-details.component";

export const ClientRouting:Route[] = [
    {path:"", redirectTo:"doctors-shown", pathMatch:"full"}, 
    {path:"doctors-shown", component:DoctorsShownComponent},
    {path:"doctors-detail/:id", component:DoctorDetailsComponent},
    {path:"personal-reserves", component:PersonalReservesComponent}
] 