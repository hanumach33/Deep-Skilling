import { Component,Input } from '@angular/core';
import { EnrollmentService } from '../../services/enrollment.service';

@Component({

selector:'app-course-card',

standalone:true,

templateUrl:'./course-card.component.html',

styleUrl:'./course-card.component.css'

})

export class CourseCardComponent{

@Input()

course:any;

constructor(

public enrollmentService:EnrollmentService

){}

toggleEnrollment(){

if(

this.enrollmentService

.isEnrolled(this.course.id)

){

this.enrollmentService

.unenroll(this.course.id);

}

else{

this.enrollmentService

.enroll(this.course.id);

}

}

}
