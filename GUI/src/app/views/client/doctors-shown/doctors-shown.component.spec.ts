import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DoctorsShownComponent } from './doctors-shown.component';

describe('DoctorsShownComponent', () => {
  let component: DoctorsShownComponent;
  let fixture: ComponentFixture<DoctorsShownComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DoctorsShownComponent]
    });
    fixture = TestBed.createComponent(DoctorsShownComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
