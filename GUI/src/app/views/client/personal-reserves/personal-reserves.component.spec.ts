import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonalReservesComponent } from './personal-reserves.component';

describe('PersonalReservesComponent', () => {
  let component: PersonalReservesComponent;
  let fixture: ComponentFixture<PersonalReservesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PersonalReservesComponent]
    });
    fixture = TestBed.createComponent(PersonalReservesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
