import{
HttpInterceptorFn
}from '@angular/common/http';

import{
catchError
}from 'rxjs/operators';

import{
throwError
}from 'rxjs';

export const errorHandlerInterceptor:

HttpInterceptorFn=

(req,next)=>{

return next(req)

.pipe(

catchError(error=>{

console.error(

error

);

return throwError(

()=>error

);

})

);

};
