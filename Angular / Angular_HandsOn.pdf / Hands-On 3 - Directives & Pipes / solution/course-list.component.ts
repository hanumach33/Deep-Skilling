import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-course-list',
  standalone: true,
  templateUrl: './course-list.component.html',
  styleUrl: './course-list.component.css'
})
export class CourseListComponent implements OnInit {

  isLoading = true;

  courses = [
    {
      id: 1,
      name: 'Angular',
      code: 'ANG101',
      credits: 4,
      gradeStatus: 'passed'
    },
    {
      id: 2,
      name: 'React',
      code: 'RCT201',
      credits: 3,
      gradeStatus: 'pending'
    },
    {
      id: 3,
      name: 'Spring Boot',
      code: 'SPR301',
      credits: 5,
      gradeStatus: 'failed'
    }
  ];

  ngOnInit(): void {

    setTimeout(() => {

      this.isLoading = false;

    },1500);

  }

  trackByCourseId(index:number,course:any){

    return course.id;

  }

}
