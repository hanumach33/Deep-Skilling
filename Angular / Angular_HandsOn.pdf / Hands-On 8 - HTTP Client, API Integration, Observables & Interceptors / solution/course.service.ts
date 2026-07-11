import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';

import { Observable, throwError } from 'rxjs';

import {
map,
tap,
catchError,
retry
} from 'rxjs/operators';

@Injectable({

providedIn:'root'

})

export class CourseService{

private api='http://localhost:3000/courses';

constructor(

private http:HttpClient

){}

getCourses():Observable<any[]>{

return this.http.get<any[]>(this.api)

.pipe(

map(

courses=>courses.filter(

course=>course.credits>0

)

),

tap(

courses=>console.log(

'Courses Loaded :',

courses.length

)

),

retry(2),

catchError(error=>{

console.error(error);

return throwError(

()=>new Error(

'Failed to load courses.'

)

);

})

);

}

getCourseById(id:number){

return this.http.get<any>(

`${this.api}/${id}`

);

}

createCourse(course:any){

return this.http.post(

this.api,

course

);

}

updateCourse(id:number,course:any){

return this.http.put(

`${this.api}/${id}`,

course

);

}

deleteCourse(id:number){

return this.http.delete(

`${this.api}/${id}`

);

}

}
