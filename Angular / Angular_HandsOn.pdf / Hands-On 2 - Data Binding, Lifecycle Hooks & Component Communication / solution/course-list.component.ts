import { Component } from '@angular/core';
import { CourseCardComponent } from '../../components/course-card/course-card.component';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-course-list',
  standalone: true,
  imports: [
    CommonModule,
    CourseCardComponent
  ],
  templateUrl: './course-list.component.html',
  styleUrl: './course-list.component.css'
})
export class CourseListComponent {

  selectedCourseId = 0;

  courses = [

    {
      id:1,
      name:'Angular',
      code:'ANG101',
      credits:4
    },

    {
      id:2,
      name:'React',
      code:'RCT101',
      credits:3
    },

    {
      id:3,
      name:'Spring Boot',
      code:'SPR201',
      credits:4
    },

    {
      id:4,
      name:'NodeJS',
      code:'NOD301',
      credits:3
    },

    {
      id:5,
      name:'MongoDB',
      code:'MNG401',
      credits:2
    }

  ];

  onEnroll(courseId:number){

    console.log(

      'Enrolling in course : ' + courseId

    );

    this.selectedCourseId = courseId;

  }

}
