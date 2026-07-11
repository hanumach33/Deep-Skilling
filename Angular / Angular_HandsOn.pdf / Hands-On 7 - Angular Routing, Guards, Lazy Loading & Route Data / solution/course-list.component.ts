import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({

selector:'app-course-list',

standalone:true,

templateUrl:'./course-list.component.html'

})

export class CourseListComponent{

courses=[

{
id:1,
name:'Angular'
},

{
id:2,
name:'React'
},

{
id:3,
name:'Spring Boot'
}

];

constructor(

private router:Router

){}

openCourse(id:number){

this.router.navigate(

['courses',id]

);

}

}
