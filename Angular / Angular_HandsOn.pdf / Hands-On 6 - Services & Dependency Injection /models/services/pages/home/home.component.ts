import { Component } from '@angular/core';
import { CourseService } from '../../services/course.service';

@Component({

selector:'app-home',

standalone:true,

templateUrl:'./home.component.html',

styleUrl:'./home.component.css'

})

export class HomeComponent{

courseCount:number=0;

constructor(

private courseService:CourseService

){

this.courseCount=

this.courseService

.getCourses()

.length;

}

}
