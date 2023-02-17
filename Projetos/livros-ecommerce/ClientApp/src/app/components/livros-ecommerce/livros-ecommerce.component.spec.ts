import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LivrosEcommerceComponent } from './livros-ecommerce.component';

describe('LivrosEcommerceComponent', () => {
  let component: LivrosEcommerceComponent;
  let fixture: ComponentFixture<LivrosEcommerceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LivrosEcommerceComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LivrosEcommerceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
