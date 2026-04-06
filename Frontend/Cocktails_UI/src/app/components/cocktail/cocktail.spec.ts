import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Cocktail } from './cocktail';

describe('Cocktail', () => {
  let component: Cocktail;
  let fixture: ComponentFixture<Cocktail>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Cocktail]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Cocktail);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
