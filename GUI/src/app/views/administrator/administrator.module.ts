import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EspecialitiesCrudComponent } from './especialities-crud/especialities-crud.component';
import { StartViewAdminComponent } from './start-view-admin/start-view-admin.component';
import { MenuComponent } from 'src/app/shared/menu/menu.component';
import { RouterModule } from '@angular/router';
import { RoutesAdmin } from './admin.routing';
import { MenuAdminComponent } from './components/menu-admin/menu-admin.component';
import { ModalComponent } from 'src/app/components/modal/modal.component';
import { FormsModule } from '@angular/forms';
import { SharedModule } from 'src/app/shared/shared.module';



@NgModule({
  declarations: [
    EspecialitiesCrudComponent,
    StartViewAdminComponent,
    MenuAdminComponent,
    ModalComponent,
  ],
  imports: [
    RouterModule.forChild(RoutesAdmin),
    FormsModule,
    SharedModule,
    CommonModule
  ]
})
export class AdministratorModule { }
