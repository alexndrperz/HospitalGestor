import { Route } from "@angular/router";
import { StartViewAdminComponent } from "./start-view-admin/start-view-admin.component";
import { EspecialitiesCrudComponent } from "./especialities-crud/especialities-crud.component";

export const RoutesAdmin:Route[] = [
    {
        path:"",
        pathMatch:"full",
        redirectTo:"especialities"
    },

    {
        path:"especialities",
        component:EspecialitiesCrudComponent
    },
]