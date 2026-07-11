import { Injectable } from '@angular/core';
import { CourseService } from './course.service';

@Injectable({

providedIn:'root'

})

export class EnrollmentService{

private enrolledCourseIds:number[]=[];

constructor(

private courseService:CourseService

){}

enroll(courseId:number){

if(!this.enrolledCourseIds.includes(courseId)){

this.enrolledCourseIds.push(courseId);

}

}

unenroll(courseId:number){

this.enrolledCourseIds=

this.enrolledCourseIds.filter(

id=>id!==courseId

);

}

isEnrolled(courseId:number){

return this.enrolledCourseIds.includes(courseId);

}

getEnrolledCourses(){

return this.courseService

.getCourses()

.filter(

course=>this.enrolledCourseIds.includes(course.id)

);

}

}
