import{
Component,
OnInit
}from '@angular/core';

import { Store } from '@ngrx/store';

import { Observable } from 'rxjs';

import * as CourseActions from '../../store/actions/course.actions';

import * as CourseSelectors from '../../store/selectors/course.selectors';

@Component({

selector:'app-course-list',

standalone:true,

templateUrl:'./course-list.component.html'

})

export class CourseListComponent implements OnInit{

courses$:Observable<any[]>;

loading$:Observable<boolean>;

error$:Observable<string|null>;

constructor(

private store:Store

){

this.courses$=

this.store.select(

CourseSelectors.selectCourses

);

this.loading$=

this.store.select(

CourseSelectors.selectLoading

);

this.error$=

this.store.select(

CourseSelectors.selectError

);

}

ngOnInit(){

this.store.dispatch(

CourseActions.loadCourses()

);

}

}
