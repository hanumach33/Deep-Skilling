import { TestBed } from '@angular/core/testing';

import {

HttpClientTestingModule,

HttpTestingController

} from '@angular/common/http/testing';

import { CourseService } from './course.service';

describe('CourseService', () => {

let service:CourseService;

let httpMock:HttpTestingController;

beforeEach(()=>{

TestBed.configureTestingModule({

imports:[

HttpClientTestingModule

]

});

service=

TestBed.inject(CourseService);

httpMock=

TestBed.inject(HttpTestingController);

});

afterEach(()=>{

httpMock.verify();

});

it('should fetch courses',()=>{

const mockCourses=[

{

id:1,

name:'Angular'

}

];

service

.getCourses()

.subscribe(data=>{

expect(data.length)

.toBe(1);

expect(data[0].name)

.toBe('Angular');

});

const request=

httpMock.expectOne(

'http://localhost:3000/courses'

);

expect(

request.request.method

)

.toBe('GET');

request.flush(

mockCourses

);

});

});
