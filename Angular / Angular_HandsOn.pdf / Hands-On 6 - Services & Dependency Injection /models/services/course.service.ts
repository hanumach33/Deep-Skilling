import { Injectable } from '@angular/core';
import { Course } from '../models/course.model';

@Injectable({

providedIn:'root'

})

export class CourseService{

private courses:Course[]=[

{
id:1,
name:'Angular',
code:'ANG101',
credits:4,
gradeStatus:'passed'
},

{
id:2,
name:'React',
code:'RCT201',
credits:3,
gradeStatus:'pending'
},

{
id:3,
name:'Spring Boot',
code:'SPR301',
credits:5,
gradeStatus:'failed'
},

{
id:4,
name:'NodeJS',
code:'NOD401',
credits:3,
gradeStatus:'passed'
},

{
id:5,
name:'MongoDB',
code:'MDB501',
credits:2,
gradeStatus:'pending'
}

];

getCourses(){

return this.courses;

}

getCourseById(id:number){

return this.courses.find(

course=>course.id===id

);

}

addCourse(course:Course){

this.courses.push(course);

}

}
