import { Component, OnInit } from '@angular/core';
import {
  AbstractControl,
  FormArray,
  FormBuilder,
  ReactiveFormsModule,
  ValidationErrors,
  Validators
} from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-reactive-enrollment-form',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './reactive-enrollment-form.component.html',
  styleUrl: './reactive-enrollment-form.component.css'
})
export class ReactiveEnrollmentFormComponent implements OnInit {

  enrollForm: any;

  constructor(private fb: FormBuilder) {}

  ngOnInit(): void {

    this.enrollForm = this.fb.group({

      studentName: [
        '',
        [
          Validators.required,
          Validators.minLength(3)
        ]
      ],

      studentEmail: [
        '',
        [
          Validators.required,
          Validators.email
        ],
        [
          this.simulateEmailCheck
        ]
      ],

      courseId: [
        '',
        [
          Validators.required,
          this.noCourseCode
        ]
      ],

      preferredSemester: [
        'Odd',
        Validators.required
      ],

      agreeToTerms: [
        false,
        Validators.requiredTrue
      ],

      additionalCourses: this.fb.array([])

    });

  }

  noCourseCode(control: AbstractControl): ValidationErrors | null {

    const value = control.value;

    if (value && value.toString().startsWith('XX')) {

      return {

        noCourseCode: true

      };

    }

    return null;

  }

  simulateEmailCheck(control: AbstractControl) {

    return new Promise(resolve => {

      setTimeout(() => {

        if (control.value &&
            control.value.includes('test@')) {

          resolve({

            emailTaken: true

          });

        }

        else{

          resolve(null);

        }

      },800);

    });

  }

  get additionalCourses(){

    return this.enrollForm.get(

      'additionalCourses'

    ) as FormArray;

  }

  addCourse(){

    this.additionalCourses.push(

      this.fb.control(

        '',

        Validators.required

      )

    );

  }

  removeCourse(index:number){

    this.additionalCourses.removeAt(index);

  }

  onSubmit(){

    console.log(

      this.enrollForm.value

    );

    console.log(

      this.enrollForm.getRawValue()

    );

  }

}
