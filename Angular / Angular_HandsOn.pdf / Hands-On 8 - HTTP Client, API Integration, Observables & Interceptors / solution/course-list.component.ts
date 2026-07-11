import{
Component,
OnInit
}from '@angular/core';

import { CourseService } from '../../services/course.service';

@Component({

selector:'app-course-list',

standalone:true,

templateUrl:'./course-list.component.html'

})

export class CourseListComponent implements OnInit{

courses:any[]=[];

errorMessage='';

isLoading=true;

constructor(

private courseService:CourseService

){}

ngOnInit(){

this.courseService

.getCourses()

.subscribe({

next:courses=>{

this.courses=courses;

},

error:error=>{

this.errorMessage=

error.message;

},

complete:()=>{

this.isLoading=false;

}

});

}

}
