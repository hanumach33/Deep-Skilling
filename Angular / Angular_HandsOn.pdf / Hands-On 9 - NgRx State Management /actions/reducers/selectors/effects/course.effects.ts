import{
Injectable
}from '@angular/core';

import{
Actions,
createEffect,
ofType
}from '@ngrx/effects';

import * as CourseActions from '../actions/course.actions';

import { CourseService } from '../../services/course.service';

import{
catchError,
map,
mergeMap
}from 'rxjs/operators';

import{
of
}from 'rxjs';

@Injectable()

export class CourseEffects{

loadCourses$=createEffect(()=>

this.actions$.pipe(

ofType(

CourseActions.loadCourses

),

mergeMap(()=>

this.courseService

.getCourses()

.pipe(

map(courses=>

CourseActions

.loadCoursesSuccess({

courses

})

),

catchError(error=>

of(

CourseActions

.loadCoursesFailure({

error:error.message

})

)

)

)

)

)

);

constructor(

private actions$:Actions,

private courseService:CourseService

){}

}
