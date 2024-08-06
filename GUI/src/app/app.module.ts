import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http'; 
import { ApiConnectService } from './services/api-connect.service';
import { MenuComponent } from './shared/menu/menu.component';
import { ModalComponent } from './components/modal/modal.component';
import { MatSnackBar, MatSnackBarModule } from '@angular/material/snack-bar';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatSnackBarModule, 
    BrowserAnimationsModule,
    HttpClientModule
  ],
  providers: [ApiConnectService],
  bootstrap: [AppComponent]
})
export class AppModule { }
