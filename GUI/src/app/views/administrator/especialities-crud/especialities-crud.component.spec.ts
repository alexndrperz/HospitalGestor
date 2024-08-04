import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EspecialitiesCrudComponent } from './especialities-crud.component';

describe('EspecialitiesCrudComponent', () => {
  let component: EspecialitiesCrudComponent;
  let fixture: ComponentFixture<EspecialitiesCrudComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EspecialitiesCrudComponent]
    });
    fixture = TestBed.createComponent(EspecialitiesCrudComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
