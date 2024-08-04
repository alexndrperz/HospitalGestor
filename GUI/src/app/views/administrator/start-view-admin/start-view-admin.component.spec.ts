import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StartViewAdminComponent } from './start-view-admin.component';

describe('StartViewAdminComponent', () => {
  let component: StartViewAdminComponent;
  let fixture: ComponentFixture<StartViewAdminComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [StartViewAdminComponent]
    });
    fixture = TestBed.createComponent(StartViewAdminComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
