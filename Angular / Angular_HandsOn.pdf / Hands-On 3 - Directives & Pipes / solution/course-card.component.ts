import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-course-card',
  standalone:true,
  templateUrl:'./course-card.component.html',
  styleUrl:'./course-card.component.css'
})
export class CourseCardComponent{

@Input()

course:any;

isExpanded=false;

isEnrolled=true;

get cardClasses(){

return{

'card--enrolled':this.isEnrolled,

'card--full':this.course.credits>=4,

'expanded':this.isExpanded

};

}

toggleDetails(){

this.isExpanded=!this.isExpanded;

}

}
