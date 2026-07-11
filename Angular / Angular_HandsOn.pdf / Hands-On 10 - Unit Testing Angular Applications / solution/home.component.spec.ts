import { TestBed } from '@angular/core/testing';
import { HomeComponent } from './home.component';

describe('HomeComponent', () => {

  beforeEach(async () => {

    await TestBed.configureTestingModule({

      imports: [HomeComponent]

    }).compileComponents();

  });

  it('should create component', () => {

    const fixture = TestBed.createComponent(HomeComponent);

    const component = fixture.componentInstance;

    expect(component).toBeTruthy();

  });

  it('should have portal title', () => {

    const fixture = TestBed.createComponent(HomeComponent);

    const component = fixture.componentInstance;

    expect(component.portalName)

      .toBe('Student Course Portal');

  });

});
