import { Component } from '@angular/core';
import { EnrollmentService } from '../../services/enrollment.service';

@Component({

selector:'app-student-profile',

standalone:true,

templateUrl:'./student-profile.component.html',

styleUrl:'./student-profile.component.css'

})

export class StudentProfileComponent{

constructor(

public enrollmentService:EnrollmentService

){}

}
