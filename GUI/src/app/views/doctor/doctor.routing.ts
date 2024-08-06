import { Route } from "@angular/router";
import { ScheduleFormComponent } from "./schedule-form/schedule-form.component";
import { ScheduleViewComponent } from "./schedule-view/schedule-view.component";
import { ReservesViewComponent } from "./reserves-view/reserves-view.component";

export const DoctorRoutes:Route[] = [
    {
        path:"",
        redirectTo:"schedule-view",
        pathMatch:"full"
    },
    {
        path:"schedule-form",
        component:ScheduleFormComponent
    },
    {
        path:"schedule-view",
        component:ScheduleViewComponent
    },
    {
        path:"reserves",
        component:ReservesViewComponent
    }
]