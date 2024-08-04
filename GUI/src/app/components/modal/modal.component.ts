import { Component } from '@angular/core';
import { Input } from '@angular/core';

@Component({
  selector: 'modal-sys',
  templateUrl: './modal.component.html',
  styleUrls: ['./modal.component.scss']
})
export class ModalComponent {

  @Input() modalId:string = "";
  @Input() title:string = ""

}
