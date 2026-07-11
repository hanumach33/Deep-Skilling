import { ApplicationConfig } from '@angular/core';

import { provideStore } from '@ngrx/store';

import { provideEffects } from '@ngrx/effects';

import { provideStoreDevtools } from '@ngrx/store-devtools';

import { courseReducer } from './store/reducers/course.reducer';

import { CourseEffects } from './store/effects/course.effects';

export const appConfig:ApplicationConfig={

providers:[

provideStore({

courses:courseReducer

}),

provideEffects([

CourseEffects

]),

provideStoreDevtools({

maxAge:25

})

]

};
