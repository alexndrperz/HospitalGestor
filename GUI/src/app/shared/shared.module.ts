import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MenuComponent } from './menu/menu.component';
import {MatSnackBar} from '@angular/material/snack-bar'


@NgModule({
  declarations: [MenuComponent],
  exports:[MenuComponent],
  imports: [
    CommonModule,
  ]
})
export class SharedModule { }
